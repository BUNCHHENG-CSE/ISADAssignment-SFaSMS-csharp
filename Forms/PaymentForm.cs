using SFaSMS.Models;
using SFaSMS.Utils;

namespace SFaSMS
{
    public partial class PaymentForm : Form
    {
        private MainForm mainFormReference;
        Staff? effectedStaff = null;
        Payment? effectedPayment = null;
        Major? effectedMajor = null;
        List<string> listBoxPayment = new List<string>();
        int PaymentCount = 0;
        int indexOfUpdatePayment;

        public PaymentForm(MainForm mainform)
        {
            InitializeComponent();
            mainFormReference = mainform;
            this.FormClosed += new FormClosedEventHandler((_, _) => mainFormReference.Show());
            btnClose.Click += (_, _) => this.Close();
            btnNew.Click += DoClickNewFormInput;
            btnInsert.Click += DoClickInsertPayment;
            btnUpdate.Click += DoClickUpdatePayment;
            cBMajorID.SelectedValueChanged += Select_Handling_MajorID;
            lsPayment.SelectedIndexChanged += Select_Handling_Payment;
            txtSearchPayment.TextChanged += SearchChangedFunc;
            dTPaymentDate.Format = DateTimePickerFormat.Custom;
            listBoxPayment.Clear();
        }
        private void SearchChangedFunc(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchPayment.Text) == false)
            {
                lsPayment.Items.Clear();
                foreach (string payment in listBoxPayment)

                {
                    string[] splitText = payment.Split('.');
                    if (splitText[1].Trim().StartsWith(txtSearchPayment.Text))
                    {
                        lsPayment.Items.Add(payment);
                    }
                }
            }
            else if (txtSearchPayment.Text == "")
            {
                lsPayment.Items.Clear();
                foreach (string payment in listBoxPayment)
                {
                    lsPayment.Items.Add(payment);
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
                    effectedMajor = MajorFunc.GetOneMajorCost(Program.Connection, int.Parse(majorID.Trim()));
                    txtMajorCost.Text = effectedMajor.MajorCost.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }

            }
        }
        private void Select_Handling_Payment(object? sender, EventArgs e)
        {
            if (lsPayment.SelectedItems != null)
            {
                if (lsPayment.SelectedIndex != -1)
                {
                    string? paymentData = lsPayment.SelectedItems[0].ToString();
                    if (paymentData == null) return;
                    string[] tempData = paymentData.Split('.');

                    try
                    {
                        effectedPayment = PaymentFunc.GetOnePayment(Program.Connection, int.Parse(tempData[0].Trim()));
                        txtPaymentNo.Text = effectedPayment.PaymentNo.ToString();
                        dTPaymentDate.Value = effectedPayment.PayDate;
                        txtPaymentAmount.Text = effectedPayment.PaidAmount.ToString();
                        txtStaffID.Text = effectedPayment.StaffID.ToString();
                        cBPaymentStatusID.SelectedItem = effectedPayment.PaymentStatusID.ToString();

                        cBMajorID.Text = effectedPayment.MajorID.ToString();
                        txtStaffNameKH.Text = effectedPayment.StaffNameKH;
                        txtStaffPosition.Text = effectedPayment.StaffPosition;

                        txtMajorCost.Text = effectedPayment.MajorCost.ToString();


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"{ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Please select the right payment list !!!");
                }

            }
        }
        private void DoClickUpdatePayment(object? sender, EventArgs e)
        {
            if (effectedPayment != null)
            {
                effectedPayment.PayDate = dTPaymentDate.Value;
                if (decimal.TryParse(txtPaymentAmount.Text, out decimal paymentamount) == false) return;
                effectedPayment.PaidAmount = paymentamount;
                if (int.TryParse(txtStaffID.Text, out int staffID) == false) return;
                effectedPayment.StaffID = staffID;
                if (int.TryParse(cBPaymentStatusID.SelectedItem.ToString(), out int psID) == false) return;
                effectedPayment.PaymentStatusID = psID;
                if (int.TryParse(cBMajorID.SelectedItem.ToString(), out int majorID) == false) return;
                effectedPayment.MajorID = majorID;
                effectedPayment.StaffNameKH = txtStaffNameKH.Text.Trim();
                effectedPayment.StaffPosition = txtStaffPosition.Text.Trim();
                if (decimal.TryParse(txtMajorCost.Text, out decimal majorCost) == false) return;
                effectedPayment.MajorCost = majorCost;
                try
                {
                    var result = PaymentFunc.UpdatePayment(Program.Connection, effectedPayment);
                    if (result == true)
                        MessageBox.Show($"Successfully updated an existing Payment  with the no {effectedPayment.PaymentNo}");
                    foreach (string checkPayment in listBoxPayment)
                    {
                        string[] splitText = checkPayment.Split('.');
                        if (splitText[0].Trim().Equals(effectedPayment.PaymentNo.ToString()))
                        {
                            indexOfUpdatePayment = listBoxPayment.IndexOf(checkPayment);
                            listBoxPayment.Remove(checkPayment);
                            break;
                        }
                    }
                    var getStudentNameKH = PaymentFunc.GetOneStudentNameKH(Program.Connection, effectedPayment.PaymentNo);
                    listBoxPayment.Insert(indexOfUpdatePayment, $"{effectedPayment.PaymentNo}. {getStudentNameKH.StudentNameKH}");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to update an existing Payment > {ex.Message}");
                }
                LoadingDataPayment();
            }

        }
        private void DoClickInsertPayment(object? sender, EventArgs e)
        {
            if (dTPaymentDate.Text == "")
            {
                MessageBox.Show("Payment Date is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (decimal.TryParse(txtPaymentAmount.Text.ToString(), out decimal paymentAmount) == false)
            {
                MessageBox.Show("Payment Amount is required or something wrong", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cBPaymentStatusID.SelectedItem == null)
            {
                MessageBox.Show("Payment Status ID is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtStaffID.Text == "")
            {
                MessageBox.Show("Staff ID is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cBMajorID.SelectedItem == null)
            {
                MessageBox.Show("Major Number is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string? staffID = txtStaffID.Text;
            if (staffID == null) return;
            string? paymentstatusID = cBPaymentStatusID.SelectedItem.ToString();
            if (paymentstatusID == null) return;
            string? majorID = cBMajorID.SelectedItem.ToString();
            if (majorID == null) return;

            Payment newPayment = new Payment()
            {
                PayDate = dTPaymentDate.Value,
                PaidAmount = paymentAmount,
                StaffID = int.Parse(staffID),
                PaymentStatusID = int.Parse(paymentstatusID),
                MajorID = int.Parse(majorID),
                StaffNameKH = txtStaffNameKH.Text,
                StaffPosition = txtStaffPosition.Text,
                MajorCost = decimal.Parse(txtMajorCost.Text.ToString()),
            };
            try
            {
                var result = PaymentFunc.AddPayment(Program.Connection, newPayment);
                if (result == true)
                    MessageBox.Show($"Successfully inserted Payment  with the no {txtPaymentNo.Text}");
                var getStudentNameKH = PaymentFunc.GetOneStudentNameKH(Program.Connection, int.Parse(txtPaymentNo.Text));
                listBoxPayment.Add($"{txtPaymentNo.Text}. {getStudentNameKH.StudentNameKH}");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            LoadingDataPayment();
        }
        private void DoClickNewFormInput(object? sender, EventArgs e)
        {

            txtPaymentNo.Text = (PaymentCount + 1).ToString();
            dTPaymentDate.ResetText();
            txtPaymentAmount.Clear();
            cBPaymentStatusID.SelectedItem = null;
            cBMajorID.SelectedItem = null;
            txtMajorCost.Clear();
        }
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            LoadingDataPayment();
            LoadingDataStaffID();
            LoadingDataPaymentStatusID();
            LoadingDataMajorID();
            txtPaymentNo.Text = (PaymentCount + 1).ToString();
            foreach (string payment in lsPayment.Items)
            {
                listBoxPayment.Add(payment);
                txtSearchPayment.CharacterCasing = CharacterCasing.Lower;
            }

        }
        private void LoadingDataStaffID()
        {
            try
            {
                txtStaffID.Text = LoginForm.userVerify.StaffID.ToString();
                txtStaffNameKH.Text = LoginForm.userVerify.StaffNameKH;
                txtStaffPosition.Text = LoginForm.userVerify.StaffPosition;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retriving Staff ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadingDataPaymentStatusID()
        {
            try
            {
                var result = PaymentStatusFunc.GetAllPaymentStatusID(Program.Connection);
                List<string> ls = new List<string>();
                foreach (var ps in result)
                {
                    
                    if ((ps.SemesterOneStatus == false && ps.SemesterTwoStatus == false)|| (ps.SemesterOneStatus == true && ps.SemesterTwoStatus == false)|| (ps.SemesterOneStatus == false && ps.SemesterTwoStatus == true))
                        if (ps.OneYearStatus == false)
                            ls.Add(ps.PaymentStatusID.ToString());
                }
                cBPaymentStatusID.DataSource = ls;
                cBPaymentStatusID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retriving Payment Status ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtMajorCost.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retriving Major ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadingDataPayment()
        {
            try
            {
                var result = PaymentFunc.GetAllPayment(Program.Connection);
                if (result.LastOrDefault() != null) { PaymentCount = result.LastOrDefault().PaymentNo; }
                else { PaymentCount = 0; }
                lsPayment.Items.Clear();
                foreach (var payment in result)
                {
                    lsPayment.Items.Add($"{payment.PaymentNo}. {payment.student.StudentNameKH}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retriving Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
