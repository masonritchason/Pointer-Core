using System.Drawing;

namespace Pointer.Core.Types;

/// <summary>
/// A Tag that can be used to categorize ControlObjects.
/// </summary>
public class ControlObjectTag
{
    /// <summary>
    /// The plain-text name assigned to the ControlObjectTag.
    /// </summary>
    public readonly string Name;

    /// <summary>
    /// The Color to display the ControlObjectTag Name on in UI.
    /// </summary>
    public Color Color;

    /// <summary>
    /// Any optional notes attached to the ControlObjectTag.
    /// </summary>
    public string? Notes;

    /// <summary>
    /// Creates a new ControlObjectTag object.
    /// </summary>
    /// <param name="name">The plain-text name assigned to the ControlObjectTag; 3-20 characters.</param>
    /// <param name="color">The Color to display the ControlObjectTag Name on in UI.</param>
    /// <exception cref="ArgumentException"></exception>
    public ControlObjectTag(string name, Color? color = null)
    {
        if (name.Length < 3 || name.Length > 20)
        {
            throw new ArgumentException($"Cannot create a ControlObjectTag with a Name of length {name.Length}. ControlObjectTag names must be between 3 and 20 characters.", nameof(name));
        }
        if (color is null)
        {
            color = Color.AntiqueWhite;
        }
        Color = (Color)color;
        Name = name;
    }
}