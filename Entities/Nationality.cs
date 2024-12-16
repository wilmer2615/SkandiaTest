namespace Entities
{
    public class Nationality
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<NaturalPerson> NaturalPersons { get; set; } = new List<NaturalPerson>();

    }
}
