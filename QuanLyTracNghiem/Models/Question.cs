using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLyTracNghiem.Models
{
    [Table("Question")]
    public class Question
    {
        public Question() { }
        private int iD;
        private string content;
        private string a;
        private string b;
        private string c;
        private string d;
        private byte answer;
        private int iDChapter;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get => iD; set => iD = value; }
        [Required, Column(TypeName = "ntext")]
        public string Content { get => content; set => content = value; }
        [Required, Column(TypeName = "ntext")]
        public string A { get => a; set => a= value; }
        [Required, Column(TypeName = "ntext")]
        public string B { get => b; set => b = value; }
        [Required, Column(TypeName = "ntext")]
        public string C { get => c; set => c = value; }
        [Required, Column(TypeName = "ntext")]
        public string D { get => d; set => d = value; }
        [Required, Column(TypeName = "tinyint")]
        public byte Answer { get => answer; set => answer = value; }
        public int IDChapter { get => iDChapter; set => iDChapter = value; }
        [ForeignKey(nameof(IDChapter))]
        public Chapter Chapter { get; set; }
    }
}
