using SFaSMS.Models;
using SFaSMS.Utils;
using System.Drawing.Imaging;


namespace SFaSMS;

public partial class LecturerForm : Form
{
    private MainForm mainFormReference;
    string? imgLocation = "";
    Lecturer? effectedLecturer = null;
    List<string> listBoxLecturer = new List<string>();
    int LecturerCount = 0;
    int indexOfUpdateLecturer;

    public LecturerForm(MainForm mainform)
    {
        InitializeComponent();
        mainFormReference = mainform;
        this.FormClosed += new FormClosedEventHandler((_, _) => mainFormReference.Show());
        cBLecturerGender.DataSource = Program.Genders;
        btnClose.Click += (_, _) => this.Close();
        btnNew.Click += DoClickNewFormInput;
        btnInsert.Click += DoClickInsertLecturer;
        btnUpdate.Click += DoClickUpdateLecturer;
        btnUploadPhoto.Click += DoClickUploadLecturerPhoto;
        lsLecturer.SelectedIndexChanged += Select_Handling_Lecturer;
        txtSearchLecturer.TextChanged += SearchChangedFunc;
        dTLecturerBD.Format = DateTimePickerFormat.Custom;
        btnInsert.Enabled = false;
        btnUpdate.Enabled = false; 
        listBoxLecturer.Clear();
    }
    private void SearchChangedFunc(object? sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtSearchLecturer.Text) == false)
        {
            lsLecturer.Items.Clear();
            foreach (string lecturer in listBoxLecturer)

            {
                string[] splitText = lecturer.Split('.');
                if (splitText[1].Trim().StartsWith(txtSearchLecturer.Text))
                {
                    lsLecturer.Items.Add(lecturer);
                }
            }
        }
        else if (txtSearchLecturer.Text == "")
        {
            lsLecturer.Items.Clear();
            foreach (string lecturer in listBoxLecturer)
            {
                lsLecturer.Items.Add(lecturer);
            }
        }

    }
    private void Select_Handling_Lecturer(object? sender, EventArgs e)
    {
        if (lsLecturer.SelectedItems != null)
        {
            if (lsLecturer.SelectedIndex != -1)
            {
                string? staffData = lsLecturer.SelectedItems[0].ToString();
                if (staffData == null) return;
                string[] tempData = staffData.Split('.');

                try
                {
                    effectedLecturer = LecturerFunc.GetOneLecturer(Program.Connection, int.Parse(tempData[0].Trim()));
                    txtLecturerID.Text = effectedLecturer.LecturerID.ToString();
                    txtLecturerNameKH.Text = effectedLecturer.LecturerNameKH;
                    txtLecturerNameEN.Text = effectedLecturer.LecturerNameEN;
                    cBLecturerGender.Text = effectedLecturer.Gender;
                    txtLecturerAddress.Text = effectedLecturer.LecturerAddress;
                    txtLecturerContactNum.Text = effectedLecturer.ContactNumber;
                    txtLecturerPersonalNum.Text = effectedLecturer.PersonalNumber;

                    dTLecturerBD.Value = (DateTime)effectedLecturer.BirthDate;

                    if (effectedLecturer.Photo == null)
                    {
                        picLecturer.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(effectedLecturer.Photo);
                        picLecturer.Image = Image.FromStream(ms);
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
    private void DoClickUpdateLecturer(object? sender, EventArgs e)
    {
        byte[] LecturerImages = null;
        if (effectedLecturer != null)
        {
            if (txtLecturerNameKH.Text == "" || txtLecturerNameKH.Text.Trim().Length > 100)
            {
                MessageBox.Show("Lecturer Name KH is required or name too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtLecturerNameEN.Text == "" || txtLecturerNameEN.Text.Trim().Length > 100)
            {
                MessageBox.Show("Lecturer Name EN is required or name too long ", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtLecturerAddress.Text == "" || txtLecturerAddress.Text.Trim().Length > 1000)
            {
                MessageBox.Show("Lecturer Address is required or address too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtLecturerContactNum.Text == "" || txtLecturerContactNum.Text.Trim().Length > 10)
            {
                MessageBox.Show("Lecturer Contact Number is required or contact number too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtLecturerPersonalNum.Text.Trim().Length > 10)
            {
                MessageBox.Show("Lecturer Personal number too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            effectedLecturer.LecturerNameKH = txtLecturerNameKH.Text.Trim();
            effectedLecturer.LecturerNameEN = txtLecturerNameEN.Text.Trim();
            effectedLecturer.Gender = cBLecturerGender.SelectedItem.ToString();
            effectedLecturer.BirthDate = dTLecturerBD.Value;
            effectedLecturer.ContactNumber = txtLecturerContactNum.Text.Trim();
            effectedLecturer.PersonalNumber = txtLecturerPersonalNum.Text.Trim();
            effectedLecturer.LecturerAddress = txtLecturerAddress.Text.Trim();
            if (picLecturer.Image != null)
            {
                Image image = picLecturer.Image;
                MemoryStream ms = new MemoryStream();
                image.Save(ms, ImageFormat.Png);
                LecturerImages = ms.ToArray();
            }

            effectedLecturer.Photo = LecturerImages;
            try
            {
                var result = LecturerFunc.UpdateLecturer(Program.Connection, effectedLecturer);
                if (result == true)
                    MessageBox.Show($"Successfully updated an existing lecturer with the id {effectedLecturer.LecturerID}");
                foreach (string checkLecturer in listBoxLecturer)
                {
                    string[] splitText = checkLecturer.Split('.');
                    if (splitText[0].Trim().Equals(effectedLecturer.LecturerID.ToString()))
                    {
                        indexOfUpdateLecturer = listBoxLecturer.IndexOf(checkLecturer);
                        listBoxLecturer.Remove(checkLecturer);
                        break;
                    }
                }
                listBoxLecturer.Insert(indexOfUpdateLecturer, $"{effectedLecturer.LecturerID}. {effectedLecturer.LecturerNameKH}");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update an existing lecturer > {ex.Message}");
            }
            LoadingDataLecturer();
        }
        else
        {
            MessageBox.Show($"Select the Lecturer first before click update ");
        }

    }
    private void DoClickUploadLecturerPhoto(object? sender, EventArgs e)
    {
        OpenFileDialog dialog = new OpenFileDialog();
        dialog.Filter = "SELECT Photo(*.Jpg; *.png; *.Gif)|*.Jpg; *.png; *.Gif";
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            imgLocation = dialog.FileName.ToString();
            picLecturer.ImageLocation = imgLocation;
        }
    }
    private void DoClickInsertLecturer(object? sender, EventArgs e)
    {
        byte[] LecturerImages = null;
        if (txtLecturerNameKH.Text == "" || txtLecturerNameKH.Text.Trim().Length > 100)
        {
            MessageBox.Show("Lecturer Name KH is required or name too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (txtLecturerNameEN.Text == "" || txtLecturerNameEN.Text.Trim().Length > 100)
        {
            MessageBox.Show("Lecturer Name EN is required or name too long ", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (cBLecturerGender.SelectedItem == null)
        {
            MessageBox.Show("Lecturer Gender is required", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (txtLecturerAddress.Text == "" || txtLecturerAddress.Text.Trim().Length > 1000)
        {
            MessageBox.Show("Lecturer Address is required or address too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (txtLecturerContactNum.Text == "" || txtLecturerContactNum.Text.Trim().Length > 10)
        {
            MessageBox.Show("Lecturer Contact Number is required or contact number too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (txtLecturerPersonalNum.Text.Trim().Length > 10)
        {
            MessageBox.Show("Lecturer Personal number too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (dTLecturerBD.Text == "")
        {
            MessageBox.Show("Lecturer BirthDate is required", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (imgLocation != "")
        {
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader breader = new BinaryReader(stream);
            LecturerImages = breader.ReadBytes((int)stream.Length);
        }

        Lecturer newLecturer = new Lecturer()
        {
            LecturerNameKH = txtLecturerNameKH.Text.Trim(),
            LecturerNameEN = txtLecturerNameEN.Text.Trim(),
            Gender = cBLecturerGender.SelectedItem.ToString(),
            BirthDate = dTLecturerBD.Value,
            ContactNumber = txtLecturerContactNum.Text.Trim(),
            PersonalNumber = txtLecturerPersonalNum.Text.Trim(),
            LecturerAddress = txtLecturerAddress.Text.Trim(),
            Photo = LecturerImages,
        };
        try
        {
            var result = LecturerFunc.AddLecturer(Program.Connection, newLecturer);
            if (result == true)
            {
                MessageBox.Show($"Successfully inserted an existing lecturer with the id {txtLecturerID.Text}");
                LecturerAmountChanged?.Invoke(this, result);
            }
            listBoxLecturer.Add($"{txtLecturerID.Text}. {newLecturer.LecturerNameKH}");
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        LoadingDataLecturer();
    }
    private void DoClickNewFormInput(object? sender, EventArgs e)
    {
        txtLecturerID.Text = (LecturerCount + 1).ToString();
        txtLecturerNameKH.Clear();
        txtLecturerNameEN.Clear();
        cBLecturerGender.SelectedItem = null;
        txtLecturerContactNum.Clear();
        txtLecturerPersonalNum.Clear();
        dTLecturerBD.ResetText();
        txtLecturerAddress.Clear();
        picLecturer.ImageLocation = "";
        imgLocation = "";
        picLecturer.Image = null;
    }
    private void LecturerForm_Load(object sender, EventArgs e)
    {
        LoadingDataLecturer();
        txtLecturerID.Text = (LecturerCount + 1).ToString();
        foreach (string lecturer in lsLecturer.Items)
        {
            listBoxLecturer.Add(lecturer);
            txtSearchLecturer.CharacterCasing = CharacterCasing.Lower;
        }
        User userVerify = LoginForm.userVerify;
        if (userVerify.StaffPosition == "Administrator")
        {
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
        }

    }
    private void LoadingDataLecturer()
    {
        try
        {
            var result = LecturerFunc.GetAllLecturer(Program.Connection);
            if (result.LastOrDefault() != null) { LecturerCount = result.LastOrDefault().LecturerID; }
            else { LecturerCount = 0; }
            lsLecturer.Items.Clear();
            foreach (var lecturer in result)
            {
                lsLecturer.Items.Add($"{lecturer.LecturerID}. {lecturer.LecturerNameKH}");
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Retriving Lecturer", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    public event AmountCountEventHandler? LecturerAmountChanged;
}
