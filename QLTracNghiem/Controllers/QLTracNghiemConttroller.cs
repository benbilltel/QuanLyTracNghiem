using QLTracNghiem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Controllers
{
    public abstract class QLTracNghiemController
    {
        public QLTracNghiemController()
        {
            db = new QLTracNghiemContext();
        }
        
        protected QLTracNghiemContext db;

       
    }
    
}
