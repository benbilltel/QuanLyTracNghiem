namespace QuanLyTracNghiem.Views
{
    partial class FSubject
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefreshSubject = new System.Windows.Forms.Button();
            this.btnSaveSubject = new System.Windows.Forms.Button();
            this.txtIDSubject = new System.Windows.Forms.TextBox();
            this.txtSearchSubject = new System.Windows.Forms.TextBox();
            this.txtNameSubject = new System.Windows.Forms.TextBox();
            this.dtgvSubject = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefreshChapter = new System.Windows.Forms.Button();
            this.btnSaveChapter = new System.Windows.Forms.Button();
            this.txtIDChapter = new System.Windows.Forms.TextBox();
            this.txtNameChapter = new System.Windows.Forms.TextBox();
            this.dtgvChapter = new System.Windows.Forms.DataGridView();
            this.dtgvQuestion = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSearchQuestion = new System.Windows.Forms.TextBox();
            this.cbAnswer = new System.Windows.Forms.ComboBox();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.btnRefreshQuestion = new System.Windows.Forms.Button();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.txtIDQuestion = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSubject)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChapter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuestion)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefreshSubject);
            this.groupBox1.Controls.Add(this.btnSaveSubject);
            this.groupBox1.Controls.Add(this.txtIDSubject);
            this.groupBox1.Controls.Add(this.txtSearchSubject);
            this.groupBox1.Controls.Add(this.txtNameSubject);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject";
            // 
            // btnRefreshSubject
            // 
            this.btnRefreshSubject.Location = new System.Drawing.Point(140, 93);
            this.btnRefreshSubject.Name = "btnRefreshSubject";
            this.btnRefreshSubject.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshSubject.TabIndex = 1;
            this.btnRefreshSubject.Text = "Refresh";
            this.btnRefreshSubject.UseVisualStyleBackColor = true;
            this.btnRefreshSubject.Click += new System.EventHandler(this.btnRefreshSubject_Click);
            // 
            // btnSaveSubject
            // 
            this.btnSaveSubject.Location = new System.Drawing.Point(140, 57);
            this.btnSaveSubject.Name = "btnSaveSubject";
            this.btnSaveSubject.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSubject.TabIndex = 1;
            this.btnSaveSubject.Text = "Save";
            this.btnSaveSubject.UseVisualStyleBackColor = true;
            this.btnSaveSubject.Click += new System.EventHandler(this.btnSaveSubject_Click);
            // 
            // txtIDSubject
            // 
            this.txtIDSubject.Location = new System.Drawing.Point(6, 19);
            this.txtIDSubject.Name = "txtIDSubject";
            this.txtIDSubject.ReadOnly = true;
            this.txtIDSubject.Size = new System.Drawing.Size(100, 20);
            this.txtIDSubject.TabIndex = 0;
            // 
            // txtSearchSubject
            // 
            this.txtSearchSubject.Location = new System.Drawing.Point(6, 57);
            this.txtSearchSubject.Name = "txtSearchSubject";
            this.txtSearchSubject.Size = new System.Drawing.Size(100, 20);
            this.txtSearchSubject.TabIndex = 0;
            this.txtSearchSubject.TextChanged += new System.EventHandler(this.txtSearchSubject_TextChanged);
            // 
            // txtNameSubject
            // 
            this.txtNameSubject.Location = new System.Drawing.Point(6, 96);
            this.txtNameSubject.Name = "txtNameSubject";
            this.txtNameSubject.Size = new System.Drawing.Size(100, 20);
            this.txtNameSubject.TabIndex = 0;
            // 
            // dtgvSubject
            // 
            this.dtgvSubject.AllowUserToAddRows = false;
            this.dtgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvSubject.Location = new System.Drawing.Point(12, 185);
            this.dtgvSubject.Name = "dtgvSubject";
            this.dtgvSubject.ReadOnly = true;
            this.dtgvSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSubject.Size = new System.Drawing.Size(228, 150);
            this.dtgvSubject.TabIndex = 2;
            this.dtgvSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvSubject_CellClick);
            this.dtgvSubject.SelectionChanged += new System.EventHandler(this.dtgvSubject_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefreshChapter);
            this.groupBox2.Controls.Add(this.btnSaveChapter);
            this.groupBox2.Controls.Add(this.txtIDChapter);
            this.groupBox2.Controls.Add(this.txtNameChapter);
            this.groupBox2.Location = new System.Drawing.Point(246, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 138);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chapter";
            // 
            // btnRefreshChapter
            // 
            this.btnRefreshChapter.Location = new System.Drawing.Point(140, 93);
            this.btnRefreshChapter.Name = "btnRefreshChapter";
            this.btnRefreshChapter.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshChapter.TabIndex = 1;
            this.btnRefreshChapter.Text = "Refresh";
            this.btnRefreshChapter.UseVisualStyleBackColor = true;
            this.btnRefreshChapter.Click += new System.EventHandler(this.btnRefreshChapter_Click);
            // 
            // btnSaveChapter
            // 
            this.btnSaveChapter.Location = new System.Drawing.Point(140, 57);
            this.btnSaveChapter.Name = "btnSaveChapter";
            this.btnSaveChapter.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChapter.TabIndex = 1;
            this.btnSaveChapter.Text = "Save";
            this.btnSaveChapter.UseVisualStyleBackColor = true;
            this.btnSaveChapter.Click += new System.EventHandler(this.btnSaveChapter_Click);
            // 
            // txtIDChapter
            // 
            this.txtIDChapter.Location = new System.Drawing.Point(6, 57);
            this.txtIDChapter.Name = "txtIDChapter";
            this.txtIDChapter.ReadOnly = true;
            this.txtIDChapter.Size = new System.Drawing.Size(100, 20);
            this.txtIDChapter.TabIndex = 0;
            // 
            // txtNameChapter
            // 
            this.txtNameChapter.Location = new System.Drawing.Point(6, 96);
            this.txtNameChapter.Name = "txtNameChapter";
            this.txtNameChapter.Size = new System.Drawing.Size(100, 20);
            this.txtNameChapter.TabIndex = 0;
            // 
            // dtgvChapter
            // 
            this.dtgvChapter.AllowUserToAddRows = false;
            this.dtgvChapter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChapter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvChapter.Location = new System.Drawing.Point(246, 185);
            this.dtgvChapter.Name = "dtgvChapter";
            this.dtgvChapter.ReadOnly = true;
            this.dtgvChapter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChapter.Size = new System.Drawing.Size(228, 150);
            this.dtgvChapter.TabIndex = 4;
            this.dtgvChapter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChapter_CellClick);
            this.dtgvChapter.SelectionChanged += new System.EventHandler(this.dtgvChapter_SelectionChanged);
            // 
            // dtgvQuestion
            // 
            this.dtgvQuestion.AllowUserToAddRows = false;
            this.dtgvQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvQuestion.Location = new System.Drawing.Point(480, 185);
            this.dtgvQuestion.Name = "dtgvQuestion";
            this.dtgvQuestion.ReadOnly = true;
            this.dtgvQuestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQuestion.Size = new System.Drawing.Size(627, 150);
            this.dtgvQuestion.TabIndex = 5;
            this.dtgvQuestion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvQuestion_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSearchQuestion);
            this.groupBox3.Controls.Add(this.cbAnswer);
            this.groupBox3.Controls.Add(this.btnRemoveStudent);
            this.groupBox3.Controls.Add(this.btnRefreshQuestion);
            this.groupBox3.Controls.Add(this.btnSaveStudent);
            this.groupBox3.Controls.Add(this.txtIDQuestion);
            this.groupBox3.Controls.Add(this.txtD);
            this.groupBox3.Controls.Add(this.txtContent);
            this.groupBox3.Controls.Add(this.txtC);
            this.groupBox3.Controls.Add(this.txtA);
            this.groupBox3.Controls.Add(this.txtB);
            this.groupBox3.Location = new System.Drawing.Point(480, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(627, 138);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Question";
            // 
            // txtSearchQuestion
            // 
            this.txtSearchQuestion.Location = new System.Drawing.Point(123, 19);
            this.txtSearchQuestion.Name = "txtSearchQuestion";
            this.txtSearchQuestion.Size = new System.Drawing.Size(100, 20);
            this.txtSearchQuestion.TabIndex = 4;
            this.txtSearchQuestion.TextChanged += new System.EventHandler(this.txtSearchQuestion_TextChanged);
            // 
            // cbAnswer
            // 
            this.cbAnswer.FormattingEnabled = true;
            this.cbAnswer.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbAnswer.Location = new System.Drawing.Point(408, 40);
            this.cbAnswer.Name = "cbAnswer";
            this.cbAnswer.Size = new System.Drawing.Size(77, 21);
            this.cbAnswer.TabIndex = 3;
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(549, 58);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveStudent.TabIndex = 2;
            this.btnRemoveStudent.Text = "Remove";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // btnRefreshQuestion
            // 
            this.btnRefreshQuestion.Location = new System.Drawing.Point(549, 93);
            this.btnRefreshQuestion.Name = "btnRefreshQuestion";
            this.btnRefreshQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshQuestion.TabIndex = 1;
            this.btnRefreshQuestion.Text = "Refresh";
            this.btnRefreshQuestion.UseVisualStyleBackColor = true;
            this.btnRefreshQuestion.Click += new System.EventHandler(this.btnRefreshQuestion_Click);
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.Location = new System.Drawing.Point(549, 29);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(75, 23);
            this.btnSaveStudent.TabIndex = 1;
            this.btnSaveStudent.Text = "Save";
            this.btnSaveStudent.UseVisualStyleBackColor = true;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // txtIDQuestion
            // 
            this.txtIDQuestion.Location = new System.Drawing.Point(6, 19);
            this.txtIDQuestion.Name = "txtIDQuestion";
            this.txtIDQuestion.ReadOnly = true;
            this.txtIDQuestion.Size = new System.Drawing.Size(100, 20);
            this.txtIDQuestion.TabIndex = 0;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(253, 97);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(100, 20);
            this.txtD.TabIndex = 0;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(6, 58);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(175, 74);
            this.txtContent.TabIndex = 0;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(253, 71);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 0;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(253, 19);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(253, 45);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 0;
            // 
            // FSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dtgvQuestion);
            this.Controls.Add(this.dtgvChapter);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtgvSubject);
            this.Controls.Add(this.groupBox1);
            this.Name = "FSubject";
            this.Text = "FSubject";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FSubject_FormClosed);
            this.Load += new System.EventHandler(this.FSubject_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSubject)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChapter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvQuestion)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefreshSubject;
        private System.Windows.Forms.Button btnSaveSubject;
        private System.Windows.Forms.TextBox txtIDSubject;
        private System.Windows.Forms.TextBox txtSearchSubject;
        private System.Windows.Forms.TextBox txtNameSubject;
        private System.Windows.Forms.DataGridView dtgvSubject;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRefreshChapter;
        private System.Windows.Forms.Button btnSaveChapter;
        private System.Windows.Forms.TextBox txtIDChapter;
        private System.Windows.Forms.TextBox txtNameChapter;
        private System.Windows.Forms.DataGridView dtgvChapter;
        private System.Windows.Forms.DataGridView dtgvQuestion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbAnswer;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button btnRefreshQuestion;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.TextBox txtIDQuestion;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtSearchQuestion;
    }
}