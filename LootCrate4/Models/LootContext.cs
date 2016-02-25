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

        public System.Data.Entity.DbSet<LootCrate4.Models.VideoGame> VideoGames { get; set; }

        public System.Data.Entity.DbSet<LootCrate4.Models.Shirt> Shirts { get; set; }

        public System.Data.Entity.DbSet<LootCrate4.Models.BobbleHead> BobbleHeads { get; set; }

        public System.Data.Entity.DbSet<LootCrate4.Models.Toy> Toys { get; set; }

        public System.Data.Entity.DbSet<LootCrate4.Models.Survey> Surveys { get; set; }
        //public DbSet<Toy> Toy { get; set; }
    }
}