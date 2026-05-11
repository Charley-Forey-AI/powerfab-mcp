namespace PowerfabMcp.Server.Models;

/// <summary>
/// Mirror of the PowerFab <c>fsPriority</c> enumeration. Values must match the
/// XML token names since they are serialised straight into the request body.
/// </summary>
public enum WorkPackagePriority
{
    Low = 0,
    Medium = 1,
    High = 2,
}
