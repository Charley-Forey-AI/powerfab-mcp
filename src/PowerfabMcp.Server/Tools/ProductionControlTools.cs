using System.ComponentModel;
using System.Globalization;
using System.Xml.Linq;
using ModelContextProtocol;
using ModelContextProtocol.Server;
using PowerfabMcp.Server.Models;
using PowerfabMcp.Server.Powerfab;

namespace PowerfabMcp.Server.Tools;

/// <summary>
/// MCP tools for discovering production control jobs (numeric IDs for API calls).
/// </summary>
[McpServerToolType]
public sealed class ProductionControlTools
{
    private static readonly XNamespace Ns = PowerfabClient.RequestNs;

    private readonly IPowerfabClient _client;
    private readonly ILogger<ProductionControlTools> _logger;

    public ProductionControlTools(IPowerfabClient client, ILogger<ProductionControlTools> logger)
    {
        _client = client;
        _logger = logger;
    }

    [McpServerTool(Name = "list_production_control_jobs", UseStructuredContent = true)]
    [Description(
        "List Tekla PowerFab production control jobs. Use the returned production_control_id " +
        "as productionControlId when calling create_work_package. No required parameters; add " +
        "optional filters to narrow the list.")]
    public Task<ListProductionControlJobsResult> ListProductionControlJobsAsync(
        [Description("Restrict to jobs in this primary group name.")]
        string? groupName = null,
        [Description("Restrict to jobs in this secondary group name.")]
        string? groupName2 = null,
        [Description("Restrict to a single job by its job number / name.")]
        string? jobNumber = null,
        [Description(
            "When true, include closed jobs. Default is false (open jobs only), matching PowerFab.")]
        bool includeClosedJobs = false,
        [Description("When true, only jobs linked to a project management job.")]
        bool onlyLinkedToProject = false,
        [Description(
            "When true, only jobs with at least one uncut, non-invalidated cut list; " +
            "response includes cut_list_count per job.")]
        bool onlyContainingCutLists = false,
        [Description("Restrict to one job by its production control ID.")]
        int? productionControlId = null,
        CancellationToken cancellationToken = default)
        => ListAsync(
            new ListProductionControlJobsInput
            {
                GroupName = groupName,
                GroupName2 = groupName2,
                JobNumber = jobNumber,
                IncludeClosedJobs = includeClosedJobs,
                OnlyLinkedToProject = onlyLinkedToProject,
                OnlyContainingCutLists = onlyContainingCutLists,
                ProductionControlId = productionControlId,
            },
            cancellationToken);

    internal async Task<ListProductionControlJobsResult> ListAsync(
        ListProductionControlJobsInput input,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(input);

        var command = new XElement(Ns + "GetProductionControlJobs");
        AddIfPresent(command, "GroupName", input.GroupName);
        AddIfPresent(command, "GroupName2", input.GroupName2);
        AddIfPresent(command, "JobNumber", input.JobNumber);
        AddIfPresent(command, "ProductionControlID", input.ProductionControlId);

        if (input.IncludeClosedJobs)
        {
            command.Add(new XElement(Ns + "IncludeClosedJobs", "true"));
        }

        if (input.OnlyLinkedToProject)
        {
            command.Add(new XElement(Ns + "OnlyLinkedToProject", "true"));
        }

        if (input.OnlyContainingCutLists)
        {
            command.Add(new XElement(Ns + "OnlyContainingCutLists", "true"));
        }

        _logger.LogInformation("Listing production control jobs via GetProductionControlJobs.");

        XElement response;
        try
        {
            response = await _client.ExecuteAsync("GetProductionControlJobs", command, cancellationToken);
        }
        catch (PowerfabException ex)
        {
            _logger.LogWarning(ex, "PowerFab rejected GetProductionControlJobs.");
            throw new McpException(ex.Message);
        }

        var jobs = new List<ProductionControlJobSummary>();
        foreach (var row in response.Elements().Where(e =>
                     string.Equals(e.Name.LocalName, "ProductionControlJob", StringComparison.OrdinalIgnoreCase)))
        {
            var idText = ChildText(row, "ProductionControlID");
            if (!int.TryParse(idText, NumberStyles.Integer, CultureInfo.InvariantCulture, out var id))
            {
                _logger.LogWarning("Skipping ProductionControlJob with missing or non-numeric ProductionControlID.");
                continue;
            }

            int? cutLists = null;
            var cutText = ChildText(row, "CutListCount");
            if (int.TryParse(cutText, NumberStyles.Integer, CultureInfo.InvariantCulture, out var c))
            {
                cutLists = c;
            }

            jobs.Add(new ProductionControlJobSummary(
                id,
                ChildText(row, "JobNumber") ?? string.Empty,
                ChildText(row, "JobDescription") ?? string.Empty,
                NullableText(ChildText(row, "JobLocation")),
                NullableText(ChildText(row, "GroupName")),
                NullableText(ChildText(row, "GroupName2")),
                cutLists));
        }

        var message = jobs.Count == 0
            ? "No production control jobs matched the filters."
            : $"Found {jobs.Count} production control job(s). Use production_control_id with create_work_package.";

        _logger.LogInformation("GetProductionControlJobs returned {Count} job(s).", jobs.Count);
        return new ListProductionControlJobsResult(jobs, message);
    }

    private static string? NullableText(string? value)
        => string.IsNullOrEmpty(value) ? null : value;

    private static string? ChildText(XElement parent, string localName)
    {
        var el = parent.Elements().FirstOrDefault(e =>
            string.Equals(e.Name.LocalName, localName, StringComparison.OrdinalIgnoreCase));
        var t = el?.Value?.Trim();
        return string.IsNullOrEmpty(t) ? null : t;
    }

    private static void AddIfPresent(XElement parent, string name, string? value)
    {
        if (!string.IsNullOrWhiteSpace(value))
        {
            parent.Add(new XElement(Ns + name, value.Trim()));
        }
    }

    private static void AddIfPresent(XElement parent, string name, int? value)
    {
        if (value is { } v && v > 0)
        {
            parent.Add(new XElement(Ns + name, v.ToString(CultureInfo.InvariantCulture)));
        }
    }
}
