using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Models
{
    public class QLTracNghiemContext : DbContext
    {
        public QLTracNghiemContext() : base("Data Source=DESKTOP-LTSC8K9\\SQLEXPRESS;Initial Catalog=QLTracNghiem;Integrated Security=True")
        {

        }
        public virtual DbSet<UserAdmin> UserAdmins { get; set; }
    }
}
