using Pointer.Core.Models;

namespace Pointer.Core.Types;

/// <summary>
/// A Section that represents a region of a ControlObject.
/// </summary>
public class ControlObjectSection
{
    /// <summary>
    /// The plain-text name assigned to the ControlObjectSection.
    /// </summary>
    public string Name;

    /// <summary>
    /// The ControlObject that the ControlObjectSection applies to.
    /// </summary>
    public ControlObject Parent;

    /// <summary>
    /// Creates a new ControlObjectSection.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="parent"></param>
    /// <exception cref="ArgumentException"></exception>
    public ControlObjectSection(string name, ControlObject parent)
    {
        if (name.Length < 3 || name.Length > 15)
        {
            throw new ArgumentException($"Cannot create a ControlObjectSection with a Name of length {name.Length}. ControlObjectSection names must be between 3 and 15 characters.", nameof(name));
        }
        Name = name;
        Parent = parent;
    }
}