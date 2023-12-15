namespace QuanLyTracNghiem.Views
{
    partial class FStudentResult
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
            this.dtgvExam = new System.Windows.Forms.DataGridView();
            this.dtgvExamDetail = new System.Windows.Forms.DataGridView();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.txtSearchExam = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExamDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvExam
            // 
            this.dtgvExam.AllowUserToAddRows = false;
            this.dtgvExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvExam.Location = new System.Drawing.Point(22, 198);
            this.dtgvExam.Name = "dtgvExam";
            this.dtgvExam.ReadOnly = true;
            this.dtgvExam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvExam.Size = new System.Drawing.Size(334, 150);
            this.dtgvExam.TabIndex = 1;
            this.dtgvExam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvExam_CellClick);
            this.dtgvExam.SelectionChanged += new System.EventHandler(this.dtgvExam_SelectionChanged);
            // 
            // dtgvExamDetail
            // 
            this.dtgvExamDetail.AllowUserToAddRows = false;
            this.dtgvExamDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvExamDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvExamDetail.Location = new System.Drawing.Point(374, 198);
            this.dtgvExamDetail.Name = "dtgvExamDetail";
            this.dtgvExamDetail.ReadOnly = true;
            this.dtgvExamDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvExamDetail.Size = new System.Drawing.Size(693, 150);
            this.dtgvExamDetail.TabIndex = 1;
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(68, 150);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(121, 21);
            this.cbSubject.TabIndex = 2;
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // txtSearchExam
            // 
            this.txtSearchExam.Location = new System.Drawing.Point(68, 102);
            this.txtSearchExam.Name = "txtSearchExam";
            this.txtSearchExam.Size = new System.Drawing.Size(121, 20);
            this.txtSearchExam.TabIndex = 3;
            this.txtSearchExam.TextChanged += new System.EventHandler(this.txtSearchExam_TextChanged);
            // 
            // FStudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 450);
            this.Controls.Add(this.txtSearchExam);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.dtgvExamDetail);
            this.Controls.Add(this.dtgvExam);
            this.Name = "FStudentResult";
            this.Text = "FStudentResult";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FStudentResult_FormClosed);
            this.Load += new System.EventHandler(this.FStudentResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExamDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvExam;
        private System.Windows.Forms.DataGridView dtgvExamDetail;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.TextBox txtSearchExam;
    }
}