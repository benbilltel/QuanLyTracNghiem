using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Models.Data
{
    [Table("HocVien")]
    public class HocVien
    {
        [Key]
        public int Ma {  get; set; }
        [Required, MaxLength(20, ErrorMessage = "Họ không được quá 20 ký tự."), MinLength(1, ErrorMessage = "Họ học viên phải có ít nhất 1 ký tự.")]
        public string Ho { get ; set; }
        [Required, MaxLength(20, ErrorMessage = "Tên học viên không được quá 20 ký tự."), MinLength(1, ErrorMessage = "Tên học viên phải có ít nhất 1 ký tự.")]
        public string Ten { get; set; }
        [Required, MaxLength(100, ErrorMessage = "Địa chỉ không được quá 100 ký tự."), MinLength(5, ErrorMessage = "Địa chỉ phải có ít nhất 5 ký tự.")]
        public string DiaChi { get; set; }
        [Required, Column(TypeName = "tinyint")]
        public byte GioiTinh { get; set; }
        [Required, MaxLength(12, ErrorMessage = "Số điện thoại không hợp lệ."), MinLength(9, ErrorMessage = "Số điện thoại không hợp lệ.")]
        public string SoDienThoai { get ; set; }

        public LopHoc LopHoc { get; set; }

    }
}
