using QLTracNghiem.Models.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Models
{
    public class QLTracNghiemContext : DbContext
    {
        public QLTracNghiemContext() : base("Data Source=DESKTOP-LTSC8K9\\SQLEXPRESS;Initial Catalog=QLTracNghiem;Integrated Security=True")
        {

        }
        public virtual DbSet<UserAdmin> UserAdmins { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<Chuong> Chuongs { get; set;}
        public virtual DbSet<HocVien> HocViens { get; set; }
        public virtual DbSet<CauHoi> CauHois { get; set; }
        public virtual DbSet<DeThi> DeThis {  get; set; }
        public virtual DbSet<DanhSachMonHoc> DanhSachMonHocs { get; set; }
        public virtual DbSet<ChiTietBaiLam> ChiTietBaiLams { get; set; }
        public virtual DbSet<ChiTietDeThi> ChiTietDeThis { get; set; }
        public virtual DbSet<UserHocVien> UserHocViens { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDeThi>()
                .HasKey(ctdt => new { ctdt.MaCauHoi, ctdt.MaDeThi });
            modelBuilder.Entity<ChiTietBaiLam>()
                .HasKey(ctbl => new { ctbl.MaHV, ctbl.MaDT, ctbl.MaCH });
            modelBuilder.Entity<DanhSachMonHoc>()
                .HasKey(dsmh => new { dsmh.MaMH, dsmh.MaLH });
        }
    }
}
