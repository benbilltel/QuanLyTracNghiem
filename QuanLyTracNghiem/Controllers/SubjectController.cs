using QuanLyTracNghiem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTracNghiem.Controllers
{
    public class SubjectController : MChoiceController
    {
        public SubjectController() :base(){ }
        public DataTable LoadSubject()
        {
            DataTable tblSubject = new DataTable();
            tblSubject.Columns.Add("ID",typeof(int));
            tblSubject.Columns.Add("Name",typeof(string));
            foreach(Subject sb in db.Subjects)
            {
                DataRow row = tblSubject.NewRow();
                row[0] = sb.ID;
                row[1] = sb.Name;
                tblSubject.Rows.Add(row);
            }
            return tblSubject;
        }
        public void SaveSubject(Subject subject, int action) {
            if(action == 0) {
                db.Subjects.Add(subject);
                if(db.Entry(subject).State == System.Data.Entity.EntityState.Added) {
                    try
                    {
                        db.SaveChanges();   
                    }catch {
                        throw new Exception("Save failed!");
                    }
                }
                else
                {
                    throw new Exception("Save failed!");
                }
            }
            else
            {
                var subjectUpdate = db.Subjects.FirstOrDefault(sb => sb.ID == subject.ID);
                if(subjectUpdate != null)
                {
                    subjectUpdate.Name = subject.Name;
                    if(db.Entry(subjectUpdate).State == System.Data.Entity.EntityState.Modified)
                    {
                        try
                        {
                            db.SaveChanges();
                        }
                        catch { 
                            throw new Exception("Saved failed!");
                        }
                    }
                    else
                    {
                        throw new Exception("Saved failed!");
                    }
                }
                else
                {
                    throw new Exception("Save failed!");
                }
            }
        }
        public DataTable LoadChapterBySubject(Subject subject) { 
            DataTable tbl = new DataTable();
            tbl.Columns.Add("ID Subject", typeof(int));
            tbl.Columns.Add("ID",typeof(int));
            tbl.Columns.Add("Name", typeof(string));
            foreach(Chapter cp in db.Chapters) { 
                if(cp.IDSubject == subject.ID)
                {
                    DataRow dataRow = tbl.NewRow();
                    dataRow[0] = cp.IDSubject;
                    dataRow[1] = cp.ID;
                    dataRow[2] = cp.Name;
                    tbl.Rows.Add(dataRow);
                }
            }
            return tbl;
        }
        public void SaveChapter(Chapter chapter,int action)
        {
            if(action == 0) {
                db.Chapters.Add(chapter);   
                if(db.Entry(chapter).State == System.Data.Entity.EntityState.Added) {
                    try
                    {
                        db.SaveChanges();
                    }
                    catch
                    {
                        throw new Exception("Save failed!");
                    }
                }
                else
                {
                    throw new Exception("Save failed!");
                }
            }
            else
            {
                var chapterUpdate = db.Chapters.FirstOrDefault(ch => ch.ID == chapter.ID);
                if(chapterUpdate != null)
                {
                    chapterUpdate.Name = chapter.Name;
                    if(db.Entry(chapterUpdate).State == System.Data.Entity.EntityState.Modified)
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
                }
                else
                {
                    throw new Exception("Save failed!");
                }
            }
        }
        public DataTable LoadQuestionByChapter(Chapter chapter) { 
            DataTable tbl = new DataTable();
            tbl.Columns.Add("ID chapter", typeof(int));
            tbl.Columns.Add("ID",typeof(int));
            tbl.Columns.Add("Content",typeof(string));
            tbl.Columns.Add("Answer A",typeof (string));
            tbl.Columns.Add("Answer B", typeof(string));
            tbl.Columns.Add("Answer C", typeof(string));
            tbl.Columns.Add("Answer D", typeof(string));
            tbl.Columns.Add("Correct answer", typeof(string));
            foreach(Question question in db.Questions)
            {
                if(question.IDChapter == chapter.ID)
                {
                    DataRow dataRow = tbl.NewRow();
                    dataRow[0] = question.IDChapter;
                    dataRow[1] = question.ID;
                    dataRow[2] = question.Content;
                    dataRow[3] = question.A;
                    dataRow[4] = question.B;
                    dataRow[5] = question.C;
                    dataRow[6] = question.D;
                    if(question.Answer == 0)
                    {
                        dataRow[7] = "A";
                    }else if (question.Answer == 1)
                    {
                        dataRow[7] = "B";
                    }
                    else if (question.Answer == 2)
                    {
                        dataRow[7] = "C";
                    }
                    else
                    {
                        dataRow[7] = "D";
                    }
                    tbl.Rows.Add(dataRow);
                }
            }
            return tbl; 
        }
        public void SaveQuestion(Question question,int action)
        {
            if(action == 0)
            {
                db.Questions.Add(question);
                if(db.Entry(question).State == System.Data.Entity.EntityState.Added)
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
                else
                {
                    throw new Exception("Save failed!");
                }
            }
            else
            {
                var questionUpdate = db.Questions.FirstOrDefault(q=>q.ID == question.ID);
                if(questionUpdate != null)
                {
                    questionUpdate.Content = question.Content;
                    questionUpdate.Answer = question.Answer;
                    questionUpdate.A = question.A;
                    questionUpdate.B = question.B;
                    questionUpdate.C = question.C;
                    questionUpdate.D = question.D;
                    if(db.Entry(questionUpdate).State == System.Data.Entity.EntityState.Modified)
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
                    else
                    {
                        throw new Exception("Save failed!");
                    }
                }
                else
                {
                    throw new Exception("Save failed!");
                }
            }
        }
        public void RemoveQuestion(List<int> idQuestions)
        {
            foreach(int idQuestion in idQuestions) { 
                var question = db.Questions.FirstOrDefault(q=>q.ID ==idQuestion);
                if (question != null)
                {
                    db.Questions.Remove(question);
                    if(db.Entry(question).State == System.Data.Entity.EntityState.Deleted)
                    {
                        try
                        {
                            db.SaveChanges() ;
                        }catch {
                            throw new Exception("Remove failed!");
                        }
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
