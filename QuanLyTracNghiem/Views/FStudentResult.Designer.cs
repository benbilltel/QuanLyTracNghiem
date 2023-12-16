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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExamDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvExam
            // 
            this.dtgvExam.AllowUserToAddRows = false;
            this.dtgvExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvExam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvExam.Location = new System.Drawing.Point(22, 151);
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
            this.dtgvExamDetail.Location = new System.Drawing.Point(391, 151);
            this.dtgvExamDetail.Name = "dtgvExamDetail";
            this.dtgvExamDetail.ReadOnly = true;
            this.dtgvExamDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvExamDetail.Size = new System.Drawing.Size(693, 150);
            this.dtgvExamDetail.TabIndex = 1;
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(86, 71);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(225, 21);
            this.cbSubject.TabIndex = 2;
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // txtSearchExam
            // 
            this.txtSearchExam.Location = new System.Drawing.Point(86, 28);
            this.txtSearchExam.Name = "txtSearchExam";
            this.txtSearchExam.Size = new System.Drawing.Size(225, 20);
            this.txtSearchExam.TabIndex = 3;
            this.txtSearchExam.TextChanged += new System.EventHandler(this.txtSearchExam_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.txtSearchExam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbSubject);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 111);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // FStudentResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1096, 343);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvExamDetail);
            this.Controls.Add(this.dtgvExam);
            this.Name = "FStudentResult";
            this.Text = "FStudentResult";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FStudentResult_FormClosed);
            this.Load += new System.EventHandler(this.FStudentResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvExamDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvExam;
        private System.Windows.Forms.DataGridView dtgvExamDetail;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.TextBox txtSearchExam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}