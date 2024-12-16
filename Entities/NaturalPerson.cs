namespace Entities
{
    public class NaturalPerson
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string DocumentTipe { get; set; } = null!;
        public string DocumentNumber { get; set; } = null!;
        public int DepartmentId { get; set; }
        public int MunicipalityId { get; set; }
        public int NationalityId { get; set; }
        public DateTime Birthdate { get; set; }
        public Department Department { get; set; } = null!;
        public Municipality Municipality { get; set; } = null!;
        public Nationality Nationality { get; set; } = null!;
        public ICollection<PersonRole> PersonRoles { get; set; } = new List<PersonRole>();
        public ICollection<LegalPerson> LegalPersons { get; set; } = new List<LegalPerson>();
        public ICollection<SavingsAccountHolder> SavingsAccountHolders { get; set; } = new List<SavingsAccountHolder>();
        public ICollection<CreditCard> CreditCards { get; set; } = new List<CreditCard>();

    }
}
