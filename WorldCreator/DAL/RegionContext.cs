using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WorldCreator.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WorldCreator.DAL
{
    public class RegionContext : DbContext
    {
        public RegionContext() : base("RegionContext")
        {
        }


        public DbSet<Creature> Creatures { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<NPC> NPCs { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}