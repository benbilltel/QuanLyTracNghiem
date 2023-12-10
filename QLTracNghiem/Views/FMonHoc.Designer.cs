namespace QLTracNghiem.Views
{
    partial class FMonHoc
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
            this.dtgvMH = new System.Windows.Forms.DataGridView();
            this.dtgvChuong = new System.Windows.Forms.DataGridView();
            this.dtgvCauHoi = new System.Windows.Forms.DataGridView();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtSearchMH = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.btnSaveMH = new System.Windows.Forms.Button();
            this.btnRefreshMH = new System.Windows.Forms.Button();
            this.txtTenChuong = new System.Windows.Forms.TextBox();
            this.btnSaceChuong = new System.Windows.Forms.Button();
            this.txtMaChuong = new System.Windows.Forms.TextBox();
            this.btnRefreshChuong = new System.Windows.Forms.Button();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.txtMaCH = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.cbDapAnDung = new System.Windows.Forms.ComboBox();
            this.btnSaveCH = new System.Windows.Forms.Button();
            this.btnRefreshCH = new System.Windows.Forms.Button();
            this.btnDeleteCH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvMH
            // 
            this.dtgvMH.AllowUserToAddRows = false;
            this.dtgvMH.AllowUserToDeleteRows = false;
            this.dtgvMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvMH.Location = new System.Drawing.Point(37, 203);
            this.dtgvMH.Name = "dtgvMH";
            this.dtgvMH.ReadOnly = true;
            this.dtgvMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMH.Size = new System.Drawing.Size(206, 189);
            this.dtgvMH.TabIndex = 9;
            this.dtgvMH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMH_CellClick);
            // 
            // dtgvChuong
            // 
            this.dtgvChuong.AllowUserToAddRows = false;
            this.dtgvChuong.AllowUserToDeleteRows = false;
            this.dtgvChuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvChuong.Location = new System.Drawing.Point(249, 203);
            this.dtgvChuong.Name = "dtgvChuong";
            this.dtgvChuong.ReadOnly = true;
            this.dtgvChuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChuong.Size = new System.Drawing.Size(220, 189);
            this.dtgvChuong.TabIndex = 10;
            this.dtgvChuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChuong_CellClick);
            // 
            // dtgvCauHoi
            // 
            this.dtgvCauHoi.AllowUserToAddRows = false;
            this.dtgvCauHoi.AllowUserToDeleteRows = false;
            this.dtgvCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCauHoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvCauHoi.Location = new System.Drawing.Point(475, 203);
            this.dtgvCauHoi.Name = "dtgvCauHoi";
            this.dtgvCauHoi.ReadOnly = true;
            this.dtgvCauHoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCauHoi.Size = new System.Drawing.Size(615, 189);
            this.dtgvCauHoi.TabIndex = 11;
            this.dtgvCauHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCauHoi_CellClick);
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(37, 99);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.ReadOnly = true;
            this.txtMaMH.Size = new System.Drawing.Size(115, 20);
            this.txtMaMH.TabIndex = 14;
            // 
            // txtSearchMH
            // 
            this.txtSearchMH.Location = new System.Drawing.Point(37, 45);
            this.txtSearchMH.Name = "txtSearchMH";
            this.txtSearchMH.Size = new System.Drawing.Size(115, 20);
            this.txtSearchMH.TabIndex = 15;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(37, 147);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(115, 20);
            this.txtTenMH.TabIndex = 16;
            // 
            // btnSaveMH
            // 
            this.btnSaveMH.Location = new System.Drawing.Point(158, 99);
            this.btnSaveMH.Name = "btnSaveMH";
            this.btnSaveMH.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMH.TabIndex = 17;
            this.btnSaveMH.Text = "Save";
            this.btnSaveMH.UseVisualStyleBackColor = true;
            this.btnSaveMH.Click += new System.EventHandler(this.btnSaveMH_Click);
            // 
            // btnRefreshMH
            // 
            this.btnRefreshMH.Location = new System.Drawing.Point(158, 147);
            this.btnRefreshMH.Name = "btnRefreshMH";
            this.btnRefreshMH.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshMH.TabIndex = 18;
            this.btnRefreshMH.Text = "Refresh";
            this.btnRefreshMH.UseVisualStyleBackColor = true;
            this.btnRefreshMH.Click += new System.EventHandler(this.btnRefreshMH_Click);
            // 
            // txtTenChuong
            // 
            this.txtTenChuong.Location = new System.Drawing.Point(249, 144);
            this.txtTenChuong.Name = "txtTenChuong";
            this.txtTenChuong.Size = new System.Drawing.Size(132, 20);
            this.txtTenChuong.TabIndex = 19;
            // 
            // btnSaceChuong
            // 
            this.btnSaceChuong.Location = new System.Drawing.Point(394, 102);
            this.btnSaceChuong.Name = "btnSaceChuong";
            this.btnSaceChuong.Size = new System.Drawing.Size(75, 23);
            this.btnSaceChuong.TabIndex = 20;
            this.btnSaceChuong.Text = "Save";
            this.btnSaceChuong.UseVisualStyleBackColor = true;
            this.btnSaceChuong.Click += new System.EventHandler(this.btnSaceChuong_Click);
            // 
            // txtMaChuong
            // 
            this.txtMaChuong.Location = new System.Drawing.Point(249, 102);
            this.txtMaChuong.Name = "txtMaChuong";
            this.txtMaChuong.ReadOnly = true;
            this.txtMaChuong.Size = new System.Drawing.Size(115, 20);
            this.txtMaChuong.TabIndex = 21;
            // 
            // btnRefreshChuong
            // 
            this.btnRefreshChuong.Location = new System.Drawing.Point(394, 147);
            this.btnRefreshChuong.Name = "btnRefreshChuong";
            this.btnRefreshChuong.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshChuong.TabIndex = 22;
            this.btnRefreshChuong.Text = "Refresh";
            this.btnRefreshChuong.UseVisualStyleBackColor = true;
            this.btnRefreshChuong.Click += new System.EventHandler(this.btnRefreshChuong_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(475, 129);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(249, 41);
            this.txtNoiDung.TabIndex = 23;
            this.txtNoiDung.Text = "";
            // 
            // txtMaCH
            // 
            this.txtMaCH.Location = new System.Drawing.Point(475, 99);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.ReadOnly = true;
            this.txtMaCH.Size = new System.Drawing.Size(115, 20);
            this.txtMaCH.TabIndex = 24;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(748, 28);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(146, 20);
            this.txtA.TabIndex = 25;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(748, 66);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(146, 20);
            this.txtB.TabIndex = 26;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(748, 105);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(146, 20);
            this.txtC.TabIndex = 26;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(748, 144);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(146, 20);
            this.txtD.TabIndex = 26;
            // 
            // cbDapAnDung
            // 
            this.cbDapAnDung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDapAnDung.FormattingEnabled = true;
            this.cbDapAnDung.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbDapAnDung.Location = new System.Drawing.Point(603, 98);
            this.cbDapAnDung.Name = "cbDapAnDung";
            this.cbDapAnDung.Size = new System.Drawing.Size(121, 21);
            this.cbDapAnDung.TabIndex = 27;
            // 
            // btnSaveCH
            // 
            this.btnSaveCH.Location = new System.Drawing.Point(938, 63);
            this.btnSaveCH.Name = "btnSaveCH";
            this.btnSaveCH.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCH.TabIndex = 28;
            this.btnSaveCH.Text = "Save";
            this.btnSaveCH.UseVisualStyleBackColor = true;
            this.btnSaveCH.Click += new System.EventHandler(this.btnSaveCH_Click);
            // 
            // btnRefreshCH
            // 
            this.btnRefreshCH.Location = new System.Drawing.Point(938, 99);
            this.btnRefreshCH.Name = "btnRefreshCH";
            this.btnRefreshCH.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshCH.TabIndex = 29;
            this.btnRefreshCH.Text = "Refresh";
            this.btnRefreshCH.UseVisualStyleBackColor = true;
            this.btnRefreshCH.Click += new System.EventHandler(this.btnRefreshCH_Click);
            // 
            // btnDeleteCH
            // 
            this.btnDeleteCH.Location = new System.Drawing.Point(938, 144);
            this.btnDeleteCH.Name = "btnDeleteCH";
            this.btnDeleteCH.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCH.TabIndex = 30;
            this.btnDeleteCH.Text = "Delete";
            this.btnDeleteCH.UseVisualStyleBackColor = true;
            this.btnDeleteCH.Click += new System.EventHandler(this.btnDeleteCH_Click);
            // 
            // FMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 450);
            this.Controls.Add(this.btnDeleteCH);
            this.Controls.Add(this.btnRefreshCH);
            this.Controls.Add(this.btnSaveCH);
            this.Controls.Add(this.cbDapAnDung);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.txtMaCH);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.btnRefreshChuong);
            this.Controls.Add(this.txtMaChuong);
            this.Controls.Add(this.btnSaceChuong);
            this.Controls.Add(this.txtTenChuong);
            this.Controls.Add(this.btnRefreshMH);
            this.Controls.Add(this.btnSaveMH);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.txtSearchMH);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.dtgvCauHoi);
            this.Controls.Add(this.dtgvChuong);
            this.Controls.Add(this.dtgvMH);
            this.Name = "FMonHoc";
            this.Text = "FMonHoc";
            this.Load += new System.EventHandler(this.FMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCauHoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMH;
        private System.Windows.Forms.DataGridView dtgvChuong;
        private System.Windows.Forms.DataGridView dtgvCauHoi;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtSearchMH;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.Button btnSaveMH;
        private System.Windows.Forms.Button btnRefreshMH;
        private System.Windows.Forms.TextBox txtTenChuong;
        private System.Windows.Forms.Button btnSaceChuong;
        private System.Windows.Forms.TextBox txtMaChuong;
        private System.Windows.Forms.Button btnRefreshChuong;
        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.TextBox txtMaCH;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.ComboBox cbDapAnDung;
        private System.Windows.Forms.Button btnSaveCH;
        private System.Windows.Forms.Button btnRefreshCH;
        private System.Windows.Forms.Button btnDeleteCH;
    }
}