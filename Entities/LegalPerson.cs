namespace Entities
{
    public class LegalPerson
    {
        public int Id { get; set; }
        public string Nit { get; set; } = null!;
        public string CompanyName { get; set; } = null!;
        public string CompanyType { get; set; } = null!;
        public int LegalRepresentativeId { get; set; }
        public NaturalPerson LegalRepresentative { get; set; } = null!;
        public ICollection<PersonRole> PersonRoles { get; set; } = new List<PersonRole>();

    }
}
