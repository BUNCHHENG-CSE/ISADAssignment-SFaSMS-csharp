namespace SFaSMS
{
    partial class SubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectForm));
            btnNew = new Button();
            dgvSubject = new DataGridView();
            txtSearchSubject = new TextBox();
            labelSearch = new Label();
            txtSubjectDescription = new TextBox();
            labelSubjectDescription = new Label();
            labelSubjectName = new Label();
            txtSubjectName = new TextBox();
            labelSubjectID = new Label();
            txtSubjectID = new TextBox();
            btnClose = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            SubjectID = new DataGridViewTextBoxColumn();
            SubjectName = new DataGridViewTextBoxColumn();
            SubjectDecription = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.FlatAppearance.BorderColor = Color.FromArgb(25, 149, 173);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(632, 106);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(121, 49);
            btnNew.TabIndex = 51;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // dgvSubject
            // 
            dgvSubject.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSubject.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubject.Columns.AddRange(new DataGridViewColumn[] { SubjectID, SubjectName, SubjectDecription });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSubject.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSubject.Location = new Point(24, 321);
            dgvSubject.MultiSelect = false;
            dgvSubject.Name = "dgvSubject";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSubject.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSubject.RowTemplate.Height = 25;
            dgvSubject.Size = new Size(784, 169);
            dgvSubject.TabIndex = 50;
            // 
            // txtSearchSubject
            // 
            txtSearchSubject.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchSubject.Location = new Point(124, 270);
            txtSearchSubject.Name = "txtSearchSubject";
            txtSearchSubject.Size = new Size(308, 28);
            txtSearchSubject.TabIndex = 49;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.Location = new Point(25, 270);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(80, 28);
            labelSearch.TabIndex = 48;
            labelSearch.Text = "Search";
            // 
            // txtSubjectDescription
            // 
            txtSubjectDescription.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubjectDescription.Location = new Point(218, 202);
            txtSubjectDescription.Name = "txtSubjectDescription";
            txtSubjectDescription.Size = new Size(244, 28);
            txtSubjectDescription.TabIndex = 47;
            // 
            // labelSubjectDescription
            // 
            labelSubjectDescription.AutoSize = true;
            labelSubjectDescription.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSubjectDescription.Location = new Point(24, 207);
            labelSubjectDescription.Name = "labelSubjectDescription";
            labelSubjectDescription.Size = new Size(174, 23);
            labelSubjectDescription.TabIndex = 46;
            labelSubjectDescription.Text = "Subject Description";
            // 
            // labelSubjectName
            // 
            labelSubjectName.AutoSize = true;
            labelSubjectName.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSubjectName.Location = new Point(25, 163);
            labelSubjectName.Name = "labelSubjectName";
            labelSubjectName.Size = new Size(124, 23);
            labelSubjectName.TabIndex = 39;
            labelSubjectName.Text = "Subject Name";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubjectName.Location = new Point(206, 158);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(405, 28);
            txtSubjectName.TabIndex = 38;
            // 
            // labelSubjectID
            // 
            labelSubjectID.AutoSize = true;
            labelSubjectID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSubjectID.Location = new Point(24, 111);
            labelSubjectID.Name = "labelSubjectID";
            labelSubjectID.Size = new Size(96, 23);
            labelSubjectID.TabIndex = 36;
            labelSubjectID.Text = "Subject ID";
            // 
            // txtSubjectID
            // 
            txtSubjectID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubjectID.Location = new Point(206, 106);
            txtSubjectID.Name = "txtSubjectID";
            txtSubjectID.ReadOnly = true;
            txtSubjectID.Size = new Size(194, 28);
            txtSubjectID.TabIndex = 56;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(775, 173);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 49);
            btnClose.TabIndex = 59;
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
            btnUpdate.Location = new Point(632, 173);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 49);
            btnUpdate.TabIndex = 58;
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
            btnInsert.Location = new Point(775, 106);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(121, 49);
            btnInsert.TabIndex = 57;
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
            panel1.Size = new Size(911, 89);
            panel1.TabIndex = 192;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 12);
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
            label3.Location = new Point(716, 65);
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
            label1.Location = new Point(125, 28);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 73;
            label1.Text = "Subject's Form";
            // 
            // SubjectID
            // 
            SubjectID.HeaderText = "Subject ID";
            SubjectID.Name = "SubjectID";
            SubjectID.Width = 140;
            // 
            // SubjectName
            // 
            SubjectName.HeaderText = "Subject Name";
            SubjectName.Name = "SubjectName";
            SubjectName.Width = 300;
            // 
            // SubjectDecription
            // 
            SubjectDecription.HeaderText = "Subject Decription";
            SubjectDecription.Name = "SubjectDecription";
            SubjectDecription.Width = 300;
            // 
            // SubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 242);
            ClientSize = new Size(908, 505);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtSubjectID);
            Controls.Add(btnNew);
            Controls.Add(dgvSubject);
            Controls.Add(txtSearchSubject);
            Controls.Add(labelSearch);
            Controls.Add(txtSubjectDescription);
            Controls.Add(labelSubjectDescription);
            Controls.Add(labelSubjectName);
            Controls.Add(txtSubjectName);
            Controls.Add(labelSubjectID);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SubjectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SubjectForm";
            Load += SubjectForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNew;
        private DataGridView dgvSubject;
        private TextBox txtSearchSubject;
        private Label labelSearch;
        private TextBox txtSubjectDescription;
        private Label labelSubjectDescription;
        private Label labelSubjectName;
        private TextBox txtSubjectName;
        private Label labelSubjectID;
        private TextBox txtSubjectID;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnInsert;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn SubjectID;
        private DataGridViewTextBoxColumn SubjectName;
        private DataGridViewTextBoxColumn SubjectDecription;
    }
}