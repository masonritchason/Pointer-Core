using Pointer.Core.Enums;
using Pointer.Core.Models;
using Pointer.Core.Types;

namespace Pointer.Core.Factories;

/// <summary>
/// Enables templated creation of ControlObjects.
/// </summary>
public class ControlObjectFactory
{
    /// <summary>
    /// Creates a new ControlObjectFactory.
    /// </summary>
    public ControlObjectFactory()
    {

    }

    /// <summary>
    /// Creates a new ControlObject model object from existing data.
    /// </summary>
    /// <param name="filePath"></param>
    /// <param name="majorRevision"></param>
    /// <param name="type"></param>
    /// <param name="name"></param>
    /// <param name="tags"></param>
    /// <param name="sections"></param>
    /// <param name="notes"></param>
    /// <param name="minorRevision"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public ControlObject CreateExisting(string filePath, int majorRevision, ControlObjectType type, string name, IEnumerable<ControlObjectTag> tags, IEnumerable<ControlObjectSection> sections, string? notes = null, int? minorRevision = null)
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
        return new ControlObject
        (
            filePath,
            majorRevision,
            type,
            name,
            tags,
            sections,
            notes,
            minorRevision
        );   
    }

    /// <summary>
    /// Creates a new ControlObject model object with default (empty) properties.
    /// </summary>
    /// <returns></returns>
    public ControlObject CreateNew()
    {
        return new ControlObject
        (
            "",
            1,
            ControlObjectType.None,
            "",
            [],
            [],
            null,
            null
        );
    }
}