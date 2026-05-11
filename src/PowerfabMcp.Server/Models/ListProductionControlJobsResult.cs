namespace PowerfabMcp.Server.Models;

/// <summary>
/// Result of <c>list_production_control_jobs</c>.
/// </summary>
public sealed record ListProductionControlJobsResult(
    IReadOnlyList<ProductionControlJobSummary> Jobs,
    string Message);
