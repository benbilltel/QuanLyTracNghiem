using QuanLyTracNghiem.Models;
using QuanLyTracNghiem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTracNghiem.Controllers
{
    public class StudentController : MChoiceController
    {
        public StudentController() :base(){ }
        public Student LoadStudent(UserStudent user)
        {
            var student = db.Students.FirstOrDefault(st => st.ID == user.IDStudent);
            if(student != null)
            {
                return student;
            }
            throw new Exception("Can't find student!");
        }
        public Classroom LoadClassroom(Student student)
        {
            var classroom = db.Classrooms.FirstOrDefault(cl => cl.ID == student.IDClassroom);
            if (classroom != null)
            {
                return classroom;
            }
            throw new Exception("Can't find classroom!");
        }
        public List<Subject> LoadListSubject(Classroom classroom) {
            List<Subject> list = new List<Subject>();
            List<int> idSubject = new List<int>();  
            foreach(ListSubject ls in  db.ListSubjects) {
                if(ls.IDClassroom == classroom.ID)
                {
                    idSubject.Add(ls.IDSubject);
                }
            }
            foreach(int id  in idSubject) { 
                var subject = db.Subjects.FirstOrDefault(sb=>sb.ID == id);
                if(subject != null)
                {
                    list.Add(subject);
                }
            }
            return list;
        }
        public Subject GetSubjectByName(string name) { 
            var subject = db.Subjects.FirstOrDefault(sb=>sb.Name.Equals(name));
            if(subject != null)
            {
                return subject;
            }
            throw new Exception("Can't find subject!");
        }
    }
}
