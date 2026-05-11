using System.Xml.Linq;

namespace PowerfabMcp.Server.Powerfab;

/// <summary>
/// Thin wrapper around the official <c>Tekla.PowerFab.API</c> transport that
/// handles connection caching, idempotent retry, and structured error mapping.
/// </summary>
public interface IPowerfabClient
{
    /// <summary>
    /// Sends a single command (the supplied <paramref name="commandElement"/>)
    /// inside a <c>FabSuiteXMLRequest</c> envelope, automatically prepending
    /// <c>ConnectionGUID</c>. Returns the matching response element from the
    /// server (e.g. for <c>WorkPackage_Insert</c> the <c>WorkPackage_Insert</c>
    /// response element).
    /// </summary>
    /// <param name="responseElementName">
    /// Local name of the response element to extract (case-insensitive,
    /// namespace-agnostic).
    /// </param>
    /// <param name="commandElement">
    /// Fully-formed command element (e.g. <c>&lt;WorkPackage_Insert&gt;…&lt;/&gt;</c>).
    /// Must already have its <c>CommandGUID</c> child set if idempotency is
    /// desired.
    /// </param>
    Task<XElement> ExecuteAsync(
        string responseElementName,
        XElement commandElement,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Forces an authentication round-trip and refreshes the cached
    /// <c>ConnectionGUID</c>. Mostly useful for the <c>/healthz</c> endpoint
    /// or smoke tests.
    /// </summary>
    Task EnsureConnectedAsync(CancellationToken cancellationToken = default);
}
