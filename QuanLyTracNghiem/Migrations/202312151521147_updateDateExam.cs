namespace QuanLyTracNghiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDateExam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Exam", "DateTake", c => c.DateTime(nullable: false));
            DropColumn("dbo.Exam", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Exam", "Name", c => c.String(nullable: false, maxLength: 20));
            DropColumn("dbo.Exam", "DateTake");
        }
    }
}
