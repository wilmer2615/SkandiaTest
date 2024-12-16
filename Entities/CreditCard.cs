using System;

namespace Entities
{
    public class CreditCard
    {
        public int Id { get; set; }
        public string CardNumber { get; set; } = null!;
        public int FranchiseId { get; set; }
        public decimal ApprovedLimit { get; set; }
        public bool State { get; set; }

        public int PersonId { get; set; }
        public NaturalPerson Person { get; set; } = null!;
        public Franchise Franchise { get; set; } = null!;

        public ICollection<CreditCardTransaction> Transactions { get; set; } = new List<CreditCardTransaction>();

    }
}
