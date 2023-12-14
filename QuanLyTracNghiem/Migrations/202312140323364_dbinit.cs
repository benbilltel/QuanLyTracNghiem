namespace QuanLyTracNghiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbinit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assignment",
                c => new
                    {
                        IDStudent = c.Int(nullable: false),
                        IDExam = c.Int(nullable: false),
                        IDQuestion = c.Int(nullable: false),
                        Answer = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => new { t.IDStudent, t.IDExam, t.IDQuestion })
                .ForeignKey("dbo.Exam", t => t.IDExam, cascadeDelete: true)
                .ForeignKey("dbo.Question", t => t.IDQuestion, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.IDStudent, cascadeDelete: true)
                .Index(t => t.IDStudent)
                .Index(t => t.IDExam)
                .Index(t => t.IDQuestion);
            
            CreateTable(
                "dbo.Exam",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        IDSubject = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Subject", t => t.IDSubject)
                .Index(t => t.IDSubject);
            
            CreateTable(
                "dbo.Subject",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Content = c.String(nullable: false, storeType: "ntext"),
                        A = c.String(nullable: false, storeType: "ntext"),
                        B = c.String(nullable: false, storeType: "ntext"),
                        C = c.String(nullable: false, storeType: "ntext"),
                        D = c.String(nullable: false, storeType: "ntext"),
                        Answer = c.Byte(nullable: false),
                        IDChapter = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Chapter", t => t.IDChapter, cascadeDelete: true)
                .Index(t => t.IDChapter);
            
            CreateTable(
                "dbo.Chapter",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        IDSubject = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Subject", t => t.IDSubject, cascadeDelete: true)
                .Index(t => t.IDSubject);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        LastName = c.String(nullable: false, maxLength: 20),
                        Address = c.String(nullable: false, maxLength: 100),
                        Gender = c.Byte(nullable: false),
                        Phone = c.String(nullable: false, maxLength: 12),
                        IDClassroom = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Classroom", t => t.IDClassroom, cascadeDelete: true)
                .Index(t => t.Phone, unique: true)
                .Index(t => t.IDClassroom);
            
            CreateTable(
                "dbo.Classroom",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Name, unique: true);
            
            CreateTable(
                "dbo.ExamDetail",
                c => new
                    {
                        IDQuestion = c.Int(nullable: false),
                        IDExam = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IDQuestion, t.IDExam })
                .ForeignKey("dbo.Exam", t => t.IDExam, cascadeDelete: true)
                .ForeignKey("dbo.Question", t => t.IDQuestion, cascadeDelete: true)
                .Index(t => t.IDQuestion)
                .Index(t => t.IDExam);
            
            CreateTable(
                "dbo.ListSubject",
                c => new
                    {
                        IDSubejct = c.Int(nullable: false),
                        IDClassroom = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.IDSubejct, t.IDClassroom })
                .ForeignKey("dbo.Classroom", t => t.IDClassroom, cascadeDelete: true)
                .ForeignKey("dbo.Subject", t => t.IDSubejct, cascadeDelete: true)
                .Index(t => t.IDSubejct)
                .Index(t => t.IDClassroom);
            
            CreateTable(
                "dbo.UserAdmin",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 20),
                        Password = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Username, unique: true);
            
            CreateTable(
                "dbo.UserStudent",
                c => new
                    {
                        IDStudent = c.Int(nullable: false),
                        Username = c.String(nullable: false, maxLength: 16),
                        Password = c.String(nullable: false, maxLength: 16),
                        Status = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.IDStudent)
                .ForeignKey("dbo.Student", t => t.IDStudent)
                .Index(t => t.IDStudent);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserStudent", "IDStudent", "dbo.Student");
            DropForeignKey("dbo.ListSubject", "IDSubejct", "dbo.Subject");
            DropForeignKey("dbo.ListSubject", "IDClassroom", "dbo.Classroom");
            DropForeignKey("dbo.ExamDetail", "IDQuestion", "dbo.Question");
            DropForeignKey("dbo.ExamDetail", "IDExam", "dbo.Exam");
            DropForeignKey("dbo.Assignment", "IDStudent", "dbo.Student");
            DropForeignKey("dbo.Student", "IDClassroom", "dbo.Classroom");
            DropForeignKey("dbo.Assignment", "IDQuestion", "dbo.Question");
            DropForeignKey("dbo.Question", "IDChapter", "dbo.Chapter");
            DropForeignKey("dbo.Chapter", "IDSubject", "dbo.Subject");
            DropForeignKey("dbo.Assignment", "IDExam", "dbo.Exam");
            DropForeignKey("dbo.Exam", "IDSubject", "dbo.Subject");
            DropIndex("dbo.UserStudent", new[] { "IDStudent" });
            DropIndex("dbo.UserAdmin", new[] { "Username" });
            DropIndex("dbo.ListSubject", new[] { "IDClassroom" });
            DropIndex("dbo.ListSubject", new[] { "IDSubejct" });
            DropIndex("dbo.ExamDetail", new[] { "IDExam" });
            DropIndex("dbo.ExamDetail", new[] { "IDQuestion" });
            DropIndex("dbo.Classroom", new[] { "Name" });
            DropIndex("dbo.Student", new[] { "IDClassroom" });
            DropIndex("dbo.Student", new[] { "Phone" });
            DropIndex("dbo.Chapter", new[] { "IDSubject" });
            DropIndex("dbo.Question", new[] { "IDChapter" });
            DropIndex("dbo.Subject", new[] { "Name" });
            DropIndex("dbo.Exam", new[] { "IDSubject" });
            DropIndex("dbo.Assignment", new[] { "IDQuestion" });
            DropIndex("dbo.Assignment", new[] { "IDExam" });
            DropIndex("dbo.Assignment", new[] { "IDStudent" });
            DropTable("dbo.UserStudent");
            DropTable("dbo.UserAdmin");
            DropTable("dbo.ListSubject");
            DropTable("dbo.ExamDetail");
            DropTable("dbo.Classroom");
            DropTable("dbo.Student");
            DropTable("dbo.Chapter");
            DropTable("dbo.Question");
            DropTable("dbo.Subject");
            DropTable("dbo.Exam");
            DropTable("dbo.Assignment");
        }
    }
}
