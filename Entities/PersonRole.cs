namespace Entities
{
    public class PersonRole
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int RoleId { get; set; }
        public string PersonType { get; set; } = null!;
        public Role Role { get; set; } = null!;
        public NaturalPerson? NaturalPerson { get; set; }
        public LegalPerson? LegalPerson { get; set; }
    }
}
