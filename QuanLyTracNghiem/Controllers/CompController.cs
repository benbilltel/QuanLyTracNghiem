using QuanLyTracNghiem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyTracNghiem.Controllers
{
    public class CompController : MChoiceController
    {
        public CompController() : base() { }
        List<Question> RandomQuestion(Subject subject, int questionCount)
        {
            Random rnd = new Random();
            var filteredChapterIds = db.Chapters.Where(c => c.IDSubject == subject.ID).Select(c => c.ID).ToList();
            var filteredQuestion = db.Questions.Where(q => filteredChapterIds.Contains(q.IDChapter)).ToList();
            var randomQuestion = filteredQuestion.OrderBy(x => rnd.Next()).Take(questionCount).ToList();
            return randomQuestion;
        }
        public DataTable LoadQuestion(Subject subject)
        {
            List<Question> questions = RandomQuestion(subject, 10);
            if (questions.Count < 10)
            {
                throw new Exception("Exam unavailable!");
            }
            else
            {
                Exam exam = new Exam();
                exam.DateTake = DateTime.Now;
                exam.IDSubject = subject.ID;
                db.Exams.Add(exam);
                if (db.Entry(exam).State == System.Data.Entity.EntityState.Added)
                {
                    try
                    {
                        db.SaveChanges();
                    }
                    catch
                    {
                        throw new Exception("Exam unavailable!");
                    }
                }
                List<ExamDetail> examDetails = new List<ExamDetail>();
                foreach (Question question in questions)
                {
                    ExamDetail examDetail = new ExamDetail();
                    examDetail.IDExam = exam.ID;
                    examDetail.IDQuestion = question.ID;
                    examDetails.Add(examDetail);
                }
                foreach (ExamDetail detail in examDetails)
                {
                    db.ExamDetails.Add(detail);
                    if (db.Entry(detail).State == System.Data.Entity.EntityState.Added)
                    {
                        db.SaveChanges();
                    }
                    else
                    {
                        throw new Exception("Exam unavailable!");
                    }
                }
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ID exam", typeof(int));
                dataTable.Columns.Add("ID question", typeof(int));
                dataTable.Columns.Add("Content", typeof(string));
                dataTable.Columns.Add("A", typeof(string));
                dataTable.Columns.Add("B", typeof(string));
                dataTable.Columns.Add("C", typeof(string));
                dataTable.Columns.Add("D", typeof(string));
                dataTable.Columns.Add("Answer", typeof(byte));
                foreach (Question question in questions)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow[0] = exam.ID;
                    dataRow[1] = question.ID;
                    dataRow[2] = question.Content;
                    dataRow[3] = question.A;
                    dataRow[4] = question.B;
                    dataRow[5] = question.C;
                    dataRow[6] = question.D;
                    dataRow[7] = 10;
                    dataTable.Rows.Add(dataRow);
                }
                return dataTable;
            }

        }
        public void Submit(List<Assignment> assignments)
        {
            foreach (Assignment assignment in assignments)
            {
                db.Assignments.Add(assignment);
                if (db.Entry(assignment).State == System.Data.Entity.EntityState.Added)
                {
                    try
                    {
                        db.SaveChanges();
                    }
                    catch
                    {
                        throw new Exception("Submit failed!");
                    }
                }
                else
                {
                    throw new Exception("Submit failed!");
                }
            }
        }
    }
}
