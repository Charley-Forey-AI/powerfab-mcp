namespace PowerfabMcp.Server.Powerfab;

/// <summary>
/// Thrown when PowerFab returns a top-level <c>XMLError</c> or a per-command
/// <c>Successful=false</c> response, or when the transport call itself fails.
/// </summary>
public sealed class PowerfabException : Exception
{
    public PowerfabException(string message) : base(message) { }

    public PowerfabException(string message, Exception inner) : base(message, inner) { }

    /// <summary>
    /// True when the failure is consistent with an expired / invalid
    /// ConnectionGUID, signalling the caller should drop the cache and retry
    /// once.
    /// </summary>
    public bool IsAuthExpired { get; init; }
}
