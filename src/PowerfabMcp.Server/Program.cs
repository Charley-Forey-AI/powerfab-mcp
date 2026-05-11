using DotNetEnv;
using PowerfabMcp.Server.Auth;
using PowerfabMcp.Server.Configuration;
using PowerfabMcp.Server.Powerfab;
using Serilog;
using Serilog.Events;

LoadDotEnvFiles();

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    .MinimumLevel.Override("Microsoft.AspNetCore", LogEventLevel.Warning)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .WriteTo.File(
        path: Path.Combine(AppContext.BaseDirectory, "logs", "powerfab-mcp-.log"),
        rollingInterval: RollingInterval.Day,
        retainedFileCountLimit: 14)
    .CreateLogger();

try
{
    var builder = WebApplication.CreateBuilder(args);

    builder.Configuration
        .AddEnvironmentVariables()
        .AddCommandLine(args);

    builder.Host.UseSerilog();

    builder.Services
        .AddOptions<PowerfabOptions>()
        .Bind(builder.Configuration.GetSection(PowerfabOptions.SectionName))
        .ValidateDataAnnotations()
        .ValidateOnStart();

    builder.Services
        .AddOptions<HostingOptions>()
        .Bind(builder.Configuration.GetSection(HostingOptions.SectionName));

    builder.Services.AddSingleton<IPowerfabClient, PowerfabClient>();

    builder.Services
        .AddMcpServer()
        .WithHttpTransport()
        .WithToolsFromAssembly();

    var app = builder.Build();

    var hosting = app.Services.GetRequiredService<Microsoft.Extensions.Options.IOptions<HostingOptions>>().Value;

    app.UseSerilogRequestLogging();
    app.UseMiddleware<McpAccessControlMiddleware>();

    app.MapGet("/healthz", () => Results.Ok(new { status = "ok" }));
    app.MapMcp(hosting.McpPath);

    Log.Information("Starting PowerFab MCP server on {BindUrl}, MCP path {McpPath}.", hosting.BindUrl, hosting.McpPath);
    app.Run(hosting.BindUrl);
}
catch (Exception ex)
{
    Log.Fatal(ex, "Host terminated unexpectedly.");
    throw;
}
finally
{
    Log.CloseAndFlush();
}

/// <summary>
/// Loads <c>.env</c> files from the current working directory and the repo
/// root (if found by walking up). Existing process environment variables win
/// so containers / systemd / Cursor still take precedence.
/// </summary>
static void LoadDotEnvFiles()
{
    var loadOptions = new LoadOptions(
        setEnvVars: true,
        clobberExistingVars: false,
        onlyExactPath: true);

    foreach (var path in EnumerateCandidateEnvFiles())
    {
        if (File.Exists(path))
        {
            Env.Load(path, loadOptions);
        }
    }
}

static IEnumerable<string> EnumerateCandidateEnvFiles()
{
    var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

    foreach (var dir in new[] { Directory.GetCurrentDirectory(), AppContext.BaseDirectory })
    {
        var current = new DirectoryInfo(dir);
        while (current is not null)
        {
            var candidate = Path.Combine(current.FullName, ".env");
            if (seen.Add(candidate))
            {
                yield return candidate;
            }

            current = current.Parent;
        }
    }
}

/// <summary>
/// Marker class so <c>WebApplicationFactory&lt;Program&gt;</c> in tests can
/// reference the host.
/// </summary>
public partial class Program;
