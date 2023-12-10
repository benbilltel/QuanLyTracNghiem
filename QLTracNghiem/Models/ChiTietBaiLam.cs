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
        public ChiTietBaiLam() { }
        private int maHV;
        private int maDT;
        private int maCH;
        private int cauTL;
        [Key]
        [Column(Order = 1)]
        public int MaHV { get => maHV; set => maHV = value; }
        [ForeignKey(nameof(MaHV))]
        public HocVien HocVien { get; set; }
        [Key]
        [Column(Order = 2)]
        public int MaDT { get => maDT; set => maDT = value; }
        [ForeignKey(nameof(MaDT))]
        public DeThi DeThi { get; set; }
        [Key]
        [Column(Order = 3)]
        public int MaCH { get => maCH; set => maCH = value; }
        [ForeignKey(nameof(MaCH))]
        public CauHoi CauHoi { get; set; }
        
        public int CauTL { get => cauTL; set => cauTL = value; } 
        

    }
}
