using QuanLyTracNghiem.Controllers;
using QuanLyTracNghiem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTracNghiem.Views
{
    public partial class FStudentResult : Form
    {
        public FStudentResult(Student student)
        {
            InitializeComponent();
            studentComp = student;
        }
        Student studentComp;
        StudentController studentController = new StudentController () ;
        StudentResultController studentResultController = new StudentResultController();
        BindingSource binding = new BindingSource();
        private void FStudentResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            FStudent fStudent = new FStudent(studentComp);
            fStudent.Show();
        }

        private void FStudentResult_Load(object sender, EventArgs e)
        {
            Classroom classroom = studentController.LoadClassroom(studentComp);
            List<Subject> subjects = studentController.LoadListSubject(classroom);
            if(subjects.Count > 0 )
            {
                foreach(Subject subject in subjects )
                {
                    cbSubject.Items.Add(subject.Name);
                    
                }
                if(cbSubject.Items.Count > 0)
                {
                    cbSubject.SelectedIndex = 0;
                    
                }
            }

        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSubject.Items.Count > 0)
            {
                binding.DataSource = studentResultController.LoadResult(studentComp, cbSubject.Text);
                dtgvExam.DataSource = binding;
                dtgvExam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgvExam.Refresh();
            }
        }

        private void dtgvExam_SelectionChanged(object sender, EventArgs e)
        {
            if(dtgvExam.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvExam.SelectedRows[0];
                dtgvExamDetail.DataSource = studentResultController.LoadAssignmentDetail(studentComp, int.Parse(row.Cells[0].Value.ToString()));
                dtgvExamDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void txtSearchExam_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchExam.Text;
            int searchValueInt;
            if (int.TryParse(searchValue, out searchValueInt))
            {
                binding.Filter = string.Format("[ID exam] = {0}", searchValueInt);
            }
            else
            {
                binding.Filter = string.Format("[Date] LIKE '%{0}%'", searchValue);
            }
            dtgvExam.Refresh();
        }

        private void dtgvExam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = dtgvExam.Rows[e.RowIndex];
                dtgvExamDetail.DataSource = studentResultController.LoadAssignmentDetail(studentComp, int.Parse(row.Cells[0].Value.ToString()));
                dtgvExamDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
    }
}
