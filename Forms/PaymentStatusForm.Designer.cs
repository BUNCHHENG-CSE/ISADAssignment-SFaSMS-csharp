namespace SFaSMS
{
    partial class PaymentStatusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentStatusForm));
            cBStudentID = new ComboBox();
            txtStudentNameKH = new TextBox();
            btnNew = new Button();
            txtPaymentStatusID = new TextBox();
            labelStaffNameKH = new Label();
            labelStudentID = new Label();
            labelOneYearStatus = new Label();
            labelSemesterTwoStatus = new Label();
            labelSemesterOneStatus = new Label();
            labelPaymentStausID = new Label();
            lsPaymentStatus = new ListBox();
            txtSearchPaymentStatus = new TextBox();
            labelSearch = new Label();
            cBSemesterOneStatus = new ComboBox();
            cBSemesterTwoStatus = new ComboBox();
            cBOneYearStatus = new ComboBox();
            btnClose = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cBStudentID
            // 
            cBStudentID.DropDownStyle = ComboBoxStyle.DropDownList;
            cBStudentID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBStudentID.FormattingEnabled = true;
            cBStudentID.Location = new Point(438, 354);
            cBStudentID.Name = "cBStudentID";
            cBStudentID.Size = new Size(152, 31);
            cBStudentID.TabIndex = 183;
            // 
            // txtStudentNameKH
            // 
            txtStudentNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStudentNameKH.Location = new Point(438, 401);
            txtStudentNameKH.Name = "txtStudentNameKH";
            txtStudentNameKH.ReadOnly = true;
            txtStudentNameKH.Size = new Size(236, 28);
            txtStudentNameKH.TabIndex = 181;
            // 
            // btnNew
            // 
            btnNew.FlatAppearance.BorderColor = Color.FromArgb(25, 149, 173);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(29, 482);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(121, 49);
            btnNew.TabIndex = 174;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // txtPaymentStatusID
            // 
            txtPaymentStatusID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPaymentStatusID.Location = new Point(424, 158);
            txtPaymentStatusID.Name = "txtPaymentStatusID";
            txtPaymentStatusID.ReadOnly = true;
            txtPaymentStatusID.Size = new Size(144, 28);
            txtPaymentStatusID.TabIndex = 168;
            // 
            // labelStaffNameKH
            // 
            labelStaffNameKH.AutoSize = true;
            labelStaffNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStaffNameKH.Location = new Point(249, 401);
            labelStaffNameKH.Name = "labelStaffNameKH";
            labelStaffNameKH.Size = new Size(160, 23);
            labelStaffNameKH.TabIndex = 166;
            labelStaffNameKH.Text = "Student Name KH";
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentID.Location = new Point(249, 354);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(101, 23);
            labelStudentID.TabIndex = 164;
            labelStudentID.Text = "Student ID";
            // 
            // labelOneYearStatus
            // 
            labelOneYearStatus.AutoSize = true;
            labelOneYearStatus.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelOneYearStatus.Location = new Point(249, 302);
            labelOneYearStatus.Name = "labelOneYearStatus";
            labelOneYearStatus.Size = new Size(143, 23);
            labelOneYearStatus.TabIndex = 163;
            labelOneYearStatus.Text = "One Year Status";
            // 
            // labelSemesterTwoStatus
            // 
            labelSemesterTwoStatus.AutoSize = true;
            labelSemesterTwoStatus.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSemesterTwoStatus.Location = new Point(249, 253);
            labelSemesterTwoStatus.Name = "labelSemesterTwoStatus";
            labelSemesterTwoStatus.Size = new Size(187, 23);
            labelSemesterTwoStatus.TabIndex = 162;
            labelSemesterTwoStatus.Text = "Semester Two Status";
            // 
            // labelSemesterOneStatus
            // 
            labelSemesterOneStatus.AutoSize = true;
            labelSemesterOneStatus.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSemesterOneStatus.Location = new Point(249, 206);
            labelSemesterOneStatus.Name = "labelSemesterOneStatus";
            labelSemesterOneStatus.Size = new Size(183, 23);
            labelSemesterOneStatus.TabIndex = 161;
            labelSemesterOneStatus.Text = "Semester One Status";
            // 
            // labelPaymentStausID
            // 
            labelPaymentStausID.AutoSize = true;
            labelPaymentStausID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPaymentStausID.Location = new Point(248, 158);
            labelPaymentStausID.Name = "labelPaymentStausID";
            labelPaymentStausID.Size = new Size(163, 23);
            labelPaymentStausID.TabIndex = 160;
            labelPaymentStausID.Text = "PaymentStatus ID";
            // 
            // lsPaymentStatus
            // 
            lsPaymentStatus.Font = new Font("Khmer OS Battambang", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lsPaymentStatus.FormattingEnabled = true;
            lsPaymentStatus.ItemHeight = 29;
            lsPaymentStatus.Location = new Point(12, 165);
            lsPaymentStatus.Name = "lsPaymentStatus";
            lsPaymentStatus.Size = new Size(211, 294);
            lsPaymentStatus.TabIndex = 159;
            // 
            // txtSearchPaymentStatus
            // 
            txtSearchPaymentStatus.Font = new Font("Khmer OS Battambang", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchPaymentStatus.Location = new Point(12, 123);
            txtSearchPaymentStatus.Name = "txtSearchPaymentStatus";
            txtSearchPaymentStatus.Size = new Size(211, 36);
            txtSearchPaymentStatus.TabIndex = 158;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.Location = new Point(12, 97);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(112, 28);
            labelSearch.TabIndex = 157;
            labelSearch.Text = "Search By";
            // 
            // cBSemesterOneStatus
            // 
            cBSemesterOneStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cBSemesterOneStatus.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBSemesterOneStatus.FormattingEnabled = true;
            cBSemesterOneStatus.Items.AddRange(new object[] { "Not Paid= 0,", "Paid=1" });
            cBSemesterOneStatus.Location = new Point(438, 202);
            cBSemesterOneStatus.Name = "cBSemesterOneStatus";
            cBSemesterOneStatus.Size = new Size(222, 31);
            cBSemesterOneStatus.TabIndex = 184;
            // 
            // cBSemesterTwoStatus
            // 
            cBSemesterTwoStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cBSemesterTwoStatus.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBSemesterTwoStatus.FormattingEnabled = true;
            cBSemesterTwoStatus.Location = new Point(438, 250);
            cBSemesterTwoStatus.Name = "cBSemesterTwoStatus";
            cBSemesterTwoStatus.Size = new Size(222, 31);
            cBSemesterTwoStatus.TabIndex = 185;
            // 
            // cBOneYearStatus
            // 
            cBOneYearStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cBOneYearStatus.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBOneYearStatus.FormattingEnabled = true;
            cBOneYearStatus.Location = new Point(438, 300);
            cBOneYearStatus.Name = "cBOneYearStatus";
            cBOneYearStatus.Size = new Size(222, 31);
            cBOneYearStatus.TabIndex = 186;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(633, 482);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 49);
            btnClose.TabIndex = 189;
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
            btnUpdate.Location = new Point(438, 482);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 49);
            btnUpdate.TabIndex = 188;
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
            btnInsert.Location = new Point(229, 482);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(121, 49);
            btnInsert.TabIndex = 187;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(790, 89);
            panel1.TabIndex = 190;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 13);
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
            label3.Location = new Point(595, 63);
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
            label1.Location = new Point(108, 30);
            label1.Name = "label1";
            label1.Size = new Size(264, 30);
            label1.TabIndex = 73;
            label1.Text = "PaymentStatus's Form";
            // 
            // PaymentStatusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 242);
            ClientSize = new Size(786, 549);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(cBOneYearStatus);
            Controls.Add(cBSemesterTwoStatus);
            Controls.Add(cBSemesterOneStatus);
            Controls.Add(cBStudentID);
            Controls.Add(txtStudentNameKH);
            Controls.Add(btnNew);
            Controls.Add(txtPaymentStatusID);
            Controls.Add(labelStaffNameKH);
            Controls.Add(labelStudentID);
            Controls.Add(labelOneYearStatus);
            Controls.Add(labelSemesterTwoStatus);
            Controls.Add(labelSemesterOneStatus);
            Controls.Add(labelPaymentStausID);
            Controls.Add(lsPaymentStatus);
            Controls.Add(txtSearchPaymentStatus);
            Controls.Add(labelSearch);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PaymentStatusForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentStatusForm";
            Load += PaymentStatusForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cBStudentID;
        private TextBox txtStudentNameKH;
        private Button btnNew;
        private TextBox txtPaymentStatusID;
        private Label labelStaffNameKH;
        private Label labelStudentID;
        private Label labelOneYearStatus;
        private Label labelSemesterTwoStatus;
        private Label labelSemesterOneStatus;
        private Label labelPaymentStausID;
        private ListBox lsPaymentStatus;
        private TextBox txtSearchPaymentStatus;
        private Label labelSearch;
        private ComboBox cBSemesterOneStatus;
        private ComboBox cBSemesterTwoStatus;
        private ComboBox cBOneYearStatus;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnInsert;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}