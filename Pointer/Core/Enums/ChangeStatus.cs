namespace Pointer.Core.Enums;

/// <summary>
/// Indicates the completion status of a Change or a ChangeRequest.
/// </summary>
public enum ChangeStatus
{
    Submitted,
    InProgress,
    Delayed,
    Cancelled,
    Complete
}