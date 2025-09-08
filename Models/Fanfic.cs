namespace simulado.Models;

public class Fanfic
{
    public int ID { get; set; }
    public int CreatorID { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }

    public required User Creator { get; set; }
    public ICollection<ReadList> ReadLists { get; set; } = [];
}