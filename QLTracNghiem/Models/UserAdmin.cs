using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Models
{
    [Table("UserAdmin")]
    public class UserAdmin
    {
        private int ma;
        private string taiKhoan;
        private string matKhau;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        [Required, MaxLength(20, ErrorMessage = "Tài khoản không được quá 20 ký tự."), MinLength(6, ErrorMessage = "Tài khoản phải có ít nhất 6 ký tự.")]
        public string TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }
        [Required, MaxLength(20, ErrorMessage = "Mật khẩu không được quá 20 ký tự."), MinLength(6, ErrorMessage = "Mật khẩu phải có ít nhất 6 ký tự.")]
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
    }
}

