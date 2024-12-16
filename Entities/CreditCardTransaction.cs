namespace Entities
{
    public class CreditCardTransaction
    {
        public int Id { get; set; }
        public int CreditCardId { get; set; }
        public decimal Amount { get; set; }
        public int TransactionCreditCardTypeId { get; set; }
        public DateTime TransactionDate { get; set; }
        public Guid TransactionNumber { get; set; }
        public CreditCard CreditCard { get; set; } = null!;
        public TransactionsCreditCardType TransactionsCreditCardType { get; set; }

        // Constructor para generar el GUID automáticamente
        public CreditCardTransaction()
        {
            TransactionNumber = Guid.NewGuid();
        }
    }
}
