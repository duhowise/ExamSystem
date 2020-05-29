namespace ExamSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedModels : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.AnsweredQuestions", new[] { "testid" });
            DropIndex("dbo.AnsweredQuestions", new[] { "userid" });
            DropIndex("dbo.Question", new[] { "testid" });
            DropIndex("dbo.Users", new[] { "testid" });
            DropIndex("dbo.TotalMarks", new[] { "userid" });
            DropIndex("dbo.TotalMarks", new[] { "testid" });
            CreateIndex("dbo.AnsweredQuestions", "Testid");
            CreateIndex("dbo.AnsweredQuestions", "Userid");
            CreateIndex("dbo.Question", "Testid");
            CreateIndex("dbo.Users", "Testid");
            CreateIndex("dbo.TotalMarks", "Userid");
            CreateIndex("dbo.TotalMarks", "Testid");
            DropColumn("dbo.AnsweredQuestions", "temp");
            DropColumn("dbo.AnsweredQuestions", "tempass");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AnsweredQuestions", "tempass", c => c.String(maxLength: 10, fixedLength: true));
            AddColumn("dbo.AnsweredQuestions", "temp", c => c.String());
            DropIndex("dbo.TotalMarks", new[] { "Testid" });
            DropIndex("dbo.TotalMarks", new[] { "Userid" });
            DropIndex("dbo.Users", new[] { "Testid" });
            DropIndex("dbo.Question", new[] { "Testid" });
            DropIndex("dbo.AnsweredQuestions", new[] { "Userid" });
            DropIndex("dbo.AnsweredQuestions", new[] { "Testid" });
            CreateIndex("dbo.TotalMarks", "testid");
            CreateIndex("dbo.TotalMarks", "userid");
            CreateIndex("dbo.Users", "testid");
            CreateIndex("dbo.Question", "testid");
            CreateIndex("dbo.AnsweredQuestions", "userid");
            CreateIndex("dbo.AnsweredQuestions", "testid");
        }
    }
}
