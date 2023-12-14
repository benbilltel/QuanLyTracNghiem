using QuanLyTracNghiem.Models;
using QuanLyTracNghiem.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTracNghiem.Controllers
{
    public class ClassroomController : MChoiceController
    {
        public ClassroomController() : base(){ }
        public DataTable LoadClassroom()
        {
            DataTable tblClass = new DataTable();
            tblClass.Columns.Add("ID", typeof(int));
            tblClass.Columns.Add("Name", typeof(string));
            foreach(Classroom classroom in db.Classrooms)
            {
                DataRow row = tblClass.NewRow();
                row[0] = classroom.ID;
                row[1] = classroom.Name;
                tblClass.Rows.Add(row); 
            }
            return tblClass;
        }
        public DataTable LoadStudentsByClass(Classroom classroom) {
            DataTable tblStudent = new DataTable();
            tblStudent.Columns.Add("ID", typeof(int));
            tblStudent.Columns.Add("First name", typeof(string));
            tblStudent.Columns.Add("Last name", typeof(string));
            tblStudent.Columns.Add("Gender", typeof(string));
            tblStudent.Columns.Add("Address", typeof(string));
            tblStudent.Columns.Add("Phone", typeof(string));
            foreach(Student student in db.Students)
            {
                if(student.IDClassroom == classroom.ID)
                {
                    DataRow row = tblStudent.NewRow();
                    row[0] = student.ID;
                    row[1] = student.FirstName;
                    row[2] = student.LastName;
                    if(student.Gender == 0)
                    {
                        row[3] = "Male";
                    }
                    else
                    {
                        row[3] = "Female";
                    }
                    row[4] = student.Address;
                    row[5] = student.Phone;
                    tblStudent.Rows.Add(row);
                }
            }
            return tblStudent;
        }
        public void SaveClassroom(Classroom classroom, int action)
        {
            if (action == 0)
            {
                db.Classrooms.Add(classroom);
                if (db.Entry(classroom).State == System.Data.Entity.EntityState.Added)
                {
                    try { db.SaveChanges(); } catch { throw new Exception("Save failed!"); }
                }
                else { throw new Exception("Save failed!"); }
            }
            else
            {
                var classUpdate = db.Classrooms.FirstOrDefault(cl => cl.ID == classroom.ID);
                if (classUpdate != null)
                {
                    classUpdate.Name = classroom.Name;

                    if (db.Entry(classUpdate).State == System.Data.Entity.EntityState.Modified)
                    {
                        try
                        {
                            db.SaveChanges();
                        }
                        catch
                        {
                            throw new Exception("Save failed!");
                        }
                    }
                    else { throw new Exception("Save failed!"); }
                }
                else
                {

                    throw new Exception("Save failed!");

                }
            }
        }
        public void SaveStudent(Student student, int action)
        {
            if (action == 0)
            {
                db.Students.Add(student);
                if (db.Entry(student).State == System.Data.Entity.EntityState.Added)
                {
                    try { db.SaveChanges(); } catch { throw new Exception("Save failed!"); }
                }
                else { throw new Exception("Save failed!"); }
                var studentUpdate = db.Students.FirstOrDefault(st => st.ID == student.ID);
                if (studentUpdate != null)
                {
                    UserStudent user = new UserStudent();
                    user.IDStudent = studentUpdate.ID;
                    user.Username = studentUpdate.Phone;
                    user.Password = studentUpdate.Phone;
                    user.Status = 1;
                    db.UserStudents.Add(user);
                    if (db.Entry(user).State == System.Data.Entity.EntityState.Added)
                    {
                        try { db.SaveChanges(); } catch { throw new Exception("Save userstudent failed!"); }
                    }
                    else { throw new Exception("Save userstudent failed!"); }
                }
                else
                {
                    throw new Exception("Generate userstudent failed!");
                }
            }
            else
            {
                var studentUdpate = db.Students.FirstOrDefault(st => st.ID == student.ID);
                if (studentUdpate != null)
                {
                    studentUdpate.FirstName = student.FirstName;
                    studentUdpate.LastName = student.LastName;
                    studentUdpate.Gender = student.Gender;
                    studentUdpate.Phone = student.Phone;    
                    studentUdpate.Address = student.Address;
                    studentUdpate.IDClassroom = student.IDClassroom;

                    if (db.Entry(studentUdpate).State == System.Data.Entity.EntityState.Modified)
                    {
                        try
                        {
                            db.SaveChanges();
                        }
                        catch
                        {
                            throw new Exception("Save failed!");
                        }
                    }
                    else { throw new Exception("Save failed!"); }
                }
                else
                {

                    throw new Exception("Save failed!");

                }
                var userUpdate = db.UserStudents.FirstOrDefault(us => us.IDStudent == student.ID);
                if (userUpdate != null)
                {
                    userUpdate.Username = student.Phone;
                    if (db.Entry(userUpdate).State == System.Data.Entity.EntityState.Modified)
                    {
                        try
                        {
                            db.SaveChanges();
                        }
                        catch
                        {
                            throw new Exception("Save username failed!");
                        }
                    }
                    else { throw new Exception("Save username failed!"); }
                }
                else
                {

                    throw new Exception("Save username failed!");

                }
            }
        }
        public void RemoveStudent(List<int> iDStudents)
        {
            foreach (int id in iDStudents) { 
                var userStudent = db.UserStudents.FirstOrDefault(us => us.IDStudent == id); 
                if (userStudent != null)
                {
                    db.UserStudents.Remove(userStudent);
                    if (db.Entry(userStudent).State == System.Data.Entity.EntityState.Deleted)
                    {
                        try
                        {
                            db.SaveChanges();
                        }
                        catch
                        {
                            throw new Exception("Remove userstudent failed!");
                        }
                    }
                        
                }
                else
                {
                    throw new Exception("Remove userstudent failed!");
                }
                var student = db.Students.FirstOrDefault(st=>st.ID == id);
                if(student != null)
                {
                    db.Students.Remove(student);
                    if(db.Entry(student).State == System.Data.Entity.EntityState.Deleted)
                    {
                        try
                        {
                            db.SaveChanges();
                        }
                        catch
                        {
                            throw new Exception("Remove student failed!");
                        }
                    }
                }else { throw new Exception("Remove student failed!"); }
            }
        }
        public DataTable LoadSubjectsByClass(Classroom classroom)
        {
            DataTable tblListSubject = new DataTable();
            tblListSubject.Columns.Add("ID Class",typeof(int));
            tblListSubject.Columns.Add("ID Subject",typeof (int));
            tblListSubject.Columns.Add("Name", typeof(string));
            List<ListSubject> listSubjects = new List<ListSubject>();
            foreach (ListSubject listSubject in db.ListSubjects)
            {
                if (listSubject.IDClassroom == classroom.ID)
                {
                    listSubjects.Add(listSubject);
                }
            }
            foreach (ListSubject listSubject in listSubjects)
            {
                foreach (Subject subject in db.Subjects)
                {
                    if (subject.ID == listSubject.IDSubject)
                    {
                        DataRow row = tblListSubject.NewRow();
                        row[0] = listSubject.IDClassroom;
                        row[1] = listSubject.IDSubject;
                        row[2] = subject.Name;
                        tblListSubject.Rows.Add(row);
                    }
                }
            }
            
            return tblListSubject;
        }
        public List<Subject> LoadListSubject()
        {
            List<Subject> list = new List<Subject>();
            foreach(Subject subject in db.Subjects)
            {
                list.Add(subject);
            }
            return list;    
        }
        public Subject SearchSubjectByName(string name)
        {
            var subject = db.Subjects.FirstOrDefault(sb=>sb.Name.Equals(name)); 
            if(subject != null)
            {
                return subject; 
            }
            return null;
        }
        public void SaveSubjectToList(ListSubject lsSubject)
        {
            var check = db.ListSubjects.FirstOrDefault(ls=>ls.IDSubject == lsSubject.IDSubject && lsSubject.IDClassroom == ls.IDClassroom);
            if(check != null)
            {
                throw new Exception("Save failed!");
            }
            else
            {
                db.ListSubjects.Add(lsSubject);
                if (db.Entry(lsSubject).State == System.Data.Entity.EntityState.Added)
                {
                    try { db.SaveChanges(); } catch { throw new Exception("Save failed!"); }
                }
                else { throw new Exception("Save failed!"); }
            }
            
        }
        public void RemoveListSubject(List<ListSubject> listSubjects)
        {
            foreach (ListSubject listSubject in listSubjects)
            {
                var listRM = db.ListSubjects.FirstOrDefault(ls => ls.IDSubject == listSubject.IDSubject && ls.IDClassroom == listSubject.IDClassroom);
                if (listRM != null)
                {
                    db.ListSubjects.Remove(listRM);
                    if (db.Entry(listRM).State == System.Data.Entity.EntityState.Deleted)
                    {
                        try { db.SaveChanges(); } catch { throw new Exception("Remove failed!"); }
                    }
                    else
                    {
                        throw new Exception("Remove failed!");
                    }
                }
                else
                {
                    throw new Exception("Remove failed!");
                }
            }
        }
    }
}
