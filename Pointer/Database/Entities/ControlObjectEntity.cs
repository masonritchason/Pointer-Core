using System.ComponentModel.DataAnnotations;

namespace Pointer.Database.Entities;

/// <summary>
/// Structure of a ControlObject in a Pointer Database.
/// </summary>
/// <param name="Id"></param>
/// <param name="FilePath"></param>
/// <param name="Type"></param>
/// <param name="MajorRevision"></param>
/// <param name="MinorRevision"></param>
/// <param name="Name"></param>
/// <param name="Notes"></param>
public class ControlObjectEntity(int Id, string FilePath, string Type, int MajorRevision, int? MinorRevision, string Name, string? Notes)
{
    [Key]
    public int Id { get; set; } = Id;

    [Required]
    [MaxLength(100)]
    public string FilePath { get; set; } = FilePath;

    [Required]
    [MaxLength(20)]
    public string Type { get; set; } = Type;

    [Required]
    public int MajorRevision { get; set; } = MajorRevision;

    public int? MinorRevision { get; set; } = MinorRevision;

    [Required]
    [MaxLength(30)]
    public string Name { get; set; } = Name;

    public string? Notes { get; set; } = Notes;
}