using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using IMS.Models;

namespace IMS.DAL
{
    public class IMSContext : DbContext
    {
        public IMSContext() : base("IMSContext")
        {
        }
        public DbSet<Models.Category> Category { get; set; }
        public DbSet<Models.Currency> Currency { get; set; }
        public DbSet<Models.Inventory> Inventory { get; set; }
        public DbSet<Models.ItemPrice> ItemPrice { get; set; }
        public DbSet<Models.Location> Location { get; set; }
        public DbSet<Models.Price> Price { get; set; }
        public DbSet<Models.Type> Type { get; set; }


    }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
}

