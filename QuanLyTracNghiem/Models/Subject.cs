using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTracNghiem.Models
{
    [Table("Subject")]
    public class Subject
    {
        public Subject() { }
        private int iD;
        private string name;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get => iD; set => iD = value; }
        [Required, MaxLength(20), MinLength(3), Index(IsUnique = true)]
        public string Name { get => name; set => name = value; }
    }
}
