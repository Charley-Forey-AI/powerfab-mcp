namespace PowerfabMcp.Server.Models;

/// <summary>
/// One row from <c>GetProductionControlJobs</c> (PowerFab production control job list).
/// </summary>
public sealed record ProductionControlJobSummary(
    int ProductionControlId,
    string JobNumber,
    string JobDescription,
    string? JobLocation,
    string? GroupName,
    string? GroupName2,
    int? CutListCount);
