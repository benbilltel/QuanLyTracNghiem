namespace QLTracNghiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateHV : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HocVien", "LopHoc_Ma", "dbo.LopHoc");
            DropIndex("dbo.HocVien", new[] { "LopHoc_Ma" });
            RenameColumn(table: "dbo.HocVien", name: "LopHoc_Ma", newName: "MaLH");
            AlterColumn("dbo.HocVien", "MaLH", c => c.Int(nullable: false));
            CreateIndex("dbo.HocVien", "MaLH");
            AddForeignKey("dbo.HocVien", "MaLH", "dbo.LopHoc", "Ma", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HocVien", "MaLH", "dbo.LopHoc");
            DropIndex("dbo.HocVien", new[] { "MaLH" });
            AlterColumn("dbo.HocVien", "MaLH", c => c.Int());
            RenameColumn(table: "dbo.HocVien", name: "MaLH", newName: "LopHoc_Ma");
            CreateIndex("dbo.HocVien", "LopHoc_Ma");
            AddForeignKey("dbo.HocVien", "LopHoc_Ma", "dbo.LopHoc", "Ma");
        }
    }
}
