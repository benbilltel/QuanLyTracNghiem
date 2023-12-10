using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Models.Data
{
    [Table("DanhSachMonHoc")]
    public class DanhSachMonHoc
    {
        [Key]
        [Column(Order = 1)]
        public int MaMH { get ; set; }
        [ForeignKey(nameof(MaMH))]  
        
        public MonHoc MonHoc { get; set; }
        [Key]
        [Column(Order = 2)]
        public int MaLH { get; set; }
        [ForeignKey(nameof(MaLH))]
        public LopHoc LopHoc { get; set; }

    }
}
