namespace SFaSMS
{
    partial class MajorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MajorForm));
            txtMajorID = new TextBox();
            btnNew = new Button();
            dgvMajor = new DataGridView();
            MajorID = new DataGridViewTextBoxColumn();
            MajorNameKH = new DataGridViewTextBoxColumn();
            MajorNameEN = new DataGridViewTextBoxColumn();
            MajorNameAbbreviation = new DataGridViewTextBoxColumn();
            MajorCost = new DataGridViewTextBoxColumn();
            MajorDescription = new DataGridViewTextBoxColumn();
            txtSearchMajor = new TextBox();
            labelSearch = new Label();
            txtMajorNameAbb = new TextBox();
            labelMajorNameAbbreviation = new Label();
            labelMajorNameEN = new Label();
            txtMajorNameEN = new TextBox();
            labelMajorID = new Label();
            txtMajorDescription = new TextBox();
            labelMajorDescription = new Label();
            labelMajorCost = new Label();
            txtMajorCost = new TextBox();
            labelMajorNameKH = new Label();
            txtMajorNameKH = new TextBox();
            btnClose = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMajor).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtMajorID
            // 
            txtMajorID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMajorID.Location = new Point(144, 105);
            txtMajorID.Name = "txtMajorID";
            txtMajorID.ReadOnly = true;
            txtMajorID.Size = new Size(156, 28);
            txtMajorID.TabIndex = 84;
            // 
            // btnNew
            // 
            btnNew.FlatAppearance.BorderColor = Color.FromArgb(25, 149, 173);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(33, 581);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(121, 49);
            btnNew.TabIndex = 79;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // dgvMajor
            // 
            dgvMajor.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMajor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMajor.ColumnHeadersHeight = 37;
            dgvMajor.Columns.AddRange(new DataGridViewColumn[] { MajorID, MajorNameKH, MajorNameEN, MajorNameAbbreviation, MajorCost, MajorDescription });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMajor.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMajor.Location = new Point(13, 404);
            dgvMajor.Name = "dgvMajor";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvMajor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvMajor.RowTemplate.Height = 25;
            dgvMajor.Size = new Size(995, 150);
            dgvMajor.TabIndex = 78;
            // 
            // MajorID
            // 
            MajorID.HeaderText = "Major ID";
            MajorID.Name = "MajorID";
            // 
            // MajorNameKH
            // 
            MajorNameKH.HeaderText = "Major Name KH";
            MajorNameKH.Name = "MajorNameKH";
            MajorNameKH.Width = 200;
            // 
            // MajorNameEN
            // 
            MajorNameEN.HeaderText = "Major Name EN";
            MajorNameEN.Name = "MajorNameEN";
            MajorNameEN.Width = 200;
            // 
            // MajorNameAbbreviation
            // 
            MajorNameAbbreviation.HeaderText = "Major Name Abb";
            MajorNameAbbreviation.Name = "MajorNameAbbreviation";
            MajorNameAbbreviation.Width = 190;
            // 
            // MajorCost
            // 
            MajorCost.HeaderText = "Major Cost";
            MajorCost.Name = "MajorCost";
            MajorCost.Width = 120;
            // 
            // MajorDescription
            // 
            MajorDescription.HeaderText = "Major Desc";
            MajorDescription.Name = "MajorDescription";
            MajorDescription.Width = 140;
            // 
            // txtSearchMajor
            // 
            txtSearchMajor.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchMajor.Location = new Point(111, 358);
            txtSearchMajor.Name = "txtSearchMajor";
            txtSearchMajor.Size = new Size(293, 28);
            txtSearchMajor.TabIndex = 77;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.Location = new Point(22, 357);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(80, 28);
            labelSearch.TabIndex = 76;
            labelSearch.Text = "Search";
            // 
            // txtMajorNameAbb
            // 
            txtMajorNameAbb.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMajorNameAbb.Location = new Point(283, 252);
            txtMajorNameAbb.Name = "txtMajorNameAbb";
            txtMajorNameAbb.Size = new Size(343, 28);
            txtMajorNameAbb.TabIndex = 75;
            // 
            // labelMajorNameAbbreviation
            // 
            labelMajorNameAbbreviation.AutoSize = true;
            labelMajorNameAbbreviation.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMajorNameAbbreviation.Location = new Point(22, 257);
            labelMajorNameAbbreviation.Name = "labelMajorNameAbbreviation";
            labelMajorNameAbbreviation.Size = new Size(227, 23);
            labelMajorNameAbbreviation.TabIndex = 74;
            labelMajorNameAbbreviation.Text = "Major Name Abbreviation";
            // 
            // labelMajorNameEN
            // 
            labelMajorNameEN.AutoSize = true;
            labelMajorNameEN.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMajorNameEN.Location = new Point(21, 208);
            labelMajorNameEN.Name = "labelMajorNameEN";
            labelMajorNameEN.Size = new Size(143, 23);
            labelMajorNameEN.TabIndex = 73;
            labelMajorNameEN.Text = "Major Name EN";
            // 
            // txtMajorNameEN
            // 
            txtMajorNameEN.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMajorNameEN.Location = new Point(189, 203);
            txtMajorNameEN.Name = "txtMajorNameEN";
            txtMajorNameEN.Size = new Size(422, 28);
            txtMajorNameEN.TabIndex = 72;
            // 
            // labelMajorID
            // 
            labelMajorID.AutoSize = true;
            labelMajorID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMajorID.Location = new Point(21, 110);
            labelMajorID.Name = "labelMajorID";
            labelMajorID.Size = new Size(85, 23);
            labelMajorID.TabIndex = 71;
            labelMajorID.Text = "Major ID";
            // 
            // txtMajorDescription
            // 
            txtMajorDescription.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMajorDescription.Location = new Point(485, 302);
            txtMajorDescription.Name = "txtMajorDescription";
            txtMajorDescription.Size = new Size(214, 28);
            txtMajorDescription.TabIndex = 88;
            // 
            // labelMajorDescription
            // 
            labelMajorDescription.AutoSize = true;
            labelMajorDescription.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMajorDescription.Location = new Point(297, 307);
            labelMajorDescription.Name = "labelMajorDescription";
            labelMajorDescription.Size = new Size(163, 23);
            labelMajorDescription.TabIndex = 87;
            labelMajorDescription.Text = "Major Description";
            // 
            // labelMajorCost
            // 
            labelMajorCost.AutoSize = true;
            labelMajorCost.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMajorCost.Location = new Point(22, 309);
            labelMajorCost.Name = "labelMajorCost";
            labelMajorCost.Size = new Size(102, 23);
            labelMajorCost.TabIndex = 86;
            labelMajorCost.Text = "Major Cost";
            // 
            // txtMajorCost
            // 
            txtMajorCost.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMajorCost.Location = new Point(130, 302);
            txtMajorCost.Name = "txtMajorCost";
            txtMajorCost.Size = new Size(147, 28);
            txtMajorCost.TabIndex = 85;
            // 
            // labelMajorNameKH
            // 
            labelMajorNameKH.AutoSize = true;
            labelMajorNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMajorNameKH.Location = new Point(22, 156);
            labelMajorNameKH.Name = "labelMajorNameKH";
            labelMajorNameKH.Size = new Size(144, 23);
            labelMajorNameKH.TabIndex = 90;
            labelMajorNameKH.Text = "Major Name KH";
            // 
            // txtMajorNameKH
            // 
            txtMajorNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMajorNameKH.Location = new Point(203, 153);
            txtMajorNameKH.Name = "txtMajorNameKH";
            txtMajorNameKH.Size = new Size(408, 28);
            txtMajorNameKH.TabIndex = 89;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(845, 581);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 49);
            btnClose.TabIndex = 93;
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
            btnUpdate.Location = new Point(593, 581);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 49);
            btnUpdate.TabIndex = 92;
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
            btnInsert.Location = new Point(297, 581);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(121, 49);
            btnInsert.TabIndex = 91;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1034, 89);
            panel1.TabIndex = 162;
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
            label3.Location = new Point(842, 63);
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
            label1.Location = new Point(120, 29);
            label1.Name = "label1";
            label1.Size = new Size(162, 30);
            label1.TabIndex = 73;
            label1.Text = "Major's Form";
            // 
            // MajorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 242);
            ClientSize = new Size(1030, 649);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(labelMajorNameKH);
            Controls.Add(txtMajorNameKH);
            Controls.Add(txtMajorDescription);
            Controls.Add(labelMajorDescription);
            Controls.Add(labelMajorCost);
            Controls.Add(txtMajorCost);
            Controls.Add(txtMajorID);
            Controls.Add(btnNew);
            Controls.Add(dgvMajor);
            Controls.Add(txtSearchMajor);
            Controls.Add(labelSearch);
            Controls.Add(txtMajorNameAbb);
            Controls.Add(labelMajorNameAbbreviation);
            Controls.Add(labelMajorNameEN);
            Controls.Add(txtMajorNameEN);
            Controls.Add(labelMajorID);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MajorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MajorForm";
            Load += MajorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMajor).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMajorID;
        private Button btnNew;
        private DataGridView dgvMajor;
        private TextBox txtSearchMajor;
        private Label labelSearch;
        private TextBox txtMajorNameAbb;
        private Label labelMajorNameAbbreviation;
        private Label labelMajorNameEN;
        private TextBox txtMajorNameEN;
        private Label labelMajorID;
        private TextBox txtMajorDescription;
        private Label labelMajorDescription;
        private Label labelMajorCost;
        private TextBox txtMajorCost;
        private Label labelMajorNameKH;
        private TextBox txtMajorNameKH;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnInsert;
        private DataGridViewTextBoxColumn MajorID;
        private DataGridViewTextBoxColumn MajorNameKH;
        private DataGridViewTextBoxColumn MajorNameEN;
        private DataGridViewTextBoxColumn MajorNameAbbreviation;
        private DataGridViewTextBoxColumn MajorCost;
        private DataGridViewTextBoxColumn MajorDescription;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}