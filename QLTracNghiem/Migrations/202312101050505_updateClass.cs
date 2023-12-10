namespace QLTracNghiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateClass : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.CauHoi", new[] { "maChuong" });
            DropIndex("dbo.Chuong", new[] { "maMH" });
            RenameColumn(table: "dbo.ChiTietDeThi", name: "MaCauHoi", newName: "MaCH");
            RenameColumn(table: "dbo.ChiTietDeThi", name: "MaDeThi", newName: "MaDT");
            RenameIndex(table: "dbo.ChiTietDeThi", name: "IX_MaCauHoi", newName: "IX_MaCH");
            RenameIndex(table: "dbo.ChiTietDeThi", name: "IX_MaDeThi", newName: "IX_MaDT");
            AddColumn("dbo.ChiTietBaiLam", "CauTL", c => c.Int(nullable: false));
            CreateIndex("dbo.CauHoi", "MaChuong");
            CreateIndex("dbo.Chuong", "MaMH");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Chuong", new[] { "MaMH" });
            DropIndex("dbo.CauHoi", new[] { "MaChuong" });
            DropColumn("dbo.ChiTietBaiLam", "CauTL");
            RenameIndex(table: "dbo.ChiTietDeThi", name: "IX_MaDT", newName: "IX_MaDeThi");
            RenameIndex(table: "dbo.ChiTietDeThi", name: "IX_MaCH", newName: "IX_MaCauHoi");
            RenameColumn(table: "dbo.ChiTietDeThi", name: "MaDT", newName: "MaDeThi");
            RenameColumn(table: "dbo.ChiTietDeThi", name: "MaCH", newName: "MaCauHoi");
            CreateIndex("dbo.Chuong", "maMH");
            CreateIndex("dbo.CauHoi", "maChuong");
        }
    }
}
