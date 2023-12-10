using QLTracNghiem.Models.Data;
using QLTracNghiem.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Controllers
{
    public class MonHocController : QLTracNghiemController
    {
        public MonHocController() : base(){
            tblData = new DataTable();
        }
        public DataTable tblData;
        public void Load()
        {
            DataTable tbltemp = new DataTable();
            tbltemp.Columns.Add("Mã",typeof(int));
            tbltemp.Columns.Add("Tên môn",typeof (string));
            foreach(MonHoc mh in db.MonHocs)
            {
                DataRow row = tbltemp.NewRow();
                row["Mã"] = mh.Ma;
                row["Tên môn"] = mh.TenMH;
                tbltemp.Rows.Add(row);
            }
            tblData = tbltemp;
        }
        public void Save(MonHoc monHoc, int action) {
            if (action == 0)
            {
                db.MonHocs.Add(monHoc);
                if (db.Entry(monHoc).State == System.Data.Entity.EntityState.Added)
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
                var mhUpdate = db.MonHocs.FirstOrDefault(ua => ua.Ma == monHoc.Ma);
                if (mhUpdate != null)
                {
                    mhUpdate.TenMH = monHoc.TenMH;

                    if (db.Entry(mhUpdate).State == System.Data.Entity.EntityState.Modified)
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
                    if ((int)row["Mã"] == mhUpdate.Ma)
                    {
                        row["Tên môn"] = mhUpdate.TenMH;
                        break;
                    }
                }
            }
        }
        public List<MonHoc> LoadListMonHoc()
        {
            return db.MonHocs.ToList();
        }
        public MonHoc TimMonHocTheoTen(string tenMH)
        {
            foreach(MonHoc mh in db.MonHocs)
            {
                if (mh.TenMH == tenMH)
                {
                    return mh;  
                }
            }
            return null;
        }
        public DataTable LoadChuongByMH(MonHoc monHoc)
        {
            DataTable tblChuong = new DataTable();
            tblChuong.Columns.Add("Mã",typeof(int));
            tblChuong.Columns.Add("Tên chương", typeof(string));
            foreach(Chuong c in db.Chuongs)
            {
                if(c.MaMH == monHoc.Ma)
                {
                    DataRow row = tblChuong.NewRow();
                    row["Mã"] = c.Ma;
                    row["Tên chương"] = c.TenChuong;
                    tblChuong.Rows.Add(row);
                }
            }
            return tblChuong;
        }
        public DataTable LoadCauHoiByChuong(Chuong chuong)
        {
            DataTable tblCH = new DataTable();
            tblCH.Columns.Add("Mã", typeof(int));
            tblCH.Columns.Add("Nội dung", typeof(string));
            tblCH.Columns.Add("A", typeof(string));
            tblCH.Columns.Add("B", typeof(string));
            tblCH.Columns.Add("C", typeof(string));
            tblCH.Columns.Add("D", typeof(string));
            tblCH.Columns.Add("Đáp án đúng", typeof(string));
            foreach (CauHoi c in db.CauHois)
            {
                if (c.MaChuong == chuong.Ma)
                {
                    DataRow row = tblCH.NewRow();
                    row["Mã"] = c.Ma;
                    row["Nội dung"] = c.NoiDung;
                    row["A"] = c.DapAnA;
                    row["B"] = c.DapAnB;
                    row["C"] = c.DapAnC;
                    row["D"] = c.DapAnD;
                    if(c.DapAnDung == 0)
                    {
                        row["Đáp án đúng"] = "A";
                    }else if (c.DapAnDung == 1)
                    {
                        row["Đáp án đúng"] = "B";
                    }else if (c.DapAnDung == 2)
                    {
                        row["Đáp án đúng"] = "C";
                    }else if (c.DapAnDung == 3)
                    {
                        row["Đáp án đúng"] = "D";
                    }

                    tblCH.Rows.Add(row);
                }
            }
            return tblCH;
        }
        public void SaveChuongToMH (Chuong chuong,int action)
        {
            if(action == 0)
            {
                db.Chuongs.Add(chuong);
                if (db.Entry(chuong).State == System.Data.Entity.EntityState.Added)
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
            else
            {
                var chuongUdpate = db.Chuongs.FirstOrDefault(ua => ua.Ma == chuong.Ma);
                if (chuongUdpate != null)
                {
                    chuongUdpate.TenChuong = chuong.TenChuong;

                    if (db.Entry(chuongUdpate).State == System.Data.Entity.EntityState.Modified)
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
                
            }
        }
        public void SaveCauHoi(CauHoi cauHoi, int action)
        {
            if (action == 0)
            {
                db.CauHois.Add(cauHoi);
                if (db.Entry(cauHoi).State == System.Data.Entity.EntityState.Added)
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
                var cauHoiUpdate = db.CauHois.FirstOrDefault(ua => ua.Ma == cauHoi.Ma);
                if (cauHoiUpdate != null)
                {
                    cauHoiUpdate.NoiDung = cauHoi.NoiDung;
                    cauHoiUpdate.DapAnA = cauHoi.DapAnA;
                    cauHoiUpdate.DapAnB = cauHoi.DapAnB;
                    cauHoiUpdate.DapAnC = cauHoi.DapAnC;
                    cauHoiUpdate.DapAnD = cauHoi.DapAnD;
                    cauHoiUpdate.DapAnDung = cauHoi.DapAnDung;

                    if (db.Entry(cauHoiUpdate).State == System.Data.Entity.EntityState.Modified)
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
            }
        }
        public void DeleteCauHois(List<int> maCHs)
        {
            foreach(int maCH in maCHs) { 
                var ch = db.CauHois.FirstOrDefault(c => c.Ma ==  maCH);
                if(ch != null)
                {
                    db.CauHois.Remove(ch);
                    if (db.Entry(ch).State == System.Data.Entity.EntityState.Deleted)
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
                else
                {

                    throw new ArgumentException("Xóa thất bại");
                }
            }
        }
        public List<MonHoc> LoadListMonThi(int maLH)
        {
            List<int> maMHs = new List<int>();
            foreach (DanhSachMonHoc ds in db.DanhSachMonHocs)
            {
                if (maLH == ds.MaLH)
                {
                    maMHs.Add(ds.MaMH);
                }
            }
            List<MonHoc> mHs = new List<MonHoc>();
            foreach (int ma in maMHs)
            {
                var mh = db.MonHocs.FirstOrDefault(m => m.Ma == ma);
                if (mh != null)
                {
                    mHs.Add(mh);
                }
            }
            return mHs;
        }
    }
}
