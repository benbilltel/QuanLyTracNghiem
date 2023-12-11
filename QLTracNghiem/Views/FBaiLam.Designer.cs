namespace QLTracNghiem.Views
{
    partial class FBaiLam
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
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.rdDapAnA = new System.Windows.Forms.RadioButton();
            this.rdDapAnB = new System.Windows.Forms.RadioButton();
            this.rdDapAnC = new System.Windows.Forms.RadioButton();
            this.rdDapAnD = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.AutoSize = true;
            this.lblCauHoi.Location = new System.Drawing.Point(41, 13);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(43, 13);
            this.lblCauHoi.TabIndex = 0;
            this.lblCauHoi.Text = "Câu hỏi";
            // 
            // rdDapAnA
            // 
            this.rdDapAnA.AutoSize = true;
            this.rdDapAnA.Location = new System.Drawing.Point(44, 196);
            this.rdDapAnA.Name = "rdDapAnA";
            this.rdDapAnA.Size = new System.Drawing.Size(70, 17);
            this.rdDapAnA.TabIndex = 1;
            this.rdDapAnA.TabStop = true;
            this.rdDapAnA.Text = "Đáp án A";
            this.rdDapAnA.UseVisualStyleBackColor = true;
            // 
            // rdDapAnB
            // 
            this.rdDapAnB.AutoSize = true;
            this.rdDapAnB.Location = new System.Drawing.Point(426, 196);
            this.rdDapAnB.Name = "rdDapAnB";
            this.rdDapAnB.Size = new System.Drawing.Size(70, 17);
            this.rdDapAnB.TabIndex = 1;
            this.rdDapAnB.TabStop = true;
            this.rdDapAnB.Text = "Đáp án B";
            this.rdDapAnB.UseVisualStyleBackColor = true;
            // 
            // rdDapAnC
            // 
            this.rdDapAnC.AutoSize = true;
            this.rdDapAnC.Location = new System.Drawing.Point(44, 295);
            this.rdDapAnC.Name = "rdDapAnC";
            this.rdDapAnC.Size = new System.Drawing.Size(70, 17);
            this.rdDapAnC.TabIndex = 1;
            this.rdDapAnC.TabStop = true;
            this.rdDapAnC.Text = "Đáp án C";
            this.rdDapAnC.UseVisualStyleBackColor = true;
            // 
            // rdDapAnD
            // 
            this.rdDapAnD.AutoSize = true;
            this.rdDapAnD.Location = new System.Drawing.Point(426, 295);
            this.rdDapAnD.Name = "rdDapAnD";
            this.rdDapAnD.Size = new System.Drawing.Size(71, 17);
            this.rdDapAnD.TabIndex = 2;
            this.rdDapAnD.TabStop = true;
            this.rdDapAnD.Text = "Đáp án D";
            this.rdDapAnD.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(426, 392);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(227, 392);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNop
            // 
            this.btnNop.Location = new System.Drawing.Point(698, 13);
            this.btnNop.Name = "btnNop";
            this.btnNop.Size = new System.Drawing.Size(90, 35);
            this.btnNop.TabIndex = 5;
            this.btnNop.Text = "Nộp bài";
            this.btnNop.UseVisualStyleBackColor = true;
            this.btnNop.Click += new System.EventHandler(this.btnNop_Click);
            // 
            // FBaiLam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNop);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.rdDapAnD);
            this.Controls.Add(this.rdDapAnB);
            this.Controls.Add(this.rdDapAnC);
            this.Controls.Add(this.rdDapAnA);
            this.Controls.Add(this.lblCauHoi);
            this.Name = "FBaiLam";
            this.Text = "FBaiLam";
            this.Load += new System.EventHandler(this.FBaiLam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.RadioButton rdDapAnA;
        private System.Windows.Forms.RadioButton rdDapAnB;
        private System.Windows.Forms.RadioButton rdDapAnC;
        private System.Windows.Forms.RadioButton rdDapAnD;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNop;
    }
}