using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Models.Data
{
    [Table("DeThi")]
    public class DeThi
    {
        public DeThi() { }
        private int ma;
        private DateTime ngayThi;
        private int maMH;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ma {  get=> ma; set=> ma = value; }
        [Required] 
        public DateTime NgayThi { get=> ngayThi ; set=> ngayThi = value; }
        public int MaMH {  get => maMH; set=> maMH = value; }
        [ForeignKey(nameof(MaMH))]
        public MonHoc MonHoc { get; set; }
    }
}
