using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Models.Data
{
    [Table("LopHoc")]
    public class LopHoc
    {
        public LopHoc() { }
        private int ma;
        private string tenLH;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ma {  get=> ma; set=> ma = value; }
        [Required, MaxLength(20, ErrorMessage = "Tên lớp học không được quá 20 ký tự."), MinLength(3, ErrorMessage = "Tên lớp học có ít nhất 3 ký tự."), Index(IsUnique = true)]
        public string TenLH { get=> tenLH; set=>tenLH = value; }
    }
}
