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
    public partial class FStudent : Form
    {
        public FStudent(UserStudent userStudent)
        {
            InitializeComponent();
            try
            {
                studentComp = studentController.LoadStudent(userStudent);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public FStudent(Student student)
        {
            InitializeComponent();
            try
            {
                studentComp = student;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        Student studentComp;
        StudentController studentController = new StudentController();
        Classroom classroom;
        private void FStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            FLogin fLogin = new FLogin();
            fLogin.Show();
        }

        private void FStudent_Load(object sender, EventArgs e)
        {
            lblNameStudent.Text = studentComp.FirstName + " " + studentComp.LastName;
            lblIDStudent.Text = studentComp.ID.ToString();
            try
            {
                classroom = studentController.LoadClassroom(studentComp);
                lblClass.Text = classroom.Name;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            List<Subject> subjects = studentController.LoadListSubject(classroom);
            foreach (Subject sb in subjects)
            {
                cbSubject.Items.Add(sb.Name);
            }
            if (cbSubject.Items.Count > 0)
            {
                cbSubject.SelectedIndex = 0;
            }

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTakeExam_Click(object sender, EventArgs e)
        {
            try
            {


                Subject subject = studentController.GetSubjectByName(cbSubject.Text);
                if (subject != null)
                {
                    FComp fComp = new FComp(studentComp, subject);
                    this.Hide();
                    fComp.Show();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            FStudentResult fStudentResult = new FStudentResult(studentComp);
            this.Hide();
            fStudentResult.Show();
        }
    }
}
