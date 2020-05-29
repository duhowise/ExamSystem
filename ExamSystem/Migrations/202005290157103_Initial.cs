namespace ExamSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnsweredQuestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        testid = c.Int(),
                        userid = c.Int(),
                        questionid = c.Int(),
                        useranswer = c.String(maxLength: 10, fixedLength: true),
                        temp = c.String(),
                        tempass = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Test", t => t.testid)
                .ForeignKey("dbo.Users", t => t.userid)
                .Index(t => t.testid)
                .Index(t => t.userid);
            
            CreateTable(
                "dbo.Test",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        testcode = c.String(nullable: false, maxLength: 50),
                        NumberofQ = c.Int(),
                        Time = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.answer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        QuestionId = c.Int(),
                        QuestionAnswer = c.String(),
                        TestId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Question", t => t.QuestionId)
                .ForeignKey("dbo.Test", t => t.TestId)
                .Index(t => t.QuestionId)
                .Index(t => t.TestId);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        testid = c.Int(nullable: false),
                        mark = c.Int(nullable: false),
                        text = c.String(nullable: false),
                        opA = c.String(nullable: false),
                        opB = c.String(nullable: false),
                        opC = c.String(),
                        opd = c.String(),
                        answer = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Test", t => t.testid)
                .Index(t => t.testid);
            
            CreateTable(
                "dbo.UserMarks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Userid = c.Int(nullable: false),
                        Testid = c.Int(nullable: false),
                        Questionid = c.Int(nullable: false),
                        Mark = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Userid)
                .ForeignKey("dbo.Question", t => t.Questionid)
                .ForeignKey("dbo.Test", t => t.Testid)
                .Index(t => t.Userid)
                .Index(t => t.Testid)
                .Index(t => t.Questionid);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 75),
                        password = c.String(nullable: false, maxLength: 75),
                        UserType = c.String(nullable: false, maxLength: 30),
                        testid = c.Int(),
                        status = c.String(maxLength: 20),
                        position = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Test", t => t.testid)
                .Index(t => t.testid);
            
            CreateTable(
                "dbo.TotalMarks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        userid = c.Int(),
                        testid = c.Int(),
                        marks = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Test", t => t.testid)
                .ForeignKey("dbo.Users", t => t.userid)
                .Index(t => t.userid)
                .Index(t => t.testid);
            
            CreateTable(
                "dbo.NamesTestsadnScores",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        NAMEOFSTUDENT = c.String(name: "NAME OF STUDENT", nullable: false, maxLength: 75),
                        TESTTAKEN = c.String(name: "TEST TAKEN", nullable: false, maxLength: 50),
                        marks = c.String(nullable: false, maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => new { t.Id, t.NAMEOFSTUDENT, t.TESTTAKEN, t.marks });
            
            CreateTable(
                "dbo.Position",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.Id, t.Name });
            
            CreateTable(
                "dbo.UserInformation",
                c => new
                    {
                        NAME = c.String(nullable: false, maxLength: 75),
                        PASSWORD = c.String(nullable: false, maxLength: 75),
                        STATUS = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => new { t.NAME, t.PASSWORD });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserMarks", "Testid", "dbo.Test");
            DropForeignKey("dbo.Question", "testid", "dbo.Test");
            DropForeignKey("dbo.answer", "TestId", "dbo.Test");
            DropForeignKey("dbo.UserMarks", "Questionid", "dbo.Question");
            DropForeignKey("dbo.UserMarks", "Userid", "dbo.Users");
            DropForeignKey("dbo.TotalMarks", "userid", "dbo.Users");
            DropForeignKey("dbo.TotalMarks", "testid", "dbo.Test");
            DropForeignKey("dbo.Users", "testid", "dbo.Test");
            DropForeignKey("dbo.AnsweredQuestions", "userid", "dbo.Users");
            DropForeignKey("dbo.answer", "QuestionId", "dbo.Question");
            DropForeignKey("dbo.AnsweredQuestions", "testid", "dbo.Test");
            DropIndex("dbo.TotalMarks", new[] { "testid" });
            DropIndex("dbo.TotalMarks", new[] { "userid" });
            DropIndex("dbo.Users", new[] { "testid" });
            DropIndex("dbo.UserMarks", new[] { "Questionid" });
            DropIndex("dbo.UserMarks", new[] { "Testid" });
            DropIndex("dbo.UserMarks", new[] { "Userid" });
            DropIndex("dbo.Question", new[] { "testid" });
            DropIndex("dbo.answer", new[] { "TestId" });
            DropIndex("dbo.answer", new[] { "QuestionId" });
            DropIndex("dbo.AnsweredQuestions", new[] { "userid" });
            DropIndex("dbo.AnsweredQuestions", new[] { "testid" });
            DropTable("dbo.UserInformation");
            DropTable("dbo.Position");
            DropTable("dbo.NamesTestsadnScores");
            DropTable("dbo.TotalMarks");
            DropTable("dbo.Users");
            DropTable("dbo.UserMarks");
            DropTable("dbo.Question");
            DropTable("dbo.answer");
            DropTable("dbo.Test");
            DropTable("dbo.AnsweredQuestions");
        }
    }
}
