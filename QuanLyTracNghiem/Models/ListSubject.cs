using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTracNghiem.Models
{
    [Table("ListSubject")]
    public class ListSubject
    {
        public ListSubject() { }
        private int iDSubejct;
        private int iDClassroom;
        [Key]
        [Column(Order = 1)]
        public int IDSubject { get => iDSubejct; set => iDSubejct = value; }
        [ForeignKey(nameof(IDSubject))]

        public Subject Subject { get; set; }
        [Key]
        [Column(Order = 2)]
        public int IDClassroom { get => iDClassroom; set => iDClassroom = value; }
        [ForeignKey(nameof(IDClassroom))]
        public Classroom Classroom { get; set; }
    }
}
