using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Models.Data
{
    [Table("UserHocVien")]
    public class UserHocVien
    {
        public UserHocVien() { }
        private int maHV;
        private string taiKhoan;
        private string matKhau;
        private int trangThai;
        [Key]
        public int MaHV { get => maHV; set=> maHV = value; }
        [ForeignKey(nameof(MaHV))]
        public HocVien HocVien { get; set; }
        [Required, MaxLength(16, ErrorMessage = "Tài khoản không được quá 20 ký tự."), MinLength(6, ErrorMessage = "Tài khoản phải có ít nhất 6 ký tự.")]
        public string TaiKhoan { get=> taiKhoan; set=> taiKhoan=value; }

        [Required,MaxLength(16,ErrorMessage = "Mật khẩu không được quá 20 ký tự."),MinLength(6,ErrorMessage = "Mật khẩu phải có ít nhất 6 ký tự.")]
        public string MatKhau { get=>matKhau; set=>matKhau = value; }
        public int TrangThai { get => trangThai;set => trangThai = value; }

    }
}
