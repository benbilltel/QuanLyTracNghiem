using QuanLyTracNghiem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTracNghiem.Controllers
{
    public class LoginController : MChoiceController
    {
        public LoginController() :base(){ }
        public UserAdmin SignInByAdmin(UserAdmin userAdmin)
        {
            var userFound = db.UserAdmins.FirstOrDefault(us=>us.Username == userAdmin.Username);    
            if (userFound != null)
            {
                if(userFound.Password == userAdmin.Password) { 
                    return userFound;
                }
                else
                {
                    throw new Exception("Wrong password!");
                }
            }
            else
            {
                throw new Exception("Wrong username!");
            }
        }
    }
}
