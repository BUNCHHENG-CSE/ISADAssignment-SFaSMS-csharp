namespace SFaSMS
{
    partial class RoomForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomForm));
            txtRoomNo = new TextBox();
            btnNew = new Button();
            dgvRoom = new DataGridView();
            RoomNo = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            BuildingLetter = new DataGridViewTextBoxColumn();
            txtSearchRoom = new TextBox();
            labelSearch = new Label();
            txtBuildingNumber = new TextBox();
            labelBuildingLetter = new Label();
            labelRoomNumber = new Label();
            txtRoomNumber = new TextBox();
            labelRoomNo = new Label();
            btnClose = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRoom).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtRoomNo
            // 
            txtRoomNo.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtRoomNo.Location = new Point(175, 112);
            txtRoomNo.Name = "txtRoomNo";
            txtRoomNo.ReadOnly = true;
            txtRoomNo.Size = new Size(136, 28);
            txtRoomNo.TabIndex = 70;
            // 
            // btnNew
            // 
            btnNew.FlatAppearance.BorderColor = Color.FromArgb(25, 149, 173);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(493, 103);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(121, 49);
            btnNew.TabIndex = 65;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // dgvRoom
            // 
            dgvRoom.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvRoom.ColumnHeadersHeight = 30;
            dgvRoom.Columns.AddRange(new DataGridViewColumn[] { RoomNo, RoomNumber, BuildingLetter });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvRoom.DefaultCellStyle = dataGridViewCellStyle5;
            dgvRoom.Location = new Point(24, 297);
            dgvRoom.Name = "dgvRoom";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvRoom.RowTemplate.Height = 25;
            dgvRoom.Size = new Size(495, 167);
            dgvRoom.TabIndex = 64;
            // 
            // RoomNo
            // 
            RoomNo.HeaderText = "Room No";
            RoomNo.Name = "RoomNo";
            RoomNo.Width = 150;
            // 
            // RoomNumber
            // 
            RoomNumber.HeaderText = "Room Number";
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Width = 150;
            // 
            // BuildingLetter
            // 
            BuildingLetter.HeaderText = "Building Letter";
            BuildingLetter.Name = "BuildingLetter";
            BuildingLetter.Width = 150;
            // 
            // txtSearchRoom
            // 
            txtSearchRoom.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchRoom.Location = new Point(295, 255);
            txtSearchRoom.Name = "txtSearchRoom";
            txtSearchRoom.Size = new Size(309, 28);
            txtSearchRoom.TabIndex = 63;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.Location = new Point(24, 254);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(250, 28);
            labelSearch.TabIndex = 62;
            labelSearch.Text = "Search (Room Number)";
            // 
            // txtBuildingNumber
            // 
            txtBuildingNumber.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtBuildingNumber.Location = new Point(185, 202);
            txtBuildingNumber.Name = "txtBuildingNumber";
            txtBuildingNumber.Size = new Size(246, 28);
            txtBuildingNumber.TabIndex = 61;
            // 
            // labelBuildingLetter
            // 
            labelBuildingLetter.AutoSize = true;
            labelBuildingLetter.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelBuildingLetter.Location = new Point(24, 207);
            labelBuildingLetter.Name = "labelBuildingLetter";
            labelBuildingLetter.Size = new Size(139, 23);
            labelBuildingLetter.TabIndex = 60;
            labelBuildingLetter.Text = "Building Letter";
            // 
            // labelRoomNumber
            // 
            labelRoomNumber.AutoSize = true;
            labelRoomNumber.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelRoomNumber.Location = new Point(23, 164);
            labelRoomNumber.Name = "labelRoomNumber";
            labelRoomNumber.Size = new Size(130, 23);
            labelRoomNumber.TabIndex = 59;
            labelRoomNumber.Text = "Room Number";
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtRoomNumber.Location = new Point(175, 159);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(240, 28);
            txtRoomNumber.TabIndex = 58;
            // 
            // labelRoomNo
            // 
            labelRoomNo.AutoSize = true;
            labelRoomNo.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelRoomNo.Location = new Point(23, 117);
            labelRoomNo.Name = "labelRoomNo";
            labelRoomNo.Size = new Size(86, 23);
            labelRoomNo.TabIndex = 57;
            labelRoomNo.Text = "Room No";
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(638, 180);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 49);
            btnClose.TabIndex = 73;
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
            btnUpdate.Location = new Point(493, 180);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 49);
            btnUpdate.TabIndex = 72;
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
            btnInsert.Location = new Point(638, 103);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(121, 49);
            btnInsert.TabIndex = 71;
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
            panel1.Size = new Size(775, 89);
            panel1.TabIndex = 191;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 13);
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
            label3.Location = new Point(580, 61);
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
            label1.Location = new Point(117, 29);
            label1.Name = "label1";
            label1.Size = new Size(158, 30);
            label1.TabIndex = 73;
            label1.Text = "Room's Form";
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 242);
            ClientSize = new Size(771, 483);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(txtRoomNo);
            Controls.Add(btnNew);
            Controls.Add(dgvRoom);
            Controls.Add(txtSearchRoom);
            Controls.Add(labelSearch);
            Controls.Add(txtBuildingNumber);
            Controls.Add(labelBuildingLetter);
            Controls.Add(labelRoomNumber);
            Controls.Add(txtRoomNumber);
            Controls.Add(labelRoomNo);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "RoomForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RoomForm";
            Load += RoomForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRoom).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRoomNo;
        private Button btnNew;
        private DataGridView dgvRoom;
        private TextBox txtSearchRoom;
        private Label labelSearch;
        private TextBox txtBuildingNumber;
        private Label labelBuildingLetter;
        private Label labelRoomNumber;
        private TextBox txtRoomNumber;
        private Label labelRoomNo;
        private DataGridViewTextBoxColumn RoomNo;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn BuildingLetter;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnInsert;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}