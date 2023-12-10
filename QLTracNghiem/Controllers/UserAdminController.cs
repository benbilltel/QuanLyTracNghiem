using QLTracNghiem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace QLTracNghiem.Controllers
{
    public class UserAdminController : QLTracNghiemController
    {
        public UserAdminController() : base()
        {
            tblData = new DataTable();
        }
        public DataTable tblData;



        public void Load()
        {
            DataTable tblTemp = new DataTable();
            tblTemp.Columns.Add("Mã", typeof(int));
            tblTemp.Columns.Add("Tài khoản", typeof(string));
            tblTemp.Columns.Add("Mật khẩu", typeof(string));

            foreach (UserAdmin us in db.UserAdmins)
            {
                DataRow row = tblTemp.NewRow();
                row["Mã"] = us.Ma;
                row["Tài khoản"] = us.TaiKhoan;
                row["Mật khẩu"] = us.MatKhau;
                tblTemp.Rows.Add(row);
            }
            tblData = tblTemp;
        }
        public void Save(int action, UserAdmin us)
        {
            if (action == 0)
            {


                db.UserAdmins.Add(us);
                if (db.Entry(us).State == System.Data.Entity.EntityState.Added)
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

                DataRow row = tblData.NewRow();
                row["Mã"] = us.Ma;
                row["Tài khoản"] = us.TaiKhoan;
                row["Mật khẩu"] = us.MatKhau;
                tblData.Rows.Add(row);
            }
            if (action == 1)
            {
                var userAdminToUpdate = db.UserAdmins.FirstOrDefault(ua => ua.Ma == us.Ma);
                if (userAdminToUpdate != null)
                {
                    userAdminToUpdate.MatKhau = us.MatKhau;

                    if (db.Entry(userAdminToUpdate).State == System.Data.Entity.EntityState.Modified)
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
                    if ((int)row["Mã"] == us.Ma)
                    {
                        row["Mật khẩu"] = us.MatKhau;
                        break;
                    }
                }
            }
        }
        public void Remove(List<UserAdmin> userAdmins)
        {
            foreach (UserAdmin userAdmin in userAdmins)
            {
                var usAD = db.UserAdmins.FirstOrDefault(ua => ua.Ma == userAdmin.Ma);
                if (usAD != null)
                {
                    db.UserAdmins.Remove(usAD);
                    if (db.Entry(usAD).State == System.Data.Entity.EntityState.Deleted)
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
            Load();
        }
    }
}
