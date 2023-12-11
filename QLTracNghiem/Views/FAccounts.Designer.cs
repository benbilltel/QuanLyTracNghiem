namespace QLTracNghiem
{
    partial class FAccounts
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
            this.btnAddUsAD = new System.Windows.Forms.Button();
            this.txtTaiKhoanUsAD = new System.Windows.Forms.TextBox();
            this.txtMatKhauUsAD = new System.Windows.Forms.TextBox();
            this.btnRefreshUsAD = new System.Windows.Forms.Button();
            this.btnRemoveUSAD = new System.Windows.Forms.Button();
            this.dtgvUsAdmin = new System.Windows.Forms.DataGridView();
            this.txtSearchUsAdmin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddUsAD
            // 
            this.btnAddUsAD.Location = new System.Drawing.Point(36, 196);
            this.btnAddUsAD.Name = "btnAddUsAD";
            this.btnAddUsAD.Size = new System.Drawing.Size(75, 23);
            this.btnAddUsAD.TabIndex = 1;
            this.btnAddUsAD.Text = "Save";
            this.btnAddUsAD.UseVisualStyleBackColor = true;
            this.btnAddUsAD.Click += new System.EventHandler(this.btnAddUsAD_Click);
            // 
            // txtTaiKhoanUsAD
            // 
            this.txtTaiKhoanUsAD.Location = new System.Drawing.Point(153, 87);
            this.txtTaiKhoanUsAD.Name = "txtTaiKhoanUsAD";
            this.txtTaiKhoanUsAD.Size = new System.Drawing.Size(194, 20);
            this.txtTaiKhoanUsAD.TabIndex = 2;
            // 
            // txtMatKhauUsAD
            // 
            this.txtMatKhauUsAD.Location = new System.Drawing.Point(153, 135);
            this.txtMatKhauUsAD.Name = "txtMatKhauUsAD";
            this.txtMatKhauUsAD.Size = new System.Drawing.Size(194, 20);
            this.txtMatKhauUsAD.TabIndex = 3;
            // 
            // btnRefreshUsAD
            // 
            this.btnRefreshUsAD.Location = new System.Drawing.Point(272, 196);
            this.btnRefreshUsAD.Name = "btnRefreshUsAD";
            this.btnRefreshUsAD.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshUsAD.TabIndex = 5;
            this.btnRefreshUsAD.Text = "Refresh";
            this.btnRefreshUsAD.UseVisualStyleBackColor = true;
            this.btnRefreshUsAD.Click += new System.EventHandler(this.btnRefreshUsAD_Click);
            // 
            // btnRemoveUSAD
            // 
            this.btnRemoveUSAD.Location = new System.Drawing.Point(153, 196);
            this.btnRemoveUSAD.Name = "btnRemoveUSAD";
            this.btnRemoveUSAD.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveUSAD.TabIndex = 6;
            this.btnRemoveUSAD.Text = "Remove";
            this.btnRemoveUSAD.UseVisualStyleBackColor = true;
            this.btnRemoveUSAD.Click += new System.EventHandler(this.btnRemoveUSAD_Click);
            // 
            // dtgvUsAdmin
            // 
            this.dtgvUsAdmin.AllowUserToAddRows = false;
            this.dtgvUsAdmin.AllowUserToDeleteRows = false;
            this.dtgvUsAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvUsAdmin.Location = new System.Drawing.Point(36, 246);
            this.dtgvUsAdmin.Name = "dtgvUsAdmin";
            this.dtgvUsAdmin.ReadOnly = true;
            this.dtgvUsAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvUsAdmin.Size = new System.Drawing.Size(311, 150);
            this.dtgvUsAdmin.TabIndex = 7;
            this.dtgvUsAdmin.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsAdmin_CellClick);
            // 
            // txtSearchUsAdmin
            // 
            this.txtSearchUsAdmin.Location = new System.Drawing.Point(153, 35);
            this.txtSearchUsAdmin.Name = "txtSearchUsAdmin";
            this.txtSearchUsAdmin.Size = new System.Drawing.Size(194, 20);
            this.txtSearchUsAdmin.TabIndex = 8;
            this.txtSearchUsAdmin.TextChanged += new System.EventHandler(this.txtSearchUsAdmin_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tìm kiếm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật khẩu";
            // 
            // FAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchUsAdmin);
            this.Controls.Add(this.dtgvUsAdmin);
            this.Controls.Add(this.btnRemoveUSAD);
            this.Controls.Add(this.btnRefreshUsAD);
            this.Controls.Add(this.txtMatKhauUsAD);
            this.Controls.Add(this.txtTaiKhoanUsAD);
            this.Controls.Add(this.btnAddUsAD);
            this.Name = "FAccounts";
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.FAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddUsAD;
        private System.Windows.Forms.TextBox txtTaiKhoanUsAD;
        private System.Windows.Forms.TextBox txtMatKhauUsAD;
        private System.Windows.Forms.Button btnRefreshUsAD;
        private System.Windows.Forms.Button btnRemoveUSAD;
        private System.Windows.Forms.DataGridView dtgvUsAdmin;
        private System.Windows.Forms.TextBox txtSearchUsAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

