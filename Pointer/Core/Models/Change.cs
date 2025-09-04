using Pointer.Core.Enums;
using Pointer.Core.Types;

namespace Pointer.Core.Models;

/// <summary>
/// A Change to a ControlObject that affects specified ControlObjectSections.
/// </summary>
public class Change
{
    /// <summary>
    /// Allows the Change to be created in "Forced" mode, which will automatically approve the Change.
    /// </summary>
    private bool IsForced = false;

    /// <summary>
    /// The accepted status of the Change.
    /// </summary>
    public bool IsAccepted = false;

    /// <summary>
    /// The completion status of the Change.
    /// </summary>
    public ChangeStatus Status;

    /// <summary>
    /// The type of change that the Change represents.
    /// </summary>
    public ChangeType Type;

    /// <summary>
    /// The ControlObject that the Change affects.
    /// </summary>
    public ControlObject Target;

    /// <summary>
    /// The ControlObjectSections of the ControlObject that the Change affects.
    /// </summary>
    public IEnumerable<ControlObjectSection> TargetSections;

    /// <summary>
    /// A short description of the Change.
    /// </summary>
    public string Description;

    /// <summary>
    /// Contains any special notes or remarks made on the Change.
    /// </summary>
    public string? AdditionalNotes;

    /// <summary>
    /// Creates a new Change.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="target"></param>
    /// <param name="targetSections"></param>
    /// <param name="description">; 3-75 characters.</param>
    /// <param name="additionalNotes"></param>
    /// <exception cref="ArgumentException"></exception>
    public Change(ChangeType type, ControlObject target, IEnumerable<ControlObjectSection> targetSections, string description, string? additionalNotes = null)
    {
        if (!targetSections.Any())
        {
            throw new ArgumentException("Cannot create a Change that is not linked to any Section of a ControlObject.", nameof(targetSections));
        }
        foreach (ControlObjectSection _section in targetSections)
        {
            if (!_section.Parent.Equals(target))
            {
                throw new ArgumentException($"Cannot create a Change to {target} ControlObject with unrelated ControlObjectSection {_section}.", nameof(targetSections));
            }
        }
        if (description.Length < 3 || description.Length > 75)
        {
            throw new ArgumentException($"Cannot create a Change with a Description of length {description.Length}. Change descriptions must be between 3 and 75 characters.", nameof(description));
        }
        Type = type;
        Target = target;
        TargetSections = targetSections;
        Description = description;
        AdditionalNotes = additionalNotes;
    }
}