using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTracNghiem.Models
{
    [Table("Exam")]
    public class Exam
    {
        public Exam() { }
        private int iD;
        private DateTime dateTake;
        private int iDSubject;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get => iD; set => iD = value; }
        
        public DateTime DateTake { get => dateTake; set => dateTake = value; }
        public int IDSubject { get => iDSubject; set => iDSubject = value; }
        [ForeignKey(nameof(IDSubject))]
        public Subject Subject { get; set; }
    }
}
