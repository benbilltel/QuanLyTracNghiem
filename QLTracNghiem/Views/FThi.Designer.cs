namespace QLTracNghiem.Views
{
    partial class FThi
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.cbListMonThi = new System.Windows.Forms.ComboBox();
            this.btnThi = new System.Windows.Forms.Button();
            this.dtgvKetQua = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKetQua)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên : ";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(191, 105);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(27, 13);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "SV1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(39, 146);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(45, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Mã lớp: ";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(191, 146);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(27, 13);
            this.lblMaLop.TabIndex = 1;
            this.lblMaLop.Text = "SV1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã học viên :";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(191, 67);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(27, 13);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "SV1";
            // 
            // cbListMonThi
            // 
            this.cbListMonThi.FormattingEnabled = true;
            this.cbListMonThi.Location = new System.Drawing.Point(154, 237);
            this.cbListMonThi.Name = "cbListMonThi";
            this.cbListMonThi.Size = new System.Drawing.Size(121, 21);
            this.cbListMonThi.TabIndex = 4;
            this.cbListMonThi.SelectedIndexChanged += new System.EventHandler(this.cbListMonThi_SelectedIndexChanged);
            // 
            // btnThi
            // 
            this.btnThi.Location = new System.Drawing.Point(374, 237);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(87, 31);
            this.btnThi.TabIndex = 5;
            this.btnThi.Text = "Thi";
            this.btnThi.UseVisualStyleBackColor = true;
            this.btnThi.Click += new System.EventHandler(this.btnThi_Click);
            // 
            // dtgvKetQua
            // 
            this.dtgvKetQua.AllowUserToAddRows = false;
            this.dtgvKetQua.AllowUserToDeleteRows = false;
            this.dtgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKetQua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvKetQua.Location = new System.Drawing.Point(36, 283);
            this.dtgvKetQua.Name = "dtgvKetQua";
            this.dtgvKetQua.ReadOnly = true;
            this.dtgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvKetQua.Size = new System.Drawing.Size(426, 150);
            this.dtgvKetQua.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Danh sách môn thi";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lblMaLop);
            this.groupBox1.Location = new System.Drawing.Point(36, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 183);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thông tin học viên";
            // 
            // FThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 474);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgvKetQua);
            this.Controls.Add(this.btnThi);
            this.Controls.Add(this.cbListMonThi);
            this.Name = "FThi";
            this.Text = "FThi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FThi_FormClosed);
            this.Load += new System.EventHandler(this.FThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKetQua)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.ComboBox cbListMonThi;
        private System.Windows.Forms.Button btnThi;
        private System.Windows.Forms.DataGridView dtgvKetQua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
    }
}