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
    /// The page range of the ControlObject that the ControlObjectSection applies to.
    /// </summary>
    /// <remarks>
    /// Only applicable on ControlObjects with Type == ControlObjectType.Document, ControlObjectType.SampleDocument, or ControlObjectType.TemplateDocument.
    /// </remarks>
    public IEnumerable<int>? PageRange;

    /// <summary>
    /// Creates a new ControlObjectSection.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="parent"></param>
    /// <param name="pageRange"></param>
    /// <exception cref="ArgumentException"></exception>
    public ControlObjectSection(string name, ControlObject parent, IEnumerable<int>? pageRange = null)
    {
        if (name.Length < 3 || name.Length > 15)
        {
            throw new ArgumentException($"Cannot create a ControlObjectSection with a Name of length {name.Length}. ControlObjectSection names must be between 3 and 15 characters.", nameof(name));
        }
        if
        (
            parent.Type == Enums.ControlObjectType.Document
            || parent.Type == Enums.ControlObjectType.SampleDocument
            || parent.Type == Enums.ControlObjectType.TemplateDocument
        )
        {
            if (pageRange is null)
            {
                throw new ArgumentException($"Cannot create a ControlObjectSection of a ControlObject of type {parent.Type} without at least one Page.", nameof(pageRange));
            }
        }
        else
        {
            pageRange = null;
        }
        Name = name;
        Parent = parent;
        PageRange = pageRange;
    }
}