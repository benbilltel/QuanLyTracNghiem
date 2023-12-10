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
        public HocVien() { }
        private int ma;
        private string ho;
        private string ten;
        private string diaChi;
        private byte gioiTinh;
        private string soDienThoai;
        private int maLH;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ma {  get=> ma; set=>ma = value; }
        [Required, MaxLength(20, ErrorMessage = "Họ không được quá 20 ký tự."), MinLength(1, ErrorMessage = "Họ học viên phải có ít nhất 1 ký tự.")]
        public string Ho { get => ho; set => ho = value; }
        [Required, MaxLength(20, ErrorMessage = "Tên học viên không được quá 20 ký tự."), MinLength(1, ErrorMessage = "Tên học viên phải có ít nhất 1 ký tự.")]
        public string Ten { get => ten; set => ten = value; }
        [Required, MaxLength(100, ErrorMessage = "Địa chỉ không được quá 100 ký tự."), MinLength(5, ErrorMessage = "Địa chỉ phải có ít nhất 5 ký tự.")]
        public string DiaChi { get => diaChi; set => diaChi = value; }
        [Required, Column(TypeName = "tinyint")]
        public byte GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        [Required, MaxLength(12, ErrorMessage = "Số điện thoại không hợp lệ."), MinLength(9, ErrorMessage = "Số điện thoại không hợp lệ."), Index(IsUnique = true)]
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public int MaLH { get => maLH; set => maLH = value; }
        [ForeignKey(nameof(MaLH))]
        public LopHoc LopHoc { get; set; }

    }
}
