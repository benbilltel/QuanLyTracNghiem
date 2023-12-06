namespace QLTracNghiem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTableDeThi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CauHoi",
                c => new
                    {
                        Ma = c.Int(nullable: false, identity: true),
                        NoiDung = c.String(nullable: false, storeType: "ntext"),
                        DapAnA = c.String(nullable: false, storeType: "ntext"),
                        DapAnB = c.String(nullable: false, storeType: "ntext"),
                        DapAnC = c.String(nullable: false, storeType: "ntext"),
                        DapAnD = c.String(nullable: false, storeType: "ntext"),
                        Chuong_Ma = c.Int(),
                    })
                .PrimaryKey(t => t.Ma)
                .ForeignKey("dbo.Chuong", t => t.Chuong_Ma)
                .Index(t => t.Chuong_Ma);
            
            CreateTable(
                "dbo.ChiTietBaiLam",
                c => new
                    {
                        MaHV = c.Int(nullable: false),
                        MaDT = c.Int(nullable: false),
                        MaCH = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MaHV, t.MaDT, t.MaCH })
                .ForeignKey("dbo.CauHoi", t => t.MaCH, cascadeDelete: true)
                .ForeignKey("dbo.DeThi", t => t.MaDT, cascadeDelete: true)
                .ForeignKey("dbo.HocVien", t => t.MaHV, cascadeDelete: true)
                .Index(t => t.MaHV)
                .Index(t => t.MaDT)
                .Index(t => t.MaCH);
            
            CreateTable(
                "dbo.DeThi",
                c => new
                    {
                        Ma = c.Int(nullable: false, identity: true),
                        NgayThi = c.DateTime(nullable: false),
                        MonHoc_Ma = c.Int(),
                    })
                .PrimaryKey(t => t.Ma)
                .ForeignKey("dbo.MonHoc", t => t.MonHoc_Ma)
                .Index(t => t.MonHoc_Ma);
            
            CreateTable(
                "dbo.HocVien",
                c => new
                    {
                        Ma = c.Int(nullable: false, identity: true),
                        Ho = c.String(nullable: false, maxLength: 20),
                        Ten = c.String(nullable: false, maxLength: 20),
                        DiaChi = c.String(nullable: false, maxLength: 100),
                        GioiTinh = c.Byte(nullable: false),
                        SoDienThoai = c.String(nullable: false, maxLength: 12),
                        LopHoc_Ma = c.Int(),
                    })
                .PrimaryKey(t => t.Ma)
                .ForeignKey("dbo.LopHoc", t => t.LopHoc_Ma)
                .Index(t => t.LopHoc_Ma);
            
            CreateTable(
                "dbo.ChiTietDeThi",
                c => new
                    {
                        MaCauHoi = c.Int(nullable: false),
                        MaDeThi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MaCauHoi, t.MaDeThi })
                .ForeignKey("dbo.CauHoi", t => t.MaCauHoi, cascadeDelete: true)
                .ForeignKey("dbo.DeThi", t => t.MaDeThi, cascadeDelete: true)
                .Index(t => t.MaCauHoi)
                .Index(t => t.MaDeThi);
            
            CreateTable(
                "dbo.DanhSachMonHoc",
                c => new
                    {
                        MaMH = c.Int(nullable: false),
                        MaLH = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MaMH, t.MaLH })
                .ForeignKey("dbo.LopHoc", t => t.MaLH, cascadeDelete: true)
                .ForeignKey("dbo.MonHoc", t => t.MaMH, cascadeDelete: true)
                .Index(t => t.MaMH)
                .Index(t => t.MaLH);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DanhSachMonHoc", "MaMH", "dbo.MonHoc");
            DropForeignKey("dbo.DanhSachMonHoc", "MaLH", "dbo.LopHoc");
            DropForeignKey("dbo.ChiTietDeThi", "MaDeThi", "dbo.DeThi");
            DropForeignKey("dbo.ChiTietDeThi", "MaCauHoi", "dbo.CauHoi");
            DropForeignKey("dbo.ChiTietBaiLam", "MaHV", "dbo.HocVien");
            DropForeignKey("dbo.HocVien", "LopHoc_Ma", "dbo.LopHoc");
            DropForeignKey("dbo.ChiTietBaiLam", "MaDT", "dbo.DeThi");
            DropForeignKey("dbo.DeThi", "MonHoc_Ma", "dbo.MonHoc");
            DropForeignKey("dbo.ChiTietBaiLam", "MaCH", "dbo.CauHoi");
            DropForeignKey("dbo.CauHoi", "Chuong_Ma", "dbo.Chuong");
            DropIndex("dbo.DanhSachMonHoc", new[] { "MaLH" });
            DropIndex("dbo.DanhSachMonHoc", new[] { "MaMH" });
            DropIndex("dbo.ChiTietDeThi", new[] { "MaDeThi" });
            DropIndex("dbo.ChiTietDeThi", new[] { "MaCauHoi" });
            DropIndex("dbo.HocVien", new[] { "LopHoc_Ma" });
            DropIndex("dbo.DeThi", new[] { "MonHoc_Ma" });
            DropIndex("dbo.ChiTietBaiLam", new[] { "MaCH" });
            DropIndex("dbo.ChiTietBaiLam", new[] { "MaDT" });
            DropIndex("dbo.ChiTietBaiLam", new[] { "MaHV" });
            DropIndex("dbo.CauHoi", new[] { "Chuong_Ma" });
            DropTable("dbo.DanhSachMonHoc");
            DropTable("dbo.ChiTietDeThi");
            DropTable("dbo.HocVien");
            DropTable("dbo.DeThi");
            DropTable("dbo.ChiTietBaiLam");
            DropTable("dbo.CauHoi");
        }
    }
}
