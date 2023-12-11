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
            this.label12 = new System.Windows.Forms.Label();
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
            this.dtgvMH.Location = new System.Drawing.Point(37, 266);
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
            this.dtgvChuong.Location = new System.Drawing.Point(268, 266);
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
            this.dtgvCauHoi.Location = new System.Drawing.Point(515, 266);
            this.dtgvCauHoi.Name = "dtgvCauHoi";
            this.dtgvCauHoi.ReadOnly = true;
            this.dtgvCauHoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCauHoi.Size = new System.Drawing.Size(615, 189);
            this.dtgvCauHoi.TabIndex = 11;
            this.dtgvCauHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCauHoi_CellClick);
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(37, 114);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.ReadOnly = true;
            this.txtMaMH.Size = new System.Drawing.Size(206, 20);
            this.txtMaMH.TabIndex = 14;
            // 
            // txtSearchMH
            // 
            this.txtSearchMH.Location = new System.Drawing.Point(37, 43);
            this.txtSearchMH.Name = "txtSearchMH";
            this.txtSearchMH.Size = new System.Drawing.Size(206, 20);
            this.txtSearchMH.TabIndex = 15;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(37, 180);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(206, 20);
            this.txtTenMH.TabIndex = 16;
            // 
            // btnSaveMH
            // 
            this.btnSaveMH.Location = new System.Drawing.Point(37, 228);
            this.btnSaveMH.Name = "btnSaveMH";
            this.btnSaveMH.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMH.TabIndex = 17;
            this.btnSaveMH.Text = "Save";
            this.btnSaveMH.UseVisualStyleBackColor = true;
            this.btnSaveMH.Click += new System.EventHandler(this.btnSaveMH_Click);
            // 
            // btnRefreshMH
            // 
            this.btnRefreshMH.Location = new System.Drawing.Point(118, 228);
            this.btnRefreshMH.Name = "btnRefreshMH";
            this.btnRefreshMH.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshMH.TabIndex = 18;
            this.btnRefreshMH.Text = "Refresh";
            this.btnRefreshMH.UseVisualStyleBackColor = true;
            this.btnRefreshMH.Click += new System.EventHandler(this.btnRefreshMH_Click);
            // 
            // txtTenChuong
            // 
            this.txtTenChuong.Location = new System.Drawing.Point(268, 180);
            this.txtTenChuong.Name = "txtTenChuong";
            this.txtTenChuong.Size = new System.Drawing.Size(220, 20);
            this.txtTenChuong.TabIndex = 19;
            // 
            // btnSaceChuong
            // 
            this.btnSaceChuong.Location = new System.Drawing.Point(268, 228);
            this.btnSaceChuong.Name = "btnSaceChuong";
            this.btnSaceChuong.Size = new System.Drawing.Size(75, 23);
            this.btnSaceChuong.TabIndex = 20;
            this.btnSaceChuong.Text = "Save";
            this.btnSaceChuong.UseVisualStyleBackColor = true;
            this.btnSaceChuong.Click += new System.EventHandler(this.btnSaceChuong_Click);
            // 
            // txtMaChuong
            // 
            this.txtMaChuong.Location = new System.Drawing.Point(268, 114);
            this.txtMaChuong.Name = "txtMaChuong";
            this.txtMaChuong.ReadOnly = true;
            this.txtMaChuong.Size = new System.Drawing.Size(201, 20);
            this.txtMaChuong.TabIndex = 21;
            // 
            // btnRefreshChuong
            // 
            this.btnRefreshChuong.Location = new System.Drawing.Point(349, 228);
            this.btnRefreshChuong.Name = "btnRefreshChuong";
            this.btnRefreshChuong.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshChuong.TabIndex = 22;
            this.btnRefreshChuong.Text = "Refresh";
            this.btnRefreshChuong.UseVisualStyleBackColor = true;
            this.btnRefreshChuong.Click += new System.EventHandler(this.btnRefreshChuong_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(515, 114);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(237, 86);
            this.txtNoiDung.TabIndex = 23;
            this.txtNoiDung.Text = "";
            // 
            // txtMaCH
            // 
            this.txtMaCH.Location = new System.Drawing.Point(515, 43);
            this.txtMaCH.Name = "txtMaCH";
            this.txtMaCH.ReadOnly = true;
            this.txtMaCH.Size = new System.Drawing.Size(115, 20);
            this.txtMaCH.TabIndex = 24;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(765, 43);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(198, 20);
            this.txtA.TabIndex = 25;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(765, 91);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(198, 20);
            this.txtB.TabIndex = 26;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(765, 142);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(198, 20);
            this.txtC.TabIndex = 26;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(765, 181);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(198, 20);
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
            this.cbDapAnDung.Location = new System.Drawing.Point(992, 43);
            this.cbDapAnDung.Name = "cbDapAnDung";
            this.cbDapAnDung.Size = new System.Drawing.Size(138, 21);
            this.cbDapAnDung.TabIndex = 27;
            // 
            // btnSaveCH
            // 
            this.btnSaveCH.Location = new System.Drawing.Point(515, 228);
            this.btnSaveCH.Name = "btnSaveCH";
            this.btnSaveCH.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCH.TabIndex = 28;
            this.btnSaveCH.Text = "Save";
            this.btnSaveCH.UseVisualStyleBackColor = true;
            this.btnSaveCH.Click += new System.EventHandler(this.btnSaveCH_Click);
            // 
            // btnRefreshCH
            // 
            this.btnRefreshCH.Location = new System.Drawing.Point(596, 228);
            this.btnRefreshCH.Name = "btnRefreshCH";
            this.btnRefreshCH.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshCH.TabIndex = 29;
            this.btnRefreshCH.Text = "Refresh";
            this.btnRefreshCH.UseVisualStyleBackColor = true;
            this.btnRefreshCH.Click += new System.EventHandler(this.btnRefreshCH_Click);
            // 
            // btnDeleteCH
            // 
            this.btnDeleteCH.Location = new System.Drawing.Point(677, 228);
            this.btnDeleteCH.Name = "btnDeleteCH";
            this.btnDeleteCH.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteCH.TabIndex = 30;
            this.btnDeleteCH.Text = "Delete";
            this.btnDeleteCH.UseVisualStyleBackColor = true;
            this.btnDeleteCH.Click += new System.EventHandler(this.btnDeleteCH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Tên môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mã môn học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tìm môn học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Mã chương";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Tên chương";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Mã câu hỏi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nội dung câu hỏi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(989, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Đáp án đúng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(762, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Đáp án A";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(762, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Đáp án B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(763, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Đáp án C";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(762, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "Đáp án D";
            // 
            // FMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1161, 537);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}