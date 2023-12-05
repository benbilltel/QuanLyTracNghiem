using QLTracNghiem.Models;
using QLTracNghiem.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Controllers.Repositories
{
    public class UserAdmin_Repo
    {
        public UserAdmin_Repo() {
            db = new QLTracNghiemContext();
            listUs = new List<DTO_UserAdmin>();
        } 
        private QLTracNghiemContext db ;
        public List<DTO_UserAdmin> listUs ;
        private object TranferObj (object us,string action)
        {
            if (us is UserAdmin userAdmin)
            {
                DTO_UserAdmin dto_us = new DTO_UserAdmin();
                dto_us.Ma = userAdmin.Ma;
                dto_us.TaiKhoan = userAdmin.TaiKhoan;
                dto_us.MatKhau = userAdmin.MatKhau;
                return dto_us;
            }
            if (us is DTO_UserAdmin dTO_UserAdmin)
            {
                UserAdmin usAD = new UserAdmin();
                usAD.Ma = dTO_UserAdmin.Ma;
                usAD.TaiKhoan = dTO_UserAdmin.TaiKhoan;
                usAD.MatKhau = dTO_UserAdmin.MatKhau;
                return usAD;

            }
            if (us is DTO_UserAdmin dTO_UserAdmin2 && action.Equals("Save"))
            {
                UserAdmin usAD = new UserAdmin();
                usAD.Ma = dTO_UserAdmin2.AutoGenMa();
                usAD.TaiKhoan = dTO_UserAdmin2.TaiKhoan;
                usAD.MatKhau = dTO_UserAdmin2.MatKhau;
                return usAD;

            }
            return null;
            
        }
        public void Read()
        {
           listUs.Clear();
           foreach (UserAdmin us in db.UserAdmins)
            {   
                if(TranferObj(us,"none") is DTO_UserAdmin dtoUserAdmin)
                {
                    listUs.Add(dtoUserAdmin);
                }
                
            }
        }
        public DTO_UserAdmin Insert(DTO_UserAdmin dtoUS)
        {
            if(TranferObj(dtoUS,"Save") is UserAdmin userAdmin)
            {
                db.UserAdmins.Add(userAdmin);
                if(db.Entry(userAdmin).State == System.Data.Entity.EntityState.Added)
                {
                    try
                    {
                       if( db.SaveChanges()>0){
                            if (TranferObj(userAdmin, "none") is DTO_UserAdmin dtoUserAdmin)
                            {
                                listUs.Add(dtoUserAdmin);
                                return dtoUserAdmin;
                            }
                        }
                    }
                    catch 
                    {
                        return null;
                    }
                }
                return null;
            }
            return dtoUS;
        }
        public DTO_UserAdmin Update(DTO_UserAdmin dtoUS)
        {
            var userAdminToUpdate = db.UserAdmins.FirstOrDefault(ua => ua.Ma == dtoUS.Ma);
            if (userAdminToUpdate != null)
            {
                userAdminToUpdate.MatKhau = dtoUS.MatKhau;

                if(db.Entry(userAdminToUpdate).State == System.Data.Entity.EntityState.Modified) {
                    try
                    {
                        if (db.SaveChanges() > 0)
                        {
                            var updatedDtoUS = TranferObj(userAdminToUpdate, "none") as DTO_UserAdmin;
                            var index = listUs.FindIndex(ua => ua.Ma == updatedDtoUS.Ma);
                            if (index != -1)
                            {
                                listUs[index] = updatedDtoUS;
                            }
                            return updatedDtoUS;
                        }
                    }
                    catch
                    {
                        return null;
                    }
                }
               
            }
            return dtoUS;
        }
        public List<DTO_UserAdmin> Delete (List<DTO_UserAdmin> dTO_UserAdmins)
        {
            foreach(DTO_UserAdmin dTO_UserAdmin in dTO_UserAdmins)
            {
                var usAD = db.UserAdmins.FirstOrDefault(ua => ua.Ma == dTO_UserAdmin.Ma);
                if (usAD != null)
                {
                    db.UserAdmins.Remove(usAD);
                    if(db.Entry(usAD).State == System.Data.Entity.EntityState.Deleted)
                    {
                        db.SaveChanges();
                        DTO_UserAdmin itemRemove = listUs.Find(ua => ua.Ma == dTO_UserAdmin.Ma);
                        listUs.Remove(itemRemove);
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            
            return listUs;
        }
    }
}
