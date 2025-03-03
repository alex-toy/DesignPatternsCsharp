namespace Lookups;

public class Article
{
    public int Id { get; set; }
    public string Title { get; set; }
    public double Price { get; set; }
    public List<Achat> Achats { get; set; } = new List<Achat>();
}
