using SFaSMS.Models;
using SFaSMS.Utils;

namespace SFaSMS
{
    public partial class ExamForm : Form
    {
        private MainForm mainFormReference;
        Exam? effectedExam = null;
        Subject? effectedSubject = null;
        List<DataGridViewRow> dataGridExam = new List<DataGridViewRow>();
        int indexOfUpdateExam;

        public ExamForm(MainForm mainform)
        {
            InitializeComponent();
            mainFormReference = mainform;
            this.FormClosed += new FormClosedEventHandler((_, _) => mainFormReference.Show());
            btnClose.Click += (_, _) => this.Close();

            btnNew.Click += DoClickNewFormInput;
            btnInsert.Click += DoClickInsertExam;
            btnUpdate.Click += DoClickUpdateExam;
            cBSubjectID.SelectedValueChanged += Select_Handling_SubjectID;
            dgvExam.CellClick += Select_Handling_Exam;
            txtSearchExam.TextChanged += SearchChangedFunc;
            txtExamScore.TextChanged += ExamScoreChangedFunc;
        }

        private void ExamScoreChangedFunc(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtExamScore.Text) == false)
            {
                if (float.TryParse(txtExamScore.Text, out float score) == false) return;
                if (score >= 85 && score <= 100)
                {
                    txtGPA.Text = "4";
                    txtGrade.Text = "A";
                }
                else if (score >= 80 && score < 85)
                {
                    txtGPA.Text = "3.5";
                    txtGrade.Text = "B+";
                }
                else if (score >= 70 && score < 80)
                {
                    txtGPA.Text = "3";
                    txtGrade.Text = "B";
                }
                else if (score >= 65 && score < 70)
                {
                    txtGPA.Text = "2.5";
                    txtGrade.Text = "C+";
                }
                else if (score >= 50 && score < 65)
                {
                    txtGPA.Text = "2";
                    txtGrade.Text = "C";
                }
                else
                {
                    txtGPA.Text = "1.5";
                    txtGrade.Text = "D";
                }
            }
            else if (txtExamScore.Text == "")
            {
                txtGPA.Clear();
                txtGrade.Clear();
            }
        }

        private void SearchChangedFunc(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchExam.Text) == false)
            {
                dgvExam.Rows.Clear();
                foreach (DataGridViewRow exam in dataGridExam)
                {
                    if (exam.Cells[0].Value.ToString().StartsWith(txtSearchExam.Text))
                    {
                        dgvExam.Rows.Add(exam);
                    }
                }
            }
            else if (txtSearchExam.Text == "")
            {
                dgvExam.Rows.Clear();
                foreach (DataGridViewRow exam in dataGridExam)
                {
                    dgvExam.Rows.Add(exam);
                }
            }
        }
        private void Select_Handling_SubjectID(object? sender, EventArgs e)
        {
            if (cBSubjectID.SelectedItem != null)
            {
                string? subjectID = cBSubjectID.SelectedItem.ToString();
                if (subjectID == null) return;

                try
                {
                    effectedSubject = SubjectFunc.GetOneSubjectname(Program.Connection, int.Parse(subjectID.Trim()));
                    txtSubjectName.Text = effectedSubject.SubjectName;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }

            }
        }
        private void Select_Handling_Exam(object? sender, EventArgs e)
        {
            if (dgvExam.CurrentRow == null) return;
            int studentID = (int)dgvExam.CurrentRow.Cells["StudentID"].Value;
            int subjectID = (int)dgvExam.CurrentRow.Cells["SubjectID"].Value;

            try
            {
                effectedExam = ExamFunc.GetOneExam(Program.Connection, subjectID, studentID);
                cBSubjectID.SelectedItem = effectedExam.SubjectID.ToString();
                cBStudentID.SelectedItem = effectedExam.StudentID.ToString();
                txtExamScore.Text = effectedExam.ExamScore.ToString();

                txtGrade.Text = effectedExam.Grade.ToString();
                txtGPA.Text = effectedExam.GPA.ToString().Trim();
                txtSubjectName.Text = effectedExam.SubjectName;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Here: {ex.Message}");
            }

        }
        private void DoClickUpdateExam(object? sender, EventArgs e)
        {

            if (effectedExam != null)
            {
                if (float.TryParse(txtExamScore.Text.ToString(), out float examscore) == false) return;
                effectedExam.ExamScore = examscore;
                effectedExam.Grade = txtGrade.Text.ToString();
                effectedExam.GPA = txtGPA.Text.ToString();
                effectedExam.SubjectName = txtSubjectName.Text.ToString();

                try
                {
                    var result = ExamFunc.UpdateExam(Program.Connection, effectedExam);
                    if (result == true)
                        MessageBox.Show($"Successfully updated an existing exam  with the student id {effectedExam.StudentID}");

                    DataGridViewRow tempDataGridViewRow = new DataGridViewRow();
                    tempDataGridViewRow.CreateCells(dgvExam);
                    tempDataGridViewRow.Cells[0].Value = effectedExam.StudentID;
                    tempDataGridViewRow.Cells[1].Value = effectedExam.SubjectID;
                    tempDataGridViewRow.Cells[2].Value = effectedExam.SubjectName;
                    tempDataGridViewRow.Cells[3].Value = effectedExam.ExamScore;
                    tempDataGridViewRow.Cells[4].Value = effectedExam.GPA;

                    foreach (DataGridViewRow checkExam in dataGridExam)
                    {
                        if (int.Parse(checkExam.Cells[0].Value.ToString()) == effectedExam.StudentID)
                        {
                            checkExam.Cells[1].Value = tempDataGridViewRow.Cells[1].Value;
                            checkExam.Cells[2].Value = tempDataGridViewRow.Cells[2].Value;
                            checkExam.Cells[3].Value = tempDataGridViewRow.Cells[3].Value;
                            checkExam.Cells[4].Value = tempDataGridViewRow.Cells[4].Value;
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to update an existing Exam > {ex.Message}");
                }
                LoadingDataExam();
            }

        }
        private void DoClickInsertExam(object? sender, EventArgs e)
        {
            if (cBStudentID.SelectedItem == null)
            {
                MessageBox.Show("Student ID is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cBSubjectID.SelectedItem == null)
            {
                MessageBox.Show("Subject ID is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (float.TryParse(txtExamScore.Text, out float examScore) == false)
            {
                MessageBox.Show("Exam score is required or something wrong", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }


            string? studentID = cBStudentID.SelectedItem.ToString();
            if (studentID == null) return;
            string? subjectID = cBSubjectID.SelectedItem.ToString();
            if (subjectID == null) return;

            Exam newExam = new Exam()
            {
                SubjectID = int.Parse(subjectID),
                StudentID = int.Parse(studentID),
                ExamScore = examScore,
                Grade = txtGrade.Text.ToString(),
                GPA = txtGPA.Text.ToString(),
                SubjectName = txtSubjectName.Text,
            };
            try
            {
                var result = ExamFunc.AddExam(Program.Connection, newExam);
                if (result == true)
                    MessageBox.Show($"Successfully inserted exam  with the student id {cBStudentID.SelectedItem} and subject id {cBSubjectID.SelectedItem}");
                DataGridViewRow tempDataGridViewRow = new DataGridViewRow();
                tempDataGridViewRow.CreateCells(dgvExam);
                tempDataGridViewRow.Cells[0].Value = cBStudentID.SelectedItem;
                tempDataGridViewRow.Cells[1].Value = cBSubjectID.SelectedItem;
                tempDataGridViewRow.Cells[2].Value = newExam.SubjectName;
                tempDataGridViewRow.Cells[3].Value = newExam.ExamScore;
                tempDataGridViewRow.Cells[4].Value = newExam.GPA;
                dataGridExam.Insert(indexOfUpdateExam, tempDataGridViewRow);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            LoadingDataExam();
        }
        private void DoClickNewFormInput(object? sender, EventArgs e)
        {
            cBSubjectID.SelectedItem = null;
            cBStudentID.SelectedItem = null;
            txtGPA.Clear();
            txtGrade.Clear();
            txtExamScore.Clear();
            txtSubjectName.Clear();
        }
        private void ExamForm_Load(object sender, EventArgs e)
        {
            LoadingDataExam();
            LoadingDataSubjectID();
            LoadingDataStudentID();
            foreach (DataGridViewRow exam in dgvExam.Rows)
            {
                dataGridExam.Add(exam);
                txtSearchExam.CharacterCasing = CharacterCasing.Lower;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving Student ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadingDataSubjectID()
        {
            try
            {
                var result = SubjectFunc.GetAllSubjectID(Program.Connection);
                List<string> ls = new List<string>();
                foreach (var subject in result)
                {
                    ls.Add(subject.SubjectID.ToString());
                }
                cBSubjectID.DataSource = ls;
                cBSubjectID.SelectedIndex = -1;
                txtSubjectName.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving Subject ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadingDataExam()
        {
            try
            {
                var result = ExamFunc.GetAllExam(Program.Connection);

                dgvExam.Rows.Clear();
                foreach (var exam in result)
                {
                    dgvExam.Rows.Add(exam.StudentID, exam.SubjectID, exam.SubjectName, exam.ExamScore, exam.GPA);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving Exam", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
