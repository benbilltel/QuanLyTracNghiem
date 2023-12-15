namespace QuanLyTracNghiem.Views
{
    partial class FComp
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.rdC = new System.Windows.Forms.RadioButton();
            this.rdD = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cbQuestion = new System.Windows.Forms.ComboBox();
            this.rdUnLocked = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(56, 49);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(47, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "question";
            // 
            // rdA
            // 
            this.rdA.AutoSize = true;
            this.rdA.Location = new System.Drawing.Point(59, 153);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(32, 17);
            this.rdA.TabIndex = 1;
            this.rdA.TabStop = true;
            this.rdA.Text = "A";
            this.rdA.UseVisualStyleBackColor = true;
            // 
            // rdB
            // 
            this.rdB.AutoSize = true;
            this.rdB.Location = new System.Drawing.Point(286, 153);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(32, 17);
            this.rdB.TabIndex = 1;
            this.rdB.TabStop = true;
            this.rdB.Text = "B";
            this.rdB.UseVisualStyleBackColor = true;
            // 
            // rdC
            // 
            this.rdC.AutoSize = true;
            this.rdC.Location = new System.Drawing.Point(59, 248);
            this.rdC.Name = "rdC";
            this.rdC.Size = new System.Drawing.Size(32, 17);
            this.rdC.TabIndex = 1;
            this.rdC.TabStop = true;
            this.rdC.Text = "C";
            this.rdC.UseVisualStyleBackColor = true;
            // 
            // rdD
            // 
            this.rdD.AutoSize = true;
            this.rdD.Location = new System.Drawing.Point(286, 248);
            this.rdD.Name = "rdD";
            this.rdD.Size = new System.Drawing.Size(33, 17);
            this.rdD.TabIndex = 1;
            this.rdD.TabStop = true;
            this.rdD.Text = "D";
            this.rdD.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(695, 23);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(98, 387);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 4;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(276, 387);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cbQuestion
            // 
            this.cbQuestion.FormattingEnabled = true;
            this.cbQuestion.Location = new System.Drawing.Point(583, 153);
            this.cbQuestion.Name = "cbQuestion";
            this.cbQuestion.Size = new System.Drawing.Size(121, 21);
            this.cbQuestion.TabIndex = 6;
            this.cbQuestion.SelectedIndexChanged += new System.EventHandler(this.cbQuestion_SelectedIndexChanged);
            // 
            // rdUnLocked
            // 
            this.rdUnLocked.AutoSize = true;
            this.rdUnLocked.Location = new System.Drawing.Point(70, 23);
            this.rdUnLocked.Name = "rdUnLocked";
            this.rdUnLocked.Size = new System.Drawing.Size(57, 17);
            this.rdUnLocked.TabIndex = 7;
            this.rdUnLocked.TabStop = true;
            this.rdUnLocked.Text = "unlock";
            this.rdUnLocked.UseVisualStyleBackColor = true;
            this.rdUnLocked.Visible = false;
            // 
            // FComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdUnLocked);
            this.Controls.Add(this.cbQuestion);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdD);
            this.Controls.Add(this.rdC);
            this.Controls.Add(this.rdB);
            this.Controls.Add(this.rdA);
            this.Controls.Add(this.lblQuestion);
            this.Name = "FComp";
            this.Text = "FComp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FComp_FormClosed);
            this.Load += new System.EventHandler(this.FComp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.RadioButton rdC;
        private System.Windows.Forms.RadioButton rdD;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox cbQuestion;
        private System.Windows.Forms.RadioButton rdUnLocked;
    }
}