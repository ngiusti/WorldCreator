using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldCreator.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WorldCreator.DAL;

namespace WorldCreator.Models
{
    public class TotalModel
    {
        public RegionContext db = new RegionContext();
        public List<Creature> Creature { get; set; }
        public List<NPC> NPC { get; set; }

    }
}