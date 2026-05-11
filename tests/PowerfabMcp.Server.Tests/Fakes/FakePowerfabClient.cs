using System.Xml.Linq;
using PowerfabMcp.Server.Powerfab;

namespace PowerfabMcp.Server.Tests.Fakes;

/// <summary>
/// Test double for <see cref="IPowerfabClient"/>. Records the last command
/// element it received and returns a configurable response.
/// </summary>
public sealed class FakePowerfabClient : IPowerfabClient
{
    public XElement? LastCommand { get; private set; }
    public string? LastResponseElementName { get; private set; }
    public Func<string, XElement, XElement> ResponseFactory { get; set; }
        = (name, _) => new XElement(PowerfabClient.RequestNs + name,
            new XElement(PowerfabClient.RequestNs + "Successful", "true"));

    public bool ConnectCalled { get; private set; }

    public Task EnsureConnectedAsync(CancellationToken cancellationToken = default)
    {
        ConnectCalled = true;
        return Task.CompletedTask;
    }

    public Task<XElement> ExecuteAsync(
        string responseElementName,
        XElement commandElement,
        CancellationToken cancellationToken = default)
    {
        LastResponseElementName = responseElementName;
        LastCommand = new XElement(commandElement);
        return Task.FromResult(ResponseFactory(responseElementName, commandElement));
    }
}
