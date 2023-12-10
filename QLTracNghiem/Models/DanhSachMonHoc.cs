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
        public DanhSachMonHoc() { }
        private int maMH;
        private int maLH;
        [Key]
        [Column(Order = 1)]
        public int MaMH { get => maMH; set=>maMH = value; }
        [ForeignKey(nameof(MaMH))]  
        
        public MonHoc MonHoc { get; set; }
        [Key]
        [Column(Order = 2)]
        public int MaLH { get => maLH; set => maLH = value; }
        [ForeignKey(nameof(MaLH))]
        public LopHoc LopHoc { get; set; }

    }
}
