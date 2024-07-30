using SFaSMS.Models;
using SFaSMS.Utils;

namespace SFaSMS
{
    public partial class ScheduleForm : Form
    {
        private MainForm mainFormReference;
        Schedule? effectedSchedule = null;
        List<ScheduleLecturerDetail> effectedScheduleLecturerDetail = new List<ScheduleLecturerDetail>();
        List<ScheduleSubjectDetail> effectedScheduleSubjectDetail = new List<ScheduleSubjectDetail>();
        Major? effectedMajor = null;
        Lecturer? effectedLecturer = null;
        Subject? effectedSubject = null;
        List<DataGridViewRow> dataGridSchedule = new List<DataGridViewRow>();
        int indexOfUpdateSchedule;
        string[] shifts { get; set; } = new string[] { "Morning", "Afternoon", "Evening" };
        string[] semester { get; set; } = new string[] { "1", "2" };
        string[] session { get; set; } = new string[] { "1", "2" };
        int ScheduleCount = 0;
        ComboBox[] LecturerID;
        ComboBox[] SubjectID;
        TextBox[] LecturerNameKH;
        TextBox[] SubjectName;
        Dictionary<string, string> dayOfTheWeek = new Dictionary<string, string>()
        {
            { "Mon", "Monday" },{ "Tue", "Tuesday" },{ "Wed", "Wednesday" },{ "Thu", "Thursday" },{ "Fri", "Friday"},{ "Sat", "Saturday" },

        };
        public ScheduleForm(MainForm mainform)
        {
            InitializeComponent();
            mainFormReference = mainform;
            this.FormClosed += new FormClosedEventHandler((_, _) => mainFormReference.Show());
            cBShift.DataSource = shifts;
            cBSemester.DataSource = semester;
            cBSession.DataSource = session;
            btnClose.Click += (_, _) => this.Close();
            btnNew.Click += DoClickNewFormInput;
            btnInsert.Click += DoClickInsertSchedule;
            btnUpdate.Click += DoClickUpdateSchedule;
            cBMajorID.SelectedValueChanged += Select_Handling_MajorID;
            dgvSchedule.CellClick += Select_Handling_Schedule;
            txtSearchSchedule.TextChanged += SearchChangedFunc;
            dTStartDate.Format = DateTimePickerFormat.Custom;
            dTEndDate.Format = DateTimePickerFormat.Custom;
            dataGridSchedule.Clear();
            LecturerID = new ComboBox[] { cBLecturerIDMon, cBLecturerIDTue, cBLecturerIDWed, cBLecturerIDThu, cBLecturerIDFri, cBLecturerIDSat };
            LecturerNameKH = new TextBox[] { txtLecturerNameMon, txtLecturerNameTue, txtLecturerNameWed, txtLecturerNameThu, txtLecturerNameFri, txtLecturerNameSat }; ;
            SubjectID = new ComboBox[] { cBSubjectIDMon, cBSubjectIDTue, cBSubjectIDWed, cBSubjectIDThu, cBSubjectIDFri, cBSubjectIDSat };
            SubjectName = new TextBox[] { txtSubjectNameMon, txtSubjectNameTue, txtSubjectNameWed, txtSubjectNameThu, txtSubjectNameFri, txtSubjectNameSat }; ;
            foreach (ComboBox cBSubjectID in SubjectID)
            {
                cBSubjectID.SelectedValueChanged += Select_Handling_SubjectID;
            }
            foreach (ComboBox cBLecturerID in LecturerID)
            {
                cBLecturerID.SelectedValueChanged += Select_Handling_LecturerID;
            }
        }

        private void SearchChangedFunc(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchSchedule.Text) == false)
            {
                dgvSchedule.Rows.Clear();
                foreach (DataGridViewRow schedule in dataGridSchedule)
                {
                    if (schedule.Cells[0].Value.ToString().StartsWith(txtSearchSchedule.Text))
                    {
                        dgvSchedule.Rows.Add(schedule);
                    }
                }
            }
            else if (txtSearchSchedule.Text == "")
            {
                dgvSchedule.Rows.Clear();
                foreach (DataGridViewRow schedule in dataGridSchedule)
                {
                    dgvSchedule.Rows.Add(schedule);
                }
            }
        }
        private void Select_Handling_MajorID(object? sender, EventArgs e)
        {
            if (cBMajorID.SelectedItem != null)
            {
                string? majorID = cBMajorID.SelectedItem.ToString();
                if (majorID == null) return;

                try
                {
                    effectedMajor = MajorFunc.GetOneMajorNameEN(Program.Connection, int.Parse(majorID.Trim()));
                    txtMajorNameEN.Text = effectedMajor.MajorNameEN;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }

            }
        }
        private void Select_Handling_SubjectID(object? sender, EventArgs e)
        {
            for (int i = 0; i < SubjectID.Length; i++)
            {

                if (SubjectID[i].SelectedItem != null)
                {
                    string? subjectID = SubjectID[i].SelectedItem.ToString();
                    if (subjectID == null) return;

                    try
                    {
                        effectedSubject = SubjectFunc.GetOneSubjectname(Program.Connection, int.Parse(subjectID.Trim()));
                        SubjectName[i].Text = effectedSubject.SubjectName;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}");
                    }

                }
            }
        }
        private void Select_Handling_LecturerID(object? sender, EventArgs e)
        {
            for (int i = 0; i < LecturerID.Length; i++)
            {

                if (LecturerID[i].SelectedItem != null)
                {
                    string? lecturerID = LecturerID[i].SelectedItem.ToString();
                    if (lecturerID == null) return;

                    try
                    {
                        effectedLecturer = LecturerFunc.GetOneLecturerNameKH(Program.Connection, int.Parse(lecturerID.Trim()));
                        LecturerNameKH[i].Text = effectedLecturer.LecturerNameKH;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}");
                    }

                }
            }
        }
        private void Select_Handling_Schedule(object? sender, EventArgs e)
        {
            if (dgvSchedule.CurrentRow == null) return;
            int id = (int)dgvSchedule.CurrentRow.Cells["ScheduleID"].Value;
            try
            {
                effectedSchedule = ScheduleFunc.GetOneSchedule(Program.Connection, id);
                effectedScheduleLecturerDetail = ScheduleFunc.GetOneScheduleLecturerDetail(Program.Connection, id);


                if (effectedScheduleLecturerDetail != null && effectedScheduleLecturerDetail.Count > 0)
                {
                    ToViewLecturerDetail(effectedScheduleLecturerDetail);
                }
                else
                {
                    for (int i = 0; i < LecturerID.Length; i++)
                    {
                        LecturerID[i].SelectedItem = null;
                        LecturerNameKH[i].Text = "";
                    }
                }
                effectedScheduleSubjectDetail = ScheduleFunc.GetOneScheduleSubjectDetail(Program.Connection, id);
                if (effectedScheduleSubjectDetail != null && effectedScheduleSubjectDetail.Count > 0)
                {
                    ToViewSubjectDetail(effectedScheduleSubjectDetail);
                }
                else
                {
                    for (int i = 0; i < SubjectID.Length; i++)
                    {
                        SubjectID[i].SelectedItem = null;
                        SubjectName[i].Text = "";
                    }
                }
                txtScheduleID.Text = effectedSchedule.ScheduleID.ToString();
                cBMajorID.SelectedItem = effectedSchedule.MajorID.ToString();
                txtMajorNameEN.Text = effectedSchedule.MajorNameEN;
                txtStudyYear.Text = effectedSchedule.StudyYears.ToString();
                cBSemester.SelectedItem = effectedSchedule.Semester.ToString();
                dTStartDate.Value = effectedSchedule.StartDate;
                dTEndDate.Value = effectedSchedule.EndDate;
                cBRoomNo.SelectedItem = effectedSchedule.RoomNo.ToString();
                cBSession.SelectedItem = effectedSchedule.Session.ToString();
                cBShift.SelectedItem = effectedSchedule.Shifts.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Here: {ex.Message}");
            }
        }
        private void DoClickUpdateSchedule(object? sender, EventArgs e)
        {

            if (effectedSchedule != null)
            {
                if (int.TryParse(cBMajorID.SelectedItem.ToString(), out int majorID) == false) return;
                effectedSchedule.MajorID = majorID;
                effectedSchedule.MajorNameEN = txtMajorNameEN.Text;
                if (byte.TryParse(txtStudyYear.Text.ToString(), out byte studyyear) == false) return;
                effectedSchedule.StudyYears = studyyear;
                if (byte.TryParse(cBSemester.SelectedItem.ToString(), out byte semester) == false) return;
                effectedSchedule.Semester = semester;
                effectedSchedule.StartDate = dTStartDate.Value;
                effectedSchedule.EndDate = dTEndDate.Value;
                if (int.TryParse(cBRoomNo.SelectedItem.ToString(), out int roomno) == false) return;
                effectedSchedule.RoomNo = roomno;
                if (byte.TryParse(cBSession.SelectedItem.ToString(), out byte session) == false) return;
                effectedSchedule.Session = session;
                effectedSchedule.Shifts = cBShift.SelectedItem.ToString();
                
                try
                {
                    var result = ScheduleFunc.UpdateSchedule(Program.Connection, effectedSchedule);
                    if (result == true)
                        MessageBox.Show($"Successfully updated an existing Schedule with the id {effectedSchedule.ScheduleID}");
                    DataGridViewRow tempDataGridViewRow = new DataGridViewRow();
                    tempDataGridViewRow.CreateCells(dgvSchedule);
                    tempDataGridViewRow.Cells[0].Value = effectedSchedule.ScheduleID;
                    tempDataGridViewRow.Cells[1].Value = effectedSchedule.MajorNameEN;
                    tempDataGridViewRow.Cells[2].Value = effectedSchedule.StudyYears;
                    tempDataGridViewRow.Cells[3].Value = effectedSchedule.room;
                    tempDataGridViewRow.Cells[4].Value = effectedSchedule.Shifts;
                    tempDataGridViewRow.Cells[5].Value = effectedSchedule.StartDate;
                    tempDataGridViewRow.Cells[6].Value = effectedSchedule.EndDate;
                    foreach (DataGridViewRow checkSchedule in dataGridSchedule)
                    {
                        if (int.Parse(checkSchedule.Cells[0].Value.ToString()) == effectedSchedule.ScheduleID)
                        {
                            checkSchedule.Cells[1].Value = tempDataGridViewRow.Cells[1].Value ;
                            checkSchedule.Cells[2].Value = tempDataGridViewRow.Cells[2].Value;
                            checkSchedule.Cells[3].Value = tempDataGridViewRow.Cells[3].Value;
                            checkSchedule.Cells[4].Value = tempDataGridViewRow.Cells[4].Value;
                            checkSchedule.Cells[5].Value = tempDataGridViewRow.Cells[5].Value;
                            checkSchedule.Cells[6].Value = tempDataGridViewRow.Cells[6].Value;
                            break;
                        }
                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to update an existing Schedule > {ex.Message}");
                }
               
                if (effectedScheduleLecturerDetail != null)
                {
                    foreach (var schelectDetail in effectedScheduleLecturerDetail)
                    {
                        int oldLecturerID = schelectDetail.LecturerID;
                        schelectDetail.ScheduleID = int.Parse(txtScheduleID.Text.ToString());
                        if (schelectDetail.DaysOfTheWeek == null) continue;
                        else if (schelectDetail.DaysOfTheWeek == "Monday") { schelectDetail.LecturerNameKH = txtLecturerNameMon.Text; schelectDetail.LecturerID = int.Parse(cBLecturerIDMon.SelectedItem.ToString()); }
                        else if (schelectDetail.DaysOfTheWeek == "Tuesday") { schelectDetail.LecturerNameKH = txtLecturerNameTue.Text; schelectDetail.LecturerID = int.Parse(cBLecturerIDTue.SelectedItem.ToString()); }
                        else if (schelectDetail.DaysOfTheWeek == "Wednesday") { schelectDetail.LecturerNameKH = txtLecturerNameWed.Text; schelectDetail.LecturerID = int.Parse(cBLecturerIDWed.SelectedItem.ToString()); }
                        else if (schelectDetail.DaysOfTheWeek == "Thursday") { schelectDetail.LecturerNameKH = txtLecturerNameThu.Text; schelectDetail.LecturerID = int.Parse(cBLecturerIDThu.SelectedItem.ToString()); }
                        else if (schelectDetail.DaysOfTheWeek == "Friday") { schelectDetail.LecturerNameKH = txtLecturerNameFri.Text; schelectDetail.LecturerID = int.Parse(cBLecturerIDFri.SelectedItem.ToString()); }
                        else if (schelectDetail.DaysOfTheWeek == "Saturday") { schelectDetail.LecturerNameKH = txtLecturerNameSat.Text; schelectDetail.LecturerID = int.Parse(cBLecturerIDSat.SelectedItem.ToString()); }
                        try
                        {
                            var result = ScheduleFunc.UpdateScheduleLecturer(Program.Connection, schelectDetail, oldLecturerID);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to update an existing Schedule > {ex.Message}");
                        }
                    }
                }
                if (effectedScheduleSubjectDetail != null)
                {
                    foreach (var schesubDetail in effectedScheduleSubjectDetail)
                    {
                        int oldSubjectID = schesubDetail.SubjectID;

                        schesubDetail.ScheduleID = int.Parse(txtScheduleID.Text.ToString());

                        if (schesubDetail.DaysOfTheWeek == null) continue;
                        else if (schesubDetail.DaysOfTheWeek == "Monday") { schesubDetail.SubjectName = txtSubjectNameMon.Text; schesubDetail.SubjectID = int.Parse(cBSubjectIDMon.SelectedItem.ToString()); }
                        else if (schesubDetail.DaysOfTheWeek == "Tuesday") { schesubDetail.SubjectName = txtSubjectNameTue.Text; schesubDetail.SubjectID = int.Parse(cBSubjectIDTue.SelectedItem.ToString()); }
                        else if (schesubDetail.DaysOfTheWeek == "Wednesday") { schesubDetail.SubjectName = txtSubjectNameWed.Text; schesubDetail.SubjectID = int.Parse(cBSubjectIDWed.SelectedItem.ToString()); }
                        else if (schesubDetail.DaysOfTheWeek == "Thursday") { schesubDetail.SubjectName = txtSubjectNameThu.Text; schesubDetail.SubjectID = int.Parse(cBSubjectIDThu.SelectedItem.ToString()); }
                        else if (schesubDetail.DaysOfTheWeek == "Friday") { schesubDetail.SubjectName = txtSubjectNameFri.Text; schesubDetail.SubjectID = int.Parse(cBSubjectIDFri.SelectedItem.ToString()); }
                        else if (schesubDetail.DaysOfTheWeek == "Saturday") { schesubDetail.SubjectName = txtSubjectNameSat.Text; schesubDetail.SubjectID = int.Parse(cBSubjectIDSat.SelectedItem.ToString()); }
                        try
                        {

                            var result = ScheduleFunc.UpdateScheduleSubject(Program.Connection, schesubDetail, oldSubjectID);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Failed to update an existing Schedule > {ex.Message}");
                        }
                    }

                }

                LoadingDataSchedule();
            }

        }
        private void DoClickInsertSchedule(object? sender, EventArgs e)
        {

            if (cBMajorID.SelectedItem == null)
            {
                MessageBox.Show("Major ID is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtStudyYear.Text == "")
            {
                MessageBox.Show("Study Year is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cBSemester.SelectedItem == null)
            {
                MessageBox.Show("Semester is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (dTStartDate.Text == "")
            {
                MessageBox.Show("Start Date is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (dTEndDate.Text == "")
            {
                MessageBox.Show("End Date is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cBRoomNo.SelectedItem == null)
            {
                MessageBox.Show("Room No is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cBSession.SelectedItem == null)
            {
                MessageBox.Show("Session is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cBShift.SelectedItem == null)
            {
                MessageBox.Show("Shift is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string? MajorID = cBMajorID.SelectedItem.ToString();
            if (MajorID == null) return;
            if (byte.TryParse(txtStudyYear.Text.ToString(), out byte studyYear) == false) return ;
            if (byte.TryParse(cBSemester.SelectedItem.ToString(), out byte semester) == false) return;
            if (byte.TryParse(cBSession.SelectedItem.ToString(), out byte session) == false) return;
            if (int.TryParse(cBRoomNo.SelectedItem.ToString(), out int roomNo) == false) return;

            Schedule newSchedule = new Schedule()
            {
                MajorID = int.Parse(MajorID),
                MajorNameEN = txtMajorNameEN.Text,
                StudyYears = studyYear,
                Semester = semester,
                StartDate = dTStartDate.Value,
                EndDate = dTEndDate.Value,
                RoomNo = roomNo,
                Session = session,
                Shifts = cBShift.SelectedItem.ToString(),

            };
            try
            {
                var result = ScheduleFunc.AddSchedule(Program.Connection, newSchedule);
                if (result == true)
                    MessageBox.Show($"Successfully inserted Schedule with the id {txtScheduleID.Text}");
                DataGridViewRow tempDataGridViewRow = new DataGridViewRow();
                tempDataGridViewRow.CreateCells(dgvSchedule);
                tempDataGridViewRow.Cells[0].Value = txtScheduleID.Text;
                tempDataGridViewRow.Cells[1].Value = newSchedule.MajorNameEN;
                tempDataGridViewRow.Cells[2].Value = newSchedule.StudyYears;
                tempDataGridViewRow.Cells[3].Value = newSchedule.room;
                tempDataGridViewRow.Cells[4].Value = newSchedule.Shifts;
                tempDataGridViewRow.Cells[5].Value = newSchedule.StartDate;
                tempDataGridViewRow.Cells[5].Value = newSchedule.EndDate;

                dataGridSchedule.Insert(indexOfUpdateSchedule, tempDataGridViewRow);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            for (int i = 0; i < SubjectID.Length; i++)
            {
                ScheduleSubjectDetail newScheduleSubjectDetail = new ScheduleSubjectDetail();
                if (SubjectID[i].SelectedItem == null) continue;
                newScheduleSubjectDetail.SubjectID = int.Parse(SubjectID[i].SelectedItem.ToString());
                newScheduleSubjectDetail.ScheduleID = int.Parse(txtScheduleID.Text.ToString());
                if (SubjectName[i].Text == "") continue;
                newScheduleSubjectDetail.SubjectName = SubjectName[i].Text.ToString();
                string? DFTW = null;
                if (SubjectID[i] != null)
                    DFTW = dayOfTheWeek[SubjectID[i].Name.Substring(SubjectID[i].Name.Length - 3)];
                newScheduleSubjectDetail.DaysOfTheWeek = DFTW;
                try
                {
                    var result = ScheduleFunc.AddScheduleSubject(Program.Connection, newScheduleSubjectDetail);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            for (int i = 0; i < LecturerID.Length; i++)
            {
                ScheduleLecturerDetail newScheduleLecturerDetail = new ScheduleLecturerDetail();

                if (LecturerID[i].SelectedItem == null) continue;
                newScheduleLecturerDetail.LecturerID = int.Parse(LecturerID[i].SelectedItem.ToString());

                if (LecturerNameKH[i].Text == "") continue;
                newScheduleLecturerDetail.ScheduleID = int.Parse(txtScheduleID.Text.ToString());

                newScheduleLecturerDetail.LecturerNameKH = LecturerNameKH[i].Text.ToString();
                string? DFTW = null;
                if (LecturerID[i] != null)
                    DFTW = dayOfTheWeek[LecturerID[i].Name.Substring(LecturerID[i].Name.Length - 3)];
                newScheduleLecturerDetail.DaysOfTheWeek = DFTW;
                try
                {
                    var result = ScheduleFunc.AddScheduleLecturer(Program.Connection, newScheduleLecturerDetail);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            LoadingDataSchedule();
        }
        private void DoClickNewFormInput(object? sender, EventArgs e)
        {
            txtScheduleID.Text = (ScheduleCount + 1).ToString();
            cBMajorID.SelectedItem = null;
            txtMajorNameEN.Clear();
            txtStudyYear.Clear();
            cBSemester.SelectedItem = null;
            dTStartDate.ResetText();
            dTEndDate.ResetText();
            cBRoomNo.SelectedItem = null;
            cBSession.SelectedItem = null;
            cBShift.SelectedItem = null;
            for (int i = 0; i < 6; i++)
            {
                LecturerID[i].SelectedItem = null;
                LecturerNameKH[i].Clear();
                SubjectID[i].SelectedItem = null;
                SubjectName[i].Clear();

            }

        }
        private void ToViewLecturerDetail(List<ScheduleLecturerDetail> scheduleLecturerDetails)
        {
            foreach (var schelectDetail in scheduleLecturerDetails)
            {
                if (schelectDetail.DaysOfTheWeek == null) continue;
                else if (schelectDetail.DaysOfTheWeek == "Monday") { txtLecturerNameMon.Text = schelectDetail.LecturerNameKH; cBLecturerIDMon.SelectedItem = schelectDetail.LecturerID.ToString(); }
                else if (schelectDetail.DaysOfTheWeek == "Tuesday") { txtLecturerNameTue.Text = schelectDetail.LecturerNameKH; cBLecturerIDTue.SelectedItem = schelectDetail.LecturerID.ToString(); }
                else if (schelectDetail.DaysOfTheWeek == "Wednesday") { txtLecturerNameWed.Text = schelectDetail.LecturerNameKH; cBLecturerIDWed.SelectedItem = schelectDetail.LecturerID.ToString(); }
                else if (schelectDetail.DaysOfTheWeek == "Thursday") { txtLecturerNameThu.Text = schelectDetail.LecturerNameKH; cBLecturerIDThu.SelectedItem = schelectDetail.LecturerID.ToString(); }
                else if (schelectDetail.DaysOfTheWeek == "Friday") { txtLecturerNameFri.Text = schelectDetail.LecturerNameKH; cBLecturerIDFri.SelectedItem = schelectDetail.LecturerID.ToString(); }
                else if (schelectDetail.DaysOfTheWeek == "Saturday") { txtLecturerNameSat.Text = schelectDetail.LecturerNameKH; cBLecturerIDSat.SelectedItem = schelectDetail.LecturerID.ToString(); }
            }
        }
        private void ToViewSubjectDetail(List<ScheduleSubjectDetail> scheduleSubjectDetails)
        {
            foreach (var schesubDetail in scheduleSubjectDetails)
            {
                if (schesubDetail.DaysOfTheWeek == null) continue;
                else if (schesubDetail.DaysOfTheWeek == "Monday") { txtSubjectNameMon.Text = schesubDetail.SubjectName; cBSubjectIDMon.SelectedItem = schesubDetail.SubjectID.ToString(); }
                else if (schesubDetail.DaysOfTheWeek == "Tuesday") { txtSubjectNameTue.Text = schesubDetail.SubjectName; cBSubjectIDTue.SelectedItem = schesubDetail.SubjectID.ToString(); }
                else if (schesubDetail.DaysOfTheWeek == "Wednesday") { txtSubjectNameWed.Text = schesubDetail.SubjectName; cBSubjectIDWed.SelectedItem = schesubDetail.SubjectID.ToString(); }
                else if (schesubDetail.DaysOfTheWeek == "Thursday") { txtSubjectNameThu.Text = schesubDetail.SubjectName; cBSubjectIDThu.SelectedItem = schesubDetail.SubjectID.ToString(); }
                else if (schesubDetail.DaysOfTheWeek == "Friday") { txtSubjectNameFri.Text = schesubDetail.SubjectName; cBSubjectIDFri.SelectedItem = schesubDetail.SubjectID.ToString(); }
                else if (schesubDetail.DaysOfTheWeek == "Saturday") { txtSubjectNameSat.Text = schesubDetail.SubjectName; cBSubjectIDSat.SelectedItem = schesubDetail.SubjectID.ToString(); }

            }
        }
        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            LoadingDataSchedule();
            LoadingDataMajorID();
            LoadingDataRoomNo();
            LoadingLecturerID();
            LoadingDataSubjectID();
            txtScheduleID.Text = (ScheduleCount + 1).ToString();
            foreach (DataGridViewRow schedule in dgvSchedule.Rows)
            {
                dataGridSchedule.Add(schedule);
                txtSearchSchedule.CharacterCasing = CharacterCasing.Lower;
            }
        }
        private void LoadingDataRoomNo()
        {
            try
            {
                var result = RoomFunc.GetAllRoomNo(Program.Connection);
                List<string> ls = new List<string>();
                foreach (var room in result)
                {
                    ls.Add(room.RoomNo.ToString());
                }
                cBRoomNo.DataSource = ls;
                cBRoomNo.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving RoomNo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadingDataMajorID()
        {
            try
            {
                var result = MajorFunc.GetAllMajorID(Program.Connection);
                List<string> ls = new List<string>();
                foreach (var major in result)
                {
                    ls.Add(major.MajorID.ToString());
                }
                cBMajorID.DataSource = ls;
                cBMajorID.SelectedIndex = -1;
                txtMajorNameEN.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving MajorID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadingDataSchedule()
        {
            try
            {
                var result = ScheduleFunc.GetAllSchedule(Program.Connection);
                if (result.LastOrDefault() != null) { ScheduleCount = result.LastOrDefault().ScheduleID; }
                else { ScheduleCount = 0; }
                dgvSchedule.Rows.Clear();
                foreach (var schedule in result)
                {
                    DateTime dateTimeStartDate = schedule.StartDate;
                    string StartDateFormat = dateTimeStartDate.ToString(@"yyyy\/MM\/dd");


                    DateTime dateTimeEndDate = schedule.StartDate;
                    string EndDateFormat = dateTimeEndDate.ToString(@"yyyy\/MM\/dd");
                    dgvSchedule.Rows.Add(schedule.ScheduleID, schedule.MajorNameEN, schedule.StudyYears, schedule.room.RoomNumber, schedule.Shifts, StartDateFormat, EndDateFormat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving schedule", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadingDataSubjectID()
        {
            try
            {
                var result = SubjectFunc.GetAllSubjectID(Program.Connection);
                for (int i = 0; i < SubjectID.Length; i++)
                {
                    List<string> ls = new List<string>();
                    foreach (var subject in result)
                    {
                        ls.Add(subject.SubjectID.ToString());
                    }
                    SubjectID[i].DataSource = ls;
                    SubjectID[i].SelectedIndex = -1;
                    SubjectName[i].Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving students", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadingLecturerID()
        {
            try
            {
                var result = LecturerFunc.GetAllLecturerID(Program.Connection);
                for (int i = 0; i < LecturerID.Length; i++)
                {
                    List<string> ls = new List<string>();
                    foreach (var lecturer in result)
                    {
                        ls.Add(lecturer.LecturerID.ToString());
                    }
                    LecturerID[i].DataSource = ls;
                    LecturerID[i].SelectedIndex = -1;
                    LecturerNameKH[i].Clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving lecturer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
