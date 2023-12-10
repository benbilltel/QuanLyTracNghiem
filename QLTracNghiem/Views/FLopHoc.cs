using QLTracNghiem.Controllers;
using QLTracNghiem.Models;
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

namespace QLTracNghiem.Views
{
    public partial class FLopHoc : Form
    {
        public FLopHoc()
        {
            InitializeComponent();
        }
        private BindingSource bindingSourceTblLH = new BindingSource();
        private BindingSource bindingSourceTblHV = new BindingSource();
        LopHocController lhController = new LopHocController();
        MonHocController mhController = new MonHocController();
        HocVienController hvController = new HocVienController();

        private void FLopHoc_Load(object sender, EventArgs e)
        {
            lhController.Load();
            bindingSourceTblLH.DataSource = lhController.tblData;
            dtgvLopHoc.DataSource = bindingSourceTblLH;
            dtgvLopHoc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvLopHoc.Refresh();
            cbGioiTinh.SelectedIndex = 0;
            LoadCBMonHoc();
            btnRefreshLH_Click(sender, e);
            if (dtgvLopHoc.Rows.Count > 0)
            {
                LopHoc lopHoc = new LopHoc();
                lopHoc.Ma = int.Parse(dtgvLopHoc.Rows[0].Cells[0].Value.ToString().Trim());
                lopHoc.TenLH = dtgvLopHoc.Rows[0].Cells[1].Value.ToString().Trim();
                dtgvDanhSachMon.DataSource = lhController.LoadDSMH(lopHoc);
                if (dtgvDanhSachMon.Rows.Count > 0)
                {
                    dtgvDanhSachMon.Columns["Mã lớp"].Visible = false;
                }
                dtgvDanhSachMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                hvController.Load(lopHoc);
                bindingSourceTblHV.DataSource = hvController.tblData;
                dtgvHocVien.DataSource = bindingSourceTblHV;
                dtgvHocVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgvHocVien.Refresh();
            }
           
        }

        private void btnSaveLH_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaLop.Text.Trim() == string.Empty)
                {
                    LopHoc lh = new LopHoc();
                    lh.TenLH = txtTenLop.Text.Trim();
                    lhController.Save(0, lh);
                    txtMaLop.Text = string.Empty;
                    txtTenLop.Text = string.Empty;
                    txtSearchLop.Text = string.Empty;
                    MessageBox.Show("Lưu thành công");
                }
                    
                
                else
                {
                    DataGridViewRow row = dtgvLopHoc.SelectedRows[0];
                    LopHoc lh = new LopHoc();
                    lh.Ma = int.Parse(txtMaLop.Text.Trim());
                    lh.TenLH = txtTenLop.Text.Trim();
                    
                    lhController.Save(1, lh);
                    txtMaLop.Text = string.Empty;
                    txtTenLop.Text = string.Empty;
                    txtSearchLop.Text = string.Empty;
                    FLopHoc_Load(sender, e);
                    MessageBox.Show("Lưu thành công");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgvLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvLopHoc.Rows[e.RowIndex];
                txtTenLop.Text = row.Cells["Tên lớp"].Value?.ToString().Trim() ?? string.Empty;
                txtMaLop.Text = row.Cells["Mã"].Value?.ToString().Trim() ?? string.Empty;
                LopHoc lopHoc = new LopHoc();
                lopHoc.Ma = int.Parse(row.Cells["Mã"].Value.ToString().Trim());
                lopHoc.TenLH = row.Cells["Tên lớp"].Value.ToString().Trim() ;
                dtgvDanhSachMon.DataSource = lhController.LoadDSMH(lopHoc);
                hvController.Load(lopHoc);
                bindingSourceTblHV.DataSource = hvController.tblData;
                dtgvHocVien.Refresh();

            }
        }
        void LoadCBMonHoc()
        {
            cbDSMH.Items.Clear();
            foreach(MonHoc mh in mhController.LoadListMonHoc())
            {
                cbDSMH.Items.Add(mh.TenMH);
            }
            cbDSMH.SelectedIndex = 0;
        }
        private void btnRefreshLH_Click(object sender, EventArgs e)
        {
            txtMaLop.Text = string.Empty;
            txtTenLop.Text = string.Empty;
            txtSearchLop.Text = string.Empty;
        }

        private void btnDeleteMH_Click(object sender, EventArgs e)
        {
            if (dtgvDanhSachMon.Rows.Count > 0)
            {
                if(dtgvDanhSachMon.SelectedRows.Count > 0)
                {
                    List<DanhSachMonHoc> dsmh = new List<DanhSachMonHoc>();
                    foreach(DataGridViewRow row in dtgvDanhSachMon.SelectedRows)
                    {
                        DanhSachMonHoc ds = new DanhSachMonHoc();
                        ds.MaLH =int.Parse( row.Cells["Mã lớp"].Value.ToString().Trim() );  
                        ds.MaMH = int.Parse(row.Cells["Mã môn"].Value.ToString().Trim() );
                        dsmh.Add(ds);
                    }
                    try
                    {
                        lhController.DeleteMHinDSMH( dsmh );
                        DataGridViewRow dr = dtgvLopHoc.SelectedRows[0];
                        LopHoc lopHoc = new LopHoc();
                        lopHoc.Ma = int.Parse(dr.Cells["Mã"].Value.ToString().Trim());
                        lopHoc.TenLH = dr.Cells["Tên lớp"].Value.ToString().Trim();
                        dtgvDanhSachMon.DataSource = lhController.LoadDSMH(lopHoc);
                        dtgvDanhSachMon.Refresh();
                        MessageBox.Show("Xóa thành công");
                        
                    }
                    catch(ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnSaveMH_Click(object sender, EventArgs e)
        {
            if(dtgvLopHoc.Rows.Count > 0) {
                try
                {
                    string tenMH = cbDSMH.Text.Trim();
                    MonHoc mh = mhController.TimMonHocTheoTen(tenMH);
                    if (mh != null)
                    {
                        DataGridViewRow row = dtgvLopHoc.SelectedRows[0];
                        int maLH = int.Parse(row.Cells["Mã"].Value.ToString().Trim());
                        lhController.SaveMHtoDSMH(mh, maLH);
                        DataGridViewRow dr = dtgvLopHoc.SelectedRows[0];
                        LopHoc lopHoc = new LopHoc();
                        lopHoc.Ma = int.Parse(dr.Cells["Mã"].Value.ToString().Trim());
                        lopHoc.TenLH = dr.Cells["Tên lớp"].Value.ToString().Trim();
                        dtgvDanhSachMon.DataSource = lhController.LoadDSMH(lopHoc);
                        dtgvDanhSachMon.Refresh();
                        MessageBox.Show("Lưu thành công");
                        
                    }
                    else
                    {
                        throw new ArgumentException("Môn học đã không còn tồn tại");
                    }
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDeleteHV_Click(object sender, EventArgs e)
        {
            if (dtgvHocVien.SelectedRows.Count > 0)
            {
                List<int> maHVs = new List<int>();  
                foreach(DataGridViewRow row in dtgvHocVien.SelectedRows)
                {
                    maHVs.Add(int.Parse(row.Cells["Mã"].Value.ToString().Trim()));
                }
                try
                {
                    hvController.Remove(maHVs);
                    DataGridViewRow row = dtgvLopHoc.SelectedRows[0];
                    LopHoc lopHoc = new LopHoc();
                    lopHoc.Ma = int.Parse(row.Cells["Mã"].Value.ToString().Trim());
                    lopHoc.TenLH = row.Cells["Tên lớp"].Value.ToString().Trim();
                    hvController.Load(lopHoc);
                    bindingSourceTblHV.DataSource = hvController.tblData;
                    dtgvDanhSachMon.Refresh();
                    btnRefreshHV_Click(sender, e);
                    MessageBox.Show("Xóa thành công");
                }
                catch(ArgumentException ex) { 
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSaveHV_Click(object sender, EventArgs e)
        {
            if(txtMaHV.Text == string.Empty )
            {
                HocVien hocVien = new HocVien();
                hocVien.Ho = txtHoHV.Text.Trim();
                hocVien.Ten = txtTenHV.Text.Trim();
                hocVien.DiaChi = txtDiaChi.Text.Trim();
                hocVien.SoDienThoai = txtSDT.Text.Trim();
                if(cbGioiTinh.Text == "Nam")
                {
                    hocVien.GioiTinh = 0;
                }
                else
                {
                    hocVien.GioiTinh = 1;
                }
                DataGridViewRow row = dtgvLopHoc.SelectedRows[0];
                hocVien.MaLH = int.Parse(row.Cells["Mã"].Value.ToString().Trim());
                try
                {
                    hvController.Save(hocVien,0);
                    LopHoc lopHoc = new LopHoc();
                    lopHoc.Ma = int.Parse(row.Cells["Mã"].Value.ToString().Trim());
                    lopHoc.TenLH = row.Cells["Tên lớp"].Value.ToString().Trim();
                    hvController.Load(lopHoc);
                    bindingSourceTblHV.DataSource = hvController.tblData;
                    dtgvDanhSachMon.Refresh();
                    MessageBox.Show("Lưu thành công");
                }catch(ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                HocVien hocVien = new HocVien();
                hocVien.Ma = int.Parse(txtMaHV.Text.Trim());
                hocVien.Ho = txtHoHV.Text.Trim();
                hocVien.Ten = txtTenHV.Text.Trim();
                hocVien.DiaChi = txtDiaChi.Text.Trim();
                hocVien.SoDienThoai = txtSDT.Text.Trim();
                if (cbGioiTinh.Text == "Nam")
                {
                    hocVien.GioiTinh = 0;
                }
                else
                {
                    hocVien.GioiTinh = 1;
                }
                DataGridViewRow row = dtgvLopHoc.SelectedRows[0];
                hocVien.MaLH = int.Parse(row.Cells["Mã"].Value.ToString().Trim());
                try
                {
                    hvController.Save(hocVien, 1);
                    LopHoc lopHoc = new LopHoc();
                    lopHoc.Ma = int.Parse(row.Cells["Mã"].Value.ToString().Trim());
                    lopHoc.TenLH = row.Cells["Tên lớp"].Value.ToString().Trim();
                    hvController.Load(lopHoc);
                    bindingSourceTblHV.DataSource = hvController.tblData;
                    dtgvDanhSachMon.Refresh();
                    btnRefreshHV_Click(sender,e);
                    MessageBox.Show("Lưu thành công");
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtgvHocVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                DataGridViewRow row = dtgvHocVien.SelectedRows[0];
                txtMaHV.Text = row.Cells["Mã"].Value.ToString().Trim();
                txtHoHV.Text = row.Cells["Họ"].Value.ToString().Trim();
                txtTenHV.Text = row.Cells["Tên"].Value.ToString().Trim();
                txtDiaChi.Text = row.Cells["Địa chỉ"].Value.ToString().Trim();
                txtSDT.Text = row.Cells["Số điện thoại"].Value.ToString().Trim();
                cbGioiTinh.Text = row.Cells["Giới tính"].Value.ToString().Trim();
            }
        }

        private void btnRefreshHV_Click(object sender, EventArgs e)
        {
            txtMaHV.Text = string.Empty;
            txtHoHV.Text = string.Empty;
            txtTenHV.Text = string.Empty;
            txtDiaChi.Text = string.Empty;
            txtSDT.Text = string.Empty;
            cbGioiTinh.SelectedIndex = 0;
        }

        private void txtSearchLop_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchLop.Text;
            int searchValueInt;
            if (int.TryParse(searchValue, out searchValueInt))
            {
                bindingSourceTblLH.Filter = string.Format("[Mã] = {0}", searchValueInt);
            }
            else
            {
                bindingSourceTblLH.Filter = string.Format("[Tên lớp] LIKE '%{0}%'", searchValue);
            }
            dtgvLopHoc.Refresh();
        }

        private void txtSearchHV_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearchHV.Text;
            int searchValueInt;
            if (int.TryParse(searchValue, out searchValueInt))
            {
                bindingSourceTblHV.Filter = string.Format("[Mã] = {0}", searchValueInt);
            }
            else
            {
                bindingSourceTblHV.Filter = string.Format("[Tên] LIKE '%{0}%'", searchValue);
            }
            dtgvHocVien.Refresh();
        }
    }
}
