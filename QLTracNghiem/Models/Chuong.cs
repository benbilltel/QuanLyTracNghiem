using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Models.Data
{
    [Table("Chuong")]
    public class Chuong
    {
        public Chuong() { }
        private int ma;
        private string tenChuong;
        private int maMH;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ma {  get => ma; set=> ma = value; }
        [Required, MaxLength(20, ErrorMessage = "Tên chương học không được quá 20 ký tự."), MinLength(3, ErrorMessage = "Tên chương học có ít nhất 3 ký tự.")]
        public string TenChuong { get => tenChuong; set => tenChuong = value; }
        public int MaMH { get=>maMH; set=>maMH =value; }
        [ForeignKey(nameof(MaMH))]
        public MonHoc MonHoc { get; set; }
    }
}
