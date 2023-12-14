using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuanLyTracNghiem.Models
{
    public class MChoiceContext : DbContext 
    {

        public MChoiceContext() : base(ConfigurationManager.ConnectionStrings["QuanLyTracNghiem"].ConnectionString) { }
        public DbSet<UserAdmin> UserAdmins { get; set; }
        public virtual DbSet<Classroom> Classrooms { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<Chapter> Chapters { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<ListSubject> ListSubjects { get; set; }
        public virtual DbSet<Assignment> Assignments { get; set; }
        public virtual DbSet<ExamDetail> ExamDetails { get; set; }
        public virtual DbSet<UserStudent> UserStudents { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExamDetail>()
                .HasKey(ctdt => new { ctdt.IDQuestion, ctdt.IDExam });
            modelBuilder.Entity<Assignment>()
                .HasKey(ctbl => new { ctbl.IDStudent, ctbl.IDExam, ctbl.IDQuestion });
            modelBuilder.Entity<ListSubject>()
                .HasKey(dsmh => new { dsmh.IDSubejct, dsmh.IDClassroom });
            modelBuilder.Entity<Exam>()
        .HasRequired(d => d.Subject)
        .WithMany()
        .HasForeignKey(d => d.IDSubject)
        .WillCascadeOnDelete(false);
        }

    }
}
