namespace Pointer.Core.Enums;

/// <summary>
/// Indicates the type of action occuring in a Change to a ControlObject.
/// </summary>
public enum ChangeType
{
    Establish,
    Revise,
    NonRevisionChange,
    Obselete,
    Delete,
    Destroy
}