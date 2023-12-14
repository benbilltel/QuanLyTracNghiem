using QuanLyTracNghiem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTracNghiem.Controllers
{
    public class MChoiceController
    {
        public MChoiceController() { 
            db = new MChoiceContext();
        }
        protected MChoiceContext db;
    }
}
