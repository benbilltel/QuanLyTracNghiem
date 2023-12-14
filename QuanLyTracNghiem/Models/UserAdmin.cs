using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTracNghiem.Models
{
    [Table("UserAdmin")]
    public class UserAdmin 
    {
        public UserAdmin() { }
        private int iD;
        private string username;
        private string password;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get => iD; set => iD = value; }
        [Required, MaxLength(20), MinLength(6), Index(IsUnique = true)]
        public string Username { get => username; set => username = value; }
        [Required, MaxLength(20), MinLength(6)]
        public string Password { get => password; set => password = value; }
    }
}
