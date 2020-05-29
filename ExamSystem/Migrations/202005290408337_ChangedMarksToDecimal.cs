namespace ExamSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedMarksToDecimal : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.NamesTestsadnScores");
            AlterColumn("dbo.NamesTestsadnScores", "Marks", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddPrimaryKey("dbo.NamesTestsadnScores", new[] { "Id", "NAME OF STUDENT", "TEST TAKEN" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.NamesTestsadnScores");
            AlterColumn("dbo.NamesTestsadnScores", "Marks", c => c.String(nullable: false, maxLength: 10, fixedLength: true));
            AddPrimaryKey("dbo.NamesTestsadnScores", new[] { "Id", "NAME OF STUDENT", "TEST TAKEN", "Marks" });
        }
    }
}
