using QLTracNghiem.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTracNghiem.Controllers
{
    public class MonHocController : QLTracNghiemController
    {
        public MonHocController() : base(){ }
        public List<MonHoc> LoadListMonHoc()
        {
            return db.MonHocs.ToList();
        }
        public MonHoc TimMonHocTheoTen(string tenMH)
        {
            foreach(MonHoc mh in db.MonHocs)
            {
                if (mh.TenMH == tenMH)
                {
                    return mh;  
                }
            }
            return null;
        }
    }
}
