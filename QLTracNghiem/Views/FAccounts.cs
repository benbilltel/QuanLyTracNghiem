using QLTracNghiem.Controllers;
using QLTracNghiem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTracNghiem
{
    public partial class FAccounts : Form
    {
        private BindingSource bindingSource = new BindingSource();
        public FAccounts()
        {
            InitializeComponent();
            
        }
        UserAdminController usAD_controller = new UserAdminController();   
        private void FAccounts_Load(object sender, EventArgs e)
        {
            usAD_controller.Load();
            bindingSource.DataSource = usAD_controller.tblData;
            dtgvUsAdmin.DataSource = bindingSource;
            dtgvUsAdmin.Columns["Mã"].Visible = false;
            dtgvUsAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvUsAdmin.Refresh();
            btnRefreshUsAD_Click(sender, e);
        }

        private void btnAddUsAD_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTaiKhoanUsAD.ReadOnly != true)
                {
                    UserAdmin usAD = new UserAdmin();
                    usAD.TaiKhoan = txtTaiKhoanUsAD.Text.Trim();
                    usAD.MatKhau = txtMatKhauUsAD.Text.Trim();
                    usAD_controller.Save(0, usAD);
                    txtMatKhauUsAD.Text = string.Empty;
                    txtTaiKhoanUsAD.Text = string.Empty;
                    MessageBox.Show("Lưu thành công");
                }
                else
                {
                    DataGridViewRow row = dtgvUsAdmin.SelectedRows[0];
                    UserAdmin usAD = new UserAdmin();
                    usAD.Ma = int.Parse(row.Cells["Mã"].Value.ToString().Trim());
                    usAD.TaiKhoan = txtTaiKhoanUsAD.Text.Trim();
                    usAD.MatKhau = txtMatKhauUsAD.Text.Trim();
                    usAD_controller.Save(1, usAD);
                    txtMatKhauUsAD.Text = string.Empty;
                    txtTaiKhoanUsAD.Text = string.Empty;
                    txtTaiKhoanUsAD.ReadOnly = false;
                    FAccounts_Load(sender, e);
                    MessageBox.Show("Lưu thành công");
                }
            }catch(ArgumentException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshUsAD_Click(object sender, EventArgs e)
        {
            txtTaiKhoanUsAD.Text = string.Empty;
            txtMatKhauUsAD.Text = string.Empty;
            txtSearchUsAdmin.Text = string.Empty;
            txtTaiKhoanUsAD.ReadOnly = false;

            bindingSource.Filter = null;
            dtgvUsAdmin.Refresh();
        }

        private void dtgvUsAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvUsAdmin.Rows[e.RowIndex];
                txtTaiKhoanUsAD.Text = row.Cells["Tài khoản"].Value?.ToString().Trim()??string.Empty;
                txtMatKhauUsAD.Text = row.Cells["Mật khẩu"].Value?.ToString().Trim() ?? string.Empty;
                txtTaiKhoanUsAD.ReadOnly = true;
            }
        }

        private void btnRemoveUSAD_Click(object sender, EventArgs e)
        {
            if (dtgvUsAdmin.SelectedRows.Count > 0)
            {
                try
                {
                    List<UserAdmin> listRemove = new List<UserAdmin>(); 
                    foreach (DataGridViewRow row in dtgvUsAdmin.SelectedRows)
                    {
                        UserAdmin usAD = new UserAdmin();
                        usAD.Ma = (int)row.Cells["Mã"].Value;
                        usAD.TaiKhoan = row.Cells["Tài khoản"].Value.ToString().Trim();
                        usAD.MatKhau = row.Cells["Mật khẩu"].Value.ToString().Trim();
                        listRemove.Add(usAD);  
                    }
                    usAD_controller.Remove(listRemove);
                    FAccounts_Load(sender, e);
                    MessageBox.Show("Xóa thành công");
                }catch(ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSearchUsAdmin_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchUsAdmin.Text;
            bindingSource.Filter = string.Format("[Tài khoản] LIKE '%{0}%'", searchValue);
            dtgvUsAdmin.Refresh();
        }
    }
}
