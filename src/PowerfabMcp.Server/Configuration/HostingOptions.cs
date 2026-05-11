namespace PowerfabMcp.Server.Configuration;

/// <summary>
/// Web hosting + MCP transport settings, bound from the <c>Hosting</c>
/// configuration section (env vars: <c>HOSTING__BINDURL</c>, etc.).
/// </summary>
public sealed class HostingOptions
{
    public const string SectionName = "Hosting";

    /// <summary>
    /// URL the Kestrel server listens on. Default loopback-only for safety;
    /// use <c>http://0.0.0.0:3000</c> (or behind TLS via reverse proxy) to
    /// expose externally.
    /// </summary>
    public string BindUrl { get; set; } = "http://127.0.0.1:3000";

    /// <summary>
    /// Optional bearer token. When set, every MCP request must include
    /// <c>Authorization: Bearer &lt;token&gt;</c>. Required by convention when
    /// <see cref="BindUrl"/> is bound to a non-loopback address.
    /// </summary>
    public string BearerToken { get; set; } = string.Empty;

    /// <summary>
    /// Comma-separated list of allowed Origin / Host header values. The MCP
    /// spec requires servers to reject unexpected Origins with HTTP 403 to
    /// stop DNS-rebinding attacks. Empty = allow loopback only.
    /// </summary>
    public string AllowedOrigins { get; set; } = string.Empty;

    /// <summary>
    /// MCP endpoint path. Cursor / Claude Desktop point at this URL.
    /// </summary>
    public string McpPath { get; set; } = "/mcp";
}
