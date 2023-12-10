using QLTracNghiem.Models;
using QLTracNghiem.Models.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTracNghiem.Controllers
{
    public class LopHocController : QLTracNghiemController
    {
        public LopHocController() : base()
        {
            tblData = new DataTable();
          
        }
        public DataTable tblData;
        public void Load()
        {
            DataTable tblTemp = new DataTable();
            tblTemp.Columns.Add("Mã", typeof(int));
            tblTemp.Columns.Add("Tên lớp", typeof(string));

            foreach (LopHoc lh in db.LopHocs)
            {
                DataRow row = tblTemp.NewRow();
                row["Mã"] = lh.Ma;
                row["Tên lớp"] = lh.TenLH;
                tblTemp.Rows.Add(row);
            }
            tblData = tblTemp;
        }
        public void Save(int action, LopHoc lh)
        {
            if (action == 0)
            {
                db.LopHocs.Add(lh);
                if (db.Entry(lh).State == System.Data.Entity.EntityState.Added)
                {
                    try
                    {
                        db.SaveChanges(); 
                    }
                    catch
                    {
                        throw new ArgumentException("Thêm thất bại");
                    }
                }

               
            }
            if (action == 1)
            {
                var lhUpdate = db.LopHocs.FirstOrDefault(ua => ua.Ma == lh.Ma);
                if (lhUpdate != null)
                {
                    lhUpdate.TenLH = lh.TenLH;

                    if (db.Entry(lhUpdate).State == System.Data.Entity.EntityState.Modified)
                    {
                        try
                        {
                            db.SaveChanges();
                        }
                        catch
                        {
                            throw new ArgumentException("Cập nhật thất bại");
                        }

                       
                    }

                }
                foreach (DataRow row in tblData.Rows)
                {
                    if ((int)row["Mã"] == lh.Ma)
                    {
                        row["Tên lớp"] = lh.TenLH;
                        break;
                    }
                }
            }
        }
        public DataTable LoadDSMH(LopHoc lopHoc)
        {
            DataTable tblDSMH = new DataTable();
            tblDSMH.Columns.Add("Mã lớp", typeof(int));
            tblDSMH.Columns.Add("Mã môn", typeof(int));
            tblDSMH.Columns.Add("Tên môn", typeof(string));
            List<DanhSachMonHoc> listDS = new List<DanhSachMonHoc> ();
            foreach (DanhSachMonHoc ds in db.DanhSachMonHocs)
            {
                if (ds.MaLH == lopHoc.Ma)
                {
                    listDS.Add(ds);
                }
            }
            foreach(DanhSachMonHoc ds in listDS)
            {
                foreach(MonHoc mh in db.MonHocs)
                {
                    if(mh.Ma == ds.MaMH) { 
                        DataRow row = tblDSMH.NewRow();
                        row["Mã lớp"] = ds.MaLH;
                        row["Mã môn"] = ds.MaMH;
                        row["Tên môn"] = mh.TenMH;
                        tblDSMH.Rows.Add(row);
                    }
                }
            }                       
            return tblDSMH;
        }
        public void SaveMHtoDSMH(MonHoc monhoc,int maLH)
        {
            var mh = db.DanhSachMonHocs.FirstOrDefault(m => m.MaLH == maLH && m.MaMH == monhoc.Ma);
            if (mh != null)
            {
                throw new ArgumentException("Môn học đã tồn tại trong danh sách môn học của lớp");
            }
            else
            {
                DanhSachMonHoc ds = new DanhSachMonHoc();
                ds.MaLH = maLH;
                ds.MaMH = monhoc.Ma;
                db.DanhSachMonHocs.Add(ds);
                if(db.Entry(ds).State == System.Data.Entity.EntityState.Added)
                {
                    try
                    {
                        db.SaveChanges();
                    }
                    catch
                    {
                        throw new ArgumentException("Thêm thất bại");
                    }
                }
                else
                {
                    throw new ArgumentException("Thêm thất bại");
                }
            }
        }
        public void DeleteMHinDSMH(List<DanhSachMonHoc> dsmhs)
        {
            foreach(DanhSachMonHoc ds in dsmhs) {
                var dsRemove = db.DanhSachMonHocs.FirstOrDefault(d => d.MaLH == ds.MaLH && d.MaMH == ds.MaMH);
                if (dsRemove == null)
                {
                    throw new ArgumentException("Môn học đã tồn tại trong danh sách môn học của lớp");
                }
                else
                {
                    db.DanhSachMonHocs.Remove(dsRemove);
                    if (db.Entry(dsRemove).State == System.Data.Entity.EntityState.Deleted)
                    {
                        try
                        {
                            db.SaveChanges();
                        }
                        catch
                        {
                            throw new ArgumentException("Xóa thất bại");
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Xóa thất bại");
                    }
                }
            }
            
        }
        
    }

}
