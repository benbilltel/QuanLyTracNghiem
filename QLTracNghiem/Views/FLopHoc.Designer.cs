namespace QLTracNghiem.Views
{
    partial class FLopHoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchHV = new System.Windows.Forms.TextBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.btnSaveHV = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenHV = new System.Windows.Forms.TextBox();
            this.txtHoHV = new System.Windows.Forms.TextBox();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.dtgvHocVien = new System.Windows.Forms.DataGridView();
            this.btnDeleteHV = new System.Windows.Forms.Button();
            this.btnDeleteMH = new System.Windows.Forms.Button();
            this.btnSaveMH = new System.Windows.Forms.Button();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.btnRefreshHV = new System.Windows.Forms.Button();
            this.btnRefreshLH = new System.Windows.Forms.Button();
            this.btnSaveLH = new System.Windows.Forms.Button();
            this.cbDSMH = new System.Windows.Forms.ComboBox();
            this.txtSearchLop = new System.Windows.Forms.TextBox();
            this.dtgvDanhSachMon = new System.Windows.Forms.DataGridView();
            this.dtgvLopHoc = new System.Windows.Forms.DataGridView();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHocVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearchHV);
            this.panel1.Controls.Add(this.cbGioiTinh);
            this.panel1.Controls.Add(this.btnSaveHV);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtTenHV);
            this.panel1.Controls.Add(this.txtHoHV);
            this.panel1.Controls.Add(this.txtMaHV);
            this.panel1.Controls.Add(this.dtgvHocVien);
            this.panel1.Controls.Add(this.btnDeleteHV);
            this.panel1.Controls.Add(this.btnDeleteMH);
            this.panel1.Controls.Add(this.btnSaveMH);
            this.panel1.Controls.Add(this.txtMaLop);
            this.panel1.Controls.Add(this.btnRefreshHV);
            this.panel1.Controls.Add(this.btnRefreshLH);
            this.panel1.Controls.Add(this.btnSaveLH);
            this.panel1.Controls.Add(this.cbDSMH);
            this.panel1.Controls.Add(this.txtSearchLop);
            this.panel1.Controls.Add(this.dtgvDanhSachMon);
            this.panel1.Controls.Add(this.dtgvLopHoc);
            this.panel1.Controls.Add(this.txtTenLop);
            this.panel1.Location = new System.Drawing.Point(24, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 475);
            this.panel1.TabIndex = 0;
            // 
            // txtSearchHV
            // 
            this.txtSearchHV.Location = new System.Drawing.Point(683, 37);
            this.txtSearchHV.Name = "txtSearchHV";
            this.txtSearchHV.Size = new System.Drawing.Size(115, 20);
            this.txtSearchHV.TabIndex = 22;
            this.txtSearchHV.TextChanged += new System.EventHandler(this.txtSearchHV_TextChanged);
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(829, 95);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(113, 21);
            this.cbGioiTinh.TabIndex = 21;
            // 
            // btnSaveHV
            // 
            this.btnSaveHV.Location = new System.Drawing.Point(542, 202);
            this.btnSaveHV.Name = "btnSaveHV";
            this.btnSaveHV.Size = new System.Drawing.Size(75, 23);
            this.btnSaveHV.TabIndex = 20;
            this.btnSaveHV.Text = "Save";
            this.btnSaveHV.UseVisualStyleBackColor = true;
            this.btnSaveHV.Click += new System.EventHandler(this.btnSaveHV_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(827, 154);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(115, 20);
            this.txtSDT.TabIndex = 19;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(542, 154);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(256, 20);
            this.txtDiaChi.TabIndex = 18;
            // 
            // txtTenHV
            // 
            this.txtTenHV.Location = new System.Drawing.Point(683, 95);
            this.txtTenHV.Name = "txtTenHV";
            this.txtTenHV.Size = new System.Drawing.Size(115, 20);
            this.txtTenHV.TabIndex = 17;
            // 
            // txtHoHV
            // 
            this.txtHoHV.Location = new System.Drawing.Point(542, 95);
            this.txtHoHV.Name = "txtHoHV";
            this.txtHoHV.Size = new System.Drawing.Size(115, 20);
            this.txtHoHV.TabIndex = 17;
            // 
            // txtMaHV
            // 
            this.txtMaHV.Location = new System.Drawing.Point(542, 37);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.ReadOnly = true;
            this.txtMaHV.Size = new System.Drawing.Size(115, 20);
            this.txtMaHV.TabIndex = 17;
            // 
            // dtgvHocVien
            // 
            this.dtgvHocVien.AllowUserToAddRows = false;
            this.dtgvHocVien.AllowUserToDeleteRows = false;
            this.dtgvHocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHocVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvHocVien.Location = new System.Drawing.Point(542, 255);
            this.dtgvHocVien.Name = "dtgvHocVien";
            this.dtgvHocVien.ReadOnly = true;
            this.dtgvHocVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHocVien.Size = new System.Drawing.Size(533, 189);
            this.dtgvHocVien.TabIndex = 16;
            this.dtgvHocVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHocVien_CellClick);
            // 
            // btnDeleteHV
            // 
            this.btnDeleteHV.Location = new System.Drawing.Point(683, 202);
            this.btnDeleteHV.Name = "btnDeleteHV";
            this.btnDeleteHV.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteHV.TabIndex = 15;
            this.btnDeleteHV.Text = "Delete";
            this.btnDeleteHV.UseVisualStyleBackColor = true;
            this.btnDeleteHV.Click += new System.EventHandler(this.btnDeleteHV_Click);
            // 
            // btnDeleteMH
            // 
            this.btnDeleteMH.Location = new System.Drawing.Point(393, 202);
            this.btnDeleteMH.Name = "btnDeleteMH";
            this.btnDeleteMH.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMH.TabIndex = 15;
            this.btnDeleteMH.Text = "Delete";
            this.btnDeleteMH.UseVisualStyleBackColor = true;
            this.btnDeleteMH.Click += new System.EventHandler(this.btnDeleteMH_Click);
            // 
            // btnSaveMH
            // 
            this.btnSaveMH.Location = new System.Drawing.Point(267, 202);
            this.btnSaveMH.Name = "btnSaveMH";
            this.btnSaveMH.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMH.TabIndex = 14;
            this.btnSaveMH.Text = "Save";
            this.btnSaveMH.UseVisualStyleBackColor = true;
            this.btnSaveMH.Click += new System.EventHandler(this.btnSaveMH_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(19, 37);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(190, 20);
            this.txtMaLop.TabIndex = 13;
            // 
            // btnRefreshHV
            // 
            this.btnRefreshHV.Location = new System.Drawing.Point(829, 202);
            this.btnRefreshHV.Name = "btnRefreshHV";
            this.btnRefreshHV.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshHV.TabIndex = 12;
            this.btnRefreshHV.Text = "Refresh";
            this.btnRefreshHV.UseVisualStyleBackColor = true;
            this.btnRefreshHV.Click += new System.EventHandler(this.btnRefreshHV_Click);
            // 
            // btnRefreshLH
            // 
            this.btnRefreshLH.Location = new System.Drawing.Point(138, 202);
            this.btnRefreshLH.Name = "btnRefreshLH";
            this.btnRefreshLH.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshLH.TabIndex = 12;
            this.btnRefreshLH.Text = "Refresh";
            this.btnRefreshLH.UseVisualStyleBackColor = true;
            this.btnRefreshLH.Click += new System.EventHandler(this.btnRefreshLH_Click);
            // 
            // btnSaveLH
            // 
            this.btnSaveLH.Location = new System.Drawing.Point(19, 202);
            this.btnSaveLH.Name = "btnSaveLH";
            this.btnSaveLH.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLH.TabIndex = 12;
            this.btnSaveLH.Text = "Save";
            this.btnSaveLH.UseVisualStyleBackColor = true;
            this.btnSaveLH.Click += new System.EventHandler(this.btnSaveLH_Click);
            // 
            // cbDSMH
            // 
            this.cbDSMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDSMH.FormattingEnabled = true;
            this.cbDSMH.Location = new System.Drawing.Point(269, 152);
            this.cbDSMH.Name = "cbDSMH";
            this.cbDSMH.Size = new System.Drawing.Size(199, 21);
            this.cbDSMH.TabIndex = 11;
            // 
            // txtSearchLop
            // 
            this.txtSearchLop.Location = new System.Drawing.Point(19, 95);
            this.txtSearchLop.Name = "txtSearchLop";
            this.txtSearchLop.Size = new System.Drawing.Size(194, 20);
            this.txtSearchLop.TabIndex = 10;
            this.txtSearchLop.TextChanged += new System.EventHandler(this.txtSearchLop_TextChanged);
            // 
            // dtgvDanhSachMon
            // 
            this.dtgvDanhSachMon.AllowUserToAddRows = false;
            this.dtgvDanhSachMon.AllowUserToDeleteRows = false;
            this.dtgvDanhSachMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvDanhSachMon.Location = new System.Drawing.Point(269, 255);
            this.dtgvDanhSachMon.Name = "dtgvDanhSachMon";
            this.dtgvDanhSachMon.ReadOnly = true;
            this.dtgvDanhSachMon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDanhSachMon.Size = new System.Drawing.Size(199, 189);
            this.dtgvDanhSachMon.TabIndex = 9;
            // 
            // dtgvLopHoc
            // 
            this.dtgvLopHoc.AllowUserToAddRows = false;
            this.dtgvLopHoc.AllowUserToDeleteRows = false;
            this.dtgvLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLopHoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvLopHoc.Location = new System.Drawing.Point(19, 255);
            this.dtgvLopHoc.Name = "dtgvLopHoc";
            this.dtgvLopHoc.ReadOnly = true;
            this.dtgvLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLopHoc.Size = new System.Drawing.Size(194, 189);
            this.dtgvLopHoc.TabIndex = 8;
            this.dtgvLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLopHoc_CellClick);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(19, 153);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(194, 20);
            this.txtTenLop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên lớp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Danh sách môn học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(539, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mã học viên";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(539, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Họ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(680, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Tên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(539, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(826, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Số điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(826, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Giới tính";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Tìm lớp";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(680, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Tìm học viên";
            // 
            // FLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 536);
            this.Controls.Add(this.panel1);
            this.Name = "FLopHoc";
            this.Text = "FLopHoc";
            this.Load += new System.EventHandler(this.FLopHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHocVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtSearchLop;
        private System.Windows.Forms.DataGridView dtgvDanhSachMon;
        private System.Windows.Forms.DataGridView dtgvLopHoc;
        private System.Windows.Forms.ComboBox cbDSMH;
        private System.Windows.Forms.Button btnRefreshLH;
        private System.Windows.Forms.Button btnSaveLH;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button btnDeleteMH;
        private System.Windows.Forms.Button btnSaveMH;
        private System.Windows.Forms.DataGridView dtgvHocVien;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenHV;
        private System.Windows.Forms.TextBox txtHoHV;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Button btnSaveHV;
        private System.Windows.Forms.Button btnDeleteHV;
        private System.Windows.Forms.Button btnRefreshHV;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.TextBox txtSearchHV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
    }
}