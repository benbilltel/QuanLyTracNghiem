namespace QuanLyTracNghiem.Views
{
    partial class FClassroom
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
            this.btnRefreshClass = new System.Windows.Forms.Button();
            this.btnSaveClass = new System.Windows.Forms.Button();
            this.txtIDClass = new System.Windows.Forms.TextBox();
            this.txtSearchClass = new System.Windows.Forms.TextBox();
            this.txtNameClass = new System.Windows.Forms.TextBox();
            this.dtgvClassroom = new System.Windows.Forms.DataGridView();
            this.dtgvListSubject = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbListSubject = new System.Windows.Forms.ComboBox();
            this.btnRemoveSubjectFromList = new System.Windows.Forms.Button();
            this.btnSaveSubjectToList = new System.Windows.Forms.Button();
            this.dtgvStudent = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.btnRefreshStudent = new System.Windows.Forms.Button();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.txtIDStudent = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClassroom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListSubject)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStudent)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRefreshClass);
            this.groupBox1.Controls.Add(this.btnSaveClass);
            this.groupBox1.Controls.Add(this.txtIDClass);
            this.groupBox1.Controls.Add(this.txtSearchClass);
            this.groupBox1.Controls.Add(this.txtNameClass);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class";
            // 
            // btnRefreshClass
            // 
            this.btnRefreshClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshClass.Location = new System.Drawing.Point(133, 187);
            this.btnRefreshClass.Name = "btnRefreshClass";
            this.btnRefreshClass.Size = new System.Drawing.Size(71, 33);
            this.btnRefreshClass.TabIndex = 1;
            this.btnRefreshClass.Text = "Refresh";
            this.btnRefreshClass.UseVisualStyleBackColor = true;
            this.btnRefreshClass.Click += new System.EventHandler(this.btnRefreshClass_Click);
            // 
            // btnSaveClass
            // 
            this.btnSaveClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClass.Location = new System.Drawing.Point(21, 187);
            this.btnSaveClass.Name = "btnSaveClass";
            this.btnSaveClass.Size = new System.Drawing.Size(71, 33);
            this.btnSaveClass.TabIndex = 1;
            this.btnSaveClass.Text = "Save";
            this.btnSaveClass.UseVisualStyleBackColor = true;
            this.btnSaveClass.Click += new System.EventHandler(this.btnSaveClass_Click);
            // 
            // txtIDClass
            // 
            this.txtIDClass.Location = new System.Drawing.Point(21, 42);
            this.txtIDClass.Name = "txtIDClass";
            this.txtIDClass.ReadOnly = true;
            this.txtIDClass.Size = new System.Drawing.Size(183, 22);
            this.txtIDClass.TabIndex = 0;
            // 
            // txtSearchClass
            // 
            this.txtSearchClass.Location = new System.Drawing.Point(21, 95);
            this.txtSearchClass.Name = "txtSearchClass";
            this.txtSearchClass.Size = new System.Drawing.Size(183, 22);
            this.txtSearchClass.TabIndex = 0;
            this.txtSearchClass.TextChanged += new System.EventHandler(this.txtSearchClass_TextChanged);
            // 
            // txtNameClass
            // 
            this.txtNameClass.Location = new System.Drawing.Point(21, 150);
            this.txtNameClass.Name = "txtNameClass";
            this.txtNameClass.Size = new System.Drawing.Size(183, 22);
            this.txtNameClass.TabIndex = 0;
            // 
            // dtgvClassroom
            // 
            this.dtgvClassroom.AllowUserToAddRows = false;
            this.dtgvClassroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvClassroom.Location = new System.Drawing.Point(12, 275);
            this.dtgvClassroom.Name = "dtgvClassroom";
            this.dtgvClassroom.ReadOnly = true;
            this.dtgvClassroom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvClassroom.Size = new System.Drawing.Size(228, 150);
            this.dtgvClassroom.TabIndex = 0;
            this.dtgvClassroom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvClassroom_CellClick);
            this.dtgvClassroom.SelectionChanged += new System.EventHandler(this.dtgvClassroom_SelectionChanged);
            // 
            // dtgvListSubject
            // 
            this.dtgvListSubject.AllowUserToAddRows = false;
            this.dtgvListSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvListSubject.Location = new System.Drawing.Point(276, 275);
            this.dtgvListSubject.Name = "dtgvListSubject";
            this.dtgvListSubject.ReadOnly = true;
            this.dtgvListSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListSubject.Size = new System.Drawing.Size(213, 150);
            this.dtgvListSubject.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbListSubject);
            this.groupBox2.Controls.Add(this.btnRemoveSubjectFromList);
            this.groupBox2.Controls.Add(this.btnSaveSubjectToList);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(276, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 241);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Subject";
            // 
            // cbListSubject
            // 
            this.cbListSubject.FormattingEnabled = true;
            this.cbListSubject.Location = new System.Drawing.Point(15, 42);
            this.cbListSubject.Name = "cbListSubject";
            this.cbListSubject.Size = new System.Drawing.Size(181, 24);
            this.cbListSubject.TabIndex = 2;
            // 
            // btnRemoveSubjectFromList
            // 
            this.btnRemoveSubjectFromList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveSubjectFromList.Location = new System.Drawing.Point(125, 81);
            this.btnRemoveSubjectFromList.Name = "btnRemoveSubjectFromList";
            this.btnRemoveSubjectFromList.Size = new System.Drawing.Size(71, 33);
            this.btnRemoveSubjectFromList.TabIndex = 1;
            this.btnRemoveSubjectFromList.Text = "Remove";
            this.btnRemoveSubjectFromList.UseVisualStyleBackColor = true;
            this.btnRemoveSubjectFromList.Click += new System.EventHandler(this.btnRemoveSubjectFromList_Click);
            // 
            // btnSaveSubjectToList
            // 
            this.btnSaveSubjectToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSubjectToList.Location = new System.Drawing.Point(15, 81);
            this.btnSaveSubjectToList.Name = "btnSaveSubjectToList";
            this.btnSaveSubjectToList.Size = new System.Drawing.Size(71, 33);
            this.btnSaveSubjectToList.TabIndex = 1;
            this.btnSaveSubjectToList.Text = "Save";
            this.btnSaveSubjectToList.UseVisualStyleBackColor = true;
            this.btnSaveSubjectToList.Click += new System.EventHandler(this.btnSaveSubjectToList_Click);
            // 
            // dtgvStudent
            // 
            this.dtgvStudent.AllowUserToAddRows = false;
            this.dtgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvStudent.Location = new System.Drawing.Point(522, 275);
            this.dtgvStudent.Name = "dtgvStudent";
            this.dtgvStudent.ReadOnly = true;
            this.dtgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvStudent.Size = new System.Drawing.Size(630, 150);
            this.dtgvStudent.TabIndex = 3;
            this.dtgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvStudent_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbGender);
            this.groupBox3.Controls.Add(this.btnRemoveStudent);
            this.groupBox3.Controls.Add(this.btnRefreshStudent);
            this.groupBox3.Controls.Add(this.btnSaveStudent);
            this.groupBox3.Controls.Add(this.txtIDStudent);
            this.groupBox3.Controls.Add(this.txtAddress);
            this.groupBox3.Controls.Add(this.txtFirstName);
            this.groupBox3.Controls.Add(this.txtPhone);
            this.groupBox3.Controls.Add(this.txtSearchStudent);
            this.groupBox3.Controls.Add(this.txtLastName);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(522, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(630, 241);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student";
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(429, 95);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(144, 24);
            this.cbGender.TabIndex = 3;
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStudent.Location = new System.Drawing.Point(369, 188);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(71, 33);
            this.btnRemoveStudent.TabIndex = 2;
            this.btnRemoveStudent.Text = "Remove";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // btnRefreshStudent
            // 
            this.btnRefreshStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshStudent.Location = new System.Drawing.Point(502, 188);
            this.btnRefreshStudent.Name = "btnRefreshStudent";
            this.btnRefreshStudent.Size = new System.Drawing.Size(71, 33);
            this.btnRefreshStudent.TabIndex = 1;
            this.btnRefreshStudent.Text = "Refresh";
            this.btnRefreshStudent.UseVisualStyleBackColor = true;
            this.btnRefreshStudent.Click += new System.EventHandler(this.btnRefreshStudent_Click);
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStudent.Location = new System.Drawing.Point(227, 188);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(71, 33);
            this.btnSaveStudent.TabIndex = 1;
            this.btnSaveStudent.Text = "Save";
            this.btnSaveStudent.UseVisualStyleBackColor = true;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // txtIDStudent
            // 
            this.txtIDStudent.Location = new System.Drawing.Point(21, 42);
            this.txtIDStudent.Name = "txtIDStudent";
            this.txtIDStudent.ReadOnly = true;
            this.txtIDStudent.Size = new System.Drawing.Size(177, 22);
            this.txtIDStudent.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(227, 150);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(346, 22);
            this.txtAddress.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(21, 96);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(177, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(21, 150);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(177, 22);
            this.txtPhone.TabIndex = 0;
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(227, 43);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(177, 22);
            this.txtSearchStudent.TabIndex = 0;
            this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtSearchStudent_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(227, 96);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(177, 22);
            this.txtLastName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Subject List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Student ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(224, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Search";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "First Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Phone Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(224, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(426, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Gender";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(224, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "Address";
            // 
            // FClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1170, 465);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dtgvStudent);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtgvListSubject);
            this.Controls.Add(this.dtgvClassroom);
            this.Controls.Add(this.groupBox1);
            this.Name = "FClassroom";
            this.Text = "FClassroom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FClassroom_FormClosed);
            this.Load += new System.EventHandler(this.FClassroom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClassroom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListSubject)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStudent)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvClassroom;
        private System.Windows.Forms.TextBox txtIDClass;
        private System.Windows.Forms.TextBox txtSearchClass;
        private System.Windows.Forms.TextBox txtNameClass;
        private System.Windows.Forms.Button btnRefreshClass;
        private System.Windows.Forms.Button btnSaveClass;
        private System.Windows.Forms.DataGridView dtgvListSubject;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSaveSubjectToList;
        private System.Windows.Forms.ComboBox cbListSubject;
        private System.Windows.Forms.Button btnRemoveSubjectFromList;
        private System.Windows.Forms.DataGridView dtgvStudent;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.Button btnRefreshStudent;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.TextBox txtIDStudent;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
    }
}