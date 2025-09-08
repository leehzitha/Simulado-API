namespace simulado.Models;
public class ReadList
{
    public int ID { get; set; }
    public string Title { get; set; }
    public DateTime LastMod { get; set; }

    public int UserID { get; set; }
    public User Creator { get; set; }
    public ICollection<Fanfic> Fanfics { get; set; } = [];
};