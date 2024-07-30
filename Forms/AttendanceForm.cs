using SFaSMS.Models;
using SFaSMS.Utils;

namespace SFaSMS
{
    public partial class AttendanceForm : Form
    {
        private MainForm mainFormReference;
        Attendance? effectedAttendance = null;
        Student? effectedStudent = null;
        List<DataGridViewRow> dataGridAttendance = new List<DataGridViewRow>();
        int indexOfUpdateAttendance;
        string[] status { get; set; } = new string[] { "Absent", "Present" };
        int AttendanceCount = 0;
        public AttendanceForm(MainForm mainform)
        {
            InitializeComponent();
            mainFormReference = mainform;
            this.FormClosed += new FormClosedEventHandler((_, _) => mainFormReference.Show());
            btnClose.Click += (_, _) => this.Close();
            btnNew.Click += DoClickNewFormInput;
            btnInsert.Click += DoClickInsertAttendance;
            btnUpdate.Click += DoClickUpdateAttendance;
            cBStudentID.SelectedValueChanged += Select_Handling_StudentID;
            cBStatus.DataSource = status;
            dgvAttendance.CellClick += Select_Handling_Attendance;
            txtSearchAttendance.TextChanged += SearchChangedFunc;
            dTTimeRecorded.Format = DateTimePickerFormat.Custom;
            dTTimeRecorded.ShowUpDown = true;
            dTDateRecorded.Format = DateTimePickerFormat.Custom;
            dataGridAttendance.Clear();
        }
        private void SearchChangedFunc(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchAttendance.Text) == false)
            {
                dgvAttendance.Rows.Clear();
                foreach (DataGridViewRow attendance in dataGridAttendance)
                {
                    if (attendance.Cells[1].Value.ToString().StartsWith(txtSearchAttendance.Text))
                    {
                        dgvAttendance.Rows.Add(attendance);
                    }
                }
            }
            else if (txtSearchAttendance.Text == "")
            {
                dgvAttendance.Rows.Clear();
                foreach (DataGridViewRow attendance in dataGridAttendance)
                {
                    dgvAttendance.Rows.Add(attendance);
                }
            }
        }
        private void Select_Handling_StudentID(object? sender, EventArgs e)
        {
            if (cBStudentID.SelectedItem != null)
            {
                string? studentID = cBStudentID.SelectedItem.ToString();
                if (studentID == null) return;
                try
                {
                    effectedStudent = StudentFunc.GetOneStudentNameKH(Program.Connection, int.Parse(studentID.Trim()));
                    txtStudentNameKH.Text = effectedStudent.StudentNameKH;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }

            }
        }
        private void Select_Handling_Attendance(object? sender, EventArgs e)
        {
            if (dgvAttendance.CurrentRow == null) return;
            int id = (int)dgvAttendance.CurrentRow.Cells["AttendanceID"].Value;
            try
            {
                effectedAttendance = AttendanceFunc.GetOneAttendance(Program.Connection, id);
                txtAttendanceID.Text = effectedAttendance.AttendanceID.ToString();
                cBStudentID.SelectedItem = effectedAttendance.StudentID.ToString();
                cBStatus.SelectedItem = effectedAttendance.Status ? "Present" : "Absent";
                txtStudentNameKH.Text = effectedAttendance.StudentNameKH;
                txtClass.Text = effectedAttendance.Class;
                dTTimeRecorded.Value = DateTime.Today.Add(effectedAttendance.TimeRecorded);
                dTDateRecorded.Value = effectedAttendance.DateRecorded;
                txtGeneration.Text = effectedAttendance.Generation.ToString();
                dTStudyYear.Value = effectedAttendance.StudyYear;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Here: {ex.Message}");
            }
        }
        private void DoClickUpdateAttendance(object? sender, EventArgs e)
        {

            if (effectedAttendance != null)
            {
                if (int.TryParse(cBStudentID.SelectedItem.ToString(), out int studentID) == false) return;
                effectedAttendance.StudentID = studentID;
                effectedAttendance.Status = cBStatus.SelectedItem == "Present" ? true : false;
                effectedAttendance.StudentNameKH = txtStudentNameKH.Text.ToString();
                effectedAttendance.Class = txtClass.Text.ToString();
                effectedAttendance.TimeRecorded = dTTimeRecorded.Value.TimeOfDay;
                effectedAttendance.DateRecorded = dTDateRecorded.Value;
                if (int.TryParse(txtGeneration.Text.ToString(), out int generation) == false) return;
                effectedAttendance.Generation = generation;
                effectedAttendance.StudyYear = dTStudyYear.Value;

                try
                {
                    var result = AttendanceFunc.UpdateAttendance(Program.Connection, effectedAttendance);
                    if (result == true)
                        MessageBox.Show($"Successfully updated an existing Attendance with the id {txtAttendanceID.Text}");
                    DataGridViewRow tempDataGridViewRow = new DataGridViewRow();
                    tempDataGridViewRow.CreateCells(dgvAttendance);
                    tempDataGridViewRow.Cells[0].Value = effectedAttendance.AttendanceID;
                    tempDataGridViewRow.Cells[1].Value = effectedAttendance.StudentID;
                    tempDataGridViewRow.Cells[2].Value = effectedAttendance.StudentNameKH;
                    tempDataGridViewRow.Cells[3].Value = effectedAttendance.TimeRecorded;
                    tempDataGridViewRow.Cells[4].Value = effectedAttendance.DateRecorded;
                    tempDataGridViewRow.Cells[5].Value = effectedAttendance.Status;           
                    foreach (DataGridViewRow checkAttendance in dataGridAttendance)
                    {
                        if (int.Parse(checkAttendance.Cells[0].Value.ToString()) == effectedAttendance.AttendanceID)
                        {
                            checkAttendance.Cells[1].Value = tempDataGridViewRow.Cells[1].Value;
                            checkAttendance.Cells[2].Value = tempDataGridViewRow.Cells[2].Value;
                            checkAttendance.Cells[3].Value = tempDataGridViewRow.Cells[3].Value;
                            checkAttendance.Cells[4].Value = tempDataGridViewRow.Cells[4].Value;
                            checkAttendance.Cells[5].Value = tempDataGridViewRow.Cells[5].Value;
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to update an existing Attendance > {ex.Message}");
                }
                LoadingDataAttendance();
            }

        }
        private void DoClickInsertAttendance(object? sender, EventArgs e)
        {

            if (cBStudentID.SelectedItem == null)
            {
                MessageBox.Show("Student ID is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cBStatus.SelectedItem == null)
            {
                MessageBox.Show("Status is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtClass.Text == "" || txtClass.Text.Trim().Length > 3)
            {
                MessageBox.Show("Class is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (dTTimeRecorded.Text == "")
            {
                MessageBox.Show("Time Recorded is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (dTDateRecorded.Text == "")
            {
                MessageBox.Show("Date Recorded is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtGeneration.Text == "")
            {
                MessageBox.Show("Generation is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (dTStudyYear.Text == "")
            {
                MessageBox.Show("Study Year is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string? studentID = cBStudentID.SelectedItem.ToString();
            if (studentID == null) return;

            if (int.TryParse(txtGeneration.Text.ToString(), out int generation) == false) return;
            Attendance newAttendance = new Attendance()
            {
                StudentID = int.Parse(studentID),
                Status = cBStatus.SelectedItem == "Present" ? true : false,
                StudentNameKH = txtStudentNameKH.Text,
                Class = txtClass.Text,
                TimeRecorded = dTTimeRecorded.Value.TimeOfDay,
                DateRecorded = dTDateRecorded.Value,
                Generation = generation,
                StudyYear = dTStudyYear.Value,

            };
            try
            {
                var result = AttendanceFunc.AddAttendance(Program.Connection, newAttendance);
                if (result == true)
                    MessageBox.Show($"Successfully inserted Attendance with the id {txtAttendanceID.Text}");
                DataGridViewRow tempDataGridViewRow = new DataGridViewRow();
                tempDataGridViewRow.CreateCells(dgvAttendance);
                tempDataGridViewRow.Cells[0].Value = txtAttendanceID.Text;
                tempDataGridViewRow.Cells[1].Value = newAttendance.StudentID;
                tempDataGridViewRow.Cells[2].Value = newAttendance.StudentNameKH;
                tempDataGridViewRow.Cells[3].Value = newAttendance.TimeRecorded;
                tempDataGridViewRow.Cells[4].Value = newAttendance.DateRecorded;
                tempDataGridViewRow.Cells[5].Value = newAttendance.Status;
                dataGridAttendance.Add(tempDataGridViewRow);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            LoadingDataAttendance();
        }
        private void DoClickNewFormInput(object? sender, EventArgs e)
        {
            txtAttendanceID.Text = (AttendanceCount + 1).ToString();
            cBStudentID.SelectedItem = null;
            cBStatus.SelectedItem = null;
            txtStudentNameKH.Clear();
            txtClass.Clear();
            dTTimeRecorded.ResetText();
            dTDateRecorded.ResetText();
            txtGeneration.Clear();
            dTStudyYear.ResetText();
        }
        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            LoadingDataAttendance();
            LoadingDataStudentID();
            txtAttendanceID.Text = (AttendanceCount + 1).ToString();
            foreach (DataGridViewRow attendance in dgvAttendance.Rows)
            {
                dataGridAttendance.Add(attendance);
                txtSearchAttendance.CharacterCasing = CharacterCasing.Lower;
            }
        }
        private void LoadingDataStudentID()
        {
            try
            {
                var result = StudentFunc.GetAllStudentID(Program.Connection);
                List<string> ls = new List<string>();
                foreach (var student in result)
                {
                    ls.Add(student.StudentID.ToString());
                }
                cBStudentID.DataSource = ls;
                cBStudentID.SelectedIndex = -1;
                txtStudentNameKH.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving students ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadingDataAttendance()
        {
            try
            {
                var result = AttendanceFunc.GetAllAttendances(Program.Connection);
                if (result.LastOrDefault() != null) { AttendanceCount = result.LastOrDefault().AttendanceID; }
                else { AttendanceCount = 0; }
                dgvAttendance.Rows.Clear();

                foreach (var attendance in result)
                {
                    TimeSpan timeSpan = attendance.TimeRecorded;
                    string TimeRecordedFormat = timeSpan.ToString(@"hh\:mm\:ss");

                    DateTime dateTime = attendance.DateRecorded;
                    string DateRecordedFormat = dateTime.ToString(@"yyyy\/MM\/dd");
                    dgvAttendance.Rows.Add(attendance.AttendanceID, attendance.StudentID, attendance.StudentNameKH, TimeRecordedFormat, DateRecordedFormat, attendance.Status ? "Present" : "Absent");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving attendance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
