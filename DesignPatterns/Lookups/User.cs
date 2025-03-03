namespace Lookups
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Achat> Achats { get; set; } = new List<Achat>();
    }
}
