using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Models.Data
{
    [Table("ChiTietDeThi")]
    public class ChiTietDeThi
    {
        public ChiTietDeThi () { }
        private int maCH;
        private int maDT;

        [Key]
        [Column(Order = 1)]
        public int MaCH { get => maCH; set => maCH = value; } 

        [Key]
        [Column(Order = 2)]
        public int MaDT { get => maDT; set => maDT = value; }
        [ForeignKey(nameof(MaCH))] 
        
        public virtual CauHoi CauHoi { get; set; }
        [ForeignKey(nameof(MaDT))]
        public virtual DeThi DeThi { get; set; }
    }
}
