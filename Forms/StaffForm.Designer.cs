namespace SFaSMS
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            labelSearch = new Label();
            txtSearchStaff = new TextBox();
            lsStaff = new ListBox();
            LabelStaffID = new Label();
            labelStaffNameKH = new Label();
            labelStaffNameEN = new Label();
            labelGender = new Label();
            labelBirthDate = new Label();
            labelStaffPosition = new Label();
            labelStaffAddress = new Label();
            labelContactNumber = new Label();
            labelHiredDate = new Label();
            txtStaffID = new TextBox();
            txtStaffNameKH = new TextBox();
            cBStaffGender = new ComboBox();
            txtStaffNameEN = new TextBox();
            txtStaffContactNum = new TextBox();
            dTStaffBD = new DateTimePicker();
            dTStaffHiredDate = new DateTimePicker();
            picStaff = new PictureBox();
            btnNew = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnClose = new Button();
            txtStaffPersonalNum = new TextBox();
            labelPersonalNumber = new Label();
            txtStaffAddress = new TextBox();
            btnUploadPhoto = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            cBStaffPosition = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picStaff).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.Location = new Point(15, 97);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(112, 28);
            labelSearch.TabIndex = 1;
            labelSearch.Text = "Search By";
            // 
            // txtSearchStaff
            // 
            txtSearchStaff.BorderStyle = BorderStyle.FixedSingle;
            txtSearchStaff.Font = new Font("Khmer OS Battambang", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchStaff.Location = new Point(16, 128);
            txtSearchStaff.Name = "txtSearchStaff";
            txtSearchStaff.Size = new Size(220, 36);
            txtSearchStaff.TabIndex = 2;
            // 
            // lsStaff
            // 
            lsStaff.Font = new Font("Khmer OS Battambang", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lsStaff.FormattingEnabled = true;
            lsStaff.ItemHeight = 29;
            lsStaff.Location = new Point(15, 170);
            lsStaff.Name = "lsStaff";
            lsStaff.Size = new Size(221, 410);
            lsStaff.TabIndex = 23;
            // 
            // LabelStaffID
            // 
            LabelStaffID.AutoSize = true;
            LabelStaffID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelStaffID.Location = new Point(250, 132);
            LabelStaffID.Name = "LabelStaffID";
            LabelStaffID.Size = new Size(76, 23);
            LabelStaffID.TabIndex = 24;
            LabelStaffID.Text = "Staff ID";
            // 
            // labelStaffNameKH
            // 
            labelStaffNameKH.AutoSize = true;
            labelStaffNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStaffNameKH.Location = new Point(250, 177);
            labelStaffNameKH.Name = "labelStaffNameKH";
            labelStaffNameKH.Size = new Size(135, 23);
            labelStaffNameKH.TabIndex = 25;
            labelStaffNameKH.Text = "Staff Name KH";
            // 
            // labelStaffNameEN
            // 
            labelStaffNameEN.AutoSize = true;
            labelStaffNameEN.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStaffNameEN.Location = new Point(250, 219);
            labelStaffNameEN.Name = "labelStaffNameEN";
            labelStaffNameEN.Size = new Size(134, 23);
            labelStaffNameEN.TabIndex = 26;
            labelStaffNameEN.Text = "Staff Name EN";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelGender.Location = new Point(250, 261);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(70, 23);
            labelGender.TabIndex = 27;
            labelGender.Text = "Gender";
            // 
            // labelBirthDate
            // 
            labelBirthDate.AutoSize = true;
            labelBirthDate.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBirthDate.Location = new Point(250, 306);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(93, 23);
            labelBirthDate.TabIndex = 28;
            labelBirthDate.Text = "BirthDate";
            // 
            // labelStaffPosition
            // 
            labelStaffPosition.AutoSize = true;
            labelStaffPosition.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStaffPosition.Location = new Point(250, 349);
            labelStaffPosition.Name = "labelStaffPosition";
            labelStaffPosition.Size = new Size(126, 23);
            labelStaffPosition.TabIndex = 29;
            labelStaffPosition.Text = "Staff Position";
            // 
            // labelStaffAddress
            // 
            labelStaffAddress.AutoSize = true;
            labelStaffAddress.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStaffAddress.Location = new Point(250, 394);
            labelStaffAddress.Name = "labelStaffAddress";
            labelStaffAddress.Size = new Size(125, 23);
            labelStaffAddress.TabIndex = 30;
            labelStaffAddress.Text = "Staff Address";
            // 
            // labelContactNumber
            // 
            labelContactNumber.AutoSize = true;
            labelContactNumber.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelContactNumber.Location = new Point(250, 439);
            labelContactNumber.Name = "labelContactNumber";
            labelContactNumber.Size = new Size(146, 23);
            labelContactNumber.TabIndex = 31;
            labelContactNumber.Text = "Contact Number";
            // 
            // labelHiredDate
            // 
            labelHiredDate.AutoSize = true;
            labelHiredDate.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelHiredDate.Location = new Point(250, 530);
            labelHiredDate.Name = "labelHiredDate";
            labelHiredDate.Size = new Size(97, 23);
            labelHiredDate.TabIndex = 32;
            labelHiredDate.Text = "HiredDate";
            // 
            // txtStaffID
            // 
            txtStaffID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStaffID.Location = new Point(423, 129);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.ReadOnly = true;
            txtStaffID.Size = new Size(141, 28);
            txtStaffID.TabIndex = 33;
            // 
            // txtStaffNameKH
            // 
            txtStaffNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStaffNameKH.Location = new Point(423, 175);
            txtStaffNameKH.Name = "txtStaffNameKH";
            txtStaffNameKH.Size = new Size(223, 28);
            txtStaffNameKH.TabIndex = 34;
            // 
            // cBStaffGender
            // 
            cBStaffGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cBStaffGender.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBStaffGender.FormattingEnabled = true;
            cBStaffGender.Location = new Point(423, 259);
            cBStaffGender.Name = "cBStaffGender";
            cBStaffGender.Size = new Size(153, 31);
            cBStaffGender.TabIndex = 36;
            // 
            // txtStaffNameEN
            // 
            txtStaffNameEN.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStaffNameEN.Location = new Point(423, 217);
            txtStaffNameEN.Name = "txtStaffNameEN";
            txtStaffNameEN.Size = new Size(253, 28);
            txtStaffNameEN.TabIndex = 35;
            // 
            // txtStaffContactNum
            // 
            txtStaffContactNum.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStaffContactNum.Location = new Point(423, 437);
            txtStaffContactNum.Name = "txtStaffContactNum";
            txtStaffContactNum.Size = new Size(277, 28);
            txtStaffContactNum.TabIndex = 39;
            // 
            // dTStaffBD
            // 
            dTStaffBD.CustomFormat = "yyyy/MM/dd";
            dTStaffBD.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dTStaffBD.Location = new Point(423, 304);
            dTStaffBD.Name = "dTStaffBD";
            dTStaffBD.Size = new Size(313, 28);
            dTStaffBD.TabIndex = 40;
            // 
            // dTStaffHiredDate
            // 
            dTStaffHiredDate.CustomFormat = "yyyy/MM/dd";
            dTStaffHiredDate.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dTStaffHiredDate.Location = new Point(423, 527);
            dTStaffHiredDate.Name = "dTStaffHiredDate";
            dTStaffHiredDate.Size = new Size(325, 28);
            dTStaffHiredDate.TabIndex = 41;
            // 
            // picStaff
            // 
            picStaff.BorderStyle = BorderStyle.FixedSingle;
            picStaff.Location = new Point(799, 145);
            picStaff.Name = "picStaff";
            picStaff.Size = new Size(145, 185);
            picStaff.SizeMode = PictureBoxSizeMode.Zoom;
            picStaff.TabIndex = 42;
            picStaff.TabStop = false;
            // 
            // btnNew
            // 
            btnNew.FlatAppearance.BorderColor = Color.FromArgb(25, 149, 173);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(51, 625);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(121, 49);
            btnNew.TabIndex = 43;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(25, 149, 173);
            btnInsert.FlatAppearance.BorderColor = Color.White;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(301, 625);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(121, 49);
            btnInsert.TabIndex = 44;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(85, 194, 218);
            btnUpdate.FlatAppearance.BorderColor = Color.White;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(555, 625);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 49);
            btnUpdate.TabIndex = 45;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(799, 625);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 49);
            btnClose.TabIndex = 46;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // txtStaffPersonalNum
            // 
            txtStaffPersonalNum.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStaffPersonalNum.Location = new Point(423, 480);
            txtStaffPersonalNum.Name = "txtStaffPersonalNum";
            txtStaffPersonalNum.Size = new Size(277, 28);
            txtStaffPersonalNum.TabIndex = 49;
            // 
            // labelPersonalNumber
            // 
            labelPersonalNumber.AutoSize = true;
            labelPersonalNumber.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPersonalNumber.Location = new Point(250, 482);
            labelPersonalNumber.Name = "labelPersonalNumber";
            labelPersonalNumber.Size = new Size(156, 23);
            labelPersonalNumber.TabIndex = 48;
            labelPersonalNumber.Text = "Personal Number";
            // 
            // txtStaffAddress
            // 
            txtStaffAddress.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStaffAddress.Location = new Point(423, 392);
            txtStaffAddress.Name = "txtStaffAddress";
            txtStaffAddress.Size = new Size(277, 28);
            txtStaffAddress.TabIndex = 38;
            // 
            // btnUploadPhoto
            // 
            btnUploadPhoto.Font = new Font("Sitka Small", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnUploadPhoto.Location = new Point(799, 336);
            btnUploadPhoto.Name = "btnUploadPhoto";
            btnUploadPhoto.Size = new Size(145, 30);
            btnUploadPhoto.TabIndex = 50;
            btnUploadPhoto.Text = "Upload Photo";
            btnUploadPhoto.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 89);
            panel1.TabIndex = 192;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 13);
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
            label3.Location = new Point(782, 62);
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
            label1.Location = new Point(112, 31);
            label1.Name = "label1";
            label1.Size = new Size(152, 30);
            label1.TabIndex = 73;
            label1.Text = "Staff's Form";
            // 
            // cBStaffPosition
            // 
            cBStaffPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cBStaffPosition.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBStaffPosition.FormattingEnabled = true;
            cBStaffPosition.Location = new Point(423, 346);
            cBStaffPosition.Name = "cBStaffPosition";
            cBStaffPosition.Size = new Size(313, 31);
            cBStaffPosition.TabIndex = 193;
            // 
            // StaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 242);
            ClientSize = new Size(975, 692);
            Controls.Add(cBStaffPosition);
            Controls.Add(panel1);
            Controls.Add(btnUploadPhoto);
            Controls.Add(txtStaffPersonalNum);
            Controls.Add(labelPersonalNumber);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(btnNew);
            Controls.Add(picStaff);
            Controls.Add(dTStaffHiredDate);
            Controls.Add(dTStaffBD);
            Controls.Add(txtStaffContactNum);
            Controls.Add(txtStaffAddress);
            Controls.Add(cBStaffGender);
            Controls.Add(txtStaffNameEN);
            Controls.Add(txtStaffNameKH);
            Controls.Add(txtStaffID);
            Controls.Add(labelHiredDate);
            Controls.Add(labelContactNumber);
            Controls.Add(labelStaffAddress);
            Controls.Add(labelStaffPosition);
            Controls.Add(labelBirthDate);
            Controls.Add(labelGender);
            Controls.Add(labelStaffNameEN);
            Controls.Add(labelStaffNameKH);
            Controls.Add(LabelStaffID);
            Controls.Add(lsStaff);
            Controls.Add(txtSearchStaff);
            Controls.Add(labelSearch);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "StaffForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StaffForm";
            Load += StaffForm_Load;
            ((System.ComponentModel.ISupportInitialize)picStaff).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSearch;
        private TextBox txtSearchStaff;
        private ListBox lsStaff;
        private Label LabelStaffID;
        private Label labelStaffNameKH;
        private Label labelStaffNameEN;
        private Label labelGender;
        private Label labelBirthDate;
        private Label labelStaffPosition;
        private Label labelStaffAddress;
        private Label labelContactNumber;
        private Label labelHiredDate;
        private TextBox txtStaffID;
        private TextBox txtStaffNameKH;
        private ComboBox cBStaffGender;
        private TextBox txtStaffNameEN;
        private TextBox txtStaffContactNum;
        private DateTimePicker dTStaffBD;
        private DateTimePicker dTStaffHiredDate;
        private PictureBox picStaff;
        private Button btnNew;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnClose;
        private TextBox txtStaffPersonalNum;
        private Label labelPersonalNumber;
        private TextBox txtStaffAddress;
        private Button btnUploadPhoto;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private ComboBox cBStaffPosition;
    }
}