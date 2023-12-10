using QLTracNghiem.Models.Data;
using QLTracNghiem.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTracNghiem.Controllers
{
    public class ThiController : QLTracNghiemController
    {
        public ThiController() :base(){ }
        List<CauHoi> RandomCauHoi (MonHoc mh,int soLuongCauHoi)
        {
            Random rnd = new Random();
            var filteredChuongIds = db.Chuongs.Where(c => c.MaMH == mh.Ma).Select(c => c.Ma).ToList();
            // Use the IDs to filter the questions
            var filteredCauHoi = db.CauHois.Where(q => filteredChuongIds.Contains(q.MaChuong)).ToList();
            var randomCauHoi = filteredCauHoi.OrderBy(x => rnd.Next()).Take(soLuongCauHoi).ToList();
            return randomCauHoi;
        }
        public DataTable LoadDeThi(string tenMH)
        {
            var mh = db.MonHocs.FirstOrDefault(m => m.TenMH.Equals(tenMH));
            DeThi deThi = new DeThi();
            deThi.NgayThi = DateTime.Today;
            deThi.MaMH = mh.Ma;
            db.DeThis.Add(deThi);
            if (db.Entry(deThi).State == System.Data.Entity.EntityState.Added)
            {
                try
                {
                    db.SaveChanges();
                    List<CauHoi> chs = RandomCauHoi(mh, 10);
                    List<ChiTietDeThi> chiTietDeThis = new List<ChiTietDeThi>();
                    foreach (CauHoi ch in chs) { 
                        ChiTietDeThi chiTiet = new ChiTietDeThi();
                        chiTiet.MaDT = deThi.Ma;
                        chiTiet.MaCH = ch.Ma;
                        chiTietDeThis.Add(chiTiet);
                    }
                    foreach(ChiTietDeThi chiTiet in chiTietDeThis)
                    {
                        db.ChiTietDeThis.Add(chiTiet);
                        if (db.Entry(chiTiet).State == System.Data.Entity.EntityState.Added)
                        {
                            db.SaveChanges();
                        }
                        else
                        {
                            throw new ArgumentException("Tai de thi that bai");
                        }
                    }
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Mã DT", typeof(int));
                    dataTable.Columns.Add("Mã CH", typeof (int));
                    dataTable.Columns.Add("Nội dung",typeof (string));
                    dataTable.Columns.Add("Đáp án A", typeof(string));
                    dataTable.Columns.Add("Đáp án B", typeof(string));
                    dataTable.Columns.Add("Đáp án C", typeof(string));
                    dataTable.Columns.Add("Đáp án D", typeof(string));
                    dataTable.Columns.Add("Câu trả lời", typeof(int));
                   
                    foreach(CauHoi ch in chs)
                    {
                        DataRow dataRow = dataTable.NewRow();
                        dataRow["Mã DT"] = deThi.Ma;
                        dataRow["Mã CH"] = ch.Ma;
                        dataRow["Nội dung"] = ch.NoiDung;
                        dataRow["Đáp án A"] = ch.DapAnA;
                        dataRow["Đáp án B"] = ch.DapAnB;
                        dataRow["Đáp án C"] = ch.DapAnC;
                        dataRow["Đáp án D"] = ch.DapAnD;
                        dataRow["Câu trả lời"] = -1;
                        dataTable.Rows.Add(dataRow);
                    }
                    return dataTable;
                }
                catch
                {
                    throw new ArgumentException("Tai de thi that bai");
                }
            }
            return null;
        }
        public void SaveBaiLam(List<ChiTietBaiLam> ctbls)
        {
            foreach(ChiTietBaiLam ct in ctbls)
            {
                db.ChiTietBaiLams.Add(ct);
                if (db.Entry(ct).State == System.Data.Entity.EntityState.Added)
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
                else
                {
                    throw new ArgumentException("Thêm thất bại");
                }
            }
        }
        /* public DataTable LoadKetQua(HocVien hv, string tenMH)
         {
             var mh = db.MonHocs.FirstOrDefault(m => m.TenMH.Equals(tenMH));
             if(mh != null)
             {
                 DataTable tblKetQua = new DataTable();
                 tblKetQua.Columns.Add("Mã đề thi", typeof(int));
                 tblKetQua.Columns.Add("Kết quả",typeof(float));

                 List<DeThi> filteredDethi = db.DeThis.Where(c=>c.MaMH == mh.Ma).ToList();
                 foreach(DeThi maDT in filteredDethi)
                 {
                     DataRow row = tblKetQua.NewRow();
                     row["Mã đề thi"] = maDT.Ma;
                     row["Kết quả"] = TinhDiem(maDT,hv);
                     tblKetQua.Rows.Add(row);
                 }
                 return tblKetQua;
             }
             return null;
         }
         private float TinhDiem(DeThi deThi,HocVien hv)
         {
             float count = 0f;
             float tong = 0f;
             foreach(ChiTietBaiLam ct in db.ChiTietBaiLams)
             {
                 if(ct.MaDT == deThi.Ma && ct.MaHV == hv.Ma)
                 {
                     var ch = db.CauHois.FirstOrDefault(m => m.Ma == ct.MaCH);
                     if(ch != null)
                     {
                         if(ch.DapAnDung == ct.CauTL)
                         {
                             tong++;
                         }
                     }
                     count++;
                 }
             }
             return (tong/ count )* 10f;
         }*/
    }
}
