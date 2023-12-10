using QLTracNghiem.Models;
using QLTracNghiem.Models.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace QLTracNghiem.Controllers
{
    public class HocVienController : QLTracNghiemController
    {
        public HocVienController(): base() {
            tblData = new DataTable();
        }
        public DataTable tblData;
        public void Load(LopHoc lh)
        {
            DataTable tblTemp = new DataTable();
            tblTemp.Columns.Add("Mã", typeof(int));
            tblTemp.Columns.Add("Họ", typeof(string));
            tblTemp.Columns.Add("Tên", typeof(string));
            tblTemp.Columns.Add("Địa chỉ", typeof(string));
            tblTemp.Columns.Add("Giới tính", typeof(string));
            tblTemp.Columns.Add("Số điện thoại", typeof(string));
            if(lh == null) {
                foreach (HocVien hv in db.HocViens)
                {
                    DataRow row = tblTemp.NewRow();
                    row["Mã"] = hv.Ma;
                    row["Họ"] = hv.Ho;
                    row["Tên"] = hv.Ten;
                    row["Địa chỉ"] = hv.DiaChi;
                    if (hv.GioiTinh == 0)
                    {
                        row["Giới tính"] = "Nam";
                    }
                    else
                    {
                        row["Giới tính"] = "Nữ";
                    }
                    row["Số điện thoại"] = hv.SoDienThoai;
                    tblTemp.Rows.Add(row);
                }
            }
            else
            {
                foreach (HocVien hv in db.HocViens)
                {
                    if(hv.MaLH == lh.Ma)
                    {
                        DataRow row = tblTemp.NewRow();
                        row["Mã"] = hv.Ma;
                        row["Họ"] = hv.Ho;
                        row["Tên"] = hv.Ten;
                        row["Địa chỉ"] = hv.DiaChi;
                        if (hv.GioiTinh == 0)
                        {
                            row["Giới tính"] = "Nam";
                        }
                        else
                        {
                            row["Giới tính"] = "Nữ";
                        }
                        row["Số điện thoại"] = hv.SoDienThoai;
                        tblTemp.Rows.Add(row);
                    }
                    
                }
            }
            tblData = tblTemp;
            
        }
        public void Save(HocVien hocVien, int action)
        {
            if(action == 0)
            {
                db.HocViens.Add(hocVien);
                if (db.Entry(hocVien).State == System.Data.Entity.EntityState.Added)
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
                var hv = db.HocViens.FirstOrDefault(h => h.Ma == hocVien.Ma);
                if (hv != null)
                {
                    UserHocVien us = new UserHocVien();
                    us.MaHV = hv.Ma;
                    us.TaiKhoan = hv.SoDienThoai;
                    us.MatKhau = hv.SoDienThoai;
                    us.TrangThai = 1;
                    db.UserHocViens.Add(us);
                    if (db.Entry(us).State == System.Data.Entity.EntityState.Added)
                    {

                        try
                        {
                            db.SaveChanges();
                        }
                        catch
                        {
                            throw new ArgumentException("Tạo tài khoản thất bại");
                        }
                    }
                }
            }
            else
            {
                var hv = db.HocViens.FirstOrDefault(h => h.Ma == hocVien.Ma);
                if(hv != null) {
                    hv.Ho = hocVien.Ho;
                    hv.Ten = hocVien.Ten;
                    hv.DiaChi = hocVien.DiaChi;
                    hv.SoDienThoai = hocVien.SoDienThoai;
                    hv.GioiTinh = hocVien.GioiTinh;
                    if (db.Entry(hv).State == System.Data.Entity.EntityState.Modified)
                    {
                        try
                        {
                            db.SaveChanges();
                            var us = db.UserHocViens.FirstOrDefault(u => u.MaHV == hv.Ma);
                            if (us != null)
                            {
                                us.TaiKhoan = hv.SoDienThoai;
                                if (db.Entry(us).State == System.Data.Entity.EntityState.Modified)
                                {
                                    db.SaveChanges();
                                }
                                else
                                {
                                    throw new ArgumentException("Cập nhật thất bại");
                                }
                            }
                            else
                            {
                                throw new ArgumentException("Cập nhật thất bại");
                            }
                        }
                        catch
                        {
                            throw new ArgumentException("Cập nhật thất bại");
                        }


                    }
                }
                else
                {
                    throw new ArgumentException("Thêm thất bại");
                }
            }
        }
        public void Remove(List<int> maHVs)
        {
            foreach (int maHv in maHVs)
            {
                var hv = db.HocViens.FirstOrDefault(ua => ua.Ma == maHv);
                if (hv != null)
                {
                    var us = db.UserHocViens.FirstOrDefault(u => u.MaHV == hv.Ma);
                    db.UserHocViens.Remove(us);
                    if (db.Entry(us).State == System.Data.Entity.EntityState.Deleted)
                    {
                        try
                        {
                            db.SaveChanges();
                            db.HocViens.Remove(hv);
                            if (db.Entry(hv).State == System.Data.Entity.EntityState.Deleted)
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
    }
}
