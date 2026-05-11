namespace PowerfabMcp.Server.Models;

/// <summary>
/// Input for <see cref="Tools.ProductionControlTools.ListAsync"/>.
/// </summary>
public sealed class ListProductionControlJobsInput
{
    public string? GroupName { get; set; }
    public string? GroupName2 { get; set; }
    public string? JobNumber { get; set; }
    public bool IncludeClosedJobs { get; set; }
    public bool OnlyLinkedToProject { get; set; }
    public bool OnlyContainingCutLists { get; set; }
    public int? ProductionControlId { get; set; }
}
