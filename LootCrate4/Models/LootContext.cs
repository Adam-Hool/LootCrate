using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LootCrate4.Models
{
    public class LootContext : DbContext
    {

        public LootContext() : base("DefaultConnection")
        { 

        }
        public DbSet<Crate> Crate { get; set; }
        public DbSet<CrateItem> CrateItem { get; set; }
        //public DbSet<Toy> Toy { get; set; }
    }
}