namespace QuanLyTracNghiem.Views
{
    partial class FAdmin
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnClassroom = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(64, 279);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnClassroom
            // 
            this.btnClassroom.Location = new System.Drawing.Point(64, 186);
            this.btnClassroom.Name = "btnClassroom";
            this.btnClassroom.Size = new System.Drawing.Size(75, 23);
            this.btnClassroom.TabIndex = 0;
            this.btnClassroom.Text = "Classroom";
            this.btnClassroom.UseVisualStyleBackColor = true;
            this.btnClassroom.Click += new System.EventHandler(this.btnClassroom_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.Location = new System.Drawing.Point(64, 113);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(75, 23);
            this.btnSubject.TabIndex = 1;
            this.btnSubject.Text = "Subject";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // FAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubject);
            this.Controls.Add(this.btnClassroom);
            this.Controls.Add(this.btnLogOut);
            this.Name = "FAdmin";
            this.Text = "FAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FAdmin_FormClosed);
            this.Load += new System.EventHandler(this.FAdmin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnClassroom;
        private System.Windows.Forms.Button btnSubject;
    }
}