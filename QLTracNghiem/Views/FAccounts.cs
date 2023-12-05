using QLTracNghiem.Controllers.Services;
using QLTracNghiem.Models.DTO;
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
        UserAdmin_Ser usAD_ser = new UserAdmin_Ser();   
        private void FAccounts_Load(object sender, EventArgs e)
        {
            usAD_ser.Load();
            bindingSource.DataSource = usAD_ser.tblData;
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
                    DTO_UserAdmin dtoUsAd = new DTO_UserAdmin();
                    dtoUsAd.TaiKhoan = txtTaiKhoanUsAD.Text.Trim();
                    dtoUsAd.MatKhau = txtMatKhauUsAD.Text.Trim();
                    usAD_ser.Save(0, dtoUsAd);
                    txtMatKhauUsAD.Text = string.Empty;
                    txtTaiKhoanUsAD.Text = string.Empty;
                    MessageBox.Show("Lưu thành công");
                }
                else
                {
                    DataGridViewRow row = dtgvUsAdmin.SelectedRows[0];
                    DTO_UserAdmin dtoUsAd = new DTO_UserAdmin();
                    dtoUsAd.Ma = int.Parse(row.Cells["Mã"].Value.ToString().Trim());
                    dtoUsAd.TaiKhoan = txtTaiKhoanUsAD.Text.Trim();
                    dtoUsAd.MatKhau = txtMatKhauUsAD.Text.Trim();
                    usAD_ser.Save(1, dtoUsAd);
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
                    List<DTO_UserAdmin> listRemove = new List<DTO_UserAdmin>(); 
                    foreach (DataGridViewRow row in dtgvUsAdmin.SelectedRows)
                    {
                        DTO_UserAdmin dTO_UserAdmin = new DTO_UserAdmin();
                        dTO_UserAdmin.Ma = (int)row.Cells["Mã"].Value;
                        dTO_UserAdmin.TaiKhoan = row.Cells["Tài khoản"].Value.ToString().Trim();
                        dTO_UserAdmin.MatKhau = row.Cells["Mật khẩu"].Value.ToString().Trim();
                        listRemove.Add(dTO_UserAdmin);  
                    }
                    usAD_ser.Remove(listRemove);
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
