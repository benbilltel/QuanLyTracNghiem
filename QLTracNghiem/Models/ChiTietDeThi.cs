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
        
        [Key]
        [Column(Order = 1)]
        public int MaCauHoi { get; set; } 

        [Key]
        [Column(Order = 2)]
        public int MaDeThi { get; set; }
        [ForeignKey(nameof(MaCauHoi))] 
        
        public virtual CauHoi CauHoi { get; set; }
        [ForeignKey(nameof(MaDeThi))]
        public virtual DeThi DeThi { get; set; }
    }
}
