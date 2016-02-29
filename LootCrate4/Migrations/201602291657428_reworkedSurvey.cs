namespace LootCrate4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reworkedSurvey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Surveys", "question1Score", c => c.String());
            AddColumn("dbo.Surveys", "question2Score", c => c.String());
            AddColumn("dbo.Surveys", "question3Score", c => c.String());
            AddColumn("dbo.Surveys", "question4Score", c => c.String());
            AddColumn("dbo.Surveys", "question5Score", c => c.String());
            AddColumn("dbo.Surveys", "question6Score", c => c.String());
            AddColumn("dbo.Surveys", "question7Score", c => c.String());
            AddColumn("dbo.Surveys", "question8Score", c => c.String());
            AddColumn("dbo.Surveys", "question9Score", c => c.String());
            AddColumn("dbo.Surveys", "question10Score", c => c.String());
            DropColumn("dbo.Surveys", "question");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Surveys", "question", c => c.String());
            DropColumn("dbo.Surveys", "question10Score");
            DropColumn("dbo.Surveys", "question9Score");
            DropColumn("dbo.Surveys", "question8Score");
            DropColumn("dbo.Surveys", "question7Score");
            DropColumn("dbo.Surveys", "question6Score");
            DropColumn("dbo.Surveys", "question5Score");
            DropColumn("dbo.Surveys", "question4Score");
            DropColumn("dbo.Surveys", "question3Score");
            DropColumn("dbo.Surveys", "question2Score");
            DropColumn("dbo.Surveys", "question1Score");
        }
    }
}
