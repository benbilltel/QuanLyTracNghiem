using QuanLyTracNghiem.Controllers;
using QuanLyTracNghiem.Helper;
using QuanLyTracNghiem.Models;
using QuanLyTracNghiem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTracNghiem
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }
        ValidationUI validate = new ValidationUI();
        LoginController loginController = new LoginController();
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                List<TextBox> textBoxes = new List<TextBox>();
                textBoxes.Add(txtUsername);
                textBoxes.Add(txtPassword);
                validate.CheckEmptyTextBox(textBoxes);
                validate.CheckLengthTextBox(textBoxes, 6, 20);
                if (rdAdmin.Checked)
                {
                    UserAdmin userAdmin = new UserAdmin();
                    userAdmin.Username = txtUsername.Text;
                    userAdmin.Password = txtPassword.Text;
                    var userLG = loginController.SignInByAdmin(userAdmin);
                    if (userLG != null)
                    {
                        FAdmin fAdmin = new FAdmin();
                        this.Hide();
                        fAdmin.ShowDialog();
                    }
                    else
                    {
                        throw new Exception("Sign in failed!");
                    }
                }
                else
                {
                    UserStudent userStudent = new UserStudent();
                    userStudent.Username = txtUsername.Text;
                    userStudent.Password = txtPassword.Text;
                    var userLG = loginController.SignInByStudent(userStudent);
                    if (userLG != null)
                    {
                        FStudent fStudent = new FStudent(userLG);
                        this.Hide();
                        fStudent.ShowDialog();
                    }
                    else
                    {
                        throw new Exception("Sign in failed!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
