using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldCreator.Models
{
    public class Region
    {
        public int RegionID { get; set; }
        public string Name { get; set; }
        public WorldType? WorldType { get; set; }
        public int Level { get; set; }
        public string Information { get; set; }

        public virtual Creature Creature { get; set; }
        public virtual NPC NPC { get; set; }
    }

    public enum WorldType
    {
        Any, Aquatic, Desert, Forest, Hill, Marsh, Mountain, Plain, Underground
    }
}