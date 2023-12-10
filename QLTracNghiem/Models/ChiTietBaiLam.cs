using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Models.Data
{
    [Table("ChiTietBaiLam")]
    public class ChiTietBaiLam
    {
        [Key]
        [Column(Order = 1)]
        public int MaHV {  get; set; }
        [ForeignKey(nameof(MaHV))]
        public HocVien HocVien { get; set; }
        [Key]
        [Column(Order = 2)]
        public int MaDT { get; set; }
        [ForeignKey(nameof(MaDT))]
        public DeThi DeThi { get; set; }
        [Key]
        [Column(Order = 3)]
        public int MaCH { get; set; }
        [ForeignKey(nameof(MaCH))]
        public CauHoi CauHoi { get; set; }
        [MaxLength(1,ErrorMessage = "Câu trả lời không hợp lệ")]
        public char CauTL { get; set; } 

    }
}
