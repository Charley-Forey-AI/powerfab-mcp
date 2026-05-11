using Microsoft.Extensions.Options;
using PowerfabMcp.Server.Configuration;

namespace PowerfabMcp.Server.Auth;

/// <summary>
/// Combined access-control middleware for the Streamable HTTP MCP endpoint:
/// <list type="bullet">
///   <item>Validates the Origin / Host header to prevent DNS-rebinding attacks
///   when the server is reachable from a browser-hosted client (per MCP spec).</item>
///   <item>If a bearer token is configured, requires
///   <c>Authorization: Bearer &lt;token&gt;</c> on every request.</item>
/// </list>
/// Applied only to the configured MCP path; <c>/healthz</c> and other endpoints
/// are unaffected.
/// </summary>
public sealed class McpAccessControlMiddleware
{
    private readonly RequestDelegate _next;
    private readonly HostingOptions _options;
    private readonly HashSet<string> _allowedOrigins;
    private readonly bool _bindIsLoopbackOnly;
    private readonly ILogger<McpAccessControlMiddleware> _logger;

    public McpAccessControlMiddleware(
        RequestDelegate next,
        IOptions<HostingOptions> options,
        ILogger<McpAccessControlMiddleware> logger)
    {
        _next = next;
        _options = options.Value;
        _logger = logger;

        _allowedOrigins = string.IsNullOrWhiteSpace(_options.AllowedOrigins)
            ? new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            : _options.AllowedOrigins
                .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                .ToHashSet(StringComparer.OrdinalIgnoreCase);

        _bindIsLoopbackOnly = LooksLoopbackOnly(_options.BindUrl);
    }

    public async Task InvokeAsync(HttpContext context)
    {
        if (!IsMcpPath(context.Request.Path))
        {
            await _next(context);
            return;
        }

        if (!IsOriginAllowed(context))
        {
            _logger.LogWarning(
                "Rejecting MCP request: disallowed Origin {Origin} from {Remote}.",
                context.Request.Headers.Origin.ToString(),
                context.Connection.RemoteIpAddress);
            context.Response.StatusCode = StatusCodes.Status403Forbidden;
            await context.Response.WriteAsync("Origin not allowed.");
            return;
        }

        if (!IsBearerAuthorized(context))
        {
            _logger.LogWarning(
                "Rejecting MCP request: missing/invalid bearer token from {Remote}.",
                context.Connection.RemoteIpAddress);
            context.Response.Headers.WWWAuthenticate = "Bearer";
            context.Response.StatusCode = StatusCodes.Status401Unauthorized;
            await context.Response.WriteAsync("Unauthorized.");
            return;
        }

        await _next(context);
    }

    private bool IsMcpPath(PathString path)
    {
        return path.StartsWithSegments(_options.McpPath, StringComparison.OrdinalIgnoreCase);
    }

    private bool IsOriginAllowed(HttpContext context)
    {
        var origin = context.Request.Headers.Origin.ToString();
        if (string.IsNullOrEmpty(origin))
        {
            return true;
        }

        if (_allowedOrigins.Contains(origin))
        {
            return true;
        }

        if (_bindIsLoopbackOnly && IsLoopbackOrigin(origin))
        {
            return true;
        }

        return false;
    }

    private bool IsBearerAuthorized(HttpContext context)
    {
        if (string.IsNullOrEmpty(_options.BearerToken))
        {
            return true;
        }

        var header = context.Request.Headers.Authorization.ToString();
        if (string.IsNullOrEmpty(header))
        {
            return false;
        }

        const string prefix = "Bearer ";
        if (!header.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        var token = header[prefix.Length..].Trim();
        return string.Equals(token, _options.BearerToken, StringComparison.Ordinal);
    }

    private static bool LooksLoopbackOnly(string bindUrl)
    {
        if (!Uri.TryCreate(bindUrl, UriKind.Absolute, out var uri))
        {
            return false;
        }

        var host = uri.Host;
        return string.Equals(host, "127.0.0.1", StringComparison.Ordinal)
            || string.Equals(host, "::1", StringComparison.Ordinal)
            || string.Equals(host, "localhost", StringComparison.OrdinalIgnoreCase);
    }

    private static bool IsLoopbackOrigin(string origin)
    {
        if (!Uri.TryCreate(origin, UriKind.Absolute, out var uri))
        {
            return false;
        }

        var host = uri.Host;
        return string.Equals(host, "127.0.0.1", StringComparison.Ordinal)
            || string.Equals(host, "::1", StringComparison.Ordinal)
            || string.Equals(host, "localhost", StringComparison.OrdinalIgnoreCase);
    }
}
