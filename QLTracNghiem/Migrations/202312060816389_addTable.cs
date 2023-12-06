namespace QLTracNghiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chuong",
                c => new
                    {
                        Ma = c.Int(nullable: false, identity: true),
                        TenChuong = c.String(nullable: false, maxLength: 20),
                        MonHoc_Ma = c.Int(),
                    })
                .PrimaryKey(t => t.Ma)
                .ForeignKey("dbo.MonHoc", t => t.MonHoc_Ma)
                .Index(t => t.MonHoc_Ma);
            
            CreateTable(
                "dbo.MonHoc",
                c => new
                    {
                        Ma = c.Int(nullable: false, identity: true),
                        TenLH = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Ma)
                .Index(t => t.TenLH, unique: true);
            
            CreateTable(
                "dbo.LopHoc",
                c => new
                    {
                        Ma = c.Int(nullable: false, identity: true),
                        TenLH = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Ma)
                .Index(t => t.TenLH, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Chuong", "MonHoc_Ma", "dbo.MonHoc");
            DropIndex("dbo.LopHoc", new[] { "TenLH" });
            DropIndex("dbo.MonHoc", new[] { "TenLH" });
            DropIndex("dbo.Chuong", new[] { "MonHoc_Ma" });
            DropTable("dbo.LopHoc");
            DropTable("dbo.MonHoc");
            DropTable("dbo.Chuong");
        }
    }
}
