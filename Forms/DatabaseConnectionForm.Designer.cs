﻿namespace SFaSMS.Forms
{
    partial class DatabaseConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseConnectionForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            labelServerName = new Label();
            labelPassword = new Label();
            labelUser = new Label();
            labelDatabaseName = new Label();
            txtServerName = new TextBox();
            txtDatabaseName = new TextBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            labelAuthentication = new Label();
            cBAuthentication = new ComboBox();
            btnConnect = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(649, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(60, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(166, 36);
            label1.Name = "label1";
            label1.Size = new Size(300, 28);
            label1.TabIndex = 12;
            label1.Text = "DATABASE CONFIGURATION";
            // 
            // labelServerName
            // 
            labelServerName.AutoSize = true;
            labelServerName.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelServerName.Location = new Point(61, 142);
            labelServerName.Name = "labelServerName";
            labelServerName.Size = new Size(142, 28);
            labelServerName.TabIndex = 0;
            labelServerName.Text = "Server Name";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point(61, 329);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(109, 28);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Password";
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelUser.Location = new Point(61, 282);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(58, 28);
            labelUser.TabIndex = 2;
            labelUser.Text = "User";
            // 
            // labelDatabaseName
            // 
            labelDatabaseName.AutoSize = true;
            labelDatabaseName.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelDatabaseName.Location = new Point(60, 188);
            labelDatabaseName.Name = "labelDatabaseName";
            labelDatabaseName.Size = new Size(168, 28);
            labelDatabaseName.TabIndex = 3;
            labelDatabaseName.Text = "Database Name";
            // 
            // txtServerName
            // 
            txtServerName.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtServerName.Location = new Point(247, 142);
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new Size(337, 28);
            txtServerName.TabIndex = 4;
            // 
            // txtDatabaseName
            // 
            txtDatabaseName.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDatabaseName.Location = new Point(247, 188);
            txtDatabaseName.Name = "txtDatabaseName";
            txtDatabaseName.Size = new Size(337, 28);
            txtDatabaseName.TabIndex = 5;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUser.Location = new Point(247, 282);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(337, 28);
            txtUser.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(247, 329);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(337, 28);
            txtPassword.TabIndex = 7;
            // 
            // labelAuthentication
            // 
            labelAuthentication.AutoSize = true;
            labelAuthentication.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelAuthentication.Location = new Point(60, 234);
            labelAuthentication.Name = "labelAuthentication";
            labelAuthentication.Size = new Size(161, 28);
            labelAuthentication.TabIndex = 9;
            labelAuthentication.Text = "Authentication";
            // 
            // cBAuthentication
            // 
            cBAuthentication.DropDownStyle = ComboBoxStyle.DropDownList;
            cBAuthentication.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBAuthentication.FormattingEnabled = true;
            cBAuthentication.Location = new Point(247, 231);
            cBAuthentication.Name = "cBAuthentication";
            cBAuthentication.Size = new Size(337, 31);
            cBAuthentication.TabIndex = 10;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(25, 149, 173);
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(32, 390);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(211, 43);
            btnConnect.TabIndex = 11;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(25, 149, 173);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(463, 390);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(146, 43);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // DatabaseConnectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 242);
            ClientSize = new Size(649, 468);
            Controls.Add(btnCancel);
            Controls.Add(btnConnect);
            Controls.Add(cBAuthentication);
            Controls.Add(labelAuthentication);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(txtDatabaseName);
            Controls.Add(txtServerName);
            Controls.Add(labelDatabaseName);
            Controls.Add(labelUser);
            Controls.Add(labelPassword);
            Controls.Add(labelServerName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DatabaseConnectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatabaseConnectionForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelServerName;
        private Label labelPassword;
        private Label labelUser;
        private Label labelDatabaseName;
        private TextBox txtServerName;
        private TextBox txtDatabaseName;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label labelAuthentication;
        private ComboBox cBAuthentication;
        private Button btnConnect;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnCancel;
    }
}