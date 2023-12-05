namespace QLTracNghiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbinit : DbMigration
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
                .PrimaryKey(t => t.Ma)
                .Index(t => t.TaiKhoan, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.UserAdmin", new[] { "TaiKhoan" });
            DropTable("dbo.UserAdmin");
        }
    }
}
