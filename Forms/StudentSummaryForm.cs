using SFaSMS.Models;
using SFaSMS.Utils;

namespace SFaSMS
{
    public partial class StudentSummaryForm : Form
    {
        private MainForm mainFormReference;
        Student? effectedStudent = null;
        StudentSummary? effectedStuSum = null;
        Major? effectedMajor = null;
        List<string> listBoxStudentSummary = new List<string>();
        int StudentSummaryCount = 0;
        int indexOfUpdateStudentSummary;

        string[] Degree { get; set; } = new string[] { "Bachelor", "Master", "PhD" };
        public StudentSummaryForm(MainForm mainform)
        {
            InitializeComponent();
            mainFormReference = mainform;
            this.FormClosed += new FormClosedEventHandler((_, _) => mainFormReference.Show());
            cBStuSumDegree.DataSource = Degree;
            btnClose.Click += (_, _) => this.Close();
            btnNew.Click += DoClickNewFormInput;
            btnInsert.Click += DoClickInsertStuSum;
            btnUpdate.Click += DoClickUpdateStuSum;
            cBStudentID.SelectedValueChanged += Select_Handling_StudentID;
            cBMajorID.SelectedValueChanged += Select_Handling_MajorID;
            lsStuSum.SelectedIndexChanged += Select_Handling_StuSum;
            txtSearchStudentSummary.TextChanged += SearchChangedFunc;
            dTStuSumRegisterDate.Format = DateTimePickerFormat.Custom;
            listBoxStudentSummary.Clear();
        }
        private void SearchChangedFunc(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchStudentSummary.Text) == false)
            {
                lsStuSum.Items.Clear();
                foreach (string studentsummary in listBoxStudentSummary)

                {
                    string[] splitText = studentsummary.Split('.');
                    if (splitText[1].Trim().StartsWith(txtSearchStudentSummary.Text))
                    {
                        lsStuSum.Items.Add(studentsummary);
                    }
                }
            }
            else if (txtSearchStudentSummary.Text == "")
            {
                lsStuSum.Items.Clear();
                foreach (string studentsummary in listBoxStudentSummary)
                {
                    lsStuSum.Items.Add(studentsummary);
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
                    effectedStudent = StudentFunc.GetOneStudentIDandPhoto(Program.Connection, int.Parse(studentID.Trim()));
                    txtStudentNameKH.Text = effectedStudent.StudentNameKH;
                    if (effectedStudent.Photo == null)
                    {
                        picStudent.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(effectedStudent.Photo);
                        picStudent.Image = Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
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
                    effectedMajor = MajorFunc.GetOneMajorNameKH(Program.Connection, int.Parse(majorID.Trim()));
                    txtMajorNameKH.Text = effectedMajor.MajorNameKH;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }

            }
        }
        private void Select_Handling_StuSum(object? sender, EventArgs e)
        {
            if (lsStuSum.SelectedItems != null)
            {
                if (lsStuSum.SelectedIndex != -1)
                {
                    string? staffData = lsStuSum.SelectedItems[0].ToString();
                    if (staffData == null) return;
                    string[] tempData = staffData.Split('.');
                    try
                    {
                        effectedStuSum = StudentSummaryFunc.GetOneStudentSummary(Program.Connection, int.Parse(tempData[0].Trim()));
                        txtStuSumID.Text = effectedStuSum.StuSumID.ToString();
                        dTStuSumRegisterDate.Value = effectedStuSum.RegisterDate;
                        cBStuSumDegree.SelectedItem = effectedStuSum.Degree.ToString();
                        cBStudentID.SelectedItem = effectedStuSum.StudentID.ToString();
                        cBRoomNo.SelectedItem = effectedStuSum.RoomNo.ToString();
                        cBMajorID.Text = effectedStuSum.MajorID.ToString();
                        txtStudentNameKH.Text = effectedStuSum.StudentNameKH;
                        txtMajorNameKH.Text = effectedStuSum.MajorNameKH;


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Please select the right name !!!");
                }
            }
        }
        private void DoClickUpdateStuSum(object? sender, EventArgs e)
        {

            if (effectedStuSum != null)
            {
                effectedStuSum.RegisterDate = dTStuSumRegisterDate.Value;
                effectedStuSum.Degree = cBStuSumDegree.SelectedItem.ToString();
                if (int.TryParse(cBStudentID.SelectedItem.ToString(), out int studentID) == false) return;
                effectedStuSum.StudentID = studentID;
                if (int.TryParse(cBRoomNo.SelectedItem.ToString(), out int roomNo) == false) return;
                effectedStuSum.RoomNo = roomNo;
                if (int.TryParse(cBMajorID.SelectedItem.ToString(), out int majorID) == false) return;
                effectedStuSum.MajorID = majorID;
                effectedStuSum.StudentNameKH = txtStudentNameKH.Text.Trim();
                effectedStuSum.MajorNameKH = txtMajorNameKH.Text.Trim();
                try
                {
                    var result = StudentSummaryFunc.UpdateStudentSummary(Program.Connection, effectedStuSum);
                    if (result == true)
                        MessageBox.Show($"Successfully updated an existing Student Summary with the id {effectedStuSum.StuSumID}");
                    foreach (string checkStudentSummary in listBoxStudentSummary)
                    {
                        string[] splitText = checkStudentSummary.Split('.');
                        if (splitText[0].Trim().Equals(effectedStuSum.StuSumID.ToString()))
                        {
                            indexOfUpdateStudentSummary = listBoxStudentSummary.IndexOf(checkStudentSummary);
                            listBoxStudentSummary.Remove(checkStudentSummary);
                            break;
                        }
                    }
                    listBoxStudentSummary.Insert(indexOfUpdateStudentSummary, $"{effectedStuSum.StuSumID}. {effectedStuSum.StudentNameKH}");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to update an existing Student Summary > {ex.Message}");
                }
                LoadingDataStuSum();
            }

        }
        private void DoClickInsertStuSum(object? sender, EventArgs e)
        {
            if (dTStuSumRegisterDate.Text == "")
            {
                MessageBox.Show("Register Date is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cBStuSumDegree.SelectedItem == null)
            {
                MessageBox.Show("Staff Name EN is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cBStudentID.SelectedItem == null)
            {
                MessageBox.Show("Student ID is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cBRoomNo.SelectedItem == null)
            {
                MessageBox.Show("Room No is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cBMajorID.SelectedItem == null)
            {
                MessageBox.Show("Major Number is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string? studentID = cBStudentID.SelectedItem.ToString();
            if (studentID == null) return;
            string? rooNo = cBRoomNo.SelectedItem.ToString();
            if (rooNo == null) return;
            string? majorID = cBMajorID.SelectedItem.ToString();
            if (majorID == null) return;

            StudentSummary newStuSum = new StudentSummary()
            {
                RegisterDate = dTStuSumRegisterDate.Value,
                Degree = cBStuSumDegree.SelectedItem.ToString(),
                StudentID = int.Parse(studentID),
                RoomNo = int.Parse(rooNo),
                MajorID = int.Parse(majorID),
                StudentNameKH = txtStudentNameKH.Text,
                MajorNameKH = txtMajorNameKH.Text,
            };
            try
            {
                var result = StudentSummaryFunc.AddStudentSummary(Program.Connection, newStuSum);
                if (result == true)
                    MessageBox.Show($"Successfully inserted Student Summary with the id {txtStuSumID.Text}");
                listBoxStudentSummary.Add($"{txtStuSumID.Text}. {newStuSum.StudentNameKH}");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            LoadingDataStuSum();
        }
        private void DoClickNewFormInput(object? sender, EventArgs e)
        {

            txtStuSumID.Text = (StudentSummaryCount + 1).ToString();
            dTStuSumRegisterDate.ResetText();
            cBStuSumDegree.SelectedItem = null;
            cBStudentID.SelectedItem = null;
            cBRoomNo.SelectedItem = null;
            cBMajorID.SelectedItem = null;
            txtStudentNameKH.Clear();
            txtMajorNameKH.Clear();
            picStudent.Image = null;
        }
        private void StudentSummaryForm_Load(object sender, EventArgs e)
        {
            LoadingDataStuSum();
            LoadingDataStudentID();
            LoadingDataRoomNo();
            LoadingDataMajorID();
            txtStuSumID.Text = (StudentSummaryCount + 1).ToString();
            foreach (string studentSummary in lsStuSum.Items)
            {
                listBoxStudentSummary.Add(studentSummary);
                txtSearchStudentSummary.CharacterCasing = CharacterCasing.Lower;
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
                picStudent.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving students ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show(ex.Message, "Retrieving Room No", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtMajorNameKH.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving Major ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadingDataStuSum()
        {
            try
            {
                var result = StudentSummaryFunc.GetAllStudentSummary(Program.Connection);
                if (result.LastOrDefault() != null) { StudentSummaryCount = result.LastOrDefault().StuSumID; }
                else { StudentSummaryCount = 0; }
                lsStuSum.Items.Clear();
                foreach (var stusum in result)
                {

                    lsStuSum.Items.Add($"{stusum.StuSumID}. {stusum.StudentNameKH}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving student Summary", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
