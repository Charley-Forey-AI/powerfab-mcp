using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PowerfabMcp.Server.Models;

/// <summary>
/// LLM-friendly input for the <c>create_work_package</c> tool. Properties map
/// 1:1 to <c>fsreqWorkPackage_Insert</c>.
/// </summary>
public sealed class CreateWorkPackageInput
{
    [Required]
    [Description("Production Control ID of the job that will own the work package.")]
    public int ProductionControlId { get; set; }

    [Required]
    [Description("Name / number of the new work package.")]
    public string WorkPackageNumber { get; set; } = string.Empty;

    [Description("Optional human-readable description.")]
    public string? Description { get; set; }

    [Description("Free-form notes attached to the work package.")]
    public string? Notes { get; set; }

    [Description("Workshop ID the work package should be scheduled to. Omit to leave unscheduled.")]
    public int? WorkshopId { get; set; }

    [Description("Status code (integer); meaning is configured per PowerFab installation.")]
    public int? Status { get; set; }

    [Description("Priority bucket: Low, Medium, or High. Defaults to Medium.")]
    public WorkPackagePriority Priority { get; set; } = WorkPackagePriority.Medium;

    [Description("Marks the work package as a future placeholder rather than current work.")]
    public bool IsFuture { get; set; }

    [Description("Planned start date (ISO 8601, e.g. 2026-05-20).")]
    public DateOnly? StartDate { get; set; }

    [Description("Due date (ISO 8601, e.g. 2026-05-30).")]
    public DateOnly? DueDate { get; set; }

    [Description("Optional grouping tag 1.")]
    public string? Group1 { get; set; }

    [Description("Optional grouping tag 2.")]
    public string? Group2 { get; set; }

    [Description(
        "Optional client-supplied idempotency key. Set to a stable value per logical " +
        "create attempt so retries do not double-create. A random GUID is used if omitted.")]
    public string? IdempotencyKey { get; set; }
}
