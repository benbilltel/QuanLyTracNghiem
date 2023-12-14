using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTracNghiem.Models
{
    [Table("Student")]
    public class Student
    {
        public Student() { }
        private int iD;
        private string firstName;
        private string lastName;
        private string address;
        private byte gender;
        private string phone;
        private int iDClassroom;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get => iD; set => iD = value; }
        [Required, MaxLength(20), MinLength(1)]
        public string FirstName { get => firstName; set => firstName = value; }
        [Required, MaxLength(20, ErrorMessage = "Tên học viên không được quá 20 ký tự."), MinLength(1, ErrorMessage = "Tên học viên phải có ít nhất 1 ký tự.")]
        public string LastName { get => lastName; set => lastName = value; }
        [Required, MaxLength(100, ErrorMessage = "Địa chỉ không được quá 100 ký tự."), MinLength(5, ErrorMessage = "Địa chỉ phải có ít nhất 5 ký tự.")]
        public string Address { get => address; set => address = value; }
        [Required, Column(TypeName = "tinyint")]
        public byte Gender { get => gender; set => gender = value; }
        [Required, MaxLength(12, ErrorMessage = "Số điện thoại không hợp lệ."), MinLength(9, ErrorMessage = "Số điện thoại không hợp lệ."), Index(IsUnique = true)]
        public string Phone { get => phone; set => phone = value; }
        public int IDClassroom { get => iDClassroom; set => iDClassroom = value; }
        [ForeignKey(nameof(IDClassroom))]
        public Classroom Classroom { get; set; }
    }
}
