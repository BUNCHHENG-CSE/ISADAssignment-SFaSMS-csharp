using SFaSMS.Models;
using SFaSMS.Utils;

namespace SFaSMS
{
    public partial class PaymentStatusForm : Form
    {
        private MainForm mainFormReference;
        Student? effectedStudent = null;
        PaymentStatus? effectedPaymentStatus = null;
        List<string> listBoxPaymentStatus = new List<string>();
        int PaymentStatusCount = 0;
        int indexOfUpdatePaymentStatus;
        string[] oneStatus { get; set; } = new string[] { "Not yet paid", "Paid" };
        string[] twoStatus { get; set; } = new string[] { "Not yet paid", "Paid" };
        string[] oneYearStatus { get; set; } = new string[] { "Not yet paid", "Paid" };

        public PaymentStatusForm(MainForm mainform)
        {
            InitializeComponent();
            mainFormReference = mainform;
            this.FormClosed += new FormClosedEventHandler((_, _) => mainFormReference.Show());
            btnNew.Click += DoClickNewFormInput;
            btnClose.Click += (_, _) => this.Close();
            cBStudentID.SelectedValueChanged += Select_Handling_StudentID;
            cBSemesterOneStatus.DataSource = oneStatus;
            cBSemesterTwoStatus.DataSource = twoStatus;
            cBOneYearStatus.DataSource = oneYearStatus;
            lsPaymentStatus.Click += Select_Handling_PaymentStatus;
            btnInsert.Click += DoClickInsertPaymentStatus;
            btnUpdate.Click += DoClickUpdatePaymentStatus;
            txtSearchPaymentStatus.TextChanged += SearchChangedFunc;
            listBoxPaymentStatus.Clear();
        }
        private void SearchChangedFunc(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchPaymentStatus.Text) == false)
            {
                lsPaymentStatus.Items.Clear();
                foreach (string paymentStatus in listBoxPaymentStatus)
                {
                    string[] splitText = paymentStatus.Split('.');
                    if (splitText[1].Trim().StartsWith(txtSearchPaymentStatus.Text))
                    {
                        lsPaymentStatus.Items.Add(paymentStatus);
                    }
                }
            }
            else if (txtSearchPaymentStatus.Text == "")
            {
                lsPaymentStatus.Items.Clear();
                foreach (string paymentStatus in listBoxPaymentStatus)
                {
                    lsPaymentStatus.Items.Add(paymentStatus);
                }
            }

        }
        private void DoClickUpdatePaymentStatus(object? sender, EventArgs e)
        {
            if (effectedPaymentStatus != null)
            {
                effectedPaymentStatus.SemesterOneStatus = cBSemesterOneStatus.SelectedItem == "Paid" ? true : false;
                effectedPaymentStatus.SemesterTwoStatus = cBSemesterTwoStatus.SelectedItem == "Paid" ? true : false;
                effectedPaymentStatus.OneYearStatus = cBOneYearStatus.SelectedItem == "Paid" ? true : false;
                effectedPaymentStatus.StudentID = int.Parse(cBStudentID.SelectedValue.ToString().Trim());
                effectedPaymentStatus.StudentNameKH = txtStudentNameKH.Text.Trim();
                try
                {
                    var result = PaymentStatusFunc.UpdatePaymentStatus(Program.Connection, effectedPaymentStatus);
                    if (result == true)
                        MessageBox.Show($"Successfully updated an existing payment status with the id {effectedPaymentStatus.PaymentStatusID}");
                    foreach (string checkPaymentStatus in listBoxPaymentStatus)
                    {
                        string[] splitText = checkPaymentStatus.Split('.');
                        if (splitText[0].Trim().Equals(effectedPaymentStatus.PaymentStatusID.ToString()))
                        {
                            indexOfUpdatePaymentStatus = listBoxPaymentStatus.IndexOf(checkPaymentStatus);
                            listBoxPaymentStatus.Remove(checkPaymentStatus);
                            break;
                        }
                    }
                    listBoxPaymentStatus.Insert(indexOfUpdatePaymentStatus, $"{effectedPaymentStatus.PaymentStatusID}. {effectedPaymentStatus.StudentNameKH}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to update an existing payment status > {ex.Message}");
                }
                LoadingDataPaymentStatus();
            }
        }
        private void DoClickInsertPaymentStatus(object? sender, EventArgs e)
        {
            if (cBSemesterOneStatus.SelectedItem == null)
            {
                MessageBox.Show("Semester One Status is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cBSemesterTwoStatus.SelectedItem == null)
            {
                MessageBox.Show("Semester Two Status is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (cBStudentID.SelectedItem == null)
            {
                MessageBox.Show("Student ID is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string? studentID = cBStudentID.SelectedItem.ToString();
            if (studentID == null) return;
            PaymentStatus newPaymentStatus = new PaymentStatus()
            {
                SemesterOneStatus = cBSemesterOneStatus.SelectedItem == "Paid" ? true : false,
                SemesterTwoStatus = cBSemesterTwoStatus.SelectedItem == "Paid" ? true : false,
                OneYearStatus = cBSemesterOneStatus.SelectedItem == "Paid" ? true : false,
                StudentID = int.Parse(studentID.Trim()),
                StudentNameKH = txtStudentNameKH.Text.Trim(),

            };
            try
            {
                var result = PaymentStatusFunc.AddPaymentStatus(Program.Connection, newPaymentStatus);
                if (result == true)
                    MessageBox.Show($"Successfully inserted payment status with the id {txtPaymentStatusID.Text}");
                listBoxPaymentStatus.Add($"{txtPaymentStatusID.Text}. {newPaymentStatus.StudentNameKH}");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            LoadingDataPaymentStatus();
        }
        private void DoClickNewFormInput(object? sender, EventArgs e)
        {
            txtPaymentStatusID.Text = (PaymentStatusCount + 1).ToString();
            cBSemesterOneStatus.SelectedItem = null;
            cBSemesterTwoStatus.SelectedItem = null;
            cBOneYearStatus.SelectedItem = null;
            cBStudentID.SelectedItem = null;
            txtStudentNameKH.Clear();
            lsPaymentStatus.ClearSelected();
        }
        private void Select_Handling_StudentID(object? sender, EventArgs e)
        {
            if (cBStudentID.SelectedItem != null)
            {
                string? staffID = cBStudentID.SelectedItem.ToString();
                if (staffID == null) return;

                try
                {
                    effectedStudent = StudentFunc.GetOneStudentNameKH(Program.Connection, int.Parse(staffID.Trim()));
                    txtStudentNameKH.Text = effectedStudent.StudentNameKH;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }

            }
        }
        private void Select_Handling_PaymentStatus(object? sender, EventArgs e)
        {
            if (lsPaymentStatus.SelectedItems != null)
            {
                if (lsPaymentStatus.SelectedIndex != -1)
                {
                    string? PaymentStatusData = lsPaymentStatus.SelectedItems[0].ToString();
                    if (PaymentStatusData == null) return;
                    string[] tempData = PaymentStatusData.Split('.');

                    try
                    {
                        effectedPaymentStatus = PaymentStatusFunc.GetOnePaymentStatus(Program.Connection, int.Parse(tempData[0].Trim()));
                        txtPaymentStatusID.Text = effectedPaymentStatus.PaymentStatusID.ToString();
                        cBSemesterOneStatus.SelectedItem = effectedPaymentStatus.SemesterOneStatus ? "Paid" : "Not yet paid";
                        cBSemesterTwoStatus.SelectedItem = effectedPaymentStatus.SemesterTwoStatus ? "Paid" : "Not yet paid";
                        cBOneYearStatus.SelectedItem = effectedPaymentStatus.OneYearStatus ? "Paid" : "Not yet paid";
                        cBStudentID.SelectedItem = effectedPaymentStatus.StudentID.ToString();
                        txtStudentNameKH.Text = effectedPaymentStatus.StudentNameKH;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Please select the right payment status list !!!");
                }
            }
        }
        private void PaymentStatusForm_Load(object sender, EventArgs e)
        {
            LoadingDataPaymentStatus();
            LoadingDataStudentID();
            txtPaymentStatusID.Text = (PaymentStatusCount + 1).ToString();
            foreach (string paymentStatus in lsPaymentStatus.Items)
            {
                listBoxPaymentStatus.Add(paymentStatus);
                txtSearchPaymentStatus.CharacterCasing = CharacterCasing.Lower;
            }
        }
        private void LoadingDataStudentID()
        {
            try
            {
                var result = StudentFunc.GetAllStudent(Program.Connection);
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
                MessageBox.Show(ex.Message, "Retrieving Student ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadingDataPaymentStatus()
        {
            try
            {
                var result = PaymentStatusFunc.GetAllPaymentStatus(Program.Connection);
                if (result.LastOrDefault() != null) { PaymentStatusCount = result.LastOrDefault().PaymentStatusID; }
                else { PaymentStatusCount = 0; }
                lsPaymentStatus.Items.Clear();
                foreach (var paymentStatus in result)
                {
                    lsPaymentStatus.Items.Add($"{paymentStatus.PaymentStatusID}. {paymentStatus.StudentNameKH}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving Payment Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}