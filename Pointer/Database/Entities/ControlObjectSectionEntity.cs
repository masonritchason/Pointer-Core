using System.ComponentModel.DataAnnotations;

namespace Pointer.Database.Entities;

/// <summary>
/// Structure of a ControlObjectSection in a Pointer database.
/// </summary>
public class ControlObjectSectionEntity(int Id, int ControlObjectId, string Name, int? StartPage, int? EndPage)
{
    [Key]
    public int Id { get; set; } = Id;

    [Required]
    public int ControlObjectId { get; set; } = ControlObjectId;

    [Required]
    [MaxLength(15)]
    public string Name { get; set; } = Name;

    public int? StartPage { get; set; } = StartPage;

    public int? EndPage { get; set; } = EndPage;
}