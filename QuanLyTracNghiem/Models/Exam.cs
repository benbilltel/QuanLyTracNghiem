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
        private string name;
        private int iDSubject;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get => iD; set => iD = value; }
        [Required, MaxLength(20), MinLength(3)]
        public string Name { get => name; set => name = value; }
        public int IDSubject { get => iDSubject; set => iDSubject = value; }
        [ForeignKey(nameof(IDSubject))]
        public Subject Subject { get; set; }
    }
}
