namespace SFaSMS
{
    partial class StudentSummaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentSummaryForm));
            btnNew = new Button();
            picStudent = new PictureBox();
            dTStuSumRegisterDate = new DateTimePicker();
            txtMajorNameKH = new TextBox();
            txtStudentNameKH = new TextBox();
            cBStuSumDegree = new ComboBox();
            txtStuSumID = new TextBox();
            labelMajorNameKH = new Label();
            labelStudentNameKH = new Label();
            labelMajorID = new Label();
            labelRoomNo = new Label();
            labelStudentID = new Label();
            labelDegree = new Label();
            labelRegisterDate = new Label();
            labelStuSum = new Label();
            lsStuSum = new ListBox();
            txtSearchStudentSummary = new TextBox();
            labelSearch = new Label();
            cBStudentID = new ComboBox();
            cBRoomNo = new ComboBox();
            cBMajorID = new ComboBox();
            btnClose = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picStudent).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.FlatAppearance.BorderColor = Color.FromArgb(25, 149, 173);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(73, 527);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(121, 49);
            btnNew.TabIndex = 95;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // picStudent
            // 
            picStudent.BorderStyle = BorderStyle.FixedSingle;
            picStudent.Location = new Point(785, 105);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(145, 185);
            picStudent.SizeMode = PictureBoxSizeMode.Zoom;
            picStudent.TabIndex = 94;
            picStudent.TabStop = false;
            // 
            // dTStuSumRegisterDate
            // 
            dTStuSumRegisterDate.CustomFormat = "yyyy/MM/dd";
            dTStuSumRegisterDate.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dTStuSumRegisterDate.Location = new Point(428, 177);
            dTStuSumRegisterDate.Name = "dTStuSumRegisterDate";
            dTStuSumRegisterDate.Size = new Size(328, 28);
            dTStuSumRegisterDate.TabIndex = 93;
            // 
            // txtMajorNameKH
            // 
            txtMajorNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMajorNameKH.Location = new Point(428, 452);
            txtMajorNameKH.Name = "txtMajorNameKH";
            txtMajorNameKH.ReadOnly = true;
            txtMajorNameKH.Size = new Size(278, 28);
            txtMajorNameKH.TabIndex = 92;
            // 
            // txtStudentNameKH
            // 
            txtStudentNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStudentNameKH.Location = new Point(428, 408);
            txtStudentNameKH.Name = "txtStudentNameKH";
            txtStudentNameKH.ReadOnly = true;
            txtStudentNameKH.Size = new Size(278, 28);
            txtStudentNameKH.TabIndex = 91;
            // 
            // cBStuSumDegree
            // 
            cBStuSumDegree.DropDownStyle = ComboBoxStyle.DropDownList;
            cBStuSumDegree.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBStuSumDegree.FormattingEnabled = true;
            cBStuSumDegree.Location = new Point(428, 221);
            cBStuSumDegree.Name = "cBStuSumDegree";
            cBStuSumDegree.Size = new Size(177, 31);
            cBStuSumDegree.TabIndex = 89;
            // 
            // txtStuSumID
            // 
            txtStuSumID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStuSumID.Location = new Point(428, 134);
            txtStuSumID.Name = "txtStuSumID";
            txtStuSumID.ReadOnly = true;
            txtStuSumID.Size = new Size(162, 28);
            txtStuSumID.TabIndex = 86;
            // 
            // labelMajorNameKH
            // 
            labelMajorNameKH.AutoSize = true;
            labelMajorNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMajorNameKH.Location = new Point(255, 456);
            labelMajorNameKH.Name = "labelMajorNameKH";
            labelMajorNameKH.Size = new Size(144, 23);
            labelMajorNameKH.TabIndex = 85;
            labelMajorNameKH.Text = "Major Name KH";
            // 
            // labelStudentNameKH
            // 
            labelStudentNameKH.AutoSize = true;
            labelStudentNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentNameKH.Location = new Point(255, 412);
            labelStudentNameKH.Name = "labelStudentNameKH";
            labelStudentNameKH.Size = new Size(160, 23);
            labelStudentNameKH.TabIndex = 84;
            labelStudentNameKH.Text = "Student Name KH";
            // 
            // labelMajorID
            // 
            labelMajorID.AutoSize = true;
            labelMajorID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMajorID.Location = new Point(255, 362);
            labelMajorID.Name = "labelMajorID";
            labelMajorID.Size = new Size(85, 23);
            labelMajorID.TabIndex = 83;
            labelMajorID.Text = "Major ID";
            // 
            // labelRoomNo
            // 
            labelRoomNo.AutoSize = true;
            labelRoomNo.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelRoomNo.Location = new Point(255, 315);
            labelRoomNo.Name = "labelRoomNo";
            labelRoomNo.Size = new Size(86, 23);
            labelRoomNo.TabIndex = 82;
            labelRoomNo.Text = "Room No";
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentID.Location = new Point(255, 267);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(101, 23);
            labelStudentID.TabIndex = 81;
            labelStudentID.Text = "Student ID";
            // 
            // labelDegree
            // 
            labelDegree.AutoSize = true;
            labelDegree.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDegree.Location = new Point(255, 221);
            labelDegree.Name = "labelDegree";
            labelDegree.Size = new Size(68, 23);
            labelDegree.TabIndex = 80;
            labelDegree.Text = "Degree";
            // 
            // labelRegisterDate
            // 
            labelRegisterDate.AutoSize = true;
            labelRegisterDate.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelRegisterDate.Location = new Point(255, 177);
            labelRegisterDate.Name = "labelRegisterDate";
            labelRegisterDate.Size = new Size(124, 23);
            labelRegisterDate.TabIndex = 79;
            labelRegisterDate.Text = "Register Date";
            // 
            // labelStuSum
            // 
            labelStuSum.AutoSize = true;
            labelStuSum.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStuSum.Location = new Point(255, 134);
            labelStuSum.Name = "labelStuSum";
            labelStuSum.Size = new Size(100, 23);
            labelStuSum.TabIndex = 78;
            labelStuSum.Text = "StuSum ID";
            // 
            // lsStuSum
            // 
            lsStuSum.Font = new Font("Khmer OS Battambang", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lsStuSum.FormattingEnabled = true;
            lsStuSum.ItemHeight = 29;
            lsStuSum.Location = new Point(21, 170);
            lsStuSum.Name = "lsStuSum";
            lsStuSum.Size = new Size(228, 323);
            lsStuSum.TabIndex = 77;
            // 
            // txtSearchStudentSummary
            // 
            txtSearchStudentSummary.Font = new Font("Khmer OS Battambang", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchStudentSummary.Location = new Point(21, 130);
            txtSearchStudentSummary.Name = "txtSearchStudentSummary";
            txtSearchStudentSummary.Size = new Size(228, 36);
            txtSearchStudentSummary.TabIndex = 76;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.Location = new Point(21, 99);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(112, 28);
            labelSearch.TabIndex = 75;
            labelSearch.Text = "Search By";
            // 
            // cBStudentID
            // 
            cBStudentID.DropDownStyle = ComboBoxStyle.DropDownList;
            cBStudentID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBStudentID.FormattingEnabled = true;
            cBStudentID.Location = new Point(428, 267);
            cBStudentID.Name = "cBStudentID";
            cBStudentID.Size = new Size(153, 31);
            cBStudentID.TabIndex = 100;
            // 
            // cBRoomNo
            // 
            cBRoomNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cBRoomNo.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBRoomNo.FormattingEnabled = true;
            cBRoomNo.Location = new Point(428, 315);
            cBRoomNo.Name = "cBRoomNo";
            cBRoomNo.Size = new Size(187, 31);
            cBRoomNo.TabIndex = 101;
            // 
            // cBMajorID
            // 
            cBMajorID.DropDownStyle = ComboBoxStyle.DropDownList;
            cBMajorID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBMajorID.FormattingEnabled = true;
            cBMajorID.Location = new Point(428, 362);
            cBMajorID.Name = "cBMajorID";
            cBMajorID.Size = new Size(200, 31);
            cBMajorID.TabIndex = 102;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(830, 527);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 49);
            btnClose.TabIndex = 105;
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
            btnUpdate.Location = new Point(585, 527);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 49);
            btnUpdate.TabIndex = 104;
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
            btnInsert.Location = new Point(331, 527);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(121, 49);
            btnInsert.TabIndex = 103;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 89);
            panel1.TabIndex = 194;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 163;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(784, 60);
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
            label1.Location = new Point(126, 29);
            label1.Name = "label1";
            label1.Size = new Size(290, 30);
            label1.TabIndex = 73;
            label1.Text = "StudentSummary's Form";
            // 
            // StudentSummaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 242);
            ClientSize = new Size(975, 596);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(cBMajorID);
            Controls.Add(cBRoomNo);
            Controls.Add(cBStudentID);
            Controls.Add(btnNew);
            Controls.Add(picStudent);
            Controls.Add(dTStuSumRegisterDate);
            Controls.Add(txtMajorNameKH);
            Controls.Add(txtStudentNameKH);
            Controls.Add(cBStuSumDegree);
            Controls.Add(txtStuSumID);
            Controls.Add(labelMajorNameKH);
            Controls.Add(labelStudentNameKH);
            Controls.Add(labelMajorID);
            Controls.Add(labelRoomNo);
            Controls.Add(labelStudentID);
            Controls.Add(labelDegree);
            Controls.Add(labelRegisterDate);
            Controls.Add(labelStuSum);
            Controls.Add(lsStuSum);
            Controls.Add(txtSearchStudentSummary);
            Controls.Add(labelSearch);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "StudentSummaryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentSummaryForm";
            Load += StudentSummaryForm_Load;
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNew;
        private PictureBox picStudent;
        private DateTimePicker dTStuSumRegisterDate;
        private TextBox txtMajorNameKH;
        private TextBox txtStudentNameKH;
        private ComboBox cBStuSumDegree;
        private TextBox txtStuSumID;
        private Label labelMajorNameKH;
        private Label labelStudentNameKH;
        private Label labelMajorID;
        private Label labelRoomNo;
        private Label labelStudentID;
        private Label labelDegree;
        private Label labelRegisterDate;
        private Label labelStuSum;
        private ListBox lsStuSum;
        private TextBox txtSearchStudentSummary;
        private Label labelSearch;
        private ComboBox cBStudentID;
        private ComboBox cBRoomNo;
        private ComboBox cBMajorID;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnInsert;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}