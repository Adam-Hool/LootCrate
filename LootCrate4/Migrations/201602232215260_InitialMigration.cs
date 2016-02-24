namespace LootCrate4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Crates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        crateName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CrateItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        toy_ID = c.Int(),
                        Crate_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Toys", t => t.toy_ID)
                .ForeignKey("dbo.Crates", t => t.Crate_ID)
                .Index(t => t.toy_ID)
                .Index(t => t.Crate_ID);
            
            CreateTable(
                "dbo.Toys",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ToyName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CrateItems", "Crate_ID", "dbo.Crates");
            DropForeignKey("dbo.CrateItems", "toy_ID", "dbo.Toys");
            DropIndex("dbo.CrateItems", new[] { "Crate_ID" });
            DropIndex("dbo.CrateItems", new[] { "toy_ID" });
            DropTable("dbo.Toys");
            DropTable("dbo.CrateItems");
            DropTable("dbo.Crates");
        }
    }
}
