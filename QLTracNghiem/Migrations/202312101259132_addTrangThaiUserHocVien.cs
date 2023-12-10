namespace QLTracNghiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTrangThaiUserHocVien : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserHocVien", "TrangThai", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserHocVien", "TrangThai");
        }
    }
}
