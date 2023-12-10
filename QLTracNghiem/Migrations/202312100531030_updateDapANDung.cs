namespace QLTracNghiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDapANDung : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CauHoi", "DapAnDung", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CauHoi", "DapAnDung");
        }
    }
}
