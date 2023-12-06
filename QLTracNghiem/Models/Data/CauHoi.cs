using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Models.Data
{
    [Table("CauHoi")]
    public class CauHoi
    {
        [Key]
        public int Ma {  get; set; }
        [Required,Column(TypeName = "ntext")]
        public string NoiDung {  get; set; }
        [Required, Column(TypeName = "ntext")]
        public string DapAnA { get; set; }
        [Required, Column(TypeName = "ntext")]
        public string DapAnB { get; set; }
        [Required, Column(TypeName = "ntext")]
        public string DapAnC { get; set; }
        [Required, Column(TypeName = "ntext")]
        public string DapAnD { get; set; }
        [Required, MaxLength(1,ErrorMessage = "Đáp án không hợp lệ")]
        public char DapAnDung {  get; set; }    
        public Chuong Chuong { get; set; }
    }
}
