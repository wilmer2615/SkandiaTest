namespace Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<PersonRole> PersonRoles { get; set; } = new List<PersonRole>();

    }
}
