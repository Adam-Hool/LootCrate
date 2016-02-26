namespace LootCrate4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedSurveysModle : DbMigration
    {
        public override void Up()
        {
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
            DropTable("dbo.Surveys");
        }
    }
}
