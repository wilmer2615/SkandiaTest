namespace Entities
{
    public class SavingsAccountTransaction
    {
        public int Id { get; set; }
        public int SavingsAccountId { get; set; }
        public decimal Amount { get; set; }
        public int TransactionTypeId { get; set; }
        public int? ExchangeTransactionStateId { get; set; }
        public DateTime TransactionDate { get; set; }
        public Guid TransactionNumber { get; set; }
        public SavingsAccount SavingsAccount { get; set; } = null!;
        public TransactionType TransactionType { get; set; } = null!;
        public ExchangeTransactionState ExchangeTransactionState { get; set; } = null!;



        // Constructor para generar el GUID automáticamente
        public SavingsAccountTransaction()
        {
            TransactionNumber = Guid.NewGuid();
        }

    }
}
