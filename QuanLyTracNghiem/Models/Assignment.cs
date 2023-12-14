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
    [Table("Assignment")]
    public class Assignment
    {
        public Assignment() { }
        private int iDStudent;
        private int iDExam;
        private int iDQuestion;
        private byte answer;
        [Key]
        [Column(Order = 1)]
        public int IDStudent { get => iDStudent; set => iDStudent = value; }
        [ForeignKey(nameof(IDStudent))]
        public Student Student { get; set; }
        [Key]
        [Column(Order = 2)]
        public int IDExam { get => iDExam; set => iDExam = value; }
        [ForeignKey(nameof(IDExam))]
        public Exam Exam{ get; set; }
        [Key]
        [Column(Order = 3)]
        public int IDQuestion { get => iDQuestion; set => iDQuestion = value; }
        [ForeignKey(nameof(IDQuestion))]
        public Question Question { get; set; }
        [Required, Column(TypeName = "tinyint")]
        public byte Answer { get => answer; set => answer = value; }
    }
}
