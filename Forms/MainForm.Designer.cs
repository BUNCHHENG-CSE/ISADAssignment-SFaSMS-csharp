namespace SFaSMS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panelHeader = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            panelSidebar = new Panel();
            labelDashboard = new Label();
            btnLogout = new Button();
            btnAttendance = new Button();
            btnPaymentStatus = new Button();
            btnUser = new Button();
            btnExam = new Button();
            btnPayment = new Button();
            btnSchedule = new Button();
            btnStudentSummary = new Button();
            btnMajor = new Button();
            btnRoom = new Button();
            btnSubject = new Button();
            btnLecturer = new Button();
            btnStaff = new Button();
            btnStudent = new Button();
            panelDisplay = new Panel();
            panelLecturer = new Panel();
            labelLecturerAmount = new Label();
            labelLecturerPanel = new Label();
            panelStaff = new Panel();
            labelStaffAmount = new Label();
            labelStaffPanel = new Label();
            panelStudent = new Panel();
            labelStudentAmount = new Label();
            labelStudentPanel = new Label();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSidebar.SuspendLayout();
            panelDisplay.SuspendLayout();
            panelLecturer.SuspendLayout();
            panelStaff.SuspendLayout();
            panelStudent.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(label3);
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(label1);
            panelHeader.Controls.Add(panel2);
            panelHeader.Location = new Point(0, 1);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1205, 100);
            panelHeader.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonShadow;
            label3.Location = new Point(1010, 73);
            label3.Name = "label3";
            label3.Size = new Size(192, 21);
            label3.TabIndex = 76;
            label3.Text = "ISAD M3 GROUP1 2024";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(59, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(156, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(287, 28);
            label1.Name = "label1";
            label1.Size = new Size(595, 35);
            label1.TabIndex = 2;
            label1.Text = "School Fee and Studying Management System";
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 554);
            panel2.TabIndex = 1;
            // 
            // panelSidebar
            // 
            panelSidebar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelSidebar.AutoScroll = true;
            panelSidebar.BackColor = Color.White;
            panelSidebar.Controls.Add(labelDashboard);
            panelSidebar.Controls.Add(btnLogout);
            panelSidebar.Controls.Add(btnAttendance);
            panelSidebar.Controls.Add(btnPaymentStatus);
            panelSidebar.Controls.Add(btnUser);
            panelSidebar.Controls.Add(btnExam);
            panelSidebar.Controls.Add(btnPayment);
            panelSidebar.Controls.Add(btnSchedule);
            panelSidebar.Controls.Add(btnStudentSummary);
            panelSidebar.Controls.Add(btnMajor);
            panelSidebar.Controls.Add(btnRoom);
            panelSidebar.Controls.Add(btnSubject);
            panelSidebar.Controls.Add(btnLecturer);
            panelSidebar.Controls.Add(btnStaff);
            panelSidebar.Controls.Add(btnStudent);
            panelSidebar.Location = new Point(0, 101);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(260, 693);
            panelSidebar.TabIndex = 1;
            // 
            // labelDashboard
            // 
            labelDashboard.AutoSize = true;
            labelDashboard.BackColor = Color.White;
            labelDashboard.Font = new Font("Sitka Small", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelDashboard.Location = new Point(81, 15);
            labelDashboard.Name = "labelDashboard";
            labelDashboard.Size = new Size(134, 30);
            labelDashboard.TabIndex = 3;
            labelDashboard.Text = "Dashboard";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 128, 128);
            btnLogout.FlatAppearance.BorderColor = Color.White;
            btnLogout.FlatAppearance.BorderSize = 2;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(12, 635);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(239, 38);
            btnLogout.TabIndex = 12;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnAttendance
            // 
            btnAttendance.FlatAppearance.BorderColor = Color.LightGray;
            btnAttendance.FlatAppearance.BorderSize = 2;
            btnAttendance.FlatStyle = FlatStyle.Flat;
            btnAttendance.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnAttendance.Location = new Point(12, 591);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(239, 38);
            btnAttendance.TabIndex = 11;
            btnAttendance.Text = "Attendance";
            btnAttendance.UseVisualStyleBackColor = true;
            // 
            // btnPaymentStatus
            // 
            btnPaymentStatus.FlatAppearance.BorderColor = Color.LightGray;
            btnPaymentStatus.FlatAppearance.BorderSize = 2;
            btnPaymentStatus.FlatStyle = FlatStyle.Flat;
            btnPaymentStatus.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnPaymentStatus.Location = new Point(12, 547);
            btnPaymentStatus.Name = "btnPaymentStatus";
            btnPaymentStatus.Size = new Size(239, 38);
            btnPaymentStatus.TabIndex = 10;
            btnPaymentStatus.Text = "Payment Status";
            btnPaymentStatus.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            btnUser.FlatAppearance.BorderColor = Color.LightGray;
            btnUser.FlatAppearance.BorderSize = 2;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnUser.Location = new Point(12, 503);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(240, 38);
            btnUser.TabIndex = 9;
            btnUser.Text = "User";
            btnUser.UseVisualStyleBackColor = true;
            // 
            // btnExam
            // 
            btnExam.FlatAppearance.BorderColor = Color.LightGray;
            btnExam.FlatAppearance.BorderSize = 2;
            btnExam.FlatStyle = FlatStyle.Flat;
            btnExam.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnExam.Location = new Point(12, 459);
            btnExam.Name = "btnExam";
            btnExam.Size = new Size(239, 38);
            btnExam.TabIndex = 8;
            btnExam.Text = "Exam";
            btnExam.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            btnPayment.FlatAppearance.BorderColor = Color.LightGray;
            btnPayment.FlatAppearance.BorderSize = 2;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnPayment.Location = new Point(12, 415);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(239, 38);
            btnPayment.TabIndex = 7;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnSchedule
            // 
            btnSchedule.FlatAppearance.BorderColor = Color.LightGray;
            btnSchedule.FlatAppearance.BorderSize = 2;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnSchedule.Location = new Point(12, 371);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(239, 38);
            btnSchedule.TabIndex = 3;
            btnSchedule.Text = " Schedule";
            btnSchedule.UseVisualStyleBackColor = true;
            // 
            // btnStudentSummary
            // 
            btnStudentSummary.FlatAppearance.BorderColor = Color.LightGray;
            btnStudentSummary.FlatAppearance.BorderSize = 2;
            btnStudentSummary.FlatStyle = FlatStyle.Flat;
            btnStudentSummary.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudentSummary.Location = new Point(12, 327);
            btnStudentSummary.Name = "btnStudentSummary";
            btnStudentSummary.Size = new Size(240, 38);
            btnStudentSummary.TabIndex = 3;
            btnStudentSummary.Text = "Student Summary";
            btnStudentSummary.UseVisualStyleBackColor = true;
            // 
            // btnMajor
            // 
            btnMajor.FlatAppearance.BorderColor = Color.LightGray;
            btnMajor.FlatAppearance.BorderSize = 2;
            btnMajor.FlatStyle = FlatStyle.Flat;
            btnMajor.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnMajor.Location = new Point(12, 283);
            btnMajor.Name = "btnMajor";
            btnMajor.Size = new Size(240, 38);
            btnMajor.TabIndex = 6;
            btnMajor.Text = "Major";
            btnMajor.UseVisualStyleBackColor = true;
            // 
            // btnRoom
            // 
            btnRoom.FlatAppearance.BorderColor = Color.LightGray;
            btnRoom.FlatAppearance.BorderSize = 2;
            btnRoom.FlatStyle = FlatStyle.Flat;
            btnRoom.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnRoom.Location = new Point(12, 239);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(240, 38);
            btnRoom.TabIndex = 3;
            btnRoom.Text = "Room";
            btnRoom.UseVisualStyleBackColor = true;
            // 
            // btnSubject
            // 
            btnSubject.FlatAppearance.BorderColor = Color.LightGray;
            btnSubject.FlatAppearance.BorderSize = 2;
            btnSubject.FlatStyle = FlatStyle.Flat;
            btnSubject.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubject.Location = new Point(12, 195);
            btnSubject.Name = "btnSubject";
            btnSubject.Size = new Size(240, 38);
            btnSubject.TabIndex = 5;
            btnSubject.Text = "Subject";
            btnSubject.UseVisualStyleBackColor = true;
            // 
            // btnLecturer
            // 
            btnLecturer.FlatAppearance.BorderColor = Color.LightGray;
            btnLecturer.FlatAppearance.BorderSize = 2;
            btnLecturer.FlatStyle = FlatStyle.Flat;
            btnLecturer.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnLecturer.Location = new Point(12, 151);
            btnLecturer.Name = "btnLecturer";
            btnLecturer.Size = new Size(239, 38);
            btnLecturer.TabIndex = 4;
            btnLecturer.Text = "Lecturer";
            btnLecturer.UseVisualStyleBackColor = true;
            // 
            // btnStaff
            // 
            btnStaff.FlatAppearance.BorderColor = Color.LightGray;
            btnStaff.FlatAppearance.BorderSize = 2;
            btnStaff.FlatStyle = FlatStyle.Flat;
            btnStaff.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnStaff.Location = new Point(12, 107);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(240, 38);
            btnStaff.TabIndex = 3;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.White;
            btnStudent.BackgroundImageLayout = ImageLayout.None;
            btnStudent.FlatAppearance.BorderColor = Color.LightGray;
            btnStudent.FlatAppearance.BorderSize = 2;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Sitka Small", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnStudent.ForeColor = Color.Black;
            btnStudent.ImageAlign = ContentAlignment.MiddleLeft;
            btnStudent.Location = new Point(12, 63);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(240, 38);
            btnStudent.TabIndex = 2;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = false;
            // 
            // panelDisplay
            // 
            panelDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelDisplay.AutoScroll = true;
            panelDisplay.BackColor = Color.FromArgb(241, 241, 242);
            panelDisplay.Controls.Add(panelLecturer);
            panelDisplay.Controls.Add(panelStaff);
            panelDisplay.Controls.Add(panelStudent);
            panelDisplay.Location = new Point(261, 101);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(941, 693);
            panelDisplay.TabIndex = 2;
            // 
            // panelLecturer
            // 
            panelLecturer.Anchor = AnchorStyles.None;
            panelLecturer.BorderStyle = BorderStyle.FixedSingle;
            panelLecturer.Controls.Add(labelLecturerAmount);
            panelLecturer.Controls.Add(labelLecturerPanel);
            panelLecturer.Location = new Point(349, 25);
            panelLecturer.Name = "panelLecturer";
            panelLecturer.Size = new Size(242, 144);
            panelLecturer.TabIndex = 2;
            // 
            // labelLecturerAmount
            // 
            labelLecturerAmount.AutoSize = true;
            labelLecturerAmount.Font = new Font("Sitka Small Semibold", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelLecturerAmount.Location = new Point(100, 78);
            labelLecturerAmount.Name = "labelLecturerAmount";
            labelLecturerAmount.Size = new Size(36, 39);
            labelLecturerAmount.TabIndex = 1;
            labelLecturerAmount.Text = "0";
            // 
            // labelLecturerPanel
            // 
            labelLecturerPanel.AutoSize = true;
            labelLecturerPanel.Font = new Font("Sitka Small Semibold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelLecturerPanel.Location = new Point(68, 18);
            labelLecturerPanel.Name = "labelLecturerPanel";
            labelLecturerPanel.Size = new Size(107, 30);
            labelLecturerPanel.TabIndex = 0;
            labelLecturerPanel.Text = "Lecturer";
            // 
            // panelStaff
            // 
            panelStaff.Anchor = AnchorStyles.Right;
            panelStaff.BorderStyle = BorderStyle.FixedSingle;
            panelStaff.Controls.Add(labelStaffAmount);
            panelStaff.Controls.Add(labelStaffPanel);
            panelStaff.Location = new Point(637, 25);
            panelStaff.Name = "panelStaff";
            panelStaff.Size = new Size(242, 144);
            panelStaff.TabIndex = 1;
            // 
            // labelStaffAmount
            // 
            labelStaffAmount.AutoSize = true;
            labelStaffAmount.Font = new Font("Sitka Small Semibold", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelStaffAmount.Location = new Point(103, 78);
            labelStaffAmount.Name = "labelStaffAmount";
            labelStaffAmount.Size = new Size(36, 39);
            labelStaffAmount.TabIndex = 1;
            labelStaffAmount.Text = "0";
            // 
            // labelStaffPanel
            // 
            labelStaffPanel.AutoSize = true;
            labelStaffPanel.Font = new Font("Sitka Small Semibold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelStaffPanel.Location = new Point(86, 18);
            labelStaffPanel.Name = "labelStaffPanel";
            labelStaffPanel.Size = new Size(66, 30);
            labelStaffPanel.TabIndex = 0;
            labelStaffPanel.Text = "Staff";
            // 
            // panelStudent
            // 
            panelStudent.Anchor = AnchorStyles.Left;
            panelStudent.BorderStyle = BorderStyle.FixedSingle;
            panelStudent.Controls.Add(labelStudentAmount);
            panelStudent.Controls.Add(labelStudentPanel);
            panelStudent.Location = new Point(53, 25);
            panelStudent.Name = "panelStudent";
            panelStudent.Size = new Size(242, 144);
            panelStudent.TabIndex = 0;
            // 
            // labelStudentAmount
            // 
            labelStudentAmount.AutoSize = true;
            labelStudentAmount.Font = new Font("Sitka Small Semibold", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentAmount.Location = new Point(98, 78);
            labelStudentAmount.Name = "labelStudentAmount";
            labelStudentAmount.Size = new Size(36, 39);
            labelStudentAmount.TabIndex = 1;
            labelStudentAmount.Text = "0";
            // 
            // labelStudentPanel
            // 
            labelStudentPanel.AutoSize = true;
            labelStudentPanel.Font = new Font("Sitka Small Semibold", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudentPanel.Location = new Point(68, 18);
            labelStudentPanel.Name = "labelStudentPanel";
            labelStudentPanel.Size = new Size(98, 30);
            labelStudentPanel.TabIndex = 0;
            labelStudentPanel.Text = "Student";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 242);
            ClientSize = new Size(1202, 794);
            Controls.Add(panelDisplay);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Load += MainForm_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelDisplay.ResumeLayout(false);
            panelLecturer.ResumeLayout(false);
            panelLecturer.PerformLayout();
            panelStaff.ResumeLayout(false);
            panelStaff.PerformLayout();
            panelStudent.ResumeLayout(false);
            panelStudent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panel2;
        private Panel panelSidebar;
        private Button btnUser;
        private Button btnExam;
        private Button btnPayment;
        private Button btnSchedule;
        private Button btnStudentSummary;
        private Button btnMajor;
        private Button btnRoom;
        private Button btnSubject;
        private Button btnStaff;
        private Button btnStudent;
        private Button btnAttendance;
        private Button btnPaymentStatus;
        private Label label1;
        private Button btnLogout;
        private Label labelDashboard;
        private Panel panelDisplay;
        private Panel panelStudent;
        private Label labelStudentAmount;
        private Label labelStudentPanel;
        private Button btnLecturer;
        private PictureBox pictureBox1;
        private Panel panelStaff;
        private Panel panelLecturer;
        private Label labelLecturerAmount;
        private Label labelLecturerPanel;
        private Label labelStaffAmount;
        private Label labelStaffPanel;
        private Label label3;
    }
}