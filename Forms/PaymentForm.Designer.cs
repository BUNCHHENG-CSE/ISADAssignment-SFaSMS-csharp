namespace SFaSMS
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            btnNew = new Button();
            dTPaymentDate = new DateTimePicker();
            txtStaffPosition = new TextBox();
            txtStaffNameKH = new TextBox();
            cBPaymentStatusID = new ComboBox();
            txtPaymentAmount = new TextBox();
            txtPaymentNo = new TextBox();
            labelStaffPosition = new Label();
            labelStaffNameKH = new Label();
            labelStaffID = new Label();
            labelMajorID = new Label();
            labelPaymentStatusID = new Label();
            labelPaymentAmount = new Label();
            labelPaymentDate = new Label();
            LabelPaymentNo = new Label();
            lsPayment = new ListBox();
            txtSearchPayment = new TextBox();
            labelSearch = new Label();
            txtMajorCost = new TextBox();
            labelMajorCost = new Label();
            cBMajorID = new ComboBox();
            btnClose = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            txtStaffID = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.FlatAppearance.BorderColor = Color.FromArgb(25, 149, 173);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(45, 574);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(121, 49);
            btnNew.TabIndex = 120;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // dTPaymentDate
            // 
            dTPaymentDate.CustomFormat = "yyyy/MM/dd";
            dTPaymentDate.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dTPaymentDate.Location = new Point(435, 170);
            dTPaymentDate.Name = "dTPaymentDate";
            dTPaymentDate.Size = new Size(327, 28);
            dTPaymentDate.TabIndex = 118;
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(435, 439);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.ReadOnly = true;
            txtStaffPosition.Size = new Size(280, 28);
            txtStaffPosition.TabIndex = 117;
            // 
            // txtStaffNameKH
            // 
            txtStaffNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStaffNameKH.Location = new Point(435, 397);
            txtStaffNameKH.Name = "txtStaffNameKH";
            txtStaffNameKH.ReadOnly = true;
            txtStaffNameKH.Size = new Size(280, 28);
            txtStaffNameKH.TabIndex = 116;
            // 
            // cBPaymentStatusID
            // 
            cBPaymentStatusID.DropDownStyle = ComboBoxStyle.DropDownList;
            cBPaymentStatusID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBPaymentStatusID.FormattingEnabled = true;
            cBPaymentStatusID.Location = new Point(435, 257);
            cBPaymentStatusID.Name = "cBPaymentStatusID";
            cBPaymentStatusID.Size = new Size(176, 31);
            cBPaymentStatusID.TabIndex = 114;
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPaymentAmount.Location = new Point(435, 214);
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.Size = new Size(200, 28);
            txtPaymentAmount.TabIndex = 113;
            // 
            // txtPaymentNo
            // 
            txtPaymentNo.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPaymentNo.Location = new Point(435, 126);
            txtPaymentNo.Name = "txtPaymentNo";
            txtPaymentNo.ReadOnly = true;
            txtPaymentNo.Size = new Size(160, 28);
            txtPaymentNo.TabIndex = 111;
            // 
            // labelStaffPosition
            // 
            labelStaffPosition.AutoSize = true;
            labelStaffPosition.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStaffPosition.Location = new Point(255, 444);
            labelStaffPosition.Name = "labelStaffPosition";
            labelStaffPosition.Size = new Size(126, 23);
            labelStaffPosition.TabIndex = 110;
            labelStaffPosition.Text = "Staff Position";
            // 
            // labelStaffNameKH
            // 
            labelStaffNameKH.AutoSize = true;
            labelStaffNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStaffNameKH.Location = new Point(255, 400);
            labelStaffNameKH.Name = "labelStaffNameKH";
            labelStaffNameKH.Size = new Size(135, 23);
            labelStaffNameKH.TabIndex = 109;
            labelStaffNameKH.Text = "Staff Name KH";
            // 
            // labelStaffID
            // 
            labelStaffID.AutoSize = true;
            labelStaffID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStaffID.Location = new Point(255, 356);
            labelStaffID.Name = "labelStaffID";
            labelStaffID.Size = new Size(76, 23);
            labelStaffID.TabIndex = 108;
            labelStaffID.Text = "Staff ID";
            // 
            // labelMajorID
            // 
            labelMajorID.AutoSize = true;
            labelMajorID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMajorID.Location = new Point(255, 309);
            labelMajorID.Name = "labelMajorID";
            labelMajorID.Size = new Size(85, 23);
            labelMajorID.TabIndex = 107;
            labelMajorID.Text = "Major ID";
            // 
            // labelPaymentStatusID
            // 
            labelPaymentStatusID.AutoSize = true;
            labelPaymentStatusID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPaymentStatusID.Location = new Point(255, 265);
            labelPaymentStatusID.Name = "labelPaymentStatusID";
            labelPaymentStatusID.Size = new Size(168, 23);
            labelPaymentStatusID.TabIndex = 106;
            labelPaymentStatusID.Text = "Payment Status ID";
            // 
            // labelPaymentAmount
            // 
            labelPaymentAmount.AutoSize = true;
            labelPaymentAmount.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPaymentAmount.Location = new Point(255, 219);
            labelPaymentAmount.Name = "labelPaymentAmount";
            labelPaymentAmount.Size = new Size(156, 23);
            labelPaymentAmount.TabIndex = 105;
            labelPaymentAmount.Text = "Payment Amount";
            // 
            // labelPaymentDate
            // 
            labelPaymentDate.AutoSize = true;
            labelPaymentDate.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPaymentDate.Location = new Point(255, 175);
            labelPaymentDate.Name = "labelPaymentDate";
            labelPaymentDate.Size = new Size(128, 23);
            labelPaymentDate.TabIndex = 104;
            labelPaymentDate.Text = "Payment Date";
            // 
            // LabelPaymentNo
            // 
            LabelPaymentNo.AutoSize = true;
            LabelPaymentNo.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPaymentNo.Location = new Point(255, 131);
            LabelPaymentNo.Name = "LabelPaymentNo";
            LabelPaymentNo.Size = new Size(112, 23);
            LabelPaymentNo.TabIndex = 103;
            LabelPaymentNo.Text = "Payment No";
            // 
            // lsPayment
            // 
            lsPayment.Font = new Font("Khmer OS Battambang", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lsPayment.FormattingEnabled = true;
            lsPayment.ItemHeight = 29;
            lsPayment.Location = new Point(21, 176);
            lsPayment.Name = "lsPayment";
            lsPayment.Size = new Size(211, 381);
            lsPayment.TabIndex = 102;
            // 
            // txtSearchPayment
            // 
            txtSearchPayment.Font = new Font("Khmer OS Battambang", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchPayment.Location = new Point(21, 134);
            txtSearchPayment.Name = "txtSearchPayment";
            txtSearchPayment.Size = new Size(211, 36);
            txtSearchPayment.TabIndex = 101;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.Location = new Point(21, 103);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(112, 28);
            labelSearch.TabIndex = 100;
            labelSearch.Text = "Search By";
            // 
            // txtMajorCost
            // 
            txtMajorCost.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMajorCost.Location = new Point(435, 486);
            txtMajorCost.Name = "txtMajorCost";
            txtMajorCost.ReadOnly = true;
            txtMajorCost.Size = new Size(228, 28);
            txtMajorCost.TabIndex = 127;
            // 
            // labelMajorCost
            // 
            labelMajorCost.AutoSize = true;
            labelMajorCost.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMajorCost.Location = new Point(255, 489);
            labelMajorCost.Name = "labelMajorCost";
            labelMajorCost.Size = new Size(102, 23);
            labelMajorCost.TabIndex = 126;
            labelMajorCost.Text = "Major Cost";
            // 
            // cBMajorID
            // 
            cBMajorID.DropDownStyle = ComboBoxStyle.DropDownList;
            cBMajorID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBMajorID.FormattingEnabled = true;
            cBMajorID.Location = new Point(435, 301);
            cBMajorID.Name = "cBMajorID";
            cBMajorID.Size = new Size(176, 31);
            cBMajorID.TabIndex = 128;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(663, 574);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 49);
            btnClose.TabIndex = 132;
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
            btnUpdate.Location = new Point(474, 574);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 49);
            btnUpdate.TabIndex = 131;
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
            btnInsert.Location = new Point(255, 574);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(121, 49);
            btnInsert.TabIndex = 130;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 89);
            panel1.TabIndex = 161;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 12);
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
            label3.Location = new Point(616, 60);
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
            label1.Location = new Point(118, 26);
            label1.Name = "label1";
            label1.Size = new Size(193, 30);
            label1.TabIndex = 73;
            label1.Text = "Payment's Form";
            // 
            // txtStaffID
            // 
            txtStaffID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStaffID.Location = new Point(435, 351);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.ReadOnly = true;
            txtStaffID.Size = new Size(144, 28);
            txtStaffID.TabIndex = 164;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 242);
            ClientSize = new Size(809, 643);
            Controls.Add(txtStaffID);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(cBMajorID);
            Controls.Add(txtMajorCost);
            Controls.Add(labelMajorCost);
            Controls.Add(btnNew);
            Controls.Add(dTPaymentDate);
            Controls.Add(txtStaffPosition);
            Controls.Add(txtStaffNameKH);
            Controls.Add(cBPaymentStatusID);
            Controls.Add(txtPaymentAmount);
            Controls.Add(txtPaymentNo);
            Controls.Add(labelStaffPosition);
            Controls.Add(labelStaffNameKH);
            Controls.Add(labelStaffID);
            Controls.Add(labelMajorID);
            Controls.Add(labelPaymentStatusID);
            Controls.Add(labelPaymentAmount);
            Controls.Add(labelPaymentDate);
            Controls.Add(LabelPaymentNo);
            Controls.Add(lsPayment);
            Controls.Add(txtSearchPayment);
            Controls.Add(labelSearch);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PaymentForm";
            Load += PaymentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNew;
        private DateTimePicker dTPaymentDate;
        private TextBox txtStaffPosition;
        private TextBox txtStaffNameKH;
        private ComboBox cBPaymentStatusID;
        private TextBox txtPaymentAmount;
        private TextBox txtPaymentNo;
        private Label labelStaffPosition;
        private Label labelStaffNameKH;
        private Label labelStaffID;
        private Label labelMajorID;
        private Label labelPaymentStatusID;
        private Label labelPaymentAmount;
        private Label labelPaymentDate;
        private Label LabelPaymentNo;
        private ListBox lsPayment;
        private TextBox txtSearchPayment;
        private Label labelSearch;
        private TextBox txtMajorCost;
        private Label labelMajorCost;
        private ComboBox cBMajorID;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnInsert;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox txtStaffID;
    }
}