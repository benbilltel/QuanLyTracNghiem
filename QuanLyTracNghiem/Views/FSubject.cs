using QuanLyTracNghiem.Controllers;
using QuanLyTracNghiem.Helper;
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
    public partial class FSubject : Form
    {
        public FSubject()
        {
            InitializeComponent();
        }

        private void FSubject_FormClosed(object sender, FormClosedEventArgs e)
        {
            FAdmin fAdmin = new FAdmin();
            fAdmin.Show();
        }
        ValidationUI validate = new ValidationUI();
        SubjectController subjectController = new SubjectController();
        BindingSource bindingSourceSubject = new BindingSource();
        BindingSource bindingSourceQuestion = new BindingSource();
        private void FSubject_Load(object sender, EventArgs e)
        {
            bindingSourceSubject.DataSource = subjectController.LoadSubject();
            dtgvSubject.DataSource = bindingSourceSubject;
            dtgvSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvSubject.Refresh();
            cbAnswer.SelectedIndex = 0;
            if (dtgvSubject.Rows.Count > 0)
            {
                DataGridViewRow row = dtgvSubject.Rows[0];
                Subject subject = new Subject();
                subject.ID = int.Parse(row.Cells[0].Value.ToString());
                subject.Name = row.Cells[1].Value.ToString();
                dtgvChapter.DataSource = subjectController.LoadChapterBySubject(subject);
                dtgvChapter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgvChapter.Columns[0].Visible = false;
                if (dtgvChapter.Rows.Count > 0)
                {
                    DataGridViewRow r = dtgvChapter.Rows[0];
                    Chapter chapter = new Chapter();
                    chapter.ID = int.Parse(r.Cells[1].Value.ToString());
                    chapter.Name = r.Cells[2].Value.ToString();
                    bindingSourceQuestion.DataSource = subjectController.LoadQuestionByChapter(chapter);
                    dtgvQuestion.DataSource = bindingSourceQuestion;
                    dtgvQuestion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgvQuestion.Columns[0].Visible = false;
                    dtgvQuestion.Refresh();
                }
            }

        }

        private void dtgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvSubject.Rows[e.RowIndex];
                txtIDSubject.Text = row.Cells[0].Value.ToString();
                txtNameSubject.Text = row.Cells[1].Value.ToString();
                Subject subject = new Subject();
                subject.ID = int.Parse(row.Cells[0].Value.ToString());
                subject.Name = row.Cells[1].Value.ToString();
                dtgvChapter.DataSource = subjectController.LoadChapterBySubject(subject);
            }
        }

        private void btnSaveSubject_Click(object sender, EventArgs e)
        {
            try
            {
                List<TextBox> textBoxes = new List<TextBox>();
                textBoxes.Add(txtNameSubject);
                if (txtIDSubject.Text == string.Empty)
                {
                    validate.CheckEmptyTextBox(textBoxes);
                    validate.CheckLengthTextBox(textBoxes, 3, 20);
                    Subject subject = new Subject();
                    subject.Name = txtNameSubject.Text;
                    subjectController.SaveSubject(subject, 0);
                    btnRefreshSubject_Click(sender, e);
                    MessageBox.Show("Saved!");
                }
                else
                {
                    validate.CheckLengthTextBox(textBoxes, 3, 20);
                    textBoxes.Add(txtIDSubject);
                    validate.CheckEmptyTextBox(textBoxes);
                    Subject subject = new Subject();
                    subject.Name = txtNameSubject.Text;
                    subject.ID = int.Parse(txtIDSubject.Text);
                    subjectController.SaveSubject(subject, 1);
                    btnRefreshSubject_Click(sender, e);
                    MessageBox.Show("Saved!");

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnRefreshSubject_Click(object sender, EventArgs e)
        {
            txtIDSubject.Text = string.Empty;
            txtNameSubject.Text = string.Empty;
            txtSearchSubject.Text = string.Empty;
            bindingSourceSubject.DataSource = subjectController.LoadSubject();
            dtgvSubject.Refresh();
            if (dtgvSubject.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvSubject.SelectedRows[0];
                Subject subject = new Subject();
                subject.ID = int.Parse(row.Cells[0].Value.ToString());
                subject.Name = row.Cells[1].Value.ToString();
                dtgvChapter.DataSource = subjectController.LoadChapterBySubject(subject);
            }
        }

        private void btnRefreshChapter_Click(object sender, EventArgs e)
        {
            txtIDChapter.Text = string.Empty;
            txtNameChapter.Text = string.Empty;
            if (dtgvSubject.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvSubject.SelectedRows[0];
                Subject subject = new Subject();
                subject.ID = int.Parse(row.Cells[0].Value.ToString());
                subject.Name = row.Cells[1].Value.ToString();
                dtgvChapter.DataSource = subjectController.LoadChapterBySubject(subject);
            }
        }

        private void btnSaveChapter_Click(object sender, EventArgs e)
        {
            try
            {
                List<TextBox> textBoxes = new List<TextBox>();
                textBoxes.Add(txtNameChapter);
                validate.CheckLengthTextBox(textBoxes, 3, 20);
                if (txtIDChapter.Text == string.Empty)
                {
                    Chapter chapter = new Chapter();
                    chapter.Name = txtNameChapter.Text;
                    DataGridViewRow row = dtgvSubject.SelectedRows[0];
                    chapter.IDSubject = int.Parse(row.Cells[0].Value.ToString());
                    subjectController.SaveChapter(chapter, 0);
                    btnRefreshChapter_Click(sender, e);
                    MessageBox.Show("Saved!");
                }
                else
                {
                    Chapter chapter = new Chapter();
                    chapter.ID = int.Parse(txtIDChapter.Text);
                    chapter.Name = txtNameChapter.Text;
                    DataGridViewRow row = dtgvSubject.SelectedRows[0];
                    chapter.IDSubject = int.Parse(row.Cells[0].Value.ToString());
                    subjectController.SaveChapter(chapter, 1);
                    btnRefreshChapter_Click(sender, e);
                    MessageBox.Show("Saved!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void dtgvChapter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvChapter.Rows[e.RowIndex];
                txtIDChapter.Text = row.Cells[1].Value.ToString();
                txtNameChapter.Text = row.Cells[2].Value.ToString();
                Chapter chapter = new Chapter();
                chapter.ID = int.Parse(row.Cells[1].Value.ToString());
                chapter.Name = row.Cells[2].Value.ToString();
                bindingSourceQuestion.DataSource = subjectController.LoadQuestionByChapter(chapter);
                dtgvQuestion.Refresh();

            }
        }

        private void txtSearchSubject_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchSubject.Text;
            int searchValueInt;
            if (int.TryParse(searchValue, out searchValueInt))
            {
                bindingSourceSubject.Filter = string.Format("[ID] = {0}", searchValueInt);
            }
            else
            {
                bindingSourceSubject.Filter = string.Format("[Name] LIKE '%{0}%'", searchValue);
            }
            dtgvSubject.Refresh();
        }

        private void dtgvSubject_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvSubject.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvSubject.SelectedRows[0];
                Subject subject = new Subject();
                subject.ID = int.Parse(row.Cells[0].Value.ToString());
                subject.Name = row.Cells[1].Value.ToString();
                dtgvChapter.DataSource = subjectController.LoadChapterBySubject(subject);
            }
        }

        private void dtgvChapter_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvChapter.SelectedRows.Count > 0) {
                DataGridViewRow row = dtgvChapter.SelectedRows[0];
                Chapter chapter = new Chapter();
                chapter.ID = int.Parse(row.Cells[1].Value.ToString());
                chapter.Name = row.Cells[2].Value.ToString();
                bindingSourceQuestion.DataSource = subjectController.LoadQuestionByChapter(chapter);
                dtgvQuestion.Refresh();
            }
            
        }

        private void dtgvQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0) { 
                DataGridViewRow row = dtgvQuestion.Rows[e.RowIndex];
                txtIDQuestion.Text = row.Cells[1].Value.ToString();
                txtContent.Text = row.Cells[2].Value.ToString();
                txtA.Text = row.Cells[3].Value.ToString();
                txtB.Text = row.Cells[4].Value.ToString();
                txtC.Text = row.Cells[5].Value.ToString();
                txtD.Text = row.Cells[6].Value.ToString();
                cbAnswer.Text = row.Cells[7].Value.ToString();
            }
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            try
            {
                List<TextBox> textBoxes = new List<TextBox>();
                textBoxes.Add(txtContent);
                textBoxes.Add(txtA);
                textBoxes.Add(txtB);
                textBoxes.Add(txtC);
                textBoxes.Add(txtD);
                validate.CheckEmptyTextBox(textBoxes);
                if (txtIDQuestion.Text == string.Empty)
                {
                    Question question = new Question(); 
                    question.Content = txtContent.Text;
                    question.A = txtA.Text;
                    question.B = txtB.Text;
                    question.C = txtC.Text;
                    question.D = txtD.Text;
                    DataGridViewRow row = dtgvChapter.SelectedRows[0];
                    question.IDChapter = int.Parse(row.Cells[1].Value.ToString());
                    if (cbAnswer.Text.Equals("A"))
                    {
                        question.Answer = 0;
                    }else if (cbAnswer.Text.Equals("B"))
                    {
                        question.Answer = 1;
                    }else if ( cbAnswer.Text.Equals("C"))
                    {
                        question.Answer = 2;
                    }
                    else
                    {
                        question.Answer = 3;
                    }
                    subjectController.SaveQuestion(question, 0);
                    btnRefreshQuestion_Click(sender, e);
                    MessageBox.Show("Saved!");
                }
                else
                {
                    Question question = new Question();
                    question.ID = int.Parse(txtIDQuestion.Text);
                    question.Content = txtContent.Text;
                    question.A = txtA.Text;
                    question.B = txtB.Text;
                    question.C = txtC.Text;
                    question.D = txtD.Text;
                    DataGridViewRow row = dtgvChapter.SelectedRows[0];
                    question.IDChapter = int.Parse(row.Cells[1].Value.ToString());
                    if (cbAnswer.Text.Equals("A"))
                    {
                        question.Answer = 0;
                    }
                    else if (cbAnswer.Text.Equals("B"))
                    {
                        question.Answer = 1;
                    }
                    else if (cbAnswer.Text.Equals("C"))
                    {
                        question.Answer = 2;
                    }
                    else
                    {
                        question.Answer = 3;
                    }
                    subjectController.SaveQuestion(question, 1);
                    btnRefreshQuestion_Click(sender, e);
                    MessageBox.Show("Saved!");
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            
        }

        private void btnRefreshQuestion_Click(object sender, EventArgs e)
        {
            txtIDQuestion.Text = string.Empty;
            txtContent.Text = string.Empty;
            txtA.Text = string.Empty;
            txtB.Text = string.Empty;
            txtC.Text = string.Empty;
            txtD.Text = string.Empty;
            cbAnswer.SelectedIndex = 0;
            txtSearchQuestion.Text = string.Empty;
            if (dtgvChapter.SelectedRows.Count > 0) { }
            {
                DataGridViewRow row = dtgvChapter.SelectedRows[0];
                Chapter chapter = new Chapter();
                chapter.ID = int.Parse(row.Cells[1].Value.ToString());
                chapter.Name = row.Cells[2].Value.ToString();
                bindingSourceQuestion.DataSource = subjectController.LoadQuestionByChapter(chapter);
                dtgvQuestion.Refresh();

            }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if(dtgvQuestion.SelectedRows.Count > 0)
            {
                List<int> idQuestions = new List<int>();
                foreach(DataGridViewRow row in dtgvQuestion.SelectedRows) {
                    idQuestions.Add(int.Parse(row.Cells[1].Value.ToString()));
                }
                try
                {
                    subjectController.RemoveQuestion(idQuestions);
                    btnRefreshQuestion_Click(sender, e);
                    MessageBox.Show("Deleted!");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSearchQuestion_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchQuestion.Text;
            int searchValueInt;
            if (int.TryParse(searchValue, out searchValueInt))
            {
                bindingSourceQuestion.Filter = string.Format("[ID] = {0}", searchValueInt);
            }
            else
            {
                bindingSourceQuestion.Filter = string.Format("[Content] LIKE '%{0}%'", searchValue);
            }
            dtgvQuestion.Refresh();
        }
    }
}
