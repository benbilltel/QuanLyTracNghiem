using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Models.Data
{
    [Table("MonHoc")]
    public class MonHoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Ma {  get; set; }
        [Required, MaxLength(20, ErrorMessage = "Tên môn học không được quá 20 ký tự."), MinLength(3, ErrorMessage = "Tên môn học có ít nhất 3 ký tự."), Index(IsUnique = true)]
        public string TenMH { get; set; }
    }
}
