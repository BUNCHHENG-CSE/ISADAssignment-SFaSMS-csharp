namespace SFaSMS
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            btnNew = new Button();
            dTStudentBD = new DateTimePicker();
            txtParentNumber = new TextBox();
            txtPersonalNumber = new TextBox();
            txtStudentAddress = new TextBox();
            cBStudentGender = new ComboBox();
            txtStudentNameEN = new TextBox();
            txtStudentNameKH = new TextBox();
            txtStudentID = new TextBox();
            labelParentNumber = new Label();
            labelPersonalNumber = new Label();
            labelStudentAddress = new Label();
            labelBirthDate = new Label();
            labelGender = new Label();
            labelStudentNameEN = new Label();
            labelStudentNameKH = new Label();
            LabelStudentID = new Label();
            lsStudent = new ListBox();
            txtSearchStudent = new TextBox();
            labelSearch = new Label();
            btnUploadPhoto = new Button();
            picStudent = new PictureBox();
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
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNew.FlatAppearance.BorderColor = Color.FromArgb(25, 149, 173);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(63, 550);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(121, 49);
            btnNew.TabIndex = 70;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // dTStudentBD
            // 
            dTStudentBD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dTStudentBD.CustomFormat = "yyyy/MM/dd";
            dTStudentBD.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dTStudentBD.Location = new Point(431, 310);
            dTStudentBD.Name = "dTStudentBD";
            dTStudentBD.Size = new Size(325, 28);
            dTStudentBD.TabIndex = 67;
            // 
            // txtParentNumber
            // 
            txtParentNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtParentNumber.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtParentNumber.Location = new Point(431, 440);
            txtParentNumber.Name = "txtParentNumber";
            txtParentNumber.Size = new Size(263, 28);
            txtParentNumber.TabIndex = 66;
            // 
            // txtPersonalNumber
            // 
            txtPersonalNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPersonalNumber.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPersonalNumber.Location = new Point(431, 397);
            txtPersonalNumber.Name = "txtPersonalNumber";
            txtPersonalNumber.Size = new Size(263, 28);
            txtPersonalNumber.TabIndex = 65;
            // 
            // txtStudentAddress
            // 
            txtStudentAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtStudentAddress.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStudentAddress.Location = new Point(431, 355);
            txtStudentAddress.Name = "txtStudentAddress";
            txtStudentAddress.Size = new Size(325, 28);
            txtStudentAddress.TabIndex = 64;
            // 
            // cBStudentGender
            // 
            cBStudentGender.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cBStudentGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cBStudentGender.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBStudentGender.FormattingEnabled = true;
            cBStudentGender.Location = new Point(431, 264);
            cBStudentGender.Name = "cBStudentGender";
            cBStudentGender.Size = new Size(188, 31);
            cBStudentGender.TabIndex = 63;
            // 
            // txtStudentNameEN
            // 
            txtStudentNameEN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtStudentNameEN.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStudentNameEN.Location = new Point(431, 220);
            txtStudentNameEN.Name = "txtStudentNameEN";
            txtStudentNameEN.Size = new Size(263, 28);
            txtStudentNameEN.TabIndex = 62;
            // 
            // txtStudentNameKH
            // 
            txtStudentNameKH.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtStudentNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStudentNameKH.Location = new Point(431, 177);
            txtStudentNameKH.Name = "txtStudentNameKH";
            txtStudentNameKH.Size = new Size(263, 28);
            txtStudentNameKH.TabIndex = 61;
            // 
            // txtStudentID
            // 
            txtStudentID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtStudentID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStudentID.Location = new Point(431, 134);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.ReadOnly = true;
            txtStudentID.Size = new Size(127, 28);
            txtStudentID.TabIndex = 60;
            // 
            // labelParentNumber
            // 
            labelParentNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelParentNumber.AutoSize = true;
            labelParentNumber.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelParentNumber.Location = new Point(257, 445);
            labelParentNumber.Name = "labelParentNumber";
            labelParentNumber.Size = new Size(138, 23);
            labelParentNumber.TabIndex = 58;
            labelParentNumber.Text = "Parent Number";
            // 
            // labelPersonalNumber
            // 
            labelPersonalNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelPersonalNumber.AutoSize = true;
            labelPersonalNumber.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPersonalNumber.Location = new Point(257, 402);
            labelPersonalNumber.Name = "labelPersonalNumber";
            labelPersonalNumber.Size = new Size(156, 23);
            labelPersonalNumber.TabIndex = 57;
            labelPersonalNumber.Text = "Personal Number";
            // 
            // labelStudentAddress
            // 
            labelStudentAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelStudentAddress.AutoSize = true;
            labelStudentAddress.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentAddress.Location = new Point(257, 360);
            labelStudentAddress.Name = "labelStudentAddress";
            labelStudentAddress.Size = new Size(150, 23);
            labelStudentAddress.TabIndex = 56;
            labelStudentAddress.Text = "Student Address";
            // 
            // labelBirthDate
            // 
            labelBirthDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelBirthDate.AutoSize = true;
            labelBirthDate.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBirthDate.Location = new Point(257, 315);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(93, 23);
            labelBirthDate.TabIndex = 55;
            labelBirthDate.Text = "BirthDate";
            // 
            // labelGender
            // 
            labelGender.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelGender.Location = new Point(257, 272);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(70, 23);
            labelGender.TabIndex = 54;
            labelGender.Text = "Gender";
            // 
            // labelStudentNameEN
            // 
            labelStudentNameEN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelStudentNameEN.AutoSize = true;
            labelStudentNameEN.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentNameEN.Location = new Point(257, 225);
            labelStudentNameEN.Name = "labelStudentNameEN";
            labelStudentNameEN.Size = new Size(159, 23);
            labelStudentNameEN.TabIndex = 53;
            labelStudentNameEN.Text = "Student Name EN";
            // 
            // labelStudentNameKH
            // 
            labelStudentNameKH.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            labelStudentNameKH.AutoSize = true;
            labelStudentNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentNameKH.Location = new Point(257, 182);
            labelStudentNameKH.Name = "labelStudentNameKH";
            labelStudentNameKH.Size = new Size(160, 23);
            labelStudentNameKH.TabIndex = 52;
            labelStudentNameKH.Text = "Student Name KH";
            // 
            // LabelStudentID
            // 
            LabelStudentID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            LabelStudentID.AutoSize = true;
            LabelStudentID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelStudentID.Location = new Point(257, 139);
            LabelStudentID.Name = "LabelStudentID";
            LabelStudentID.Size = new Size(101, 23);
            LabelStudentID.TabIndex = 51;
            LabelStudentID.Text = "Student ID";
            // 
            // lsStudent
            // 
            lsStudent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lsStudent.Font = new Font("Khmer OS Battambang", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lsStudent.FormattingEnabled = true;
            lsStudent.ItemHeight = 29;
            lsStudent.Location = new Point(23, 169);
            lsStudent.MaximumSize = new Size(311, 0);
            lsStudent.MinimumSize = new Size(211, 352);
            lsStudent.Name = "lsStudent";
            lsStudent.Size = new Size(211, 352);
            lsStudent.TabIndex = 50;
            // 
            // txtSearchStudent
            // 
            txtSearchStudent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchStudent.BorderStyle = BorderStyle.FixedSingle;
            txtSearchStudent.Font = new Font("Khmer OS Battambang", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchStudent.Location = new Point(23, 126);
            txtSearchStudent.MaximumSize = new Size(311, 36);
            txtSearchStudent.MinimumSize = new Size(211, 36);
            txtSearchStudent.Name = "txtSearchStudent";
            txtSearchStudent.Size = new Size(211, 36);
            txtSearchStudent.TabIndex = 49;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.Location = new Point(23, 95);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(112, 28);
            labelSearch.TabIndex = 48;
            labelSearch.Text = "Search By";
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUploadPhoto.Font = new Font("Sitka Small", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnUploadPhoto.Location = new Point(787, 326);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(145, 30);
            btnUploadPhoto.TabIndex = 75;
            btnUploadPhoto.Text = "Upload Photo";
            btnUploadPhoto.UseVisualStyleBackColor = true;
            // 
            // picStudent
            // 
            picStudent.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picStudent.BorderStyle = BorderStyle.FixedSingle;
            picStudent.Location = new Point(787, 135);
            picStudent.Name = "picStudent";
            picStudent.Size = new Size(145, 185);
            picStudent.SizeMode = PictureBoxSizeMode.Zoom;
            picStudent.TabIndex = 76;
            picStudent.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(787, 550);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 49);
            btnClose.TabIndex = 79;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.BackColor = Color.FromArgb(85, 194, 218);
            btnUpdate.FlatAppearance.BorderColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(542, 550);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 49);
            btnUpdate.TabIndex = 78;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnInsert.BackColor = Color.FromArgb(25, 149, 173);
            btnInsert.FlatAppearance.BorderColor = Color.White;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(296, 550);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(121, 49);
            btnInsert.TabIndex = 77;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 89);
            panel1.TabIndex = 193;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 12);
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
            label3.Location = new Point(782, 61);
            label3.Name = "label3";
            label3.Size = new Size(192, 21);
            label3.TabIndex = 75;
            label3.Text = "ISAD M3 GROUP1 2024";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(120, 29);
            label1.Name = "label1";
            label1.Size = new Size(183, 30);
            label1.TabIndex = 73;
            label1.Text = "Student's Form";
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 242);
            ClientSize = new Size(975, 623);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(picStudent);
            Controls.Add(btnUploadPhoto);
            Controls.Add(btnNew);
            Controls.Add(dTStudentBD);
            Controls.Add(txtParentNumber);
            Controls.Add(txtPersonalNumber);
            Controls.Add(txtStudentAddress);
            Controls.Add(cBStudentGender);
            Controls.Add(txtStudentNameEN);
            Controls.Add(txtStudentNameKH);
            Controls.Add(txtStudentID);
            Controls.Add(labelParentNumber);
            Controls.Add(labelPersonalNumber);
            Controls.Add(labelStudentAddress);
            Controls.Add(labelBirthDate);
            Controls.Add(labelGender);
            Controls.Add(labelStudentNameEN);
            Controls.Add(labelStudentNameKH);
            Controls.Add(LabelStudentID);
            Controls.Add(lsStudent);
            Controls.Add(txtSearchStudent);
            Controls.Add(labelSearch);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(991, 662);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentForm";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)picStudent).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNew;
        private DateTimePicker dTStudentBD;
        private TextBox txtParentNumber;
        private TextBox txtPersonalNumber;
        private TextBox txtStudentAddress;
        private ComboBox cBStudentGender;
        private TextBox txtStudentNameEN;
        private TextBox txtStudentNameKH;
        private TextBox txtStudentID;
        private Label labelParentNumber;
        private Label labelPersonalNumber;
        private Label labelStudentAddress;
        private Label labelBirthDate;
        private Label labelGender;
        private Label labelStudentNameEN;
        private Label labelStudentNameKH;
        private Label LabelStudentID;
        private ListBox lsStudent;
        private TextBox txtSearchStudent;
        private Label labelSearch;
        private Button btnUploadPhoto;
        private PictureBox picStudent;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnInsert;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}