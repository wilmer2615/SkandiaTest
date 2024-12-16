namespace Entities
{
    public class Franchise
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public ICollection<CreditCard> CreditCards { get; set; } = new List<CreditCard>();

    }
}
