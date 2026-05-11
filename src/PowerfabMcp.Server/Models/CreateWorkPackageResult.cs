namespace PowerfabMcp.Server.Models;

/// <summary>
/// Successful response shape returned by <c>create_work_package</c>.
/// </summary>
public sealed record CreateWorkPackageResult(
    int WorkPackageId,
    string Message);
