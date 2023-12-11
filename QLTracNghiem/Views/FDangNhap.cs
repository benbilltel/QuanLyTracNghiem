using QLTracNghiem.Controllers;
using QLTracNghiem.Models;
using QLTracNghiem.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTracNghiem.Views
{
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }
        DangNhapController dn = new DangNhapController();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(rdQuanLy.Checked) {
                UserAdmin us = new UserAdmin(); 
                us.TaiKhoan = txtTaiKhoan.Text;
                us.MatKhau = txtMatKhau.Text;
                if(dn.DangNhapQuanLy(us) )
                {
                    FAdmin fAdmin = new FAdmin();
                    this.Hide();
                    fAdmin.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            else
            {
                UserHocVien us = new UserHocVien();
                us.TaiKhoan = txtTaiKhoan.Text;
                us.MatKhau = txtMatKhau.Text;
                var hv = dn.DangNhapHocVien(us);
                if (hv != null)
                {
                    FThi fThi = new FThi(hv);
                    this.Hide();
                    fThi.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
        }

        private void FDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
