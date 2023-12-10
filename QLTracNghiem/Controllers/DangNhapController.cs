using QLTracNghiem.Models;
using QLTracNghiem.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Controllers
{
    public class DangNhapController:QLTracNghiemController
    {
        public DangNhapController() : base(){ } 
        public bool DangNhapQuanLy(UserAdmin us)
        {
            var usAD = db.UserAdmins.FirstOrDefault(u=>u.TaiKhoan == us.TaiKhoan);
            if (usAD != null)
            {
                if(us.MatKhau ==  usAD.MatKhau)
                {
                    return true;
                }
            }
            return false;
        }
        public HocVien DangNhapHocVien(UserHocVien userHoc)
        {
            var usHV = db.UserHocViens.FirstOrDefault(u => u.TaiKhoan == userHoc.TaiKhoan && u.TrangThai == 1);
            if (usHV != null)
            {
                if (usHV.MatKhau == userHoc.MatKhau)
                {
                    var hv = db.HocViens.FirstOrDefault(u => u.Ma == usHV.MaHV);
                    return hv;
                }
            }
            return null;
        }
        
    }
}
