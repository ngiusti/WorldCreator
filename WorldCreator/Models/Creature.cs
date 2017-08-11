using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WorldCreator.Models
{
    public class Creature
    {
        public int CreatureID { get; set; }
        public string CreatureName { get; set; }
        public int Hitpoints { get; set; }
        public int Speed { get; set; }
        public IEnumerable<SelectListItem> Attack { get; set; }
        public string Information { get; set; }

        public virtual ICollection<Region> Region { get; set; }
    }
}