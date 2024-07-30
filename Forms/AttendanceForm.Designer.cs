namespace SFaSMS
{
    partial class AttendanceForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            dgvAttendance = new DataGridView();
            AttendanceID = new DataGridViewTextBoxColumn();
            StudentID = new DataGridViewTextBoxColumn();
            StudentNameKH = new DataGridViewTextBoxColumn();
            TimeRecorded = new DataGridViewTextBoxColumn();
            DateRecorded = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            txtSearchAttendance = new TextBox();
            labelSearch = new Label();
            labelTimeRecorded = new Label();
            labelDateRecorded = new Label();
            labelClass = new Label();
            cBStudentID = new ComboBox();
            labelStudentID = new Label();
            labelStudentNameKH = new Label();
            txtStudentNameKH = new TextBox();
            labelAttendanceID = new Label();
            cBStatus = new ComboBox();
            labelStatus = new Label();
            txtAttendanceID = new TextBox();
            txtClass = new TextBox();
            txtGeneration = new TextBox();
            labelGeneration = new Label();
            labelStudyYear = new Label();
            dTDateRecorded = new DateTimePicker();
            dTTimeRecorded = new DateTimePicker();
            dTStudyYear = new DateTimePicker();
            btnNew = new Button();
            btnClose = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Columns.AddRange(new DataGridViewColumn[] { AttendanceID, StudentID, StudentNameKH, TimeRecorded, DateRecorded, Status });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvAttendance.DefaultCellStyle = dataGridViewCellStyle2;
            dgvAttendance.Location = new Point(22, 407);
            dgvAttendance.Name = "dgvAttendance";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvAttendance.RowTemplate.Height = 25;
            dgvAttendance.Size = new Size(960, 150);
            dgvAttendance.TabIndex = 50;
            // 
            // AttendanceID
            // 
            AttendanceID.HeaderText = "Attendance ID";
            AttendanceID.Name = "AttendanceID";
            AttendanceID.Width = 160;
            // 
            // StudentID
            // 
            StudentID.HeaderText = "Student ID";
            StudentID.Name = "StudentID";
            StudentID.Width = 130;
            // 
            // StudentNameKH
            // 
            StudentNameKH.HeaderText = "Student Name KH";
            StudentNameKH.Name = "StudentNameKH";
            StudentNameKH.Width = 200;
            // 
            // TimeRecorded
            // 
            TimeRecorded.HeaderText = "Time Recorded";
            TimeRecorded.Name = "TimeRecorded";
            TimeRecorded.Width = 170;
            // 
            // DateRecorded
            // 
            DateRecorded.HeaderText = "Date Recorded";
            DateRecorded.Name = "DateRecorded";
            DateRecorded.Width = 160;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.Width = 95;
            // 
            // txtSearchAttendance
            // 
            txtSearchAttendance.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchAttendance.Location = new Point(267, 358);
            txtSearchAttendance.Name = "txtSearchAttendance";
            txtSearchAttendance.Size = new Size(280, 28);
            txtSearchAttendance.TabIndex = 49;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.Location = new Point(22, 358);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(225, 28);
            labelSearch.TabIndex = 48;
            labelSearch.Text = "Search ( Student ID )";
            // 
            // labelTimeRecorded
            // 
            labelTimeRecorded.AutoSize = true;
            labelTimeRecorded.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTimeRecorded.Location = new Point(22, 203);
            labelTimeRecorded.Name = "labelTimeRecorded";
            labelTimeRecorded.Size = new Size(135, 23);
            labelTimeRecorded.TabIndex = 46;
            labelTimeRecorded.Text = "Time Recorded";
            // 
            // labelDateRecorded
            // 
            labelDateRecorded.AutoSize = true;
            labelDateRecorded.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDateRecorded.Location = new Point(22, 262);
            labelDateRecorded.Name = "labelDateRecorded";
            labelDateRecorded.Size = new Size(132, 23);
            labelDateRecorded.TabIndex = 45;
            labelDateRecorded.Text = "Date Recorded";
            // 
            // labelClass
            // 
            labelClass.AutoSize = true;
            labelClass.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelClass.Location = new Point(381, 149);
            labelClass.Name = "labelClass";
            labelClass.Size = new Size(55, 23);
            labelClass.TabIndex = 42;
            labelClass.Text = "Class";
            // 
            // cBStudentID
            // 
            cBStudentID.DropDownStyle = ComboBoxStyle.DropDownList;
            cBStudentID.Font = new Font("Sitka Small Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBStudentID.FormattingEnabled = true;
            cBStudentID.Location = new Point(488, 95);
            cBStudentID.Name = "cBStudentID";
            cBStudentID.Size = new Size(143, 31);
            cBStudentID.TabIndex = 41;
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentID.Location = new Point(335, 103);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(101, 23);
            labelStudentID.TabIndex = 40;
            labelStudentID.Text = "Student ID";
            // 
            // labelStudentNameKH
            // 
            labelStudentNameKH.AutoSize = true;
            labelStudentNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentNameKH.Location = new Point(22, 149);
            labelStudentNameKH.Name = "labelStudentNameKH";
            labelStudentNameKH.Size = new Size(160, 23);
            labelStudentNameKH.TabIndex = 39;
            labelStudentNameKH.Text = "Student Name KH";
            // 
            // txtStudentNameKH
            // 
            txtStudentNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStudentNameKH.Location = new Point(188, 144);
            txtStudentNameKH.Name = "txtStudentNameKH";
            txtStudentNameKH.ReadOnly = true;
            txtStudentNameKH.Size = new Size(177, 28);
            txtStudentNameKH.TabIndex = 38;
            // 
            // labelAttendanceID
            // 
            labelAttendanceID.AutoSize = true;
            labelAttendanceID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelAttendanceID.Location = new Point(22, 99);
            labelAttendanceID.Name = "labelAttendanceID";
            labelAttendanceID.Size = new Size(130, 23);
            labelAttendanceID.TabIndex = 36;
            labelAttendanceID.Text = "Attendance ID";
            // 
            // cBStatus
            // 
            cBStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cBStatus.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBStatus.FormattingEnabled = true;
            cBStatus.Location = new Point(787, 97);
            cBStatus.Name = "cBStatus";
            cBStatus.Size = new Size(140, 31);
            cBStatus.TabIndex = 57;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStatus.Location = new Point(687, 105);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(64, 23);
            labelStatus.TabIndex = 56;
            labelStatus.Text = "Status";
            // 
            // txtAttendanceID
            // 
            txtAttendanceID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtAttendanceID.Location = new Point(163, 94);
            txtAttendanceID.Name = "txtAttendanceID";
            txtAttendanceID.ReadOnly = true;
            txtAttendanceID.Size = new Size(138, 28);
            txtAttendanceID.TabIndex = 58;
            // 
            // txtClass
            // 
            txtClass.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtClass.Location = new Point(461, 146);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(157, 28);
            txtClass.TabIndex = 59;
            // 
            // txtGeneration
            // 
            txtGeneration.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtGeneration.Location = new Point(642, 198);
            txtGeneration.Name = "txtGeneration";
            txtGeneration.Size = new Size(180, 28);
            txtGeneration.TabIndex = 63;
            // 
            // labelGeneration
            // 
            labelGeneration.AutoSize = true;
            labelGeneration.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelGeneration.Location = new Point(515, 203);
            labelGeneration.Name = "labelGeneration";
            labelGeneration.Size = new Size(103, 23);
            labelGeneration.TabIndex = 62;
            labelGeneration.Text = "Generation";
            // 
            // labelStudyYear
            // 
            labelStudyYear.AutoSize = true;
            labelStudyYear.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudyYear.Location = new Point(24, 309);
            labelStudyYear.Name = "labelStudyYear";
            labelStudyYear.Size = new Size(101, 23);
            labelStudyYear.TabIndex = 61;
            labelStudyYear.Text = "Study Year";
            // 
            // dTDateRecorded
            // 
            dTDateRecorded.CalendarFont = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dTDateRecorded.CustomFormat = "yyyy/MM/dd";
            dTDateRecorded.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dTDateRecorded.Location = new Point(160, 257);
            dTDateRecorded.Name = "dTDateRecorded";
            dTDateRecorded.Size = new Size(326, 28);
            dTDateRecorded.TabIndex = 65;
            // 
            // dTTimeRecorded
            // 
            dTTimeRecorded.CalendarFont = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dTTimeRecorded.CustomFormat = "   hh:mm tt";
            dTTimeRecorded.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dTTimeRecorded.Location = new Point(163, 198);
            dTTimeRecorded.Name = "dTTimeRecorded";
            dTTimeRecorded.Size = new Size(335, 28);
            dTTimeRecorded.TabIndex = 66;
            // 
            // dTStudyYear
            // 
            dTStudyYear.CalendarFont = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dTStudyYear.CustomFormat = "yyyy/MM/dd";
            dTStudyYear.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dTStudyYear.Location = new Point(143, 304);
            dTStudyYear.Name = "dTStudyYear";
            dTStudyYear.Size = new Size(323, 28);
            dTStudyYear.TabIndex = 67;
            // 
            // btnNew
            // 
            btnNew.FlatAppearance.BorderColor = Color.FromArgb(25, 149, 173);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(36, 580);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(121, 49);
            btnNew.TabIndex = 68;
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
            btnClose.Location = new Point(819, 580);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 49);
            btnClose.TabIndex = 71;
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
            btnUpdate.Location = new Point(569, 580);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 49);
            btnUpdate.TabIndex = 70;
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
            btnInsert.Location = new Point(315, 580);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(121, 49);
            btnInsert.TabIndex = 69;
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
            panel1.Size = new Size(998, 89);
            panel1.TabIndex = 72;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 77;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(797, 60);
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
            label1.Location = new Point(132, 31);
            label1.Name = "label1";
            label1.Size = new Size(221, 30);
            label1.TabIndex = 73;
            label1.Text = "Attendance's Form";
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 242);
            ClientSize = new Size(992, 647);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnNew);
            Controls.Add(dTStudyYear);
            Controls.Add(dTTimeRecorded);
            Controls.Add(dTDateRecorded);
            Controls.Add(txtGeneration);
            Controls.Add(labelGeneration);
            Controls.Add(labelStudyYear);
            Controls.Add(txtClass);
            Controls.Add(txtAttendanceID);
            Controls.Add(cBStatus);
            Controls.Add(labelStatus);
            Controls.Add(dgvAttendance);
            Controls.Add(txtSearchAttendance);
            Controls.Add(labelSearch);
            Controls.Add(labelTimeRecorded);
            Controls.Add(labelDateRecorded);
            Controls.Add(labelClass);
            Controls.Add(cBStudentID);
            Controls.Add(labelStudentID);
            Controls.Add(labelStudentNameKH);
            Controls.Add(txtStudentNameKH);
            Controls.Add(labelAttendanceID);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AttendanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AttendanceForm";
            Load += AttendanceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvAttendance;
        private TextBox txtSearchAttendance;
        private Label labelSearch;
        private Label labelTimeRecorded;
        private Label labelDateRecorded;
        private Label labelClass;
        private ComboBox cBStudentID;
        private Label labelStudentID;
        private Label labelStudentNameKH;
        private TextBox txtStudentNameKH;
        private Label labelAttendanceID;
        private ComboBox cBStatus;
        private Label labelStatus;
        private TextBox txtAttendanceID;
        private TextBox txtClass;
        private TextBox txtGeneration;
        private Label labelGeneration;
        private Label labelStudyYear;
        private DateTimePicker dTDateRecorded;
        private DateTimePicker dTTimeRecorded;
        private DateTimePicker dTStudyYear;
        private Button btnNew;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnInsert;
        private DataGridViewTextBoxColumn AttendanceID;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentNameKH;
        private DataGridViewTextBoxColumn TimeRecorded;
        private DataGridViewTextBoxColumn DateRecorded;
        private DataGridViewTextBoxColumn Status;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}