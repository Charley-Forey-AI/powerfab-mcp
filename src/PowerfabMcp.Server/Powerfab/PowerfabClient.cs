using System.Text;
using System.Xml;
using System.Xml.Linq;
using Microsoft.Extensions.Options;
using PowerfabMcp.Server.Configuration;
using TeklaPowerFab.TeklaPowerFabAPI;

namespace PowerfabMcp.Server.Powerfab;

/// <summary>
/// Singleton wrapper around <see cref="ITeklaPowerFabAPI"/>. Caches one shared
/// <c>ConnectionGUID</c> across all in-flight requests and reconnects once on
/// auth-expired errors.
/// </summary>
public sealed class PowerfabClient : IPowerfabClient, IDisposable
{
    public static readonly XNamespace RequestNs =
        "http://www.fabsuite.com/xml/fabsuite-xml-request-v0108.xsd";

    private static readonly XmlWriterSettings WriterSettings = new()
    {
        OmitXmlDeclaration = false,
        Encoding = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false),
        Indent = false,
    };

    private readonly ITeklaPowerFabAPI _api;
    private readonly PowerfabOptions _options;
    private readonly ILogger<PowerfabClient> _logger;
    private readonly SemaphoreSlim _connectLock = new(1, 1);

    private string? _connectionGuid;

    public PowerfabClient(
        IOptions<PowerfabOptions> options,
        ILogger<PowerfabClient> logger)
        : this(new global::TeklaPowerFab.TeklaPowerFabAPI.TeklaPowerFabAPI(), options, logger)
    {
    }

    internal PowerfabClient(
        ITeklaPowerFabAPI api,
        IOptions<PowerfabOptions> options,
        ILogger<PowerfabClient> logger)
    {
        _api = api;
        _options = options.Value;
        _logger = logger;
    }

    public async Task EnsureConnectedAsync(CancellationToken cancellationToken = default)
    {
        _ = await GetOrConnectAsync(forceReconnect: false, cancellationToken);
    }

    public async Task<XElement> ExecuteAsync(
        string responseElementName,
        XElement commandElement,
        CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(responseElementName);
        ArgumentNullException.ThrowIfNull(commandElement);

        if (!string.IsNullOrWhiteSpace(_options.ApiLog) && commandElement.Element(RequestNs + "APILog") is null)
        {
            commandElement.Add(new XElement(RequestNs + "APILog", _options.ApiLog));
        }

        try
        {
            return await ExecuteOnceAsync(responseElementName, commandElement, forceReconnect: false, cancellationToken);
        }
        catch (PowerfabException ex) when (ex.IsAuthExpired)
        {
            _logger.LogWarning("PowerFab connection expired; reconnecting and retrying once.");
            return await ExecuteOnceAsync(responseElementName, commandElement, forceReconnect: true, cancellationToken);
        }
    }

    private async Task<XElement> ExecuteOnceAsync(
        string responseElementName,
        XElement commandElement,
        bool forceReconnect,
        CancellationToken cancellationToken)
    {
        var guid = await GetOrConnectAsync(forceReconnect, cancellationToken);

        var envelope = BuildEnvelope(guid, commandElement);
        var requestXml = SerializeEnvelope(envelope);

        var responseXml = await SendAsync(requestXml, cancellationToken);
        var doc = ParseResponse(responseXml);

        ThrowOnTopLevelError(doc);
        return ExtractCommandResponse(doc, responseElementName);
    }

    private async Task<string> GetOrConnectAsync(bool forceReconnect, CancellationToken cancellationToken)
    {
        if (!forceReconnect && _connectionGuid is { Length: > 0 })
        {
            return _connectionGuid;
        }

        await _connectLock.WaitAsync(cancellationToken);
        try
        {
            if (!forceReconnect && _connectionGuid is { Length: > 0 })
            {
                return _connectionGuid;
            }

            _logger.LogInformation(
                "Establishing PowerFab Remote connection as user {Username} on {Host}:{Port}.",
                _options.Username,
                _options.RemoteHost,
                _options.RemotePort);

            var connectCommand = new XElement(RequestNs + "ConnectRemote",
                new XElement(RequestNs + "Username", _options.Username),
                new XElement(RequestNs + "Password", _options.Password));

            var envelope = BuildEnvelope(connectionGuid: null, connectCommand);
            var responseXml = await SendAsync(SerializeEnvelope(envelope), cancellationToken);

            var doc = ParseResponse(responseXml);
            ThrowOnTopLevelError(doc);
            var connectResponse = ExtractCommandResponse(doc, "ConnectRemote");

            var guid = LocalString(connectResponse, "ConnectionGUID");
            if (string.IsNullOrWhiteSpace(guid))
            {
                throw new PowerfabException("ConnectRemote succeeded but no ConnectionGUID was returned.");
            }

            _connectionGuid = guid;
            return guid;
        }
        finally
        {
            _connectLock.Release();
        }
    }

    private async Task<string> SendAsync(string requestXml, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        try
        {
            var sendTask = Task.Run(() => _api.ExecuteRemote(_options.RemoteHost, _options.RemotePort, requestXml), cancellationToken);
            var timeoutTask = Task.Delay(_options.RequestTimeout, cancellationToken);
            var completed = await Task.WhenAny(sendTask, timeoutTask);
            if (completed != sendTask)
            {
                throw new PowerfabException($"PowerFab request timed out after {_options.RequestTimeout.TotalSeconds:F0}s.");
            }

            return await sendTask;
        }
        catch (PowerfabException)
        {
            throw;
        }
        catch (Exception ex)
        {
            throw new PowerfabException($"Transport error talking to PowerFab Remote Service: {ex.Message}", ex);
        }
    }

    private static XElement BuildEnvelope(string? connectionGuid, XElement command)
    {
        var envelope = new XElement(RequestNs + "FabSuiteXMLRequest");
        if (!string.IsNullOrEmpty(connectionGuid))
        {
            envelope.Add(new XElement(RequestNs + "ConnectionGUID", connectionGuid));
        }

        envelope.Add(command);
        return envelope;
    }

    private static string SerializeEnvelope(XElement envelope)
    {
        using var sw = new StringWriter();
        using (var xw = XmlWriter.Create(sw, WriterSettings))
        {
            envelope.Save(xw);
        }

        return sw.ToString();
    }

    private static XDocument ParseResponse(string responseXml)
    {
        if (string.IsNullOrWhiteSpace(responseXml))
        {
            throw new PowerfabException("PowerFab returned an empty response body.");
        }

        try
        {
            return XDocument.Parse(responseXml);
        }
        catch (XmlException ex)
        {
            throw new PowerfabException($"PowerFab returned malformed XML: {ex.Message}", ex);
        }
    }

    private static void ThrowOnTopLevelError(XDocument doc)
    {
        var root = doc.Root ?? throw new PowerfabException("PowerFab response had no root element.");
        var errorEl = root.Elements().FirstOrDefault(e => string.Equals(e.Name.LocalName, "XMLError", StringComparison.OrdinalIgnoreCase));
        if (errorEl is null)
        {
            return;
        }

        var message = errorEl.Value?.Trim();
        throw new PowerfabException(string.IsNullOrEmpty(message)
            ? "PowerFab returned an XMLError with no message."
            : $"PowerFab XMLError: {message}");
    }

    private static XElement ExtractCommandResponse(XDocument doc, string responseElementName)
    {
        var root = doc.Root!;
        var responseEl = root.Elements().FirstOrDefault(e =>
            string.Equals(e.Name.LocalName, responseElementName, StringComparison.OrdinalIgnoreCase));

        if (responseEl is null)
        {
            throw new PowerfabException($"PowerFab response did not contain a <{responseElementName}> element.");
        }

        var successful = LocalString(responseEl, "Successful");
        var errorMessage = LocalString(responseEl, "ErrorMessage");

        if (!string.Equals(successful, "true", StringComparison.OrdinalIgnoreCase))
        {
            var msg = string.IsNullOrWhiteSpace(errorMessage)
                ? $"PowerFab command {responseElementName} reported failure with no ErrorMessage."
                : $"PowerFab command {responseElementName} failed: {errorMessage}";

            throw new PowerfabException(msg)
            {
                IsAuthExpired = LooksLikeAuthExpired(errorMessage),
            };
        }

        return responseEl;
    }

    private static string LocalString(XElement parent, string localName)
    {
        var el = parent.Elements().FirstOrDefault(e =>
            string.Equals(e.Name.LocalName, localName, StringComparison.OrdinalIgnoreCase));
        return el?.Value?.Trim() ?? string.Empty;
    }

    private static bool LooksLikeAuthExpired(string? errorMessage)
    {
        if (string.IsNullOrEmpty(errorMessage))
        {
            return false;
        }

        ReadOnlySpan<string> hints = ["connection", "session", "guid", "expired", "log in", "login", "not connected", "authent"];
        foreach (var hint in hints)
        {
            if (errorMessage.Contains(hint, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }

    public void Dispose() => _connectLock.Dispose();
}
