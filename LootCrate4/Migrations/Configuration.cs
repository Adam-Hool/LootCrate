namespace LootCrate4.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LootCrate4.Models.LootContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LootCrate4.Models.LootContext context)
        {
            context.Crate.AddOrUpdate(
                Batman => batman.crateItems,
                new Shirt { superHeroName = "Batman", size = 2 },
                new VideoGame { superHeroName = "Batman", Genre = "RPG",Title = "Arkam Asylem" },
                new Toy { superHeroName = "Batman", ToyName = "Batarang"},
                new BobbleHead { superHeroName = "Batman"});
        }
            //  ^
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        
    }
}
