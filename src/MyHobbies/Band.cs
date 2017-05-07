using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyHobbies
{
    public class Band
    {
        public string Naam { get; set; }
        public int Jaar { get; set; }
        public List<Bandlid> Bandleden { get; set; }
    }
}
