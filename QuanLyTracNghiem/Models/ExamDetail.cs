using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyTracNghiem.Models
{
    [Table("ExamDetail")]
    public class ExamDetail
    {
        public ExamDetail() { }
        private int iDQuestion;
        private int iDExam;

        [Key]
        [Column(Order = 1)]
        public int IDQuestion { get => iDQuestion; set => iDQuestion = value; }

        [Key]
        [Column(Order = 2)]
        public int IDExam { get => iDExam; set => iDExam = value; }
        [ForeignKey(nameof(IDQuestion))]

        public virtual Question Question { get; set; }
        [ForeignKey(nameof(IDExam))]
        public virtual Exam Exam { get; set; }
    }
}
