namespace Pointer.Database.Transfer;

public class ControlObjectDto(string FilePath, string Type, int MajorRevision, int? MinorRevision, string Name, string? Notes)
{
    public int Id { get; set; }
    public string FilePath { get; set; } = FilePath;
    public string Type { get; set; } = Type;
    public int MajorRevision { get; set; } = MajorRevision;
    public int? MinorRevision { get; set; } = MinorRevision;
    public string Name { get; set; } = Name;
    public string? Notes { get; set; } = Notes;
}