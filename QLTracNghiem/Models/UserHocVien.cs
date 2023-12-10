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
        [Key]
        public int MaHV { get; set; }
        [ForeignKey(nameof(MaHV))]
        public HocVien HocVien { get; set; }
        [Required, MaxLength(16, ErrorMessage = "Tài khoản không được quá 20 ký tự."), MinLength(6, ErrorMessage = "Tài khoản phải có ít nhất 6 ký tự.")]
        public string TaiKhoan { get; set; }

        [Required,MaxLength(16,ErrorMessage = "Mật khẩu không được quá 20 ký tự."),MinLength(6,ErrorMessage = "Mật khẩu phải có ít nhất 6 ký tự.")]
        public string MatKhau { get; set; }

    }
}
