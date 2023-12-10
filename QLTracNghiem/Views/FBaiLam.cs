using QLTracNghiem.Controllers;
using QLTracNghiem.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTracNghiem.Views
{
    public partial class FBaiLam : Form
    {
        public FBaiLam(string tm,HocVien hv)
        {
            InitializeComponent();
            tenMon = tm;
            hocVienThi = hv;
        }
        HocVien hocVienThi;
        string tenMon;
        DataTable tblCauHoi ;
        ThiController thiController = new ThiController();
        int crr = 0;
       
        private void FBaiLam_Load(object sender, EventArgs e)
        {
            try
            {
                tblCauHoi = thiController.LoadDeThi(tenMon);

                LoadCauHoi(crr);
                rdDapAnA.Checked = false;
                rdDapAnB.Checked = false;
                rdDapAnC.Checked = false;
                rdDapAnD.Checked = false;


            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
            

        }
        public void LoadCauHoi(int maCH)
        {
            DataRow row = tblCauHoi.Rows[maCH];
            lblCauHoi.Text = row["Nội dung"].ToString();
            rdDapAnA.Text = row["Đáp án A"].ToString();
            rdDapAnB.Text = row["Đáp án B"].ToString();
            rdDapAnC.Text = row["Đáp án C"].ToString();
            rdDapAnD.Text = row["Đáp án D"].ToString();
            if (int.Parse(row["Câu trả lời"].ToString()) == 0)
            {
                rdDapAnA.Checked = true;
            }
            if (int.Parse(row["Câu trả lời"].ToString()) == 1)
            {
                rdDapAnB.Checked = true;
            }
            if (int.Parse(row["Câu trả lời"].ToString()) == 2)
            {
                rdDapAnC.Checked = true;
            }
            if (int.Parse(row["Câu trả lời"].ToString()) == 3)
            {
                rdDapAnD.Checked = true;
            }
            else
            {
                rdDapAnA.Checked = false;
                rdDapAnB.Checked = false;
                rdDapAnC.Checked = false;
                rdDapAnD.Checked = false;
            }
            
            int savedAnswer = int.Parse(row["Câu trả lời"].ToString());
            switch (savedAnswer)
            {
                case 0:
                    rdDapAnA.Checked = true;
                    break;
                case 1:
                    rdDapAnB.Checked = true;
                    break;
                case 2:
                    rdDapAnC.Checked = true;
                    break;
                case 3:
                    rdDapAnD.Checked = true;
                    break;
                default:
                    break;
            }

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (crr < tblCauHoi.Rows.Count - 1)
            {
                SaveCurrentAnswer();
                crr++;
                LoadCauHoi(crr);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (crr > 0)
            {
                SaveCurrentAnswer();
                crr--;
                LoadCauHoi(crr);
            }
        }
        private void SaveCurrentAnswer()
        {
            DataRow row = tblCauHoi.Rows[crr];
            if (rdDapAnA.Checked)
            {
                row["Câu trả lời"] = 0;
            }
            else if (rdDapAnB.Checked)
            {
                row["Câu trả lời"] = 1;
            }
            else if (rdDapAnC.Checked)
            {
                row["Câu trả lời"] = 2;
            }
            else if (rdDapAnD.Checked)
            {
                row["Câu trả lời"] = 3;
            }
            else
            {
                row["Câu trả lời"] = -1; 
            }
        }
        private void btnNop_Click(object sender, EventArgs e)
        {
            DataRow row = tblCauHoi.Rows[crr];
            if (rdDapAnA.Checked)
            {
                row["Câu trả lời"] = 0;
            }
            if (rdDapAnB.Checked)
            {
                row["Câu trả lời"] = 1;
            }
            if (rdDapAnC.Checked)
            {
                row["Câu trả lời"] = 2;
            }
            if (rdDapAnD.Checked)
            {
                row["Câu trả lời"] = 3;
            }
            else
            {
                row["Câu trả lời"] = -1;
            }
            List<ChiTietBaiLam> ctbls = new List<ChiTietBaiLam>();
           foreach(DataRow dr in tblCauHoi.Rows) {
                ChiTietBaiLam ct = new ChiTietBaiLam();
                ct.MaHV = hocVienThi.Ma;
                ct.MaDT = int.Parse(dr["Mã DT"].ToString());
                ct.CauTL = int.Parse(dr["Câu trả lời"].ToString());
                ct.MaCH = int.Parse(dr["Mã CH"].ToString());
                ctbls.Add(ct);  
            }
            try
            {
                thiController.SaveBaiLam(ctbls);
                MessageBox.Show("Bài làm đã được lưu!");
                this.Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
