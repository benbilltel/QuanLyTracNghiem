using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTracNghiem.Models
{
    [Table("UserStudent")]
    public class UserStudent
    {
        public UserStudent() { }
        private int iDStudent;
        private string username;
        private string password;
        private byte status;
        [Key]
        public int IDStudent { get => iDStudent; set => iDStudent = value; }
        [ForeignKey(nameof(IDStudent))]
        public Student Student { get; set; }
        [Required, MaxLength(16), MinLength(6)]
        public string Username { get => username; set => username = value; }

        [Required, MaxLength(16), MinLength(6)]
        public string Password { get => password; set => password = value; }
        [Required, Column(TypeName = "tinyint")]
        public byte Status { get => status; set => status = value; }
    }
}
