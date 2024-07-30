using SFaSMS.Models;
using SFaSMS.Utils;
using System.Drawing.Imaging;

namespace SFaSMS;

public partial class StudentForm : Form
{
    private MainForm mainFormReference;
    string? imgLocation = "";
    Student? effectedStudent = null;
    List<string> listBoxStudent = new List<string>();
    int StudentCount = 0;
    int indexOfUpdateStudent;
    public StudentForm(MainForm mainform)
    {
        InitializeComponent();
        mainFormReference = mainform;
        this.FormClosed += new FormClosedEventHandler((_, _) => mainFormReference.Show());
        cBStudentGender.DataSource = Program.Genders;
        btnClose.Click += (_, _) => this.Close();
        btnNew.Click += DoClickNewFormInput;
        btnInsert.Click += DoClickInsertStudent;
        btnUpdate.Click += DoClickUpdateStudent;
        txtSearchStudent.TextChanged += SearchChangedFunc;
        btnUploadPhoto.Click += DoClickUploadStudentPhoto;
        lsStudent.SelectedValueChanged += Select_Handling_Student;
        dTStudentBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        listBoxStudent.Clear();
    }
    private void SearchChangedFunc(object? sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtSearchStudent.Text) == false)
        {
            lsStudent.Items.Clear();
            foreach (string student in listBoxStudent)

            {
                string[] splitText = student.Split('.');
                if (splitText[1].Trim().StartsWith(txtSearchStudent.Text))
                {
                    lsStudent.Items.Add(student);
                }
            }
        }
        else if (txtSearchStudent.Text == "")
        {
            lsStudent.Items.Clear();
            foreach (string student in listBoxStudent)
            {
                lsStudent.Items.Add(student);
            }
        }

    }
    private void Select_Handling_Student(object? sender, EventArgs e)
    {
        if (lsStudent.SelectedItems != null)
        {
            if (lsStudent.SelectedIndex != -1)
            {
                string? staffData = lsStudent.SelectedItems[0].ToString();
                if (staffData == null) return;
                string[] tempData = staffData.Split('.');
                try
                {
                    effectedStudent = StudentFunc.GetOneStudent(Program.Connection, int.Parse(tempData[0].Trim()));
                    txtStudentID.Text = effectedStudent.StudentID.ToString();
                    txtStudentNameKH.Text = effectedStudent.StudentNameKH;
                    txtStudentNameEN.Text = effectedStudent.StudentNameEN;
                    cBStudentGender.Text = effectedStudent.Gender;
                    dTStudentBD.Value = (DateTime)effectedStudent.BirthDate;
                    txtStudentAddress.Text = effectedStudent.StudentAddress;
                    txtPersonalNumber.Text = effectedStudent.PersonalNumber;
                    txtParentNumber.Text = effectedStudent.ParentNumber;
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
            else
            {
                MessageBox.Show("Please select the right name !!!");
            }
        }
    }
    private void DoClickUpdateStudent(object? sender, EventArgs e)
    {
        byte[] StudentImages = null;
        if (effectedStudent != null)
        {
            if (txtStudentNameKH.Text == "" || txtStudentNameKH.Text.Trim().Length > 100)
            {
                MessageBox.Show("Student Name KH is required or name too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtStudentNameEN.Text == "" || txtStudentNameEN.Text.Trim().Length > 100)
            {
                MessageBox.Show("Student Name EN is required or name too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtStudentAddress.Text == "" || txtStudentAddress.Text.Trim().Length > 1000)
            {
                MessageBox.Show("Student Address is required or address too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtPersonalNumber.Text == "" || txtPersonalNumber.Text.Trim().Length > 10)
            {
                MessageBox.Show("Personal Number is required or personal number too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtParentNumber.Text == "" || txtParentNumber.Text.Trim().Length > 10)
            {
                MessageBox.Show("Parent Number is required parent number too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            effectedStudent.StudentNameKH = txtStudentNameKH.Text.Trim();
            effectedStudent.StudentNameEN = txtStudentNameEN.Text.Trim();
            effectedStudent.Gender = cBStudentGender.SelectedItem.ToString();
            effectedStudent.BirthDate = dTStudentBD.Value;
            effectedStudent.StudentAddress = txtStudentAddress.Text.Trim();
            effectedStudent.PersonalNumber = txtPersonalNumber.Text.Trim();
            effectedStudent.ParentNumber = txtParentNumber.Text.Trim();
            if (picStudent.Image != null)
            {
                Image image = picStudent.Image;
                MemoryStream ms = new MemoryStream();
                image.Save(ms, ImageFormat.Png);
                StudentImages = ms.ToArray();
            }
            effectedStudent.Photo = StudentImages;
            try
            {
                var result = StudentFunc.UpdateStudent(Program.Connection, effectedStudent);
                if (result == true)
                    MessageBox.Show($"Successfully updated an existing student with the id {effectedStudent.StudentID}");

                foreach (string checkStudent in listBoxStudent)
                {
                    string[] splitText = checkStudent.Split('.');
                    if (splitText[0].Trim().Equals(effectedStudent.StudentID.ToString()))
                    {
                        indexOfUpdateStudent = listBoxStudent.IndexOf(checkStudent);
                        listBoxStudent.Remove(checkStudent);
                        break;
                    }
                }
                listBoxStudent.Insert(indexOfUpdateStudent, $"{effectedStudent.StudentID}. {effectedStudent.StudentNameKH}");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update an existing student > {ex.Message}");
            }
            LoadingDataStudent();
        }
    }
    private void DoClickUploadStudentPhoto(object? sender, EventArgs e)
    {
        OpenFileDialog dialog = new OpenFileDialog();
        dialog.Filter = "SELECT Photo(*.Jpg; *.png; *.Gif)|*.Jpg; *.png; *.Gif";
        if (dialog.ShowDialog() == DialogResult.OK)
        {
            imgLocation = dialog.FileName.ToString();
            picStudent.ImageLocation = imgLocation;
        }
    }
    private void DoClickInsertStudent(object? sender, EventArgs e)
    {
        byte[] StudentImages = null;
        if (txtStudentNameKH.Text == "" || txtStudentNameKH.Text.Trim().Length > 100)
        {
            MessageBox.Show("Student Name KH is required or name too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (txtStudentNameEN.Text == "" || txtStudentNameEN.Text.Trim().Length > 100)
        {
            MessageBox.Show("Student Name EN is required or name too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (cBStudentGender.SelectedItem == null)
        {
            MessageBox.Show("Student Gender is required", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (dTStudentBD.Text == "")
        {
            MessageBox.Show("Student BirthDate is required", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (txtStudentAddress.Text == "" || txtStudentAddress.Text.Trim().Length > 1000)
        {
            MessageBox.Show("Student Address is required or address too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (txtPersonalNumber.Text == "" || txtPersonalNumber.Text.Trim().Length > 10)
        {
            MessageBox.Show("Personal Number is required personal number too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (txtParentNumber.Text == "" || txtParentNumber.Text.Trim().Length > 10)
        {
            MessageBox.Show("Parent Number is required parent number too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (picStudent.Image != null)
        {
            FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader bReader = new BinaryReader(stream);
            StudentImages = bReader.ReadBytes((int)stream.Length);
        }
        Student newStudent = new Student()
        {
            StudentNameKH = txtStudentNameKH.Text.Trim(),
            StudentNameEN = txtStudentNameEN.Text.Trim(),
            Gender = cBStudentGender.SelectedItem.ToString(),
            BirthDate = dTStudentBD.Value,
            StudentAddress = txtStudentAddress.Text.Trim(),
            PersonalNumber = txtPersonalNumber.Text.Trim(),
            ParentNumber = txtParentNumber.Text.Trim(),
            Photo = StudentImages,
        };
        try
        {
            var result = StudentFunc.AddStudent(Program.Connection, newStudent);
            if (result == true)
            {
                MessageBox.Show($"Successfully inserted student with the id {txtStudentID.Text}");
                StudentAmountChanged?.Invoke(this, result);
            }
            listBoxStudent.Add($"{txtStudentID.Text}. {newStudent.StudentNameKH}");
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        LoadingDataStudent();
    }
    private void StudentForm_Load(object? sender, EventArgs e)
    {
        LoadingDataStudent();
        txtStudentID.Text = (StudentCount + 1).ToString();
        foreach (string student in lsStudent.Items)
        {
            listBoxStudent.Add(student);
            txtSearchStudent.CharacterCasing = CharacterCasing.Lower;
        }

    }
    private void LoadingDataStudent()
    {
        try
        {
            var result = StudentFunc.GetAllStudent(Program.Connection);
            if (result.LastOrDefault() != null) { StudentCount = result.LastOrDefault().StudentID; }
            else { StudentCount = 0; }
            lsStudent.Items.Clear();
            foreach (var student in result)
            {

                lsStudent.Items.Add($"{student.StudentID}. {student.StudentNameKH}");
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Retrieving students", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    private void DoClickNewFormInput(object? sender, EventArgs e)
    {

        txtStudentID.Text = (StudentCount + 1).ToString();
        txtStudentNameKH.Clear();
        txtStudentNameEN.Clear();
        cBStudentGender.SelectedItem = null;
        dTStudentBD.ResetText();
        txtStudentAddress.Clear();
        txtPersonalNumber.Clear();
        txtParentNumber.Clear();
        picStudent.Image = null;
        imgLocation = "";
        picStudent.Image = null;
    }
    public event AmountCountEventHandler? StudentAmountChanged;


}
