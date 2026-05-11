using System.ComponentModel.DataAnnotations;

namespace PowerfabMcp.Server.Configuration;

/// <summary>
/// PowerFab Remote Service connection settings, bound from the <c>Powerfab</c>
/// configuration section (env vars: <c>POWERFAB__USERNAME</c>, <c>POWERFAB__PASSWORD</c>, etc.).
/// </summary>
public sealed class PowerfabOptions
{
    public const string SectionName = "Powerfab";

    /// <summary>
    /// External user created in PowerFab Office under External Users. Required.
    /// </summary>
    [Required]
    public string Username { get; set; } = string.Empty;

    /// <summary>
    /// External user password. Required.
    /// </summary>
    [Required]
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// IP address (or hostname) of the PowerFab Remote Service.
    /// </summary>
    [Required]
    public string RemoteHost { get; set; } = "127.0.0.1";

    /// <summary>
    /// TCP port the PowerFab Remote Service is listening on.
    /// </summary>
    [Range(1, 65535)]
    public int RemotePort { get; set; } = 8080;

    /// <summary>
    /// When set, every command will set <c>APILog</c> to the given value
    /// (e.g. <c>"all"</c>) so requests show up under PowerFab → Maintenance →
    /// Integration Settings → API Log. Leave empty to disable.
    /// </summary>
    public string ApiLog { get; set; } = string.Empty;

    /// <summary>
    /// Per-call timeout for PowerFab requests.
    /// </summary>
    public TimeSpan RequestTimeout { get; set; } = TimeSpan.FromSeconds(60);
}
