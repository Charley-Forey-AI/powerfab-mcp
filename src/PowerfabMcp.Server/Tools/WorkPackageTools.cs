using System.ComponentModel;
using System.Globalization;
using System.Xml.Linq;
using ModelContextProtocol;
using ModelContextProtocol.Server;
using PowerfabMcp.Server.Models;
using PowerfabMcp.Server.Powerfab;

namespace PowerfabMcp.Server.Tools;

/// <summary>
/// MCP tools for managing PowerFab work packages.
/// </summary>
[McpServerToolType]
public sealed class WorkPackageTools
{
    private static readonly XNamespace Ns = PowerfabClient.RequestNs;

    private readonly IPowerfabClient _client;
    private readonly ILogger<WorkPackageTools> _logger;

    public WorkPackageTools(IPowerfabClient client, ILogger<WorkPackageTools> logger)
    {
        _client = client;
        _logger = logger;
    }

    [McpServerTool(Name = "create_work_package", UseStructuredContent = true)]
    [Description(
        "Create a new work package on a Tekla PowerFab job. Returns the new " +
        "work_package_id. Pass an idempotency_key to make retries safe.")]
    public Task<CreateWorkPackageResult> CreateWorkPackageAsync(
        [Description("Production Control ID of the job that will own the work package. Call list_production_control_jobs first if you do not know valid IDs.")]
        int productionControlId,
        [Description("Name / number of the new work package.")]
        string workPackageNumber,
        [Description("Optional human-readable description.")]
        string? description = null,
        [Description("Free-form notes attached to the work package.")]
        string? notes = null,
        [Description("Workshop ID the work package should be scheduled to. Omit to leave unscheduled.")]
        int? workshopId = null,
        [Description("Status code (integer); meaning is configured per PowerFab installation.")]
        int? status = null,
        [Description("Priority bucket: Low, Medium, or High. Defaults to Medium.")]
        WorkPackagePriority priority = WorkPackagePriority.Medium,
        [Description("Marks the work package as a future placeholder rather than current work.")]
        bool isFuture = false,
        [Description("Planned start date (ISO 8601, e.g. 2026-05-20).")]
        DateOnly? startDate = null,
        [Description("Due date (ISO 8601, e.g. 2026-05-30).")]
        DateOnly? dueDate = null,
        [Description("Optional grouping tag 1.")]
        string? group1 = null,
        [Description("Optional grouping tag 2.")]
        string? group2 = null,
        [Description(
            "Optional client-supplied idempotency key. Set to a stable value per logical " +
            "create attempt so retries do not double-create. A random GUID is used if omitted.")]
        string? idempotencyKey = null,
        CancellationToken cancellationToken = default)
    {
        var input = new CreateWorkPackageInput
        {
            ProductionControlId = productionControlId,
            WorkPackageNumber = workPackageNumber,
            Description = description,
            Notes = notes,
            WorkshopId = workshopId,
            Status = status,
            Priority = priority,
            IsFuture = isFuture,
            StartDate = startDate,
            DueDate = dueDate,
            Group1 = group1,
            Group2 = group2,
            IdempotencyKey = idempotencyKey,
        };

        return CreateAsync(input, cancellationToken);
    }

    /// <summary>
    /// Internal entry point used by tests. Same logic as the public tool but
    /// accepts a single DTO for convenience.
    /// </summary>
    internal async Task<CreateWorkPackageResult> CreateAsync(
        CreateWorkPackageInput input,
        CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(input);

        if (input.ProductionControlId <= 0)
        {
            throw new ArgumentException("production_control_id must be a positive integer.", nameof(input));
        }

        if (string.IsNullOrWhiteSpace(input.WorkPackageNumber))
        {
            throw new ArgumentException("work_package_number is required.", nameof(input));
        }

        var idempotencyKey = string.IsNullOrWhiteSpace(input.IdempotencyKey)
            ? Guid.NewGuid().ToString("D")
            : input.IdempotencyKey.Trim();

        var command = new XElement(Ns + "WorkPackage_Insert",
            new XElement(Ns + "CommandGUID", idempotencyKey),
            new XElement(Ns + "ProductionControlID", input.ProductionControlId),
            new XElement(Ns + "WorkPackageNumber", input.WorkPackageNumber.Trim()),
            new XElement(Ns + "Priority", input.Priority.ToString()),
            new XElement(Ns + "IsFuture", input.IsFuture ? "true" : "false"));

        AddIfPresent(command, "Description", input.Description);
        AddIfPresent(command, "Notes", input.Notes);
        AddIfPresent(command, "WorkshopID", input.WorkshopId);
        AddIfPresent(command, "Status", input.Status);
        AddIfPresent(command, "StartDate", input.StartDate);
        AddIfPresent(command, "DueDate", input.DueDate);
        AddIfPresent(command, "Group1", input.Group1);
        AddIfPresent(command, "Group2", input.Group2);

        _logger.LogInformation(
            "Creating work package {Name} on job {JobId} (idempotency_key={Key}).",
            input.WorkPackageNumber,
            input.ProductionControlId,
            idempotencyKey);

        XElement response;
        try
        {
            response = await _client.ExecuteAsync("WorkPackage_Insert", command, cancellationToken);
        }
        catch (PowerfabException ex)
        {
            _logger.LogWarning(ex, "PowerFab rejected WorkPackage_Insert for job {JobId}.", input.ProductionControlId);
            throw new McpException(ex.Message);
        }

        var idText = response
            .Elements()
            .FirstOrDefault(e => string.Equals(e.Name.LocalName, "WorkPackageID", StringComparison.OrdinalIgnoreCase))
            ?.Value?.Trim();

        if (!int.TryParse(idText, NumberStyles.Integer, CultureInfo.InvariantCulture, out var workPackageId))
        {
            throw new McpException(
                "WorkPackage_Insert succeeded but the response did not contain a numeric WorkPackageID.");
        }

        var message = $"Created work package '{input.WorkPackageNumber}' (id={workPackageId}) on job {input.ProductionControlId}.";
        _logger.LogInformation("{Message}", message);
        return new CreateWorkPackageResult(workPackageId, message);
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
        if (value.HasValue)
        {
            parent.Add(new XElement(Ns + name, value.Value.ToString(CultureInfo.InvariantCulture)));
        }
    }

    private static void AddIfPresent(XElement parent, string name, DateOnly? value)
    {
        if (value.HasValue)
        {
            parent.Add(new XElement(Ns + name, value.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture)));
        }
    }
}
