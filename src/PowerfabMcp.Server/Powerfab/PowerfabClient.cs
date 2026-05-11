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

            WarnIfRemotePortLooksLikeDatabase(_options.RemotePort);

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
            var msg = $"Transport error talking to PowerFab Remote Service: {ex.Message}";
            throw new PowerfabException(AppendMisconfiguredRemotePortHint(msg), ex);
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

    private XDocument ParseResponse(string responseXml)
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
            throw new PowerfabException(AppendMisconfiguredRemotePortHint($"PowerFab returned malformed XML: {ex.Message}"), ex);
        }
    }

    /// <summary>
    /// Users often point RemotePort at the database (3306) instead of the Remote Service API port.
    /// </summary>
    private string AppendMisconfiguredRemotePortHint(string message)
    {
        if (!IsCommonDatabasePort(_options.RemotePort))
        {
            return message;
        }

        if (!LooksLikeProtocolMismatch(message))
        {
            return message;
        }

        return $"{message} " +
               $"(Configuration hint: Powerfab__RemotePort is {_options.RemotePort}, which is typically a database port. " +
               "Use Powerfab__RemoteHost / Powerfab__RemotePort for the Tekla PowerFab Remote Service (API/XML), not the SQL Server instance—see Integration / Remote Service settings in PowerFab Office.)";
    }

    private static bool IsCommonDatabasePort(int port) =>
        port is 3306 or 33060 or 5432 or 1433;

    private static bool LooksLikeProtocolMismatch(string message)
    {
        if (string.IsNullOrEmpty(message))
        {
            return false;
        }

        return message.Contains("frame", StringComparison.OrdinalIgnoreCase)
            || message.Contains("corrupt", StringComparison.OrdinalIgnoreCase)
            || message.Contains("SSL", StringComparison.OrdinalIgnoreCase)
            || message.Contains("TLS", StringComparison.OrdinalIgnoreCase)
            || (message.Contains("authentication", StringComparison.OrdinalIgnoreCase)
                && message.Contains("handshake", StringComparison.OrdinalIgnoreCase));
    }

    private void WarnIfRemotePortLooksLikeDatabase(int port)
    {
        if (!IsCommonDatabasePort(port))
        {
            return;
        }

        _logger.LogWarning(
            "Powerfab RemotePort is {Port}, which is often used by SQL/MySQL/PostgreSQL — not the PowerFab Remote Service API. " +
            "If calls fail with TLS or 'frame' errors, set Powerfab__RemotePort to the Remote Service port from PowerFab Office (many sites use 8080).",
            port);
    }

    private void ThrowOnTopLevelError(XDocument doc)
    {
        var root = doc.Root ?? throw new PowerfabException("PowerFab response had no root element.");
        var errorEl = root.Elements().FirstOrDefault(e => string.Equals(e.Name.LocalName, "XMLError", StringComparison.OrdinalIgnoreCase));
        if (errorEl is null)
        {
            return;
        }

        var message = errorEl.Value?.Trim();
        var text = string.IsNullOrEmpty(message)
            ? "PowerFab returned an XMLError with no message."
            : $"PowerFab XMLError: {message}";
        throw new PowerfabException(AppendMisconfiguredRemotePortHint(text));
    }

    private XElement ExtractCommandResponse(XDocument doc, string responseElementName)
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

        // PowerFab uses both "true"/"false" and "1"/"0" in different responses.
        if (!IsSuccessfulFlag(successful))
        {
            var msg = string.IsNullOrWhiteSpace(errorMessage)
                ? $"PowerFab command {responseElementName} reported failure with no ErrorMessage."
                : $"PowerFab command {responseElementName} failed: {errorMessage}";

            throw new PowerfabException(AppendMisconfiguredRemotePortHint(msg))
            {
                IsAuthExpired = LooksLikeAuthExpired(errorMessage),
            };
        }

        return responseEl;
    }

    private static bool IsSuccessfulFlag(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return false;
        }

        return string.Equals(value, "true", StringComparison.OrdinalIgnoreCase)
            || string.Equals(value, "1", StringComparison.Ordinal)
            || string.Equals(value, "yes", StringComparison.OrdinalIgnoreCase);
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
