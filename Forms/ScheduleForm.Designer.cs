namespace SFaSMS
{
    partial class ScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
            dTStartDate = new DateTimePicker();
            cBMajorID = new ComboBox();
            txtMajorNameEN = new TextBox();
            txtScheduleID = new TextBox();
            labelSemester = new Label();
            labelStudyYear = new Label();
            labelMajorName = new Label();
            labelMajorID = new Label();
            labelScheduleID = new Label();
            labelStartDate = new Label();
            labelShift = new Label();
            labelSession = new Label();
            labelRoomNo = new Label();
            labelEndDate = new Label();
            txtStudyYear = new TextBox();
            cBSemester = new ComboBox();
            dTEndDate = new DateTimePicker();
            cBRoomNo = new ComboBox();
            cBSession = new ComboBox();
            cBShift = new ComboBox();
            btnNew = new Button();
            txtSearchSchedule = new TextBox();
            labelSearch = new Label();
            panel1 = new Panel();
            txtLecturerNameMon = new TextBox();
            txtSubjectNameTue = new TextBox();
            txtSubjectNameWed = new TextBox();
            txtSubjectNameThu = new TextBox();
            txtSubjectNameFri = new TextBox();
            txtSubjectNameSat = new TextBox();
            txtLecturerNameThu = new TextBox();
            txtLecturerNameSat = new TextBox();
            txtLecturerNameTue = new TextBox();
            txtLecturerNameWed = new TextBox();
            txtLecturerNameFri = new TextBox();
            txtSubjectNameMon = new TextBox();
            cBSubjectIDMon = new ComboBox();
            cBSubjectIDTue = new ComboBox();
            cBSubjectIDWed = new ComboBox();
            cBSubjectIDThu = new ComboBox();
            cBLecturerIDMon = new ComboBox();
            cBLecturerIDTue = new ComboBox();
            cBLecturerIDWed = new ComboBox();
            cBLecturerIDThu = new ComboBox();
            cBLecturerIDFri = new ComboBox();
            cBLecturerIDSat = new ComboBox();
            cBSubjectIDFri = new ComboBox();
            cBSubjectIDSat = new ComboBox();
            labelSaturday = new Label();
            labelFriday = new Label();
            labelThursday = new Label();
            labelWedneday = new Label();
            labelTuesday = new Label();
            labelMonday = new Label();
            labelSubjectName = new Label();
            labelSubjectID = new Label();
            labelLecturerName = new Label();
            labelLecturerID = new Label();
            dgvSchedule = new DataGridView();
            ScheduleID = new DataGridViewTextBoxColumn();
            MajorName = new DataGridViewTextBoxColumn();
            StudyYears = new DataGridViewTextBoxColumn();
            RoomNumber = new DataGridViewTextBoxColumn();
            Shift = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            btnClose = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dTStartDate
            // 
            dTStartDate.CustomFormat = "yyyy/MM/dd";
            dTStartDate.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dTStartDate.Location = new Point(150, 281);
            dTStartDate.Name = "dTStartDate";
            dTStartDate.Size = new Size(326, 28);
            dTStartDate.TabIndex = 77;
            // 
            // cBMajorID
            // 
            cBMajorID.DropDownStyle = ComboBoxStyle.DropDownList;
            cBMajorID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBMajorID.FormattingEnabled = true;
            cBMajorID.Location = new Point(150, 140);
            cBMajorID.Name = "cBMajorID";
            cBMajorID.Size = new Size(179, 31);
            cBMajorID.TabIndex = 76;
            // 
            // txtMajorNameEN
            // 
            txtMajorNameEN.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMajorNameEN.Location = new Point(150, 176);
            txtMajorNameEN.Name = "txtMajorNameEN";
            txtMajorNameEN.ReadOnly = true;
            txtMajorNameEN.Size = new Size(252, 28);
            txtMajorNameEN.TabIndex = 75;
            // 
            // txtScheduleID
            // 
            txtScheduleID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtScheduleID.Location = new Point(150, 106);
            txtScheduleID.Name = "txtScheduleID";
            txtScheduleID.ReadOnly = true;
            txtScheduleID.Size = new Size(200, 28);
            txtScheduleID.TabIndex = 73;
            // 
            // labelSemester
            // 
            labelSemester.AutoSize = true;
            labelSemester.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSemester.Location = new Point(4, 253);
            labelSemester.Name = "labelSemester";
            labelSemester.Size = new Size(87, 23);
            labelSemester.TabIndex = 72;
            labelSemester.Text = "Semester";
            // 
            // labelStudyYear
            // 
            labelStudyYear.AutoSize = true;
            labelStudyYear.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStudyYear.Location = new Point(4, 223);
            labelStudyYear.Name = "labelStudyYear";
            labelStudyYear.Size = new Size(101, 23);
            labelStudyYear.TabIndex = 71;
            labelStudyYear.Text = "Study Year";
            // 
            // labelMajorName
            // 
            labelMajorName.AutoSize = true;
            labelMajorName.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMajorName.Location = new Point(1, 183);
            labelMajorName.Name = "labelMajorName";
            labelMajorName.Size = new Size(143, 23);
            labelMajorName.TabIndex = 70;
            labelMajorName.Text = "Major Name EN";
            // 
            // labelMajorID
            // 
            labelMajorID.AutoSize = true;
            labelMajorID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMajorID.Location = new Point(4, 148);
            labelMajorID.Name = "labelMajorID";
            labelMajorID.Size = new Size(85, 23);
            labelMajorID.TabIndex = 69;
            labelMajorID.Text = "Major ID";
            // 
            // labelScheduleID
            // 
            labelScheduleID.AutoSize = true;
            labelScheduleID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelScheduleID.Location = new Point(4, 109);
            labelScheduleID.Name = "labelScheduleID";
            labelScheduleID.Size = new Size(110, 23);
            labelScheduleID.TabIndex = 68;
            labelScheduleID.Text = "Schedule ID";
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelStartDate.Location = new Point(4, 287);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(96, 23);
            labelStartDate.TabIndex = 78;
            labelStartDate.Text = "Start Date";
            // 
            // labelShift
            // 
            labelShift.AutoSize = true;
            labelShift.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelShift.Location = new Point(4, 431);
            labelShift.Name = "labelShift";
            labelShift.Size = new Size(51, 23);
            labelShift.TabIndex = 79;
            labelShift.Text = "Shift";
            // 
            // labelSession
            // 
            labelSession.AutoSize = true;
            labelSession.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSession.Location = new Point(4, 394);
            labelSession.Name = "labelSession";
            labelSession.Size = new Size(74, 23);
            labelSession.TabIndex = 80;
            labelSession.Text = "Session";
            // 
            // labelRoomNo
            // 
            labelRoomNo.AutoSize = true;
            labelRoomNo.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelRoomNo.Location = new Point(4, 357);
            labelRoomNo.Name = "labelRoomNo";
            labelRoomNo.Size = new Size(86, 23);
            labelRoomNo.TabIndex = 81;
            labelRoomNo.Text = "Room No";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelEndDate.Location = new Point(4, 325);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(88, 23);
            labelEndDate.TabIndex = 82;
            labelEndDate.Text = "End Date";
            // 
            // txtStudyYear
            // 
            txtStudyYear.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStudyYear.Location = new Point(150, 211);
            txtStudyYear.Name = "txtStudyYear";
            txtStudyYear.Size = new Size(200, 28);
            txtStudyYear.TabIndex = 83;
            // 
            // cBSemester
            // 
            cBSemester.DropDownStyle = ComboBoxStyle.DropDownList;
            cBSemester.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBSemester.FormattingEnabled = true;
            cBSemester.Location = new Point(150, 245);
            cBSemester.Name = "cBSemester";
            cBSemester.Size = new Size(154, 31);
            cBSemester.TabIndex = 84;
            // 
            // dTEndDate
            // 
            dTEndDate.CustomFormat = "yyyy/MM/dd";
            dTEndDate.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dTEndDate.Location = new Point(150, 313);
            dTEndDate.Name = "dTEndDate";
            dTEndDate.Size = new Size(326, 28);
            dTEndDate.TabIndex = 85;
            // 
            // cBRoomNo
            // 
            cBRoomNo.DropDownStyle = ComboBoxStyle.DropDownList;
            cBRoomNo.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBRoomNo.FormattingEnabled = true;
            cBRoomNo.Location = new Point(150, 347);
            cBRoomNo.Name = "cBRoomNo";
            cBRoomNo.Size = new Size(142, 31);
            cBRoomNo.TabIndex = 86;
            // 
            // cBSession
            // 
            cBSession.DropDownStyle = ComboBoxStyle.DropDownList;
            cBSession.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBSession.FormattingEnabled = true;
            cBSession.Location = new Point(150, 384);
            cBSession.Name = "cBSession";
            cBSession.Size = new Size(128, 31);
            cBSession.TabIndex = 87;
            // 
            // cBShift
            // 
            cBShift.DropDownStyle = ComboBoxStyle.DropDownList;
            cBShift.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBShift.FormattingEnabled = true;
            cBShift.Location = new Point(150, 421);
            cBShift.Name = "cBShift";
            cBShift.Size = new Size(179, 31);
            cBShift.TabIndex = 88;
            // 
            // btnNew
            // 
            btnNew.FlatAppearance.BorderColor = Color.FromArgb(25, 149, 173);
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.Location = new Point(57, 478);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(121, 49);
            btnNew.TabIndex = 89;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // txtSearchSchedule
            // 
            txtSearchSchedule.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchSchedule.Location = new Point(271, 551);
            txtSearchSchedule.Name = "txtSearchSchedule";
            txtSearchSchedule.Size = new Size(356, 28);
            txtSearchSchedule.TabIndex = 95;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelSearch.Location = new Point(31, 551);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(237, 28);
            labelSearch.TabIndex = 94;
            labelSearch.Text = "Search ( Schedule ID )";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtLecturerNameMon);
            panel1.Controls.Add(txtSubjectNameTue);
            panel1.Controls.Add(txtSubjectNameWed);
            panel1.Controls.Add(txtSubjectNameThu);
            panel1.Controls.Add(txtSubjectNameFri);
            panel1.Controls.Add(txtSubjectNameSat);
            panel1.Controls.Add(txtLecturerNameThu);
            panel1.Controls.Add(txtLecturerNameSat);
            panel1.Controls.Add(txtLecturerNameTue);
            panel1.Controls.Add(txtLecturerNameWed);
            panel1.Controls.Add(txtLecturerNameFri);
            panel1.Controls.Add(txtSubjectNameMon);
            panel1.Controls.Add(cBSubjectIDMon);
            panel1.Controls.Add(cBSubjectIDTue);
            panel1.Controls.Add(cBSubjectIDWed);
            panel1.Controls.Add(cBSubjectIDThu);
            panel1.Controls.Add(cBLecturerIDMon);
            panel1.Controls.Add(cBLecturerIDTue);
            panel1.Controls.Add(cBLecturerIDWed);
            panel1.Controls.Add(cBLecturerIDThu);
            panel1.Controls.Add(cBLecturerIDFri);
            panel1.Controls.Add(cBLecturerIDSat);
            panel1.Controls.Add(cBSubjectIDFri);
            panel1.Controls.Add(cBSubjectIDSat);
            panel1.Controls.Add(labelSaturday);
            panel1.Controls.Add(labelFriday);
            panel1.Controls.Add(labelThursday);
            panel1.Controls.Add(labelWedneday);
            panel1.Controls.Add(labelTuesday);
            panel1.Controls.Add(labelMonday);
            panel1.Controls.Add(labelSubjectName);
            panel1.Controls.Add(labelSubjectID);
            panel1.Controls.Add(labelLecturerName);
            panel1.Controls.Add(labelLecturerID);
            panel1.Location = new Point(495, 143);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 293);
            panel1.TabIndex = 97;
            // 
            // txtLecturerNameMon
            // 
            txtLecturerNameMon.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLecturerNameMon.Location = new Point(237, 58);
            txtLecturerNameMon.Name = "txtLecturerNameMon";
            txtLecturerNameMon.ReadOnly = true;
            txtLecturerNameMon.Size = new Size(217, 28);
            txtLecturerNameMon.TabIndex = 130;
            // 
            // txtSubjectNameTue
            // 
            txtSubjectNameTue.Anchor = AnchorStyles.Right;
            txtSubjectNameTue.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubjectNameTue.Location = new Point(586, 95);
            txtSubjectNameTue.Name = "txtSubjectNameTue";
            txtSubjectNameTue.ReadOnly = true;
            txtSubjectNameTue.Size = new Size(369, 28);
            txtSubjectNameTue.TabIndex = 129;
            // 
            // txtSubjectNameWed
            // 
            txtSubjectNameWed.Anchor = AnchorStyles.Right;
            txtSubjectNameWed.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubjectNameWed.Location = new Point(586, 133);
            txtSubjectNameWed.Name = "txtSubjectNameWed";
            txtSubjectNameWed.ReadOnly = true;
            txtSubjectNameWed.Size = new Size(369, 28);
            txtSubjectNameWed.TabIndex = 128;
            // 
            // txtSubjectNameThu
            // 
            txtSubjectNameThu.Anchor = AnchorStyles.Right;
            txtSubjectNameThu.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubjectNameThu.Location = new Point(586, 169);
            txtSubjectNameThu.Name = "txtSubjectNameThu";
            txtSubjectNameThu.ReadOnly = true;
            txtSubjectNameThu.Size = new Size(369, 28);
            txtSubjectNameThu.TabIndex = 127;
            // 
            // txtSubjectNameFri
            // 
            txtSubjectNameFri.Anchor = AnchorStyles.Right;
            txtSubjectNameFri.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubjectNameFri.Location = new Point(586, 208);
            txtSubjectNameFri.Name = "txtSubjectNameFri";
            txtSubjectNameFri.ReadOnly = true;
            txtSubjectNameFri.Size = new Size(369, 28);
            txtSubjectNameFri.TabIndex = 126;
            // 
            // txtSubjectNameSat
            // 
            txtSubjectNameSat.Anchor = AnchorStyles.Right;
            txtSubjectNameSat.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubjectNameSat.Location = new Point(586, 244);
            txtSubjectNameSat.Name = "txtSubjectNameSat";
            txtSubjectNameSat.ReadOnly = true;
            txtSubjectNameSat.Size = new Size(369, 28);
            txtSubjectNameSat.TabIndex = 125;
            // 
            // txtLecturerNameThu
            // 
            txtLecturerNameThu.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLecturerNameThu.Location = new Point(237, 172);
            txtLecturerNameThu.Name = "txtLecturerNameThu";
            txtLecturerNameThu.ReadOnly = true;
            txtLecturerNameThu.Size = new Size(217, 28);
            txtLecturerNameThu.TabIndex = 124;
            // 
            // txtLecturerNameSat
            // 
            txtLecturerNameSat.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLecturerNameSat.Location = new Point(237, 244);
            txtLecturerNameSat.Name = "txtLecturerNameSat";
            txtLecturerNameSat.ReadOnly = true;
            txtLecturerNameSat.Size = new Size(217, 28);
            txtLecturerNameSat.TabIndex = 123;
            // 
            // txtLecturerNameTue
            // 
            txtLecturerNameTue.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLecturerNameTue.Location = new Point(237, 95);
            txtLecturerNameTue.Name = "txtLecturerNameTue";
            txtLecturerNameTue.ReadOnly = true;
            txtLecturerNameTue.Size = new Size(217, 28);
            txtLecturerNameTue.TabIndex = 122;
            // 
            // txtLecturerNameWed
            // 
            txtLecturerNameWed.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLecturerNameWed.Location = new Point(237, 135);
            txtLecturerNameWed.Name = "txtLecturerNameWed";
            txtLecturerNameWed.ReadOnly = true;
            txtLecturerNameWed.Size = new Size(217, 28);
            txtLecturerNameWed.TabIndex = 121;
            // 
            // txtLecturerNameFri
            // 
            txtLecturerNameFri.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtLecturerNameFri.Location = new Point(237, 209);
            txtLecturerNameFri.Name = "txtLecturerNameFri";
            txtLecturerNameFri.ReadOnly = true;
            txtLecturerNameFri.Size = new Size(217, 28);
            txtLecturerNameFri.TabIndex = 120;
            // 
            // txtSubjectNameMon
            // 
            txtSubjectNameMon.Anchor = AnchorStyles.Right;
            txtSubjectNameMon.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSubjectNameMon.Location = new Point(586, 59);
            txtSubjectNameMon.Name = "txtSubjectNameMon";
            txtSubjectNameMon.ReadOnly = true;
            txtSubjectNameMon.Size = new Size(369, 28);
            txtSubjectNameMon.TabIndex = 119;
            // 
            // cBSubjectIDMon
            // 
            cBSubjectIDMon.Anchor = AnchorStyles.Right;
            cBSubjectIDMon.DropDownStyle = ComboBoxStyle.DropDownList;
            cBSubjectIDMon.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBSubjectIDMon.FormattingEnabled = true;
            cBSubjectIDMon.Location = new Point(470, 55);
            cBSubjectIDMon.Name = "cBSubjectIDMon";
            cBSubjectIDMon.Size = new Size(110, 31);
            cBSubjectIDMon.TabIndex = 118;
            // 
            // cBSubjectIDTue
            // 
            cBSubjectIDTue.Anchor = AnchorStyles.Right;
            cBSubjectIDTue.DropDownStyle = ComboBoxStyle.DropDownList;
            cBSubjectIDTue.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBSubjectIDTue.FormattingEnabled = true;
            cBSubjectIDTue.Location = new Point(470, 92);
            cBSubjectIDTue.Name = "cBSubjectIDTue";
            cBSubjectIDTue.Size = new Size(110, 31);
            cBSubjectIDTue.TabIndex = 117;
            // 
            // cBSubjectIDWed
            // 
            cBSubjectIDWed.Anchor = AnchorStyles.Right;
            cBSubjectIDWed.DropDownStyle = ComboBoxStyle.DropDownList;
            cBSubjectIDWed.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBSubjectIDWed.FormattingEnabled = true;
            cBSubjectIDWed.Location = new Point(470, 132);
            cBSubjectIDWed.Name = "cBSubjectIDWed";
            cBSubjectIDWed.Size = new Size(110, 31);
            cBSubjectIDWed.TabIndex = 116;
            // 
            // cBSubjectIDThu
            // 
            cBSubjectIDThu.Anchor = AnchorStyles.Right;
            cBSubjectIDThu.DropDownStyle = ComboBoxStyle.DropDownList;
            cBSubjectIDThu.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBSubjectIDThu.FormattingEnabled = true;
            cBSubjectIDThu.Location = new Point(470, 169);
            cBSubjectIDThu.Name = "cBSubjectIDThu";
            cBSubjectIDThu.Size = new Size(110, 31);
            cBSubjectIDThu.TabIndex = 115;
            // 
            // cBLecturerIDMon
            // 
            cBLecturerIDMon.DropDownStyle = ComboBoxStyle.DropDownList;
            cBLecturerIDMon.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBLecturerIDMon.FormattingEnabled = true;
            cBLecturerIDMon.Location = new Point(121, 55);
            cBLecturerIDMon.Name = "cBLecturerIDMon";
            cBLecturerIDMon.Size = new Size(110, 31);
            cBLecturerIDMon.TabIndex = 114;
            // 
            // cBLecturerIDTue
            // 
            cBLecturerIDTue.DropDownStyle = ComboBoxStyle.DropDownList;
            cBLecturerIDTue.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBLecturerIDTue.FormattingEnabled = true;
            cBLecturerIDTue.Location = new Point(121, 92);
            cBLecturerIDTue.Name = "cBLecturerIDTue";
            cBLecturerIDTue.Size = new Size(110, 31);
            cBLecturerIDTue.TabIndex = 113;
            // 
            // cBLecturerIDWed
            // 
            cBLecturerIDWed.DropDownStyle = ComboBoxStyle.DropDownList;
            cBLecturerIDWed.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBLecturerIDWed.FormattingEnabled = true;
            cBLecturerIDWed.Location = new Point(121, 132);
            cBLecturerIDWed.Name = "cBLecturerIDWed";
            cBLecturerIDWed.Size = new Size(110, 31);
            cBLecturerIDWed.TabIndex = 112;
            // 
            // cBLecturerIDThu
            // 
            cBLecturerIDThu.DropDownStyle = ComboBoxStyle.DropDownList;
            cBLecturerIDThu.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBLecturerIDThu.FormattingEnabled = true;
            cBLecturerIDThu.Location = new Point(121, 169);
            cBLecturerIDThu.Name = "cBLecturerIDThu";
            cBLecturerIDThu.Size = new Size(110, 31);
            cBLecturerIDThu.TabIndex = 111;
            // 
            // cBLecturerIDFri
            // 
            cBLecturerIDFri.DropDownStyle = ComboBoxStyle.DropDownList;
            cBLecturerIDFri.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBLecturerIDFri.FormattingEnabled = true;
            cBLecturerIDFri.Location = new Point(121, 206);
            cBLecturerIDFri.Name = "cBLecturerIDFri";
            cBLecturerIDFri.Size = new Size(110, 31);
            cBLecturerIDFri.TabIndex = 110;
            // 
            // cBLecturerIDSat
            // 
            cBLecturerIDSat.DropDownStyle = ComboBoxStyle.DropDownList;
            cBLecturerIDSat.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBLecturerIDSat.FormattingEnabled = true;
            cBLecturerIDSat.Location = new Point(121, 243);
            cBLecturerIDSat.Name = "cBLecturerIDSat";
            cBLecturerIDSat.Size = new Size(110, 31);
            cBLecturerIDSat.TabIndex = 109;
            // 
            // cBSubjectIDFri
            // 
            cBSubjectIDFri.Anchor = AnchorStyles.Right;
            cBSubjectIDFri.DropDownStyle = ComboBoxStyle.DropDownList;
            cBSubjectIDFri.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBSubjectIDFri.FormattingEnabled = true;
            cBSubjectIDFri.Location = new Point(470, 206);
            cBSubjectIDFri.Name = "cBSubjectIDFri";
            cBSubjectIDFri.Size = new Size(110, 31);
            cBSubjectIDFri.TabIndex = 108;
            // 
            // cBSubjectIDSat
            // 
            cBSubjectIDSat.Anchor = AnchorStyles.Right;
            cBSubjectIDSat.DropDownStyle = ComboBoxStyle.DropDownList;
            cBSubjectIDSat.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cBSubjectIDSat.FormattingEnabled = true;
            cBSubjectIDSat.Location = new Point(470, 243);
            cBSubjectIDSat.Name = "cBSubjectIDSat";
            cBSubjectIDSat.Size = new Size(110, 31);
            cBSubjectIDSat.TabIndex = 107;
            // 
            // labelSaturday
            // 
            labelSaturday.AutoSize = true;
            labelSaturday.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSaturday.Location = new Point(13, 249);
            labelSaturday.Name = "labelSaturday";
            labelSaturday.Size = new Size(87, 23);
            labelSaturday.TabIndex = 106;
            labelSaturday.Text = "Saturday";
            // 
            // labelFriday
            // 
            labelFriday.AutoSize = true;
            labelFriday.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelFriday.Location = new Point(13, 214);
            labelFriday.Name = "labelFriday";
            labelFriday.Size = new Size(66, 23);
            labelFriday.TabIndex = 105;
            labelFriday.Text = "Friday";
            // 
            // labelThursday
            // 
            labelThursday.AutoSize = true;
            labelThursday.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelThursday.Location = new Point(13, 177);
            labelThursday.Name = "labelThursday";
            labelThursday.Size = new Size(91, 23);
            labelThursday.TabIndex = 104;
            labelThursday.Text = "Thursday";
            // 
            // labelWedneday
            // 
            labelWedneday.AutoSize = true;
            labelWedneday.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelWedneday.Location = new Point(13, 140);
            labelWedneday.Name = "labelWedneday";
            labelWedneday.Size = new Size(97, 23);
            labelWedneday.TabIndex = 103;
            labelWedneday.Text = "Wedneday";
            // 
            // labelTuesday
            // 
            labelTuesday.AutoSize = true;
            labelTuesday.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelTuesday.Location = new Point(16, 100);
            labelTuesday.Name = "labelTuesday";
            labelTuesday.Size = new Size(81, 23);
            labelTuesday.TabIndex = 102;
            labelTuesday.Text = "Tuesday";
            // 
            // labelMonday
            // 
            labelMonday.AutoSize = true;
            labelMonday.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMonday.Location = new Point(16, 64);
            labelMonday.Name = "labelMonday";
            labelMonday.Size = new Size(78, 23);
            labelMonday.TabIndex = 101;
            labelMonday.Text = "Monday";
            // 
            // labelSubjectName
            // 
            labelSubjectName.Anchor = AnchorStyles.Right;
            labelSubjectName.AutoSize = true;
            labelSubjectName.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSubjectName.Location = new Point(602, 29);
            labelSubjectName.Name = "labelSubjectName";
            labelSubjectName.Size = new Size(124, 23);
            labelSubjectName.TabIndex = 100;
            labelSubjectName.Text = "Subject Name";
            // 
            // labelSubjectID
            // 
            labelSubjectID.Anchor = AnchorStyles.Right;
            labelSubjectID.AutoSize = true;
            labelSubjectID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelSubjectID.Location = new Point(484, 29);
            labelSubjectID.Name = "labelSubjectID";
            labelSubjectID.Size = new Size(96, 23);
            labelSubjectID.TabIndex = 99;
            labelSubjectID.Text = "Subject ID";
            // 
            // labelLecturerName
            // 
            labelLecturerName.AutoSize = true;
            labelLecturerName.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelLecturerName.Location = new Point(241, 29);
            labelLecturerName.Name = "labelLecturerName";
            labelLecturerName.Size = new Size(134, 23);
            labelLecturerName.TabIndex = 98;
            labelLecturerName.Text = "Lecturer Name";
            // 
            // labelLecturerID
            // 
            labelLecturerID.AutoSize = true;
            labelLecturerID.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelLecturerID.Location = new Point(121, 29);
            labelLecturerID.Name = "labelLecturerID";
            labelLecturerID.Size = new Size(106, 23);
            labelLecturerID.TabIndex = 69;
            labelLecturerID.Text = "Lecturer ID";
            // 
            // dgvSchedule
            // 
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Columns.AddRange(new DataGridViewColumn[] { ScheduleID, MajorName, StudyYears, RoomNumber, Shift, StartDate, EndDate });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSchedule.Location = new Point(120, 585);
            dgvSchedule.Name = "dgvSchedule";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Sitka Small", 11.249999F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvSchedule.RowTemplate.Height = 25;
            dgvSchedule.Size = new Size(1123, 166);
            dgvSchedule.TabIndex = 98;
            // 
            // ScheduleID
            // 
            ScheduleID.HeaderText = "Schedule ID";
            ScheduleID.Name = "ScheduleID";
            ScheduleID.Width = 150;
            // 
            // MajorName
            // 
            MajorName.HeaderText = "Major Name";
            MajorName.Name = "MajorName";
            MajorName.Width = 250;
            // 
            // StudyYears
            // 
            StudyYears.HeaderText = "Study Years";
            StudyYears.Name = "StudyYears";
            StudyYears.Width = 140;
            // 
            // RoomNumber
            // 
            RoomNumber.HeaderText = "Room Number";
            RoomNumber.Name = "RoomNumber";
            RoomNumber.Width = 170;
            // 
            // Shift
            // 
            Shift.HeaderText = "Shift";
            Shift.Name = "Shift";
            // 
            // StartDate
            // 
            StartDate.HeaderText = "Start Date";
            StartDate.Name = "StartDate";
            StartDate.Width = 135;
            // 
            // EndDate
            // 
            EndDate.HeaderText = "End Date";
            EndDate.Name = "EndDate";
            EndDate.Width = 135;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatAppearance.BorderColor = Color.White;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Sitka Small", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1277, 478);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(121, 49);
            btnClose.TabIndex = 101;
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
            btnUpdate.Location = new Point(921, 478);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(121, 49);
            btnUpdate.TabIndex = 100;
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
            btnInsert.Location = new Point(486, 478);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(121, 49);
            btnInsert.TabIndex = 99;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1490, 89);
            panel2.TabIndex = 192;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 13);
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
            label3.Location = new Point(1295, 59);
            label3.Name = "label3";
            label3.Size = new Size(192, 21);
            label3.TabIndex = 74;
            label3.Text = "ISAD M3 GROUP1 2024";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(120, 32);
            label1.Name = "label1";
            label1.Size = new Size(195, 30);
            label1.TabIndex = 73;
            label1.Text = "Schedule's Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(495, 113);
            label2.Name = "label2";
            label2.Size = new Size(185, 23);
            label2.TabIndex = 131;
            label2.Text = "schedule per session";
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 241, 242);
            ClientSize = new Size(1486, 769);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(dgvSchedule);
            Controls.Add(panel1);
            Controls.Add(txtSearchSchedule);
            Controls.Add(labelSearch);
            Controls.Add(btnNew);
            Controls.Add(cBShift);
            Controls.Add(cBSession);
            Controls.Add(cBRoomNo);
            Controls.Add(dTEndDate);
            Controls.Add(cBSemester);
            Controls.Add(txtStudyYear);
            Controls.Add(labelEndDate);
            Controls.Add(labelRoomNo);
            Controls.Add(labelSession);
            Controls.Add(labelShift);
            Controls.Add(labelStartDate);
            Controls.Add(dTStartDate);
            Controls.Add(cBMajorID);
            Controls.Add(txtMajorNameEN);
            Controls.Add(txtScheduleID);
            Controls.Add(labelSemester);
            Controls.Add(labelStudyYear);
            Controls.Add(labelMajorName);
            Controls.Add(labelMajorID);
            Controls.Add(labelScheduleID);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1502, 808);
            MinimumSize = new Size(1502, 0);
            Name = "ScheduleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ScheduleForm";
            Load += ScheduleForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dTStartDate;
        private ComboBox cBMajorID;
        private TextBox txtMajorNameEN;
        private TextBox txtScheduleID;
        private Label labelSemester;
        private Label labelStudyYear;
        private Label labelMajorName;
        private Label labelMajorID;
        private Label labelScheduleID;
        private Label labelStartDate;
        private Label labelShift;
        private Label labelSession;
        private Label labelRoomNo;
        private Label labelEndDate;
        private TextBox txtStudyYear;
        private ComboBox cBSemester;
        private DateTimePicker dTEndDate;
        private ComboBox cBRoomNo;
        private ComboBox cBSession;
        private ComboBox cBShift;
        private Button btnNew;
        private TextBox txtSearchSchedule;
        private Label labelSearch;
        private Panel panel1;
        private Label labelSubjectName;
        private Label labelSubjectID;
        private Label labelLecturerName;
        private Label labelLecturerID;
        private ComboBox cBSubjectIDTue;
        private ComboBox cBSubjectIDWed;
        private ComboBox cBSubjectIDThu;
        private ComboBox cBLecturerIDMon;
        private ComboBox cBLecturerIDTue;
        private ComboBox cBLecturerIDWed;
        private ComboBox cBLecturerIDThu;
        private ComboBox cBLecturerIDFri;
        private ComboBox cBLecturerIDSat;
        private ComboBox cBSubjectIDFri;
        private ComboBox cBSubjectIDSat;
        private Label labelSaturday;
        private Label labelFriday;
        private Label labelThursday;
        private Label labelWedneday;
        private Label labelTuesday;
        private Label labelMonday;
        private TextBox txtSubjectNameTue;
        private TextBox txtSubjectNameWed;
        private TextBox txtSubjectNameThu;
        private TextBox txtSubjectNameFri;
        private TextBox txtSubjectNameSat;
        private TextBox txtLecturerNameThu;
        private TextBox txtLecturerNameSat;
        private TextBox txtLecturerNameTue;
        private TextBox txtLecturerNameWed;
        private TextBox txtLecturerNameFri;
        private TextBox txtSubjectNameMon;
        private ComboBox cBSubjectIDMon;
        private TextBox txtLecturerNameMon;
        private DataGridView dgvSchedule;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnInsert;
        private DataGridViewTextBoxColumn ScheduleID;
        private DataGridViewTextBoxColumn MajorName;
        private DataGridViewTextBoxColumn StudyYears;
        private DataGridViewTextBoxColumn RoomNumber;
        private DataGridViewTextBoxColumn Shift;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}