namespace SFaSMS
{
    partial class ExamForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamForm));
            labelSubjectID = new Label();
            cBSubjectID = new ComboBox();
            txtExamScore = new TextBox();
            labelExamScore = new Label();
            labelStudentID = new Label();
            cBStudentID = new ComboBox();
            labelGrade = new Label();
            labelGPA = new Label();
            labelSubjectName = new Label();
            txtSubjectName = new TextBox();
            labelSearch = new Label();
            txtSearchExam = new TextBox();
            dgvExam = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            SubjectID = new DataGridViewTextBoxColumn();
            SubjectName = new DataGridViewTextBoxColumn();
            ExamScore = new DataGridViewTextBoxColumn();
            GPA = new DataGridViewTextBoxColumn();
            btnNew = new Button();
            btnClose = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            txtGrade = new TextBox();
            txtGPA = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvExam).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelSubjectID
            // 
            labelSubjectID.AutoSize = true;
            labelSubjectID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSubjectID.Location = new Point(22, 110);
            labelSubjectID.Name = "labelSubjectID";
            labelSubjectID.Size = new Size(96, 23);
            labelSubjectID.TabIndex = 5;
            labelSubjectID.Text = "Subject ID";
            // 
            // cBSubjectID
            // 
            cBSubjectID.DropDownStyle = ComboBoxStyle.DropDownList;
            cBSubjectID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBSubjectID.FormattingEnabled = true;
            cBSubjectID.Location = new Point(154, 106);
            cBSubjectID.Name = "cBSubjectID";
            cBSubjectID.Size = new Size(140, 31);
            cBSubjectID.TabIndex = 17;
            // 
            // txtExamScore
            // 
            txtExamScore.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtExamScore.Location = new Point(154, 158);
            txtExamScore.Name = "txtExamScore";
            txtExamScore.Size = new Size(158, 28);
            txtExamScore.TabIndex = 18;
            // 
            // labelExamScore
            // 
            labelExamScore.AutoSize = true;
            labelExamScore.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelExamScore.Location = new Point(22, 166);
            labelExamScore.Name = "labelExamScore";
            labelExamScore.Size = new Size(108, 23);
            labelExamScore.TabIndex = 19;
            labelExamScore.Text = "Exam Score";
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentID.Location = new Point(344, 110);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(101, 23);
            labelStudentID.TabIndex = 20;
            labelStudentID.Text = "Student ID";
            // 
            // cBStudentID
            // 
            cBStudentID.DropDownStyle = ComboBoxStyle.DropDownList;
            cBStudentID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBStudentID.FormattingEnabled = true;
            cBStudentID.Location = new Point(470, 106);
            cBStudentID.Name = "cBStudentID";
            cBStudentID.Size = new Size(121, 31);
            cBStudentID.TabIndex = 21;
            // 
            // labelGrade
            // 
            labelGrade.AutoSize = true;
            labelGrade.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelGrade.Location = new Point(344, 166);
            labelGrade.Name = "labelGrade";
            labelGrade.Size = new Size(60, 23);
            labelGrade.TabIndex = 22;
            labelGrade.Text = "Grade";
            // 
            // labelGPA
            // 
            labelGPA.AutoSize = true;
            labelGPA.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelGPA.Location = new Point(487, 222);
            labelGPA.Name = "labelGPA";
            labelGPA.Size = new Size(44, 23);
            labelGPA.TabIndex = 25;
            labelGPA.Text = "GPA";
            // 
            // labelSubjectName
            // 
            labelSubjectName.AutoSize = true;
            labelSubjectName.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSubjectName.Location = new Point(22, 220);
            labelSubjectName.Name = "labelSubjectName";
            labelSubjectName.Size = new Size(124, 23);
            labelSubjectName.TabIndex = 26;
            labelSubjectName.Text = "Subject Name";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubjectName.Location = new Point(157, 214);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.ReadOnly = true;
            txtSubjectName.Size = new Size(313, 28);
            txtSubjectName.TabIndex = 27;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.Location = new Point(22, 271);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(225, 28);
            labelSearch.TabIndex = 28;
            labelSearch.Text = "Search ( Student ID )";
            // 
            // txtSearchExam
            // 
            txtSearchExam.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchExam.Location = new Point(264, 271);
            txtSearchExam.Name = "txtSearchExam";
            txtSearchExam.Size = new Size(256, 28);
            txtSearchExam.TabIndex = 29;
            // 
            // dgvExam
            // 
            dgvExam.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvExam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvExam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExam.Columns.AddRange(new DataGridViewColumn[] { StudentID, SubjectID, SubjectName, ExamScore, GPA });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvExam.DefaultCellStyle = dataGridViewCellStyle3;
            dgvExam.Location = new Point(16, 323);
            dgvExam.Name = "dgvExam";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvExam.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvExam.RowTemplate.Height = 25;
            dgvExam.Size = new Size(744, 150);
            dgvExam.TabIndex = 30;
            // 
            // StudentID
            // 
            dataGridViewCellStyle2.Font = new Font("Sitka Small", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            StudentID.DefaultCellStyle = dataGridViewCellStyle2;
            StudentID.HeaderText = "Student ID";
            StudentID.Name = "StudentID";
            StudentID.Width = 130;
            // 
            // SubjectID
            // 
            SubjectID.HeaderText = "Subject ID";
            SubjectID.Name = "SubjectID";
            SubjectID.Width = 130;
            // 
            // SubjectName
            // 
            SubjectName.HeaderText = "Subject Name";
            SubjectName.Name = "SubjectName";
            SubjectName.Width = 200;
            // 
            // ExamScore
            // 
            ExamScore.HeaderText = "Exam Score";
            ExamScore.Name = "ExamScore";
            ExamScore.Width = 140;
            // 
            // GPA
            // 
            GPA.HeaderText = "GPA";
            GPA.Name = "GPA";
            // 
            // btnNew
            // 
            btnNew.FlatAppearance.BorderColor = Color.FromArgb(25, 149, 173);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(25, 494);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(121, 49);
            btnNew.TabIndex = 31;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(604, 494);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 49);
            btnClose.TabIndex = 49;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(85, 194, 218);
            btnUpdate.FlatAppearance.BorderColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(421, 494);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 49);
            btnUpdate.TabIndex = 48;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(25, 149, 173);
            btnInsert.FlatAppearance.BorderColor = Color.White;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(218, 494);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(121, 49);
            btnInsert.TabIndex = 47;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(779, 89);
            panel1.TabIndex = 73;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 78;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(580, 59);
            label3.Name = "label3";
            label3.Size = new Size(192, 21);
            label3.TabIndex = 76;
            label3.Text = "ISAD M3 GROUP1 2024";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(124, 30);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 73;
            label1.Text = "Exam's Form";
            // 
            // txtGrade
            // 
            txtGrade.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtGrade.Location = new Point(433, 158);
            txtGrade.Name = "txtGrade";
            txtGrade.ReadOnly = true;
            txtGrade.Size = new Size(158, 28);
            txtGrade.TabIndex = 74;
            // 
            // txtGPA
            // 
            txtGPA.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtGPA.Location = new Point(537, 215);
            txtGPA.Name = "txtGPA";
            txtGPA.ReadOnly = true;
            txtGPA.Size = new Size(158, 28);
            txtGPA.TabIndex = 75;
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 242);
            ClientSize = new Size(777, 562);
            Controls.Add(txtGPA);
            Controls.Add(txtGrade);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnNew);
            Controls.Add(dgvExam);
            Controls.Add(txtSearchExam);
            Controls.Add(labelSearch);
            Controls.Add(txtSubjectName);
            Controls.Add(labelSubjectName);
            Controls.Add(labelGPA);
            Controls.Add(labelGrade);
            Controls.Add(cBStudentID);
            Controls.Add(labelStudentID);
            Controls.Add(labelExamScore);
            Controls.Add(txtExamScore);
            Controls.Add(cBSubjectID);
            Controls.Add(labelSubjectID);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExamForm";
            Load += ExamForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExam).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSubjectID;
        private ComboBox cBSubjectID;
        private TextBox txtExamScore;
        private Label labelExamScore;
        private Label labelStudentID;
        private ComboBox cBStudentID;
        private Label labelGrade;
        private Label labelGPA;
        private Label labelSubjectName;
        private TextBox txtSubjectName;
        private Label labelSearch;
        private TextBox txtSearchExam;
        private DataGridView dgvExam;
        private Button btnNew;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnInsert;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn SubjectID;
        private DataGridViewTextBoxColumn SubjectName;
        private DataGridViewTextBoxColumn ExamScore;
        private DataGridViewTextBoxColumn GPA;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox txtGrade;
        private TextBox txtGPA;
    }
}