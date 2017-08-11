using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldCreator.Models;

namespace WorldCreator.DAL
{
    public class RegionIntiallizer : System.Data.Entity.DropCreateDatabaseIfModelChanges<RegionContext>
    {
        protected override void Seed(RegionContext context)
        {
            var region = new List<Region>
            {
            new Region{RegionID = 1 , Name="Carson",WorldType=WorldType.Any,Level=4}

            };

            region.ForEach(r => context.Regions.Add(r));
            context.SaveChanges();
        }

    }
}