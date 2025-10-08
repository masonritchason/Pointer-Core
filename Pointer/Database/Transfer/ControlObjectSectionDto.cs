namespace Pointer.Database.Transfer;

public class ControlObjectSectionDto(int ControlObjectId, string Name, int? StartPage, int? EndPage)
{
    public int Id { get; set; }
    public int ControlObjectId { get; set; } = ControlObjectId;
    public string Name { get; set; } = Name;
    public int? StartPage { get; set; } = StartPage;
    public int? EndPage { get; set; } = EndPage;
}