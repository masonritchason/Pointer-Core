using Pointer.Core.Enums;
using Pointer.Core.Types;

namespace Pointer.Core.Models;

/// <summary>
/// An individual controlled item of a specific type, indicated by <see cref="ControlObjectType"/>.
/// </summary>
public class ControlObject
{
    /// <summary>
    /// Indicates the most recent revision number of the ControlObject (the number of revisions made to the item).
    /// </summary>
    private int MajorRevision;

    /// <summary>
    /// Indicates an optional minor revision number of the ControlObject (a revision made on the Major revision).
    /// </summary>
    private int? MinorRevision;

    /// <summary>
    /// The unique type of the ControlObject.
    /// </summary>
    public readonly ControlObjectType Type;

    /// <summary>
    /// The plain-text name assigned to the ControlObject.
    /// </summary>
    public string Name { get; private set; }

    /// <summary>
    /// Contains any special notes or remarks made on the ControlObject.
    /// </summary>
    public string? Notes { get; private set; }

    /// <summary>
    /// A set of ControlObjectTags that categorize the ControlObject.
    /// </summary>
    public IEnumerable<ControlObjectTag> Tags { get; private set; }

    /// <summary>
    /// A set of ControlObjectSections that outline the structure of the ControlObject.
    /// </summary>
    public IEnumerable<ControlObjectSection> Sections { get; private set; }

    /// <summary>
    /// Creates a new ControlObject.
    /// </summary>
    /// <param name="majorRevision">Indicates the most recent revision number of the ControlObject (the number of revisions made to the item).</param>
    /// <param name="type">The unique type of the ControlObject.</param>
    /// <param name="name">The plain-text name assigned to the ControlObject.</param>
    /// <param name="tags">A set of ControlObjectTags that categorize the ControlObject.</param>
    /// <param name="sections">A set of ControlObjectSections that outline the structure of the ControlObject.</param>
    /// <param name="notes">Contains any special notes or remarks made on the ControlObject.</param>
    /// <param name="minorRevision">Indicates an optional minor revision number of the ControlObject (a revision made on the Major revision).</param>
    /// <exception cref="ArgumentException"></exception>
    public ControlObject(int majorRevision, ControlObjectType type, string name, IEnumerable<ControlObjectTag> tags, IEnumerable<ControlObjectSection> sections, string? notes = null, int? minorRevision = null)
    {
        if (majorRevision < 0)
        {
            throw new ArgumentException("Cannot create a ControlObject with a negative revision.", nameof(majorRevision));
        }
        if (name.Length < 3 || name.Length > 30)
        {
            throw new ArgumentException($"Cannot create a ControlObject with a Name of length {name.Length}. ControlObject names must be between 3 and 30 characters.", nameof(name));
        }
        if (!sections.Any())
        {
            throw new ArgumentException("Cannot create a ControlObject without at least one defined Section.", nameof(sections));
        }
        MajorRevision = majorRevision;
        Type = type;
        Name = name;
        Tags = tags;
        Sections = sections;
        Notes = notes;
        MinorRevision = minorRevision;
    }
}