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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HoTen : ";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(138, 46);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(27, 13);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "SV1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(66, 82);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(48, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Ma lop : ";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(138, 82);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(27, 13);
            this.lblMaLop.TabIndex = 1;
            this.lblMaLop.Text = "SV1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ma :";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(138, 9);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(27, 13);
            this.lblMa.TabIndex = 1;
            this.lblMa.Text = "SV1";
            // 
            // cbListMonThi
            // 
            this.cbListMonThi.FormattingEnabled = true;
            this.cbListMonThi.Location = new System.Drawing.Point(36, 172);
            this.cbListMonThi.Name = "cbListMonThi";
            this.cbListMonThi.Size = new System.Drawing.Size(121, 21);
            this.cbListMonThi.TabIndex = 4;
            this.cbListMonThi.SelectedIndexChanged += new System.EventHandler(this.cbListMonThi_SelectedIndexChanged);
            // 
            // btnThi
            // 
            this.btnThi.Location = new System.Drawing.Point(189, 172);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(75, 23);
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
            this.dtgvKetQua.Location = new System.Drawing.Point(36, 230);
            this.dtgvKetQua.Name = "dtgvKetQua";
            this.dtgvKetQua.ReadOnly = true;
            this.dtgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvKetQua.Size = new System.Drawing.Size(426, 150);
            this.dtgvKetQua.TabIndex = 8;
            // 
            // FThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 506);
            this.Controls.Add(this.dtgvKetQua);
            this.Controls.Add(this.btnThi);
            this.Controls.Add(this.cbListMonThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblMaLop);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.label1);
            this.Name = "FThi";
            this.Text = "FThi";
            this.Load += new System.EventHandler(this.FThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKetQua)).EndInit();
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
    }
}