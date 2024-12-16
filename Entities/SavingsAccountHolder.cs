namespace Entities
{
    public class SavingsAccountHolder
    {
        public int Id { get; set; }
        public int SavingsAccountId { get; set; }
        public int PersonId { get; set; }
        public SavingsAccount SavingsAccount { get; set; } = null!;
        public NaturalPerson? NaturalPerson { get; set; }

    }
}
