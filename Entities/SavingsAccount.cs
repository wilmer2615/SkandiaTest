
namespace Entities
{
    public class SavingsAccount
    {
        public int Id { get; set; }
        public Guid AccountNumber { get; set; }
        public bool State { get; set; }
        public ICollection<SavingsAccountHolder> AccountHolders { get; set; } = new List<SavingsAccountHolder>();
        public ICollection<SavingsAccountTransaction> Transactions { get; set; } = new List<SavingsAccountTransaction>();


        public SavingsAccount()
        {
            // Generar el GUID cuando se cree una nueva cuenta
            AccountNumber = Guid.NewGuid();
        }
    }
}
