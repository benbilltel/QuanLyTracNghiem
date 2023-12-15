namespace QuanLyTracNghiem.Views
{
    partial class FStudent
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
            this.lblNameStudent = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblIDStudent = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.btnTakeExam = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNameStudent
            // 
            this.lblNameStudent.AutoSize = true;
            this.lblNameStudent.Location = new System.Drawing.Point(122, 61);
            this.lblNameStudent.Name = "lblNameStudent";
            this.lblNameStudent.Size = new System.Drawing.Size(35, 13);
            this.lblNameStudent.TabIndex = 0;
            this.lblNameStudent.Text = "Name";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(122, 93);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 0;
            this.lblClass.Text = "Class";
            // 
            // lblIDStudent
            // 
            this.lblIDStudent.AutoSize = true;
            this.lblIDStudent.Location = new System.Drawing.Point(122, 31);
            this.lblIDStudent.Name = "lblIDStudent";
            this.lblIDStudent.Size = new System.Drawing.Size(18, 13);
            this.lblIDStudent.TabIndex = 0;
            this.lblIDStudent.Text = "ID";
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(140, 202);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(121, 21);
            this.cbSubject.TabIndex = 1;
            // 
            // btnTakeExam
            // 
            this.btnTakeExam.Location = new System.Drawing.Point(333, 202);
            this.btnTakeExam.Name = "btnTakeExam";
            this.btnTakeExam.Size = new System.Drawing.Size(75, 23);
            this.btnTakeExam.TabIndex = 2;
            this.btnTakeExam.Text = "Enroll";
            this.btnTakeExam.UseVisualStyleBackColor = true;
            this.btnTakeExam.Click += new System.EventHandler(this.btnTakeExam_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(333, 164);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(333, 259);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // FStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnTakeExam);
            this.Controls.Add(this.cbSubject);
            this.Controls.Add(this.lblIDStudent);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblNameStudent);
            this.Name = "FStudent";
            this.Text = "FStudent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FStudent_FormClosed);
            this.Load += new System.EventHandler(this.FStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameStudent;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblIDStudent;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Button btnTakeExam;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnLogOut;
    }
}