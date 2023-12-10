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
    public partial class FAdmin : Form
    {
        public FAdmin()
        {
            InitializeComponent();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            FAccounts fAccounts = new FAccounts();
            fAccounts.ShowDialog();
        }

        private void FAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            FLopHoc fLopHoc = new FLopHoc();
            fLopHoc.ShowDialog();
        }

        private void btnMH_Click(object sender, EventArgs e)
        {
            FMonHoc fMonHoc = new FMonHoc();
            fMonHoc.ShowDialog();
        }
    }
}
