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
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClassroom_Click(object sender, EventArgs e)
        {
            FClassroom fClassroom = new FClassroom();
            this.Hide();
            fClassroom.Show();
        }

        private void FAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            FLogin fLogin = new FLogin();
            fLogin.Show();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            FSubject fSubject = new FSubject();
            this.Hide();
            fSubject.Show();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {

        }

        private void FAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
