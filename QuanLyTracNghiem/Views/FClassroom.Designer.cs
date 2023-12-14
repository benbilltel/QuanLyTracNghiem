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
            this.btnRefreshStudent = new System.Windows.Forms.Button();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.txtIDStudent = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.btnRefreshClass);
            this.groupBox1.Controls.Add(this.btnSaveClass);
            this.groupBox1.Controls.Add(this.txtIDClass);
            this.groupBox1.Controls.Add(this.txtSearchClass);
            this.groupBox1.Controls.Add(this.txtNameClass);
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class";
            // 
            // btnRefreshClass
            // 
            this.btnRefreshClass.Location = new System.Drawing.Point(140, 93);
            this.btnRefreshClass.Name = "btnRefreshClass";
            this.btnRefreshClass.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshClass.TabIndex = 1;
            this.btnRefreshClass.Text = "Refresh";
            this.btnRefreshClass.UseVisualStyleBackColor = true;
            this.btnRefreshClass.Click += new System.EventHandler(this.btnRefreshClass_Click);
            // 
            // btnSaveClass
            // 
            this.btnSaveClass.Location = new System.Drawing.Point(140, 57);
            this.btnSaveClass.Name = "btnSaveClass";
            this.btnSaveClass.Size = new System.Drawing.Size(75, 23);
            this.btnSaveClass.TabIndex = 1;
            this.btnSaveClass.Text = "Save";
            this.btnSaveClass.UseVisualStyleBackColor = true;
            this.btnSaveClass.Click += new System.EventHandler(this.btnSaveClass_Click);
            // 
            // txtIDClass
            // 
            this.txtIDClass.Location = new System.Drawing.Point(6, 19);
            this.txtIDClass.Name = "txtIDClass";
            this.txtIDClass.ReadOnly = true;
            this.txtIDClass.Size = new System.Drawing.Size(100, 20);
            this.txtIDClass.TabIndex = 0;
            // 
            // txtSearchClass
            // 
            this.txtSearchClass.Location = new System.Drawing.Point(6, 57);
            this.txtSearchClass.Name = "txtSearchClass";
            this.txtSearchClass.Size = new System.Drawing.Size(100, 20);
            this.txtSearchClass.TabIndex = 0;
            this.txtSearchClass.TextChanged += new System.EventHandler(this.txtSearchClass_TextChanged);
            // 
            // txtNameClass
            // 
            this.txtNameClass.Location = new System.Drawing.Point(6, 96);
            this.txtNameClass.Name = "txtNameClass";
            this.txtNameClass.Size = new System.Drawing.Size(100, 20);
            this.txtNameClass.TabIndex = 0;
            // 
            // dtgvClassroom
            // 
            this.dtgvClassroom.AllowUserToAddRows = false;
            this.dtgvClassroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvClassroom.Location = new System.Drawing.Point(12, 205);
            this.dtgvClassroom.Name = "dtgvClassroom";
            this.dtgvClassroom.ReadOnly = true;
            this.dtgvClassroom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvClassroom.Size = new System.Drawing.Size(228, 150);
            this.dtgvClassroom.TabIndex = 0;
            this.dtgvClassroom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvClassroom_CellClick);
            // 
            // dtgvListSubject
            // 
            this.dtgvListSubject.AllowUserToAddRows = false;
            this.dtgvListSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvListSubject.Location = new System.Drawing.Point(246, 205);
            this.dtgvListSubject.Name = "dtgvListSubject";
            this.dtgvListSubject.ReadOnly = true;
            this.dtgvListSubject.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvListSubject.Size = new System.Drawing.Size(213, 150);
            this.dtgvListSubject.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbListSubject);
            this.groupBox2.Controls.Add(this.btnRemoveSubjectFromList);
            this.groupBox2.Controls.Add(this.btnSaveSubjectToList);
            this.groupBox2.Location = new System.Drawing.Point(246, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 138);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Subject";
            // 
            // cbListSubject
            // 
            this.cbListSubject.FormattingEnabled = true;
            this.cbListSubject.Location = new System.Drawing.Point(26, 56);
            this.cbListSubject.Name = "cbListSubject";
            this.cbListSubject.Size = new System.Drawing.Size(121, 21);
            this.cbListSubject.TabIndex = 2;
            // 
            // btnRemoveSubjectFromList
            // 
            this.btnRemoveSubjectFromList.Location = new System.Drawing.Point(116, 93);
            this.btnRemoveSubjectFromList.Name = "btnRemoveSubjectFromList";
            this.btnRemoveSubjectFromList.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSubjectFromList.TabIndex = 1;
            this.btnRemoveSubjectFromList.Text = "Remove";
            this.btnRemoveSubjectFromList.UseVisualStyleBackColor = true;
            this.btnRemoveSubjectFromList.Click += new System.EventHandler(this.btnRemoveSubjectFromList_Click);
            // 
            // btnSaveSubjectToList
            // 
            this.btnSaveSubjectToList.Location = new System.Drawing.Point(26, 93);
            this.btnSaveSubjectToList.Name = "btnSaveSubjectToList";
            this.btnSaveSubjectToList.Size = new System.Drawing.Size(75, 23);
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
            this.dtgvStudent.Location = new System.Drawing.Point(465, 205);
            this.dtgvStudent.Name = "dtgvStudent";
            this.dtgvStudent.ReadOnly = true;
            this.dtgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvStudent.Size = new System.Drawing.Size(630, 150);
            this.dtgvStudent.TabIndex = 3;
            this.dtgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvStudent_CellClick);
            // 
            // groupBox3
            // 
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
            this.groupBox3.Location = new System.Drawing.Point(465, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(630, 138);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student";
            // 
            // btnRefreshStudent
            // 
            this.btnRefreshStudent.Location = new System.Drawing.Point(549, 93);
            this.btnRefreshStudent.Name = "btnRefreshStudent";
            this.btnRefreshStudent.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshStudent.TabIndex = 1;
            this.btnRefreshStudent.Text = "Refresh";
            this.btnRefreshStudent.UseVisualStyleBackColor = true;
            this.btnRefreshStudent.Click += new System.EventHandler(this.btnRefreshStudent_Click);
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
            // txtIDStudent
            // 
            this.txtIDStudent.Location = new System.Drawing.Point(6, 19);
            this.txtIDStudent.Name = "txtIDStudent";
            this.txtIDStudent.ReadOnly = true;
            this.txtIDStudent.Size = new System.Drawing.Size(100, 20);
            this.txtIDStudent.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(6, 57);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(127, 56);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 0;
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
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(6, 95);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 0;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(127, 95);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 0;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(247, 56);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(77, 21);
            this.cbGender.TabIndex = 3;
            // 
            // txtSearchStudent
            // 
            this.txtSearchStudent.Location = new System.Drawing.Point(127, 19);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(100, 20);
            this.txtSearchStudent.TabIndex = 0;
            this.txtSearchStudent.TextChanged += new System.EventHandler(this.txtSearchStudent_TextChanged);
            // 
            // FClassroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 450);
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
    }
}