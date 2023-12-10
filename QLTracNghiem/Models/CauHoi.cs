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
        public CauHoi() { }
        private int ma;
        private string noiDung;
        private string dapAnA;
        private string dapAnB;
        private string dapAnC;
        private string dapAnD;
        private int dapAnDung;
        private int maChuong;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ma {  get => ma; set => ma = value; }
        [Required,Column(TypeName = "ntext")]
        public string NoiDung { get => noiDung; set => noiDung = value; }
        [Required, Column(TypeName = "ntext")]
        public string DapAnA { get => dapAnA; set => dapAnA = value; }
        [Required, Column(TypeName = "ntext")]
        public string DapAnB { get => dapAnB; set => dapAnB = value; }
        [Required, Column(TypeName = "ntext")]
        public string DapAnC { get => dapAnC; set => dapAnC = value; }
        [Required, Column(TypeName = "ntext")]
        public string DapAnD { get => dapAnD; set => dapAnD = value; }
        
        public int DapAnDung { get => dapAnDung; set => dapAnDung = value; }    
        public int MaChuong { get => maChuong; set => maChuong = value; }
        [ForeignKey(nameof(MaChuong))]
        public Chuong Chuong { get; set; }
    }
}
