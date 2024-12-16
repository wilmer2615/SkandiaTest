using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Municipality
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public ICollection<NaturalPerson> NaturalPersons { get; set; } = new List<NaturalPerson>();

    }
}
