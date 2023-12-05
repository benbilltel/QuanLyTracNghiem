using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Models.DTO
{
    public class DTO_UserAdmin
    {
        public DTO_UserAdmin() { }
        private static int countMa = 0;
        private int ma;
        private string taiKhoan;
        private string matKhau;
        public int CountMa
        {
            get { return countMa; } 
        }
        public int AutoGenMa()
        {
            countMa++;
            return countMa;  
        }
        public int Ma
        {
            get { return ma; }
            set { ma = value; }
        }
       
        public string TaiKhoan
        {
            get { return taiKhoan; }
            set
            {
                if (value == string.Empty || value.Length > 20 || value.Length < 6) {
                    throw new ArgumentException("Tài khoản không hợp lệ");
                }
                else
                {
                    taiKhoan = value;
                }
            }
        }


        public string MatKhau
        {
            get { return matKhau; }
            set {
                if (value == string.Empty || value.Length > 20 || value.Length < 6)
                {
                    throw new ArgumentException("Mật khẩu không hợp lệ");
                }
                else
                {
                    matKhau = value;
                }
            }
        }
    }
}
