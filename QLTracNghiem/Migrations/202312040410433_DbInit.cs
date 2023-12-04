namespace QLTracNghiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserAdmin",
                c => new
                    {
                        Ma = c.Int(nullable: false, identity: true),
                        TaiKhoan = c.String(nullable: false, maxLength: 20),
                        MatKhau = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Ma);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserAdmin");
        }
    }
}
