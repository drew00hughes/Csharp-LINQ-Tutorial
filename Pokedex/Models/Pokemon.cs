using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokedex.Models
{
    public class Pokemon
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string EggGroup { get; set; }
        public bool OnTeam { get; set; }
    }
}