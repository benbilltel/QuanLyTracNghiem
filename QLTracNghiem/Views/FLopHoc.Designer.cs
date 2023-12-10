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
            this.txtSearchHV = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHocVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDanhSachMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLopHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(35, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 434);
            this.panel1.TabIndex = 0;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(788, 126);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(121, 21);
            this.cbGioiTinh.TabIndex = 21;
            // 
            // btnSaveHV
            // 
            this.btnSaveHV.Location = new System.Drawing.Point(942, 37);
            this.btnSaveHV.Name = "btnSaveHV";
            this.btnSaveHV.Size = new System.Drawing.Size(75, 23);
            this.btnSaveHV.TabIndex = 20;
            this.btnSaveHV.Text = "Save";
            this.btnSaveHV.UseVisualStyleBackColor = true;
            this.btnSaveHV.Click += new System.EventHandler(this.btnSaveHV_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(643, 130);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(115, 20);
            this.txtSDT.TabIndex = 19;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(509, 130);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(115, 20);
            this.txtDiaChi.TabIndex = 18;
            // 
            // txtTenHV
            // 
            this.txtTenHV.Location = new System.Drawing.Point(643, 84);
            this.txtTenHV.Name = "txtTenHV";
            this.txtTenHV.Size = new System.Drawing.Size(115, 20);
            this.txtTenHV.TabIndex = 17;
            // 
            // txtHoHV
            // 
            this.txtHoHV.Location = new System.Drawing.Point(509, 84);
            this.txtHoHV.Name = "txtHoHV";
            this.txtHoHV.Size = new System.Drawing.Size(115, 20);
            this.txtHoHV.TabIndex = 17;
            // 
            // txtMaHV
            // 
            this.txtMaHV.Location = new System.Drawing.Point(509, 39);
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
            this.dtgvHocVien.Location = new System.Drawing.Point(509, 190);
            this.dtgvHocVien.Name = "dtgvHocVien";
            this.dtgvHocVien.ReadOnly = true;
            this.dtgvHocVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvHocVien.Size = new System.Drawing.Size(533, 189);
            this.dtgvHocVien.TabIndex = 16;
            this.dtgvHocVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvHocVien_CellClick);
            // 
            // btnDeleteHV
            // 
            this.btnDeleteHV.Location = new System.Drawing.Point(942, 82);
            this.btnDeleteHV.Name = "btnDeleteHV";
            this.btnDeleteHV.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteHV.TabIndex = 15;
            this.btnDeleteHV.Text = "Delete";
            this.btnDeleteHV.UseVisualStyleBackColor = true;
            this.btnDeleteHV.Click += new System.EventHandler(this.btnDeleteHV_Click);
            // 
            // btnDeleteMH
            // 
            this.btnDeleteMH.Location = new System.Drawing.Point(398, 81);
            this.btnDeleteMH.Name = "btnDeleteMH";
            this.btnDeleteMH.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMH.TabIndex = 15;
            this.btnDeleteMH.Text = "Delete";
            this.btnDeleteMH.UseVisualStyleBackColor = true;
            this.btnDeleteMH.Click += new System.EventHandler(this.btnDeleteMH_Click);
            // 
            // btnSaveMH
            // 
            this.btnSaveMH.Location = new System.Drawing.Point(398, 37);
            this.btnSaveMH.Name = "btnSaveMH";
            this.btnSaveMH.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMH.TabIndex = 14;
            this.btnSaveMH.Text = "Save";
            this.btnSaveMH.UseVisualStyleBackColor = true;
            this.btnSaveMH.Click += new System.EventHandler(this.btnSaveMH_Click);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(50, 37);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.ReadOnly = true;
            this.txtMaLop.Size = new System.Drawing.Size(115, 20);
            this.txtMaLop.TabIndex = 13;
            this.txtMaLop.Visible = false;
            // 
            // btnRefreshHV
            // 
            this.btnRefreshHV.Location = new System.Drawing.Point(942, 130);
            this.btnRefreshHV.Name = "btnRefreshHV";
            this.btnRefreshHV.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshHV.TabIndex = 12;
            this.btnRefreshHV.Text = "Refresh";
            this.btnRefreshHV.UseVisualStyleBackColor = true;
            this.btnRefreshHV.Click += new System.EventHandler(this.btnRefreshHV_Click);
            // 
            // btnRefreshLH
            // 
            this.btnRefreshLH.Location = new System.Drawing.Point(171, 127);
            this.btnRefreshLH.Name = "btnRefreshLH";
            this.btnRefreshLH.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshLH.TabIndex = 12;
            this.btnRefreshLH.Text = "Refresh";
            this.btnRefreshLH.UseVisualStyleBackColor = true;
            this.btnRefreshLH.Click += new System.EventHandler(this.btnRefreshLH_Click);
            // 
            // btnSaveLH
            // 
            this.btnSaveLH.Location = new System.Drawing.Point(171, 83);
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
            this.cbDSMH.Location = new System.Drawing.Point(274, 126);
            this.cbDSMH.Name = "cbDSMH";
            this.cbDSMH.Size = new System.Drawing.Size(121, 21);
            this.cbDSMH.TabIndex = 11;
            // 
            // txtSearchLop
            // 
            this.txtSearchLop.Location = new System.Drawing.Point(50, 83);
            this.txtSearchLop.Name = "txtSearchLop";
            this.txtSearchLop.Size = new System.Drawing.Size(115, 20);
            this.txtSearchLop.TabIndex = 10;
            this.txtSearchLop.TextChanged += new System.EventHandler(this.txtSearchLop_TextChanged);
            // 
            // dtgvDanhSachMon
            // 
            this.dtgvDanhSachMon.AllowUserToAddRows = false;
            this.dtgvDanhSachMon.AllowUserToDeleteRows = false;
            this.dtgvDanhSachMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDanhSachMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvDanhSachMon.Location = new System.Drawing.Point(274, 190);
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
            this.dtgvLopHoc.Location = new System.Drawing.Point(50, 190);
            this.dtgvLopHoc.Name = "dtgvLopHoc";
            this.dtgvLopHoc.ReadOnly = true;
            this.dtgvLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLopHoc.Size = new System.Drawing.Size(194, 189);
            this.dtgvLopHoc.TabIndex = 8;
            this.dtgvLopHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLopHoc_CellClick);
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(50, 127);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(115, 20);
            this.txtTenLop.TabIndex = 1;
            // 
            // txtSearchHV
            // 
            this.txtSearchHV.Location = new System.Drawing.Point(643, 37);
            this.txtSearchHV.Name = "txtSearchHV";
            this.txtSearchHV.Size = new System.Drawing.Size(115, 20);
            this.txtSearchHV.TabIndex = 22;
            this.txtSearchHV.TextChanged += new System.EventHandler(this.txtSearchHV_TextChanged);
            // 
            // FLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 471);
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
    }
}