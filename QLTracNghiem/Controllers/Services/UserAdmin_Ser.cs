using QLTracNghiem.Controllers.Repositories;
using QLTracNghiem.Models.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Controllers.Services
{
    public class UserAdmin_Ser
    {
        public UserAdmin_Ser() {
            us_repo = new UserAdmin_Repo();
            us_repo.Read();
            tblData = new DataTable();
            tblData.Columns.Add("Ma", typeof(int));
            tblData.Columns.Add("Tài khoản", typeof(string));
            tblData.Columns.Add("Mật khẩu", typeof(string));
        }  
        private UserAdmin_Repo us_repo;
        public DataTable tblData;
        public void Load()
        {
            DataTable tblTemp = new DataTable();
            tblTemp.Columns.Add("Mã", typeof(int));
            tblTemp.Columns.Add("Tài khoản", typeof(string));
            tblTemp.Columns.Add("Mật khẩu", typeof(string));
            foreach (DTO_UserAdmin dtoUs in us_repo.listUs)
            {
                DataRow row = tblTemp.NewRow();
                row["Mã"] = dtoUs.Ma;
                row["Tài khoản"] = dtoUs.TaiKhoan;
                row["Mật khẩu"] = dtoUs.MatKhau;
                tblTemp.Rows.Add(row);  
            }
            tblData = tblTemp;
        }
        public void Save(int action,DTO_UserAdmin us) {
            if(action == 0) {
                
                DTO_UserAdmin dTO_UserAdmin = us_repo.Insert(us);
                if(dTO_UserAdmin == null) { throw new ArgumentException("Lưu thất bại"); }
                DataRow row = tblData.NewRow();
                row["Mã"] = dTO_UserAdmin.Ma;
                row["Tài khoản"] = dTO_UserAdmin.TaiKhoan;
                row["Mật khẩu"] = dTO_UserAdmin.MatKhau;
                tblData.Rows.Add(row);
            }
            if(action == 1){
                DTO_UserAdmin dTO_UserAdmin = us_repo.Update(us);
                if (dTO_UserAdmin == null) { throw new ArgumentException("Cập nhật thất bại"); }
                foreach (DataRow row in tblData.Rows)
                {
                    if ((int)row["Mã"] == us.Ma)
                    {
                        row["Mật khẩu"] = us.MatKhau;
                    }
                }
            }
        }
        public void Remove(List<DTO_UserAdmin> dTO_UserAdmins)
        {
            List<DTO_UserAdmin> tempList = us_repo.Delete(dTO_UserAdmins);
            if(tempList == null) { throw new ArgumentException("Xóa thất bại"); }
            Load();
        }
    }
}
