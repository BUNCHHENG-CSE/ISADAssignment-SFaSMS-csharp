namespace SFaSMS
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            labelSearch = new Label();
            txtSearchUsername = new TextBox();
            LabelUserID = new Label();
            LabelUsername = new Label();
            LabelPassword = new Label();
            LabelStaffID = new Label();
            LabelStaffNameKH = new Label();
            LabelStaffPostion = new Label();
            txtUserID = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtStaffNameKH = new TextBox();
            txtStaffPosition = new TextBox();
            cBoxStaffID = new ComboBox();
            btnNew = new Button();
            lsUser = new ListBox();
            btnClose = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            chBShowPass = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.Location = new Point(24, 98);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(219, 28);
            labelSearch.TabIndex = 0;
            labelSearch.Text = "Search ( Username )";
            // 
            // txtSearchUsername
            // 
            txtSearchUsername.Font = new Font("Sitka Small", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchUsername.Location = new Point(24, 130);
            txtSearchUsername.Name = "txtSearchUsername";
            txtSearchUsername.Size = new Size(200, 26);
            txtSearchUsername.TabIndex = 1;
            // 
            // LabelUserID
            // 
            LabelUserID.AutoSize = true;
            LabelUserID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelUserID.Location = new Point(254, 151);
            LabelUserID.Name = "LabelUserID";
            LabelUserID.Size = new Size(74, 23);
            LabelUserID.TabIndex = 4;
            LabelUserID.Text = "User ID";
            // 
            // LabelUsername
            // 
            LabelUsername.AutoSize = true;
            LabelUsername.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelUsername.Location = new Point(254, 191);
            LabelUsername.Name = "LabelUsername";
            LabelUsername.Size = new Size(95, 23);
            LabelUsername.TabIndex = 5;
            LabelUsername.Text = "Username";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPassword.Location = new Point(254, 234);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(93, 23);
            LabelPassword.TabIndex = 6;
            LabelPassword.Text = "Password";
            // 
            // LabelStaffID
            // 
            LabelStaffID.AutoSize = true;
            LabelStaffID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelStaffID.Location = new Point(254, 276);
            LabelStaffID.Name = "LabelStaffID";
            LabelStaffID.Size = new Size(76, 23);
            LabelStaffID.TabIndex = 7;
            LabelStaffID.Text = "Staff ID";
            // 
            // LabelStaffNameKH
            // 
            LabelStaffNameKH.AutoSize = true;
            LabelStaffNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelStaffNameKH.Location = new Point(252, 322);
            LabelStaffNameKH.Name = "LabelStaffNameKH";
            LabelStaffNameKH.Size = new Size(135, 23);
            LabelStaffNameKH.TabIndex = 8;
            LabelStaffNameKH.Text = "Staff Name KH";
            // 
            // LabelStaffPostion
            // 
            LabelStaffPostion.AutoSize = true;
            LabelStaffPostion.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelStaffPostion.Location = new Point(254, 371);
            LabelStaffPostion.Name = "LabelStaffPostion";
            LabelStaffPostion.Size = new Size(126, 23);
            LabelStaffPostion.TabIndex = 9;
            LabelStaffPostion.Text = "Staff Position";
            // 
            // txtUserID
            // 
            txtUserID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserID.Location = new Point(411, 146);
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(119, 28);
            txtUserID.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(411, 188);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(180, 28);
            txtUsername.TabIndex = 11;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(411, 229);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(180, 28);
            txtPassword.TabIndex = 12;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtStaffNameKH
            // 
            txtStaffNameKH.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStaffNameKH.Location = new Point(411, 317);
            txtStaffNameKH.Name = "txtStaffNameKH";
            txtStaffNameKH.ReadOnly = true;
            txtStaffNameKH.Size = new Size(261, 28);
            txtStaffNameKH.TabIndex = 13;
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(411, 366);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.ReadOnly = true;
            txtStaffPosition.Size = new Size(261, 28);
            txtStaffPosition.TabIndex = 14;
            // 
            // cBoxStaffID
            // 
            cBoxStaffID.DropDownStyle = ComboBoxStyle.DropDownList;
            cBoxStaffID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBoxStaffID.FormattingEnabled = true;
            cBoxStaffID.Location = new Point(411, 268);
            cBoxStaffID.Name = "cBoxStaffID";
            cBoxStaffID.Size = new Size(136, 31);
            cBoxStaffID.TabIndex = 16;
            // 
            // btnNew
            // 
            btnNew.FlatAppearance.BorderColor = Color.FromArgb(25, 149, 173);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(33, 440);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(121, 49);
            btnNew.TabIndex = 17;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // lsUser
            // 
            lsUser.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lsUser.FormattingEnabled = true;
            lsUser.ItemHeight = 23;
            lsUser.Location = new Point(24, 162);
            lsUser.Name = "lsUser";
            lsUser.Size = new Size(200, 257);
            lsUser.TabIndex = 22;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(595, 438);
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
            btnUpdate.Location = new Point(411, 440);
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
            btnInsert.Location = new Point(228, 440);
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
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(759, 89);
            panel1.TabIndex = 193;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 13);
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
            label3.Location = new Point(567, 62);
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
            label1.Location = new Point(121, 31);
            label1.Name = "label1";
            label1.Size = new Size(148, 30);
            label1.TabIndex = 73;
            label1.Text = "User's Form";
            // 
            // chBShowPass
            // 
            chBShowPass.AutoSize = true;
            chBShowPass.Location = new Point(619, 239);
            chBShowPass.Name = "chBShowPass";
            chBShowPass.Size = new Size(54, 19);
            chBShowPass.TabIndex = 194;
            chBShowPass.Text = "show";
            chBShowPass.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(756, 505);
            Controls.Add(chBShowPass);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(lsUser);
            Controls.Add(btnNew);
            Controls.Add(cBoxStaffID);
            Controls.Add(txtStaffPosition);
            Controls.Add(txtStaffNameKH);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtUserID);
            Controls.Add(LabelStaffPostion);
            Controls.Add(LabelStaffNameKH);
            Controls.Add(LabelStaffID);
            Controls.Add(LabelPassword);
            Controls.Add(LabelUsername);
            Controls.Add(LabelUserID);
            Controls.Add(txtSearchUsername);
            Controls.Add(labelSearch);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            Load += UserForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSearch;
        private TextBox txtSearchUsername;
        private Label LabelUserID;
        private Label LabelUsername;
        private Label LabelPassword;
        private Label LabelStaffID;
        private Label LabelStaffNameKH;
        private Label LabelStaffPostion;
        private TextBox txtUserID;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtStaffNameKH;
        private TextBox txtStaffPosition;
        private ComboBox cBoxStaffID;
        private Button btnNew;
        private ListBox lsUser;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnInsert;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private CheckBox chBShowPass;
    }
}