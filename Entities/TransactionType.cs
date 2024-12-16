namespace Entities
{
    public class TransactionType
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public ICollection<SavingsAccountTransaction> Transactions { get; set; } = new List<SavingsAccountTransaction>();

    }
}
 