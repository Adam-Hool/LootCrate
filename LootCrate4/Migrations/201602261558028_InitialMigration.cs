namespace LootCrate4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BobbleHeads",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        superHeroName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Crates",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        crateName = c.String(),
                        bobbleHead_ID = c.Int(),
                        shirt_ID = c.Int(),
                        toy_ID = c.Int(),
                        videoGame_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BobbleHeads", t => t.bobbleHead_ID)
                .ForeignKey("dbo.Shirts", t => t.shirt_ID)
                .ForeignKey("dbo.Toys", t => t.toy_ID)
                .ForeignKey("dbo.VideoGames", t => t.videoGame_ID)
                .Index(t => t.bobbleHead_ID)
                .Index(t => t.shirt_ID)
                .Index(t => t.toy_ID)
                .Index(t => t.videoGame_ID);
            
            CreateTable(
                "dbo.Shirts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        size = c.Int(nullable: false),
                        superHeroName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Toys",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ToyName = c.String(),
                        superHeroName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VideoGames",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Genre = c.String(),
                        superHeroName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CrateItems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        bobbleHead_ID = c.Int(),
                        shirt_ID = c.Int(),
                        toy_ID = c.Int(),
                        videoGame_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.BobbleHeads", t => t.bobbleHead_ID)
                .ForeignKey("dbo.Shirts", t => t.shirt_ID)
                .ForeignKey("dbo.Toys", t => t.toy_ID)
                .ForeignKey("dbo.VideoGames", t => t.videoGame_ID)
                .Index(t => t.bobbleHead_ID)
                .Index(t => t.shirt_ID)
                .Index(t => t.toy_ID)
                .Index(t => t.videoGame_ID);
            
            CreateTable(
                "dbo.Surveys",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        question = c.String(),
                        questionAnswer = c.String(),
                        questionScore = c.Int(nullable: false),
                        totalScore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CrateItems", "videoGame_ID", "dbo.VideoGames");
            DropForeignKey("dbo.CrateItems", "toy_ID", "dbo.Toys");
            DropForeignKey("dbo.CrateItems", "shirt_ID", "dbo.Shirts");
            DropForeignKey("dbo.CrateItems", "bobbleHead_ID", "dbo.BobbleHeads");
            DropForeignKey("dbo.Crates", "videoGame_ID", "dbo.VideoGames");
            DropForeignKey("dbo.Crates", "toy_ID", "dbo.Toys");
            DropForeignKey("dbo.Crates", "shirt_ID", "dbo.Shirts");
            DropForeignKey("dbo.Crates", "bobbleHead_ID", "dbo.BobbleHeads");
            DropIndex("dbo.CrateItems", new[] { "videoGame_ID" });
            DropIndex("dbo.CrateItems", new[] { "toy_ID" });
            DropIndex("dbo.CrateItems", new[] { "shirt_ID" });
            DropIndex("dbo.CrateItems", new[] { "bobbleHead_ID" });
            DropIndex("dbo.Crates", new[] { "videoGame_ID" });
            DropIndex("dbo.Crates", new[] { "toy_ID" });
            DropIndex("dbo.Crates", new[] { "shirt_ID" });
            DropIndex("dbo.Crates", new[] { "bobbleHead_ID" });
            DropTable("dbo.Surveys");
            DropTable("dbo.CrateItems");
            DropTable("dbo.VideoGames");
            DropTable("dbo.Toys");
            DropTable("dbo.Shirts");
            DropTable("dbo.Crates");
            DropTable("dbo.BobbleHeads");
        }
    }
}
