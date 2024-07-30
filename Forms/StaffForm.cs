using SFaSMS.Models;
using SFaSMS.Utils;
using System.Drawing.Imaging;

namespace SFaSMS;

public partial class StaffForm : Form
{
    private MainForm mainFormReference;
    string? imgLocation = "";
    Staff? effectedStaff = null;
    List<string> listBoxStaff = new List<string>();
    int staffCount = 0;
    int indexOfUpdateStaff;
    string[] staffPosition { get; set; } = new string[] { "Administrator", "Accountant", "Receptionist" };
    public StaffForm(MainForm mainform)
    {
        InitializeComponent();
        mainFormReference = mainform;
        this.FormClosed += new FormClosedEventHandler((_, _) => mainFormReference.Show());
        cBStaffGender.DataSource = Program.Genders;
        btnClose.Click += (_, _) => this.Close();
        btnNew.Click += DoClickNewFormInput;
        btnInsert.Click += DoClickInsertStaff;
        btnUpdate.Click += DoClickUpdateStaff;
        btnUploadPhoto.Click += DoClickUploadStaffPhoto;
        lsStaff.SelectedIndexChanged += Select_Handling_Staff;
        txtSearchStaff.TextChanged += SearchChangedFunc;
        cBStaffPosition.DataSource = staffPosition;
        dTStaffBD.Format = DateTimePickerFormat.Custom;
        dTStaffHiredDate.Format = DateTimePickerFormat.Custom;
        listBoxStaff.Clear();
        btnInsert.Enabled = false;
        btnUpdate.Enabled = false;
    }
    private void SearchChangedFunc(object? sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtSearchStaff.Text) == false)
        {
            lsStaff.Items.Clear();
            foreach (string staff in listBoxStaff)

            {
                string[] splitText = staff.Split('.');
                if (splitText[1].Trim().StartsWith(txtSearchStaff.Text))
                {
                    lsStaff.Items.Add(staff);
                }
            }
        }
        else if (txtSearchStaff.Text == "")
        {
            lsStaff.Items.Clear();
            foreach (string staff in listBoxStaff)
            {
                lsStaff.Items.Add(staff);
            }
        }

    }
    private void Select_Handling_Staff(object? sender, EventArgs e)
    {
        if (lsStaff.SelectedItems != null)
        {
            if (lsStaff.SelectedIndex != -1)
            {
                string? staffData = lsStaff.SelectedItems[0].ToString();
                if (staffData == null) return;
                string[] tempData = staffData.Split('.');
                try
                {
                    effectedStaff = StaffFunc.GetOneStaff(Program.Connection, int.Parse(tempData[0].Trim()));
                    txtStaffID.Text = effectedStaff.StaffID.ToString();
                    txtStaffNameKH.Text = effectedStaff.StaffNameKH;
                    txtStaffNameEN.Text = effectedStaff.StaffNameEN;
                    cBStaffGender.Text = effectedStaff.Gender;
                    txtStaffAddress.Text = effectedStaff.StaffAddress;
                    txtStaffContactNum.Text = effectedStaff.ContactNumber;
                    txtStaffPersonalNum.Text = effectedStaff.PersonalNumber;
                    cBStaffPosition.SelectedItem = effectedStaff.StaffPosition;
                    dTStaffBD.Value = (DateTime)effectedStaff.BirthDate;
                    dTStaffHiredDate.Value = (DateTime)effectedStaff.HiredDate;
                    if (effectedStaff.Photo == null)
                    {
                        picStaff.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(effectedStaff.Photo);
                        picStaff.Image = Image.FromStream(ms);
                    }

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
    private void DoClickUpdateStaff(object? sender, EventArgs e)
    {
        byte[] StaffImages = null;
        if (effectedStaff != null)
        {
            if (txtStaffNameKH.Text == "" || txtStaffNameKH.Text.Trim().Length > 100)
            {
                MessageBox.Show("Staff Name KH is required or name too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtStaffNameEN.Text == "" || txtStaffNameEN.Text.Trim().Length > 100)
            {
                MessageBox.Show("Staff Name EN is required or name too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtStaffAddress.Text == "" || txtStaffAddress.Text.Trim().Length > 1000)
            {
                MessageBox.Show("Staff Address is required or address too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtStaffContactNum.Text == "" || txtStaffContactNum.Text.Trim().Length > 10)
            {
                MessageBox.Show("Staff Contact Number is required or contact number too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtStaffPersonalNum.Text.Trim().Length > 10)
            {
                MessageBox.Show("Staff Personal number too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cBStaffPosition.SelectedItem == null)
            {
                MessageBox.Show("Staff Position is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            effectedStaff.StaffNameKH = txtStaffNameKH.Text.Trim();
            effectedStaff.StaffNameEN = txtStaffNameEN.Text.Trim();
            effectedStaff.Gender = cBStaffGender.SelectedItem.ToString();
            effectedStaff.BirthDate = dTStaffBD.Value;
            effectedStaff.StaffAddress = txtStaffAddress.Text.Trim();
            effectedStaff.ContactNumber = txtStaffContactNum.Text.Trim();
            effectedStaff.PersonalNumber = txtStaffPersonalNum.Text.Trim();
            effectedStaff.StaffPosition = cBStaffPosition.SelectedItem.ToString();
            effectedStaff.HiredDate = dTStaffHiredDate.Value;

            if (picStaff.Image != null)
            {
                Image image = picStaff.Image;
                MemoryStream ms = new MemoryStream();
                image.Save(ms, ImageFormat.Png);
                StaffImages = ms.ToArray();
            }
            effectedStaff.Photo = StaffImages;
            try
            {
                var result = StaffFunc.UpdateStaff(Program.Connection, effectedStaff);
                if (result == true)
                    MessageBox.Show($"Successfully updated an existing staff with the id {txtStaffID.Text}");
                foreach (string checkStaff in listBoxStaff)
                {
                    string[] splitText = checkStaff.Split('.');
                    if (splitText[0].Trim().Equals(effectedStaff.StaffID.ToString()))
                    {
                        indexOfUpdateStaff = listBoxStaff.IndexOf(checkStaff);
                        listBoxStaff.Remove(checkStaff);
                        break;
                    }
                }
                listBoxStaff.Insert(indexOfUpdateStaff, $"{effectedStaff.StaffID}. {effectedStaff.StaffNameKH}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update an existing staff > {ex.Message}");
            }
        }

        LoadingDataStaff();
    }
    private void DoClickUploadStaffPhoto(object? sender, EventArgs e)
    {
        OpenFileDialog dialog = new OpenFileDialog();
        dialog.Filter = "SELECT Photo(*.Jpg; *.png; *.Gif)|*.Jpg; *.png; *.Gif";
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            imgLocation = dialog.FileName.ToString();
            picStaff.ImageLocation = imgLocation;
        }
    }
    private void DoClickInsertStaff(object? sender, EventArgs e)
    {
        byte[] StaffImages = null;
        if (txtStaffNameKH.Text == "" || txtStaffNameKH.Text.Trim().Length > 100)
        {
            MessageBox.Show("Staff Name KH is required or name too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (txtStaffNameEN.Text == "" || txtStaffNameEN.Text.Trim().Length > 100)
        {
            MessageBox.Show("Staff Name EN is required or name too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (cBStaffGender.SelectedItem == null)
        {
            MessageBox.Show("Staff Gender is required", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (txtStaffAddress.Text == "" || txtStaffAddress.Text.Trim().Length > 1000)
        {
            MessageBox.Show("Staff Address is required or address too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (txtStaffContactNum.Text == "" || txtStaffContactNum.Text.Trim().Length > 10)
        {
            MessageBox.Show("Staff Contact Number is required or contact number too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (txtStaffPersonalNum.Text.Trim().Length > 10)
        {
            MessageBox.Show("Staff Personal number too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (cBStaffPosition.SelectedItem == null)
        {
            MessageBox.Show("Staff Position is required", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (dTStaffBD.Text == "")
        {
            MessageBox.Show("Staff BirthDate is required", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (dTStaffHiredDate.Text == "")
        {
            MessageBox.Show("Staff Hired Date is required", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (imgLocation != "")
        {
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader breader = new BinaryReader(stream);
            StaffImages = breader.ReadBytes((int)stream.Length);
        }

        Staff newStaff = new Staff()
        {
            StaffNameKH = txtStaffNameKH.Text.Trim(),
            StaffNameEN = txtStaffNameEN.Text.Trim(),
            Gender = cBStaffGender.SelectedItem.ToString(),
            BirthDate = dTStaffBD.Value,
            StaffAddress = txtStaffAddress.Text.Trim(),
            ContactNumber = txtStaffContactNum.Text.Trim(),
            PersonalNumber = txtStaffPersonalNum.Text.Trim(),
            StaffPosition = cBStaffPosition.SelectedItem.ToString(),
            HiredDate = dTStaffHiredDate.Value,
            Photo = StaffImages,
        };
        try
        {
            var result = StaffFunc.AddStaff(Program.Connection, newStaff);
            if (result == true)
            {
                MessageBox.Show($"Successfully inserted staff with the id {txtStaffID.Text}");
                StaffAmountChanged?.Invoke(this, result);
            }
            listBoxStaff.Add($"{txtStaffID.Text}. {newStaff.StaffNameKH}");
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        LoadingDataStaff();
    }
    private void DoClickNewFormInput(object? sender, EventArgs e)
    {

        txtStaffID.Text = (staffCount + 1).ToString();
        txtStaffNameKH.Clear();
        txtStaffNameEN.Clear();
        cBStaffGender.SelectedItem = null;
        txtStaffAddress.Clear();
        txtStaffContactNum.Clear();
        txtStaffPersonalNum.Clear();
        cBStaffPosition.SelectedItem = null;
        dTStaffBD.ResetText();
        dTStaffHiredDate.ResetText();
        picStaff.ImageLocation = "";
        imgLocation = "";
        picStaff.Image = null;

    }
    private void StaffForm_Load(object sender, EventArgs e)
    {
        LoadingDataStaff();
        txtStaffID.Text = (staffCount + 1).ToString();
        foreach (string staff in lsStaff.Items)
        {
            listBoxStaff.Add(staff);
            txtSearchStaff.CharacterCasing = CharacterCasing.Lower;
        }
        User userVerify = LoginForm.userVerify;
        if(userVerify.StaffPosition == "Administrator")
        {
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;   
        }

    }
    private void LoadingDataStaff()
    {
        try
        {
            var result = StaffFunc.GetAllStaff(Program.Connection);
            if (result.LastOrDefault() != null) { staffCount = result.LastOrDefault().StaffID; }
            else { staffCount = 0; }
            lsStaff.Items.Clear();
            foreach (var staff in result)
            {
                lsStaff.Items.Add($"{staff.StaffID}. {staff.StaffNameKH}");
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Retriving staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    public event AmountCountEventHandler? StaffAmountChanged;
}