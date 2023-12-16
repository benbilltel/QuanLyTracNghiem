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
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRefreshSubject);
            this.groupBox1.Controls.Add(this.btnSaveSubject);
            this.groupBox1.Controls.Add(this.txtIDSubject);
            this.groupBox1.Controls.Add(this.txtNameSubject);
            this.groupBox1.Controls.Add(this.txtSearchSubject);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 305);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subject";
            // 
            // btnRefreshSubject
            // 
            this.btnRefreshSubject.BackColor = System.Drawing.Color.White;
            this.btnRefreshSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSubject.Location = new System.Drawing.Point(141, 208);
            this.btnRefreshSubject.Name = "btnRefreshSubject";
            this.btnRefreshSubject.Size = new System.Drawing.Size(71, 33);
            this.btnRefreshSubject.TabIndex = 1;
            this.btnRefreshSubject.Text = "Refresh";
            this.btnRefreshSubject.UseVisualStyleBackColor = false;
            this.btnRefreshSubject.Click += new System.EventHandler(this.btnRefreshSubject_Click);
            // 
            // btnSaveSubject
            // 
            this.btnSaveSubject.BackColor = System.Drawing.Color.White;
            this.btnSaveSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSubject.Location = new System.Drawing.Point(19, 208);
            this.btnSaveSubject.Name = "btnSaveSubject";
            this.btnSaveSubject.Size = new System.Drawing.Size(71, 33);
            this.btnSaveSubject.TabIndex = 1;
            this.btnSaveSubject.Text = "Save";
            this.btnSaveSubject.UseVisualStyleBackColor = false;
            this.btnSaveSubject.Click += new System.EventHandler(this.btnSaveSubject_Click);
            // 
            // txtIDSubject
            // 
            this.txtIDSubject.Location = new System.Drawing.Point(19, 58);
            this.txtIDSubject.Name = "txtIDSubject";
            this.txtIDSubject.ReadOnly = true;
            this.txtIDSubject.Size = new System.Drawing.Size(193, 22);
            this.txtIDSubject.TabIndex = 0;
            // 
            // txtSearchSubject
            // 
            this.txtSearchSubject.Location = new System.Drawing.Point(19, 110);
            this.txtSearchSubject.Name = "txtSearchSubject";
            this.txtSearchSubject.Size = new System.Drawing.Size(193, 22);
            this.txtSearchSubject.TabIndex = 0;
            this.txtSearchSubject.TextChanged += new System.EventHandler(this.txtSearchSubject_TextChanged);
            // 
            // txtNameSubject
            // 
            this.txtNameSubject.Location = new System.Drawing.Point(19, 165);
            this.txtNameSubject.Name = "txtNameSubject";
            this.txtNameSubject.Size = new System.Drawing.Size(193, 22);
            this.txtNameSubject.TabIndex = 0;
            // 
            // dtgvSubject
            // 
            this.dtgvSubject.AllowUserToAddRows = false;
            this.dtgvSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvSubject.Location = new System.Drawing.Point(12, 329);
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
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnRefreshChapter);
            this.groupBox2.Controls.Add(this.btnSaveChapter);
            this.groupBox2.Controls.Add(this.txtIDChapter);
            this.groupBox2.Controls.Add(this.txtNameChapter);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(267, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 305);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chapter";
            // 
            // btnRefreshChapter
            // 
            this.btnRefreshChapter.BackColor = System.Drawing.Color.White;
            this.btnRefreshChapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshChapter.Location = new System.Drawing.Point(138, 147);
            this.btnRefreshChapter.Name = "btnRefreshChapter";
            this.btnRefreshChapter.Size = new System.Drawing.Size(71, 33);
            this.btnRefreshChapter.TabIndex = 1;
            this.btnRefreshChapter.Text = "Refresh";
            this.btnRefreshChapter.UseVisualStyleBackColor = false;
            this.btnRefreshChapter.Click += new System.EventHandler(this.btnRefreshChapter_Click);
            // 
            // btnSaveChapter
            // 
            this.btnSaveChapter.BackColor = System.Drawing.Color.White;
            this.btnSaveChapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChapter.Location = new System.Drawing.Point(20, 147);
            this.btnSaveChapter.Name = "btnSaveChapter";
            this.btnSaveChapter.Size = new System.Drawing.Size(71, 33);
            this.btnSaveChapter.TabIndex = 1;
            this.btnSaveChapter.Text = "Save";
            this.btnSaveChapter.UseVisualStyleBackColor = false;
            this.btnSaveChapter.Click += new System.EventHandler(this.btnSaveChapter_Click);
            // 
            // txtIDChapter
            // 
            this.txtIDChapter.Location = new System.Drawing.Point(20, 58);
            this.txtIDChapter.Name = "txtIDChapter";
            this.txtIDChapter.ReadOnly = true;
            this.txtIDChapter.Size = new System.Drawing.Size(189, 22);
            this.txtIDChapter.TabIndex = 0;
            // 
            // txtNameChapter
            // 
            this.txtNameChapter.Location = new System.Drawing.Point(20, 110);
            this.txtNameChapter.Name = "txtNameChapter";
            this.txtNameChapter.Size = new System.Drawing.Size(189, 22);
            this.txtNameChapter.TabIndex = 0;
            // 
            // dtgvChapter
            // 
            this.dtgvChapter.AllowUserToAddRows = false;
            this.dtgvChapter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChapter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgvChapter.Location = new System.Drawing.Point(267, 329);
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
            this.dtgvQuestion.Location = new System.Drawing.Point(520, 329);
            this.dtgvQuestion.Name = "dtgvQuestion";
            this.dtgvQuestion.ReadOnly = true;
            this.dtgvQuestion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvQuestion.Size = new System.Drawing.Size(627, 150);
            this.dtgvQuestion.TabIndex = 5;
            this.dtgvQuestion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvQuestion_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
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
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(520, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(627, 311);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Question";
            // 
            // txtSearchQuestion
            // 
            this.txtSearchQuestion.Location = new System.Drawing.Point(208, 58);
            this.txtSearchQuestion.Name = "txtSearchQuestion";
            this.txtSearchQuestion.Size = new System.Drawing.Size(382, 22);
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
            this.cbAnswer.Location = new System.Drawing.Point(476, 108);
            this.cbAnswer.Name = "cbAnswer";
            this.cbAnswer.Size = new System.Drawing.Size(114, 24);
            this.cbAnswer.TabIndex = 3;
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.BackColor = System.Drawing.Color.White;
            this.btnRemoveStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveStudent.Location = new System.Drawing.Point(427, 272);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(71, 33);
            this.btnRemoveStudent.TabIndex = 2;
            this.btnRemoveStudent.Text = "Remove";
            this.btnRemoveStudent.UseVisualStyleBackColor = false;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // btnRefreshQuestion
            // 
            this.btnRefreshQuestion.BackColor = System.Drawing.Color.White;
            this.btnRefreshQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshQuestion.Location = new System.Drawing.Point(519, 272);
            this.btnRefreshQuestion.Name = "btnRefreshQuestion";
            this.btnRefreshQuestion.Size = new System.Drawing.Size(71, 33);
            this.btnRefreshQuestion.TabIndex = 1;
            this.btnRefreshQuestion.Text = "Refresh";
            this.btnRefreshQuestion.UseVisualStyleBackColor = false;
            this.btnRefreshQuestion.Click += new System.EventHandler(this.btnRefreshQuestion_Click);
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.BackColor = System.Drawing.Color.White;
            this.btnSaveStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStudent.Location = new System.Drawing.Point(329, 272);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(71, 33);
            this.btnSaveStudent.TabIndex = 1;
            this.btnSaveStudent.Text = "Save";
            this.btnSaveStudent.UseVisualStyleBackColor = false;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // txtIDQuestion
            // 
            this.txtIDQuestion.Location = new System.Drawing.Point(21, 58);
            this.txtIDQuestion.Name = "txtIDQuestion";
            this.txtIDQuestion.ReadOnly = true;
            this.txtIDQuestion.Size = new System.Drawing.Size(165, 22);
            this.txtIDQuestion.TabIndex = 0;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(329, 235);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(261, 22);
            this.txtD.TabIndex = 0;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(21, 110);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(422, 49);
            this.txtContent.TabIndex = 0;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(21, 235);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(258, 22);
            this.txtC.TabIndex = 0;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(21, 186);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(261, 22);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(329, 186);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(261, 22);
            this.txtB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Subject ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subject Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chapter ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Chapter Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Question ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Content";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(205, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Search";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(473, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Answer";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(326, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "B";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "C";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(326, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "D";
            // 
            // FSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1159, 498);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}