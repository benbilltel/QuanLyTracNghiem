using QuanLyTracNghiem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTracNghiem.Controllers
{
    public class StudentResultController : MChoiceController
    {
        public StudentResultController() :base(){ }
        public DataTable LoadResult(Student student, string namSubject)
        {
            using (var newContext = new MChoiceContext())
            {
                var subject = newContext.Subjects.AsNoTracking().FirstOrDefault(m => m.Name.Equals(namSubject));
                if (subject != null)
                {
                    var listExam = newContext.Exams.AsNoTracking().Where(ex => ex.IDSubject == subject.ID).ToList();
                    if (listExam.Count > 0)
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Columns.Add("ID exam", typeof(int));
                        dataTable.Columns.Add("Date", typeof(string));
                        dataTable.Columns.Add("Result", typeof(float));
                        var listExamSaved = newContext.Assignments.AsNoTracking()
                                    .Where(ct => ct.IDStudent == student.ID)
                                    .Select(ct => ct.IDExam)
                                    .Distinct().ToList();
                        foreach (var exCheck in listExamSaved)
                        {
                            foreach(var exOfSubject in listExam)
                            {
                                if(exOfSubject.ID == exCheck)
                                {
                                    var listAssign = newContext.Assignments.AsNoTracking().Where(ct => ct.IDStudent == student.ID && ct.IDExam == exCheck).ToList();
                                    if (listAssign.Count > 0)
                                    {
                                        DataRow row = dataTable.NewRow();
                                        var date = newContext.Exams.AsNoTracking()
                                            .Where(d => d.ID == exCheck)
                                            .Select(d => d.DateTake)
                                            .FirstOrDefault();

                                        row[0] = exCheck;
                                        row[1] = date.ToString();
                                        row[2] = CheckExam(newContext, exCheck, student.ID);
                                        dataTable.Rows.Add(row);

                                    }
                                }
                            }
                            
                        }

                        return dataTable.Rows.Count > 0 ? dataTable : null;
                    }
                }
                return null;
            }
        }
        private float CheckExam(MChoiceContext context, int maDT, int maHV)
        {
            var assigments = context.Assignments.AsNoTracking()
                .Where(ct => ct.IDExam == maDT && ct.IDStudent == maHV)
                .ToList();

            float sum = assigments.Count(ct => context.Questions.AsNoTracking()
                .Any(ch => ch.ID == ct.IDQuestion && ch.Answer == ct.Answer));

            return assigments.Count > 0 ? (sum / assigments.Count) * 10f : 0f;
        }
        public DataTable LoadAssignmentDetail(Student student, int IDExam)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID question",typeof(int));
            dataTable.Columns.Add("Content",typeof(string));
            dataTable.Columns.Add("A",typeof(string));
            dataTable.Columns.Add("B", typeof(string));
            dataTable.Columns.Add("C", typeof(string));
            dataTable.Columns.Add("D", typeof(string));
            dataTable.Columns.Add("Correct answer", typeof(string));
            dataTable.Columns.Add("Your answer", typeof(string));
            List<int> idQuestion = new List<int>();
            
            List<Question> questions = new List<Question>();
            List<Assignment> assignments = new List<Assignment>();
            foreach (Assignment ass in db.Assignments)
            {
                if (ass.IDExam == IDExam && ass.IDStudent == student.ID)
                {
                    assignments.Add(ass);
                    idQuestion.Add(ass.IDQuestion);
                }
            }
            foreach (int id in idQuestion)
            {
                foreach(Question question in db.Questions)
                {
                    if(id == question.ID) { 
                        questions.Add(question);
                    }
                }
            }
            foreach(Assignment ass in assignments)
            {
                foreach(Question question in questions)
                {
                    if(ass.IDQuestion == question.ID)
                    {
                        DataRow row = dataTable.NewRow();
                        row[0] = question.ID;
                        row[1] = question.Content;
                        row[2] = question.A;
                        row[3] = question.B;
                        row[4] = question.C;
                        row[5] = question.D;
                        if(question.Answer == 0)
                        {
                            row[6] = "A";
                        }else if(question.Answer == 1)
                        {
                            row[6] = "B";
                        }else if( question.Answer == 2)
                        {
                            row[6] = "C";
                        }else { row[6] = "D"; }
                        if (ass.Answer == 0)
                        {
                            row[7] = "A";
                        }
                        else if (ass.Answer == 1)
                        {
                            row[7] = "B";
                        }
                        else if (ass.Answer == 2)
                        {
                            row[7] = "C";
                        }
                        else if(ass.Answer == 3)
                        {
                            row[7] = "D";
                        }
                        else
                        {
                            row[7] = "Unlocked";
                        }
                        dataTable.Rows.Add(row);
                    }
                }
            }
            return dataTable;
        }
    }
}
