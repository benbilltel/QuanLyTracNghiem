using QLTracNghiem.Controllers;
using QLTracNghiem.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QLTracNghiem.Views
{
    public partial class FMonHoc : Form
    {
        public FMonHoc()
        {
            InitializeComponent();
        }
        private BindingSource bindingSourceTblMH = new BindingSource();
        private BindingSource bindingSourceTblCH = new BindingSource();
        MonHocController mhController = new MonHocController();
        private void FMonHoc_Load(object sender, EventArgs e)
        {
            mhController.Load();
            bindingSourceTblMH.DataSource = mhController.tblData;
            dtgvMH.DataSource = bindingSourceTblMH;
            dtgvMH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvMH.Refresh();
            cbDapAnDung.SelectedIndex = 0;
            if(dtgvMH.Rows.Count > 0)
            {
                DataGridViewRow row = dtgvMH.Rows[0];
                MonHoc mh = new MonHoc();
                mh.Ma = int.Parse(row.Cells["Mã"].Value.ToString());
                mh.TenMH = row.Cells["Tên môn"].Value.ToString();   
                dtgvChuong.DataSource = mhController.LoadChuongByMH(mh);
                dtgvChuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dtgvChuong.Rows.Count > 0)
                {
                    DataGridViewRow dr = dtgvChuong.Rows[0];
                    Chuong chuong = new Chuong();
                    chuong.Ma = int.Parse(dr.Cells["Mã"].Value.ToString().Trim());
                    chuong.TenChuong = dr.Cells["Tên chương"].Value.ToString().Trim();
                    bindingSourceTblCH.DataSource = mhController.LoadCauHoiByChuong(chuong);
                    dtgvCauHoi.DataSource = bindingSourceTblCH;
                    dtgvCauHoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dtgvCauHoi.Refresh();
                }
                
            }
        }

        private void btnSaveMH_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaMH.Text.Trim() == string.Empty)
                {
                    MonHoc mh = new MonHoc();
                    mh.TenMH = txtTenMH.Text.Trim();
                    mhController.Save(mh,0);
                    btnRefreshMH_Click(sender, e);
                    MessageBox.Show("Lưu thành công");
                }


                else
                {
                    DataGridViewRow row = dtgvMH.SelectedRows[0];
                    MonHoc mh = new MonHoc();
                    mh.Ma = int.Parse(txtMaMH.Text.Trim());
                    mh.TenMH = txtTenMH.Text.Trim();

                    mhController.Save(mh,1 );
                    btnRefreshMH_Click(sender, e);
                    MessageBox.Show("Lưu thành công");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshMH_Click(object sender, EventArgs e)
        {
            txtTenMH.Text = string.Empty;
            txtSearchMH.Text = string.Empty;
            txtMaMH.Text = string.Empty;
            mhController.Load();
            bindingSourceTblMH.DataSource = mhController.tblData;
            dtgvMH.Refresh();
        }

        private void dtgvMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0) {
                DataGridViewRow row = dtgvMH.Rows[e.RowIndex];
                txtMaMH.Text = row.Cells["Mã"].Value.ToString().Trim();
                txtTenMH.Text = row.Cells["Tên môn"].Value.ToString().Trim();
                MonHoc mh = new MonHoc();
                mh.Ma = int.Parse(row.Cells["Mã"].Value.ToString());
                mh.TenMH = row.Cells["Tên môn"].Value.ToString();
                dtgvChuong.DataSource = mhController.LoadChuongByMH(mh);
            }
        }

        private void dtgvChuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvChuong.Rows[e.RowIndex];
                txtMaChuong.Text = row.Cells["Mã"].Value.ToString().Trim();
                txtTenChuong.Text = row.Cells["Tên chương"].Value.ToString().Trim();
                Chuong chuong = new Chuong();   
                chuong.Ma = int.Parse(row.Cells["Mã"].Value.ToString().Trim());
                chuong.TenChuong = row.Cells["Tên chương"].Value.ToString().Trim();
                bindingSourceTblCH.DataSource = mhController.LoadCauHoiByChuong(chuong);
                dtgvCauHoi.DataSource = bindingSourceTblCH;
                dtgvCauHoi.Refresh();

            }
        }

        private void btnSaceChuong_Click(object sender, EventArgs e)
        {
            if(dtgvMH.Rows.Count > 0) { 
                if(txtMaChuong.Text == string.Empty)
                {
                    DataGridViewRow row = dtgvMH.SelectedRows[0];
                    Chuong chuong = new Chuong();
                    chuong.TenChuong = txtTenChuong.Text;
                    chuong.MaMH = int.Parse(row.Cells["Mã"].Value.ToString().Trim());
                    try
                    {
                        mhController.SaveChuongToMH(chuong,0);
                        btnRefreshChuong_Click(sender, e);
                        MessageBox.Show("Lưu thành công");
                    }
                    catch(ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    
                }
                else
                {
                    DataGridViewRow row = dtgvMH.SelectedRows[0];
                    Chuong chuong = new Chuong();
                    chuong.Ma = int.Parse(txtMaChuong.Text);
                    chuong.TenChuong = txtTenChuong.Text;
                    chuong.MaMH = int.Parse(row.Cells["Mã"].Value.ToString().Trim());
                    try
                    {
                        mhController.SaveChuongToMH(chuong, 1);
                        btnRefreshChuong_Click(sender, e);
                        MessageBox.Show("Lưu thành công");
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    
                }
            }
        }

        private void btnRefreshChuong_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtgvMH.SelectedRows[0];
            MonHoc monHoc = new MonHoc();
            monHoc.Ma = int.Parse(row.Cells["Mã"].Value.ToString().Trim());
            monHoc.TenMH = row.Cells["Tên môn"].Value.ToString().Trim();
            dtgvChuong.DataSource = mhController.LoadChuongByMH(monHoc);
            txtMaChuong.Text = string.Empty;
            txtTenChuong.Text = string.Empty;
        }

        private void dtgvCauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = dtgvCauHoi.Rows[e.RowIndex];
                txtMaCH.Text = row.Cells[0].Value.ToString();
                txtNoiDung.Text = row.Cells[1].Value.ToString();
                txtA.Text = row.Cells[2].Value.ToString();
                txtB.Text = row.Cells[3].Value.ToString();
                txtC.Text = row.Cells[4].Value.ToString();
                txtD.Text = row.Cells[5].Value.ToString();
                cbDapAnDung.Text = row.Cells[6].Value.ToString();

            }
        }

        private void btnRefreshCH_Click(object sender, EventArgs e)
        {
            txtMaCH.Text = string.Empty;
            txtNoiDung.Text = string.Empty;
            txtA.Text = string.Empty;
            txtB.Text = string.Empty;
            txtC.Text = string.Empty;
            txtD.Text = string.Empty;
            cbDapAnDung.SelectedIndex = 0;
            DataGridViewRow row = dtgvChuong.SelectedRows[0];
            txtMaChuong.Text = row.Cells["Mã"].Value.ToString().Trim();
            txtTenChuong.Text = row.Cells["Tên chương"].Value.ToString().Trim();
            Chuong chuong = new Chuong();
            chuong.Ma = int.Parse(row.Cells["Mã"].Value.ToString().Trim());
            chuong.TenChuong = row.Cells["Tên chương"].Value.ToString().Trim();
            bindingSourceTblCH.DataSource = mhController.LoadCauHoiByChuong(chuong);
            dtgvCauHoi.DataSource = bindingSourceTblCH;
            dtgvCauHoi.Refresh();
        }

        private void btnSaveCH_Click(object sender, EventArgs e)
        {
            if(txtMaCH.Text == string.Empty) { 
                CauHoi cauHoi = new CauHoi();
                cauHoi.NoiDung = txtNoiDung.Text;
                cauHoi.DapAnA = txtA.Text;
                cauHoi.DapAnB = txtB.Text;
                cauHoi.DapAnC = txtC.Text;
                cauHoi.DapAnD = txtD.Text;
                if(cbDapAnDung.Text.Equals("A"))
                {
                    cauHoi.DapAnDung = 0;
                }else if (cbDapAnDung.Text.Equals("B")) {
                    cauHoi.DapAnDung = 1;
                }
                else if (cbDapAnDung.Text.Equals("C"))
                {
                    cauHoi.DapAnDung = 2;
                }
                else 
                {
                    cauHoi.DapAnDung = 3;
                }
                if (dtgvChuong.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dtgvChuong.SelectedRows[0];
                    cauHoi.MaChuong = int.Parse(row.Cells[0].Value.ToString());
                }

                try
                {
                    mhController.SaveCauHoi(cauHoi, 0);
                    btnRefreshCH_Click(sender, e);
                    MessageBox.Show("Lưu thành công");
                }catch(ArgumentException ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                CauHoi cauHoi = new CauHoi();
                cauHoi.Ma = int.Parse(txtMaCH.Text);
                cauHoi.NoiDung = txtNoiDung.Text;
                cauHoi.DapAnA = txtA.Text;
                cauHoi.DapAnB = txtB.Text;
                cauHoi.DapAnC = txtC.Text;
                cauHoi.DapAnD = txtD.Text;
                if (cbDapAnDung.Text.Equals("A"))
                {
                    cauHoi.DapAnDung = 0;
                }
                else if (cbDapAnDung.Text.Equals("B"))
                {
                    cauHoi.DapAnDung = 1;
                }
                else if (cbDapAnDung.Text.Equals("C"))
                {
                    cauHoi.DapAnDung = 2;
                }
                else
                {
                    cauHoi.DapAnDung = 3;
                }
                if (dtgvChuong.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dtgvChuong.SelectedRows[0];
                    cauHoi.MaChuong = int.Parse(row.Cells[0].Value.ToString());
                }
                try
                {
                    mhController.SaveCauHoi(cauHoi, 1);
                    btnRefreshCH_Click(sender, e);
                    MessageBox.Show("Lưu thành công");
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDeleteCH_Click(object sender, EventArgs e)
        {
            if(dtgvCauHoi.SelectedRows.Count > 0)
            {
                List<int> maCHs = new List<int>();  
                foreach(DataGridViewRow row in dtgvCauHoi.SelectedRows)
                {
                    maCHs.Add(int.Parse(row.Cells[0].Value.ToString()));
                }
                try
                {
                    mhController.DeleteCauHois(maCHs);
                    btnRefreshCH_Click(sender, e);
                    MessageBox.Show("Xóa thành công");
                }catch(ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
