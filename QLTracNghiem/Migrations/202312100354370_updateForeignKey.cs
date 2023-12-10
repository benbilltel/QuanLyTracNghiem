namespace QLTracNghiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CauHoi", "Chuong_Ma", "dbo.Chuong");
            DropForeignKey("dbo.Chuong", "MonHoc_Ma", "dbo.MonHoc");
            DropIndex("dbo.CauHoi", new[] { "Chuong_Ma" });
            DropIndex("dbo.Chuong", new[] { "MonHoc_Ma" });
            DropIndex("dbo.DeThi", new[] { "MonHoc_Ma" });
            RenameColumn(table: "dbo.CauHoi", name: "Chuong_Ma", newName: "maChuong");
            RenameColumn(table: "dbo.Chuong", name: "MonHoc_Ma", newName: "maMH");
            RenameColumn(table: "dbo.DeThi", name: "MonHoc_Ma", newName: "MaMH");
            AlterColumn("dbo.CauHoi", "maChuong", c => c.Int(nullable: false));
            AlterColumn("dbo.Chuong", "maMH", c => c.Int(nullable: false));
            AlterColumn("dbo.DeThi", "MaMH", c => c.Int(nullable: false));
            CreateIndex("dbo.CauHoi", "maChuong");
            CreateIndex("dbo.Chuong", "maMH");
            CreateIndex("dbo.DeThi", "MaMH");
            AddForeignKey("dbo.CauHoi", "maChuong", "dbo.Chuong", "Ma", cascadeDelete: true);
            AddForeignKey("dbo.Chuong", "maMH", "dbo.MonHoc", "Ma", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Chuong", "maMH", "dbo.MonHoc");
            DropForeignKey("dbo.CauHoi", "maChuong", "dbo.Chuong");
            DropIndex("dbo.DeThi", new[] { "MaMH" });
            DropIndex("dbo.Chuong", new[] { "maMH" });
            DropIndex("dbo.CauHoi", new[] { "maChuong" });
            AlterColumn("dbo.DeThi", "MaMH", c => c.Int());
            AlterColumn("dbo.Chuong", "maMH", c => c.Int());
            AlterColumn("dbo.CauHoi", "maChuong", c => c.Int());
            RenameColumn(table: "dbo.DeThi", name: "MaMH", newName: "MonHoc_Ma");
            RenameColumn(table: "dbo.Chuong", name: "maMH", newName: "MonHoc_Ma");
            RenameColumn(table: "dbo.CauHoi", name: "maChuong", newName: "Chuong_Ma");
            CreateIndex("dbo.DeThi", "MonHoc_Ma");
            CreateIndex("dbo.Chuong", "MonHoc_Ma");
            CreateIndex("dbo.CauHoi", "Chuong_Ma");
            AddForeignKey("dbo.Chuong", "MonHoc_Ma", "dbo.MonHoc", "Ma");
            AddForeignKey("dbo.CauHoi", "Chuong_Ma", "dbo.Chuong", "Ma");
        }
    }
}
