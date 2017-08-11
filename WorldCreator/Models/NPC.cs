using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldCreator.Models
{
    public class NPC
    {
        public int NPCID { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Information { get; set; }

        public virtual ICollection<Region> Region { get; set; }

    }
}