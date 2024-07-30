namespace SFaSMS
{
    partial class LecturerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerForm));
            btnNew = new Button();
            dTLecturerBD = new DateTimePicker();
            txtLecturerAddress = new TextBox();
            txtLecturerPersonalNum = new TextBox();
            txtLecturerContactNum = new TextBox();
            cBLecturerGender = new ComboBox();
            txtLecturerNameEN = new TextBox();
            txtLecturerNameKH = new TextBox();
            txtLecturerID = new TextBox();
            labelLecturerAddress = new Label();
            labelPersonalNumber = new Label();
            labelContactNumber = new Label();
            labelBirthDate = new Label();
            labelGender = new Label();
            labelLecturerNameEN = new Label();
            labelLecturerNameKH = new Label();
            LabelLecturerID = new Label();
            lsLecturer = new ListBox();
            txtSearchLecturer = new TextBox();
            labelSearch = new Label();
            btnUploadPhoto = new Button();
            picLecturer = new PictureBox();
            btnClose = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)picLecturer).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.FlatAppearance.BorderColor = Color.FromArgb(25, 149, 173);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(50, 546);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(121, 49);
            btnNew.TabIndex = 95;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // dTLecturerBD
            // 
            dTLecturerBD.CustomFormat = "yyyy/MM/dd";
            dTLecturerBD.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dTLecturerBD.Location = new Point(428, 311);
            dTLecturerBD.Name = "dTLecturerBD";
            dTLecturerBD.Size = new Size(328, 28);
            dTLecturerBD.TabIndex = 93;
            // 
            // txtLecturerAddress
            // 
            txtLecturerAddress.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLecturerAddress.Location = new Point(428, 454);
            txtLecturerAddress.Name = "txtLecturerAddress";
            txtLecturerAddress.Size = new Size(348, 28);
            txtLecturerAddress.TabIndex = 92;
            // 
            // txtLecturerPersonalNum
            // 
            txtLecturerPersonalNum.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLecturerPersonalNum.Location = new Point(428, 408);
            txtLecturerPersonalNum.Name = "txtLecturerPersonalNum";
            txtLecturerPersonalNum.Size = new Size(284, 28);
            txtLecturerPersonalNum.TabIndex = 91;
            // 
            // txtLecturerContactNum
            // 
            txtLecturerContactNum.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLecturerContactNum.Location = new Point(428, 359);
            txtLecturerContactNum.Name = "txtLecturerContactNum";
            txtLecturerContactNum.Size = new Size(284, 28);
            txtLecturerContactNum.TabIndex = 90;
            // 
            // cBLecturerGender
            // 
            cBLecturerGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cBLecturerGender.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBLecturerGender.FormattingEnabled = true;
            cBLecturerGender.Location = new Point(428, 264);
            cBLecturerGender.Name = "cBLecturerGender";
            cBLecturerGender.Size = new Size(176, 31);
            cBLecturerGender.TabIndex = 89;
            // 
            // txtLecturerNameEN
            // 
            txtLecturerNameEN.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLecturerNameEN.Location = new Point(428, 219);
            txtLecturerNameEN.Name = "txtLecturerNameEN";
            txtLecturerNameEN.Size = new Size(271, 28);
            txtLecturerNameEN.TabIndex = 88;
            // 
            // txtLecturerNameKH
            // 
            txtLecturerNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLecturerNameKH.Location = new Point(428, 172);
            txtLecturerNameKH.Name = "txtLecturerNameKH";
            txtLecturerNameKH.Size = new Size(271, 28);
            txtLecturerNameKH.TabIndex = 87;
            // 
            // txtLecturerID
            // 
            txtLecturerID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLecturerID.Location = new Point(428, 125);
            txtLecturerID.Name = "txtLecturerID";
            txtLecturerID.ReadOnly = true;
            txtLecturerID.Size = new Size(200, 28);
            txtLecturerID.TabIndex = 86;
            // 
            // labelLecturerAddress
            // 
            labelLecturerAddress.AutoSize = true;
            labelLecturerAddress.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelLecturerAddress.Location = new Point(252, 459);
            labelLecturerAddress.Name = "labelLecturerAddress";
            labelLecturerAddress.Size = new Size(155, 23);
            labelLecturerAddress.TabIndex = 85;
            labelLecturerAddress.Text = "Lecturer Address";
            // 
            // labelPersonalNumber
            // 
            labelPersonalNumber.AutoSize = true;
            labelPersonalNumber.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPersonalNumber.Location = new Point(252, 413);
            labelPersonalNumber.Name = "labelPersonalNumber";
            labelPersonalNumber.Size = new Size(156, 23);
            labelPersonalNumber.TabIndex = 84;
            labelPersonalNumber.Text = "Personal Number";
            // 
            // labelContactNumber
            // 
            labelContactNumber.AutoSize = true;
            labelContactNumber.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelContactNumber.Location = new Point(252, 364);
            labelContactNumber.Name = "labelContactNumber";
            labelContactNumber.Size = new Size(146, 23);
            labelContactNumber.TabIndex = 83;
            labelContactNumber.Text = "Contact Number";
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBirthDate.Location = new Point(252, 315);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(93, 23);
            labelBirthDate.TabIndex = 82;
            labelBirthDate.Text = "BirthDate";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelGender.Location = new Point(252, 272);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(70, 23);
            labelGender.TabIndex = 81;
            labelGender.Text = "Gender";
            // 
            // labelLecturerNameEN
            // 
            labelLecturerNameEN.AutoSize = true;
            labelLecturerNameEN.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelLecturerNameEN.Location = new Point(252, 224);
            labelLecturerNameEN.Name = "labelLecturerNameEN";
            labelLecturerNameEN.Size = new Size(164, 23);
            labelLecturerNameEN.TabIndex = 80;
            labelLecturerNameEN.Text = "Lecturer Name EN";
            // 
            // labelLecturerNameKH
            // 
            labelLecturerNameKH.AutoSize = true;
            labelLecturerNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelLecturerNameKH.Location = new Point(252, 177);
            labelLecturerNameKH.Name = "labelLecturerNameKH";
            labelLecturerNameKH.Size = new Size(160, 23);
            labelLecturerNameKH.TabIndex = 79;
            labelLecturerNameKH.Text = "LecturerName KH";
            // 
            // LabelLecturerID
            // 
            LabelLecturerID.AutoSize = true;
            LabelLecturerID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelLecturerID.Location = new Point(252, 132);
            LabelLecturerID.Name = "LabelLecturerID";
            LabelLecturerID.Size = new Size(106, 23);
            LabelLecturerID.TabIndex = 78;
            LabelLecturerID.Text = "Lecturer ID";
            // 
            // lsLecturer
            // 
            lsLecturer.Font = new Font("Khmer OS Battambang", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lsLecturer.FormattingEnabled = true;
            lsLecturer.ItemHeight = 29;
            lsLecturer.Location = new Point(13, 176);
            lsLecturer.Name = "lsLecturer";
            lsLecturer.Size = new Size(211, 352);
            lsLecturer.TabIndex = 77;
            // 
            // txtSearchLecturer
            // 
            txtSearchLecturer.BorderStyle = BorderStyle.FixedSingle;
            txtSearchLecturer.Font = new Font("Khmer OS Battambang", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchLecturer.Location = new Point(13, 130);
            txtSearchLecturer.Name = "txtSearchLecturer";
            txtSearchLecturer.Size = new Size(211, 36);
            txtSearchLecturer.TabIndex = 76;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.Location = new Point(13, 99);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(112, 28);
            labelSearch.TabIndex = 75;
            labelSearch.Text = "Search By";
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.FlatAppearance.BorderColor = Color.FromArgb(25, 149, 173);
            btnUploadPhoto.Font = new Font("Sitka Small", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnUploadPhoto.Location = new Point(815, 315);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(145, 30);
            btnUploadPhoto.TabIndex = 100;
            btnUploadPhoto.Text = "Upload Photo";
            btnUploadPhoto.UseVisualStyleBackColor = true;
            // 
            // picLecturer
            // 
            picLecturer.BorderStyle = BorderStyle.FixedSingle;
            picLecturer.Location = new Point(815, 120);
            picLecturer.Name = "picLecturer";
            picLecturer.Size = new Size(145, 185);
            picLecturer.SizeMode = PictureBoxSizeMode.Zoom;
            picLecturer.TabIndex = 101;
            picLecturer.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(815, 546);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 49);
            btnClose.TabIndex = 104;
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
            btnUpdate.Location = new Point(578, 546);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 49);
            btnUpdate.TabIndex = 103;
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
            btnInsert.Location = new Point(313, 546);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(121, 49);
            btnInsert.TabIndex = 102;
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
            panel1.Size = new Size(989, 89);
            panel1.TabIndex = 161;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 162;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(791, 63);
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
            label1.Location = new Point(109, 27);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 73;
            label1.Text = "Lecturer's Form";
            // 
            // LecturerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 242);
            ClientSize = new Size(986, 612);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(picLecturer);
            Controls.Add(btnUploadPhoto);
            Controls.Add(btnNew);
            Controls.Add(dTLecturerBD);
            Controls.Add(txtLecturerAddress);
            Controls.Add(txtLecturerPersonalNum);
            Controls.Add(txtLecturerContactNum);
            Controls.Add(cBLecturerGender);
            Controls.Add(txtLecturerNameEN);
            Controls.Add(txtLecturerNameKH);
            Controls.Add(txtLecturerID);
            Controls.Add(labelLecturerAddress);
            Controls.Add(labelPersonalNumber);
            Controls.Add(labelContactNumber);
            Controls.Add(labelBirthDate);
            Controls.Add(labelGender);
            Controls.Add(labelLecturerNameEN);
            Controls.Add(labelLecturerNameKH);
            Controls.Add(LabelLecturerID);
            Controls.Add(lsLecturer);
            Controls.Add(txtSearchLecturer);
            Controls.Add(labelSearch);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LecturerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LecturerForm";
            Load += LecturerForm_Load;
            ((System.ComponentModel.ISupportInitialize)picLecturer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNew;
        private DateTimePicker dTLecturerBD;
        private TextBox txtLecturerAddress;
        private TextBox txtLecturerPersonalNum;
        private TextBox txtLecturerContactNum;
        private ComboBox cBLecturerGender;
        private TextBox txtLecturerNameEN;
        private TextBox txtLecturerNameKH;
        private TextBox txtLecturerID;
        private Label labelLecturerAddress;
        private Label labelPersonalNumber;
        private Label labelContactNumber;
        private Label labelBirthDate;
        private Label labelGender;
        private Label labelLecturerNameEN;
        private Label labelLecturerNameKH;
        private Label LabelLecturerID;
        private ListBox lsLecturer;
        private TextBox txtSearchLecturer;
        private Label labelSearch;
        private Button btnUploadPhoto;
        private PictureBox picLecturer;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnInsert;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}