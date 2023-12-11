using QLTracNghiem.Controllers;
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
    public partial class FThi : Form
    {
        public FThi(HocVien hv)
        {
            InitializeComponent();
            hocVienThi = hv;
        }
        HocVien hocVienThi;
        MonHocController monHocController = new MonHocController();
        ThiController thiController = new ThiController();
        private void FThi_Load(object sender, EventArgs e)
        {
            lblHoTen.Text = hocVienThi.Ho + " " + hocVienThi.Ten;
            lblMa.Text = hocVienThi.Ma.ToString();
            lblMaLop.Text = hocVienThi.MaLH.ToString();
            List<MonHoc> mhs = monHocController.LoadListMonThi(hocVienThi.MaLH);
            foreach(MonHoc mh in mhs)
            {
                cbListMonThi.Items.Add(mh.TenMH);
            }
            if (cbListMonThi.Items.Count > 0)
            {
                cbListMonThi.SelectedIndex = 0;
                
            }
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            FBaiLam fBaiLam = new FBaiLam(cbListMonThi.Text,hocVienThi);
            fBaiLam.Show();
        }

        private void cbListMonThi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbListMonThi.Items.Count > 0)
            {
                dtgvKetQua.DataSource = thiController.LoadKetQua(hocVienThi, cbListMonThi.Text);
                dtgvKetQua.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void FThi_FormClosed(object sender, FormClosedEventArgs e)
        {
            FDangNhap fDang = new FDangNhap();
            fDang.Show();
            this.Close();
        }
    }
}
