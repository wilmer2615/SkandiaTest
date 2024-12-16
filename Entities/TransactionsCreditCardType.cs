namespace Entities
{
    public class TransactionsCreditCardType
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public ICollection<CreditCardTransaction> Transactions { get; set; } = new List<CreditCardTransaction>();

    }
}
