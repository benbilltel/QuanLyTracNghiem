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
    public partial class FClassroom : Form
    {
        public FClassroom()
        {
            InitializeComponent();
        }
        ClassroomController classroomController = new ClassroomController();
        BindingSource bindingSourceClass = new BindingSource();
        BindingSource bindingSourceStudent = new BindingSource();
        ValidationUI validate = new ValidationUI();
        private void FClassroom_Load(object sender, EventArgs e)
        {
            bindingSourceClass.DataSource = classroomController.LoadClassroom();
            dtgvClassroom.DataSource = bindingSourceClass;
            dtgvClassroom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvClassroom.Refresh();
            cbGender.SelectedIndex = 0;
            if (dtgvClassroom.Rows.Count > 0)
            {
                Classroom classroom = new Classroom();
                DataGridViewRow row = dtgvClassroom.Rows[0];
                classroom.ID = int.Parse(row.Cells[0].Value.ToString());
                classroom.Name = row.Cells[1].Value.ToString();
                dtgvListSubject.DataSource = classroomController.LoadSubjectsByClass(classroom);
                dtgvListSubject.Columns[0].Visible = false;
                dtgvListSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                List<Subject> listSubject =  classroomController.LoadListSubject();
                foreach(Subject subject in listSubject)
                {
                    cbListSubject.Items.Add(subject.Name);
                }
                if(cbListSubject.Items.Count > 0)
                {
                    cbListSubject.SelectedIndex = 0;
                }
                bindingSourceStudent.DataSource = classroomController.LoadStudentsByClass(classroom);
                dtgvStudent.DataSource = bindingSourceStudent;
                dtgvStudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgvStudent.Refresh();
            }
        }

        private void FClassroom_FormClosed(object sender, FormClosedEventArgs e)
        {
            FAdmin fAdmin = new FAdmin();
            fAdmin.Show();
           
        }

        private void dtgvClassroom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) { 
                DataGridViewRow row = dtgvClassroom.Rows[e.RowIndex];
                txtIDClass.Text = row.Cells[0].Value.ToString();
                txtNameClass.Text = row.Cells[1].Value.ToString();
                Classroom classroom = new Classroom();
                classroom.ID = int.Parse(row.Cells[0].Value.ToString());
                classroom.Name = row.Cells[1].Value.ToString();
                dtgvListSubject.DataSource = classroomController.LoadSubjectsByClass(classroom);
                bindingSourceStudent.DataSource = classroomController.LoadStudentsByClass(classroom);
                dtgvStudent.Refresh();
            }
        }

        private void btnRefreshClass_Click(object sender, EventArgs e)
        {
            txtNameClass.Text = string.Empty;
            txtSearchClass.Text = string.Empty;
            txtIDClass.Text = string.Empty;
            bindingSourceClass.DataSource = classroomController.LoadClassroom();
            dtgvClassroom.Refresh();
        }

        private void btnSaveClass_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtIDClass.Text == string.Empty) {
                    List<TextBox> textBoxes = new List<TextBox>();
                    textBoxes.Add(txtNameClass);
                    validate.CheckEmptyTextBox(textBoxes);
                    validate.CheckLengthTextBox(textBoxes, 3, 20);
                    Classroom classroom = new Classroom();
                    classroom.Name = txtNameClass.Text;
                    classroomController.SaveClassroom(classroom, 0);
                    btnRefreshClass_Click(sender, e);
                    MessageBox.Show("Saved!");
                }
                else
                {
                    List<TextBox> textBoxes = new List<TextBox>();
                    textBoxes.Add(txtNameClass);
                    validate.CheckLengthTextBox(textBoxes, 3, 20);
                    textBoxes.Add(txtIDClass);
                    validate.CheckEmptyTextBox(textBoxes);
                    Classroom classroom = new Classroom();
                    classroom.ID = int.Parse(txtIDClass.Text);
                    classroom.Name = txtNameClass.Text;
                    classroomController.SaveClassroom(classroom, 1);
                    btnRefreshClass_Click(sender, e);
                    MessageBox.Show("Saved!");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchClass_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchClass.Text;
            int searchValueInt;
            if (int.TryParse(searchValue, out searchValueInt))
            {
                bindingSourceClass.Filter = string.Format("[ID] = {0}", searchValueInt);
            }
            else
            {
                bindingSourceClass.Filter = string.Format("[Name] LIKE '%{0}%'", searchValue);
            }
            dtgvClassroom.Refresh();
        }

        private void btnSaveSubjectToList_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dtgvClassroom.SelectedRows[0];
                Classroom classroom = new Classroom();
                classroom.ID = int.Parse(row.Cells[0].Value.ToString());
                classroom.Name = row.Cells[1].Value.ToString(); 
                ListSubject listSubject = new ListSubject();    
                listSubject.IDClassroom = int.Parse(row.Cells[0].Value.ToString());
                Subject subject = classroomController.SearchSubjectByName(cbListSubject.Text);
                listSubject.IDSubject = subject.ID;
                classroomController.SaveSubjectToList(listSubject);
                dtgvListSubject.DataSource = classroomController.LoadSubjectsByClass(classroom);
                MessageBox.Show("Saved!");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveSubjectFromList_Click(object sender, EventArgs e)
        {
            if (dtgvListSubject.SelectedRows.Count > 0)
            {
                try
                {
                    List<ListSubject> listSubjects = new List<ListSubject>();
                    
                    foreach(DataGridViewRow dr in dtgvListSubject.SelectedRows)
                    {
                        ListSubject listSubject = new ListSubject();
                        listSubject.IDClassroom = int.Parse(dr.Cells[0].Value.ToString());
                        listSubject.IDSubject = int.Parse(dr.Cells[1].Value.ToString());
                        listSubjects.Add(listSubject);  
                    }
                    classroomController.RemoveListSubject(listSubjects);
                    DataGridViewRow row = dtgvClassroom.SelectedRows[0];
                    Classroom classroom = new Classroom();
                    classroom.ID = int.Parse(row.Cells[0].Value.ToString());
                    classroom.Name = row.Cells[1].Value.ToString();
                    dtgvListSubject.DataSource = classroomController.LoadSubjectsByClass(classroom);
                    MessageBox.Show("Deleted!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRefreshStudent_Click(object sender, EventArgs e)
        {
            txtIDStudent.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtAddress.Text = string.Empty; 
            txtPhone.Text = string.Empty;
            txtSearchClass.Text = string.Empty; 
            cbGender.SelectedIndex = 0;
            if (dtgvClassroom.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvClassroom.SelectedRows[0];
                Classroom classroom = new Classroom();
                classroom.ID = int.Parse(row.Cells[0].Value.ToString());
                classroom.Name = row.Cells[1].Value.ToString();
                bindingSourceStudent.DataSource = classroomController.LoadStudentsByClass(classroom);
                dtgvStudent.Refresh();
            }
        }

        private void dtgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) {
                DataGridViewRow row = dtgvStudent.Rows[e.RowIndex];
                txtIDStudent.Text = row.Cells[0].Value.ToString();
                txtFirstName.Text = row.Cells[1].Value.ToString();
                txtLastName.Text = row.Cells[2].Value.ToString();
                cbGender.Text = row.Cells[3].Value.ToString();
                txtAddress.Text = row.Cells[4].Value.ToString();
                txtPhone.Text = row.Cells[5].Value.ToString();
            }
        }
        void ValidateStudent()
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(txtFirstName);
            textBoxes.Add(txtLastName);
            textBoxes.Add(txtAddress);
            textBoxes.Add(txtPhone);
            validate.CheckEmptyTextBox(textBoxes);
            textBoxes.Clear();
            textBoxes.Add(txtFirstName);
            textBoxes.Add(txtLastName);
            validate.CheckLengthTextBox(textBoxes, 0, 20);
            textBoxes.Clear();
            textBoxes.Add(txtAddress);
            validate.CheckLengthTextBox(textBoxes, 3, 100);
            textBoxes.Clear();
            textBoxes.Add(txtPhone);
            validate.CheckLengthTextBox(textBoxes, 9, 12);

        }
        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            if(dtgvClassroom.SelectedRows.Count > 0) { 
            try
            {
                DataGridViewRow row = dtgvClassroom.SelectedRows[0];
                ValidateStudent();
                if(txtIDStudent.Text == string.Empty)
                {
                   
                    Student student = new Student();
                    student.FirstName = txtFirstName.Text;
                    student.LastName = txtLastName.Text;
                    student.Address = txtAddress.Text;
                    student.Phone = txtPhone.Text;
                    if(cbGender.Text.Equals("Male")) {
                        student.Gender = 0;
                    }
                    else
                    {
                        student.Gender = 1;
                    }
                    student.IDClassroom = int.Parse(row.Cells[0].Value.ToString());
                    classroomController.SaveStudent(student,0);
                    btnRefreshStudent_Click(sender, e);
                    MessageBox.Show("Saved!");
                }
                else
                {
                    Student student = new Student();
                    student.ID = int.Parse(txtIDStudent.Text);
                    student.FirstName = txtFirstName.Text;
                    student.LastName = txtLastName.Text;
                    student.Address = txtAddress.Text;
                    student.Phone = txtPhone.Text;
                    if (cbGender.Text.Equals("Male"))
                    {
                        student.Gender = 0;
                    }
                    else
                    {
                        student.Gender = 1;
                    }
                     student.IDClassroom = int.Parse(row.Cells[0].Value.ToString());
                    classroomController.SaveStudent(student, 1);
                    btnRefreshStudent_Click(sender, e);
                    MessageBox.Show("Saved!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if(dtgvStudent.SelectedRows.Count > 0) { 
                List <int> idStudents = new List<int>();    
                foreach(DataGridViewRow row in dtgvStudent.SelectedRows)
                {
                    idStudents.Add(int.Parse(row.Cells[0].Value.ToString()));
                }
                try
                {
                    classroomController.RemoveStudent(idStudents);
                    btnRefreshStudent_Click(sender, e);
                    MessageBox.Show("Deleted!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchStudent.Text;
            int searchValueInt;
            if (int.TryParse(searchValue, out searchValueInt))
            {
                bindingSourceStudent.Filter = string.Format("[ID] = {0}", searchValueInt);
            }
            else
            {
                bindingSourceStudent.Filter = string.Format("[First Name] LIKE '%{0}%' OR [Last Name] LIKE '%{0}%'", searchValue);
            }
            dtgvStudent.Refresh();
        }

        private void dtgvClassroom_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvClassroom.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dtgvClassroom.SelectedRows[0];
                txtIDClass.Text = row.Cells[0].Value.ToString();
                txtNameClass.Text = row.Cells[1].Value.ToString();
                Classroom classroom = new Classroom();
                classroom.ID = int.Parse(row.Cells[0].Value.ToString());
                classroom.Name = row.Cells[1].Value.ToString();
                dtgvListSubject.DataSource = classroomController.LoadSubjectsByClass(classroom);
                bindingSourceStudent.DataSource = classroomController.LoadStudentsByClass(classroom);
                dtgvStudent.Refresh();
            }
        }
    }
}
