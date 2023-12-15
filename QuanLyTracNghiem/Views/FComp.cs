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
    public partial class FComp : Form
    {
        public FComp(Student student,Subject subject)
        {
            InitializeComponent();
            studentComp = student;
            subjectComp = subject;
        }
        Student studentComp;
        Subject subjectComp;
        DataTable tblAssignment;
        CompController compController = new CompController();  
        private int questionCrr = 0;
        private void FComp_Load(object sender, EventArgs e)
        {
            try
            {
                tblAssignment = compController.LoadQuestion(subjectComp);
                if(tblAssignment.Rows.Count>0) {
                    
                    for(int i = 1;i<= tblAssignment.Rows.Count;i++)
                    {
                        cbQuestion.Items.Add("Question " + i.ToString());
                    }
                }
                if(cbQuestion.Items.Count>0)
                {
                    cbQuestion.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
            }
        }
        void LoadQuestion() {
            
            DataRow row = tblAssignment.Rows[questionCrr];
            lblQuestion.Text = row[2].ToString();
            rdA.Text = row[3].ToString();
            rdB.Text = row[4].ToString();
            rdC.Text = row[5].ToString();
            rdD.Text = row[6].ToString();
            byte answer = byte.Parse(row[7].ToString());
            switch (answer)
            {
                case 0: rdA.Checked = true; break;
                case 1: rdB.Checked = true; break;
                case 2: rdC.Checked = true; break;
                case 3: rdD.Checked = true; break;
                default:
                    rdUnLocked.Checked = true;
                break;
            }
            
        }
        void SaveAnswerTemp()
        {
            DataRow dataRow = tblAssignment.Rows[questionCrr];
            if(rdA.Checked)
            {
                dataRow[7] = 0;
            }else if (rdB.Checked)
            {
                dataRow[7] = 1;
            }else if (rdC.Checked)
            {
                dataRow[7] = 2;
            }else if (rdD.Checked)
            {
                dataRow[7] = 3;
            }else
            {
                dataRow[7] = 10;
            }
        }
        private void FComp_FormClosed(object sender, FormClosedEventArgs e)
        {
            FStudent fStudent = new FStudent(studentComp);
            fStudent.Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(questionCrr<=8)
            {
                SaveAnswerTemp();
                questionCrr++;
                cbQuestion.SelectedIndex = questionCrr;
                LoadQuestion();

            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (questionCrr >= 1)
            {
                SaveAnswerTemp();
                questionCrr--;
                cbQuestion.SelectedIndex = questionCrr;
                LoadQuestion();
            }
        }

        private void cbQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(questionCrr!= cbQuestion.SelectedIndex)
            {
                SaveAnswerTemp();
            }
            
            questionCrr = cbQuestion.SelectedIndex ;
            LoadQuestion();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SaveAnswerTemp();
                List<Assignment> assignmentList = new List<Assignment>();
                foreach (DataRow row in tblAssignment.Rows)
                {
                    Assignment assignment = new Assignment();
                    assignment.IDStudent = studentComp.ID;
                    assignment.IDQuestion = int.Parse(row[1].ToString());
                    assignment.IDExam = int.Parse(row[0].ToString());
                    assignment.Answer = byte.Parse(row[7].ToString());
                    assignmentList.Add(assignment);
                }
                compController.Submit(assignmentList);
                MessageBox.Show("Your asnwer was saved!");
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
