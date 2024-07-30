using SFaSMS.Models;
using SFaSMS.Utils;

namespace SFaSMS
{
    public partial class UserForm : Form
    {
        private MainForm mainFormReference;
        Staff? effectedStaff = null;
        User? effectedUser = null;
        List<string> listBoxUser = new List<string>();
        int UserCount = 0;
        int indexOfUpdateUser;
        User userVerify = LoginForm.userVerify;

        public UserForm(MainForm mainform)
        {
            InitializeComponent();
            mainFormReference = mainform;
            this.FormClosed += new FormClosedEventHandler((_, _) => mainFormReference.Show());
            btnNew.Click += DoClickNewFormInput;
            btnClose.Click += (_, _) => this.Close();
            cBoxStaffID.SelectedValueChanged += Select_Handling_StaffID;
            lsUser.Click += Select_Handling_User;
            btnInsert.Click += DoClickInsertUser;
            btnUpdate.Click += DoClickUpdateUser;
            txtSearchUsername.TextChanged += SearchChangedFunc;
            btnUpdate.Enabled = false;
            btnInsert.Enabled = false;
            chBShowPass.CheckedChanged += CheckedShowPassword;
            listBoxUser.Clear();
        }
        private void CheckedShowPassword(object? sender, EventArgs e)
        {
            if (chBShowPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        private void SearchChangedFunc(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchUsername.Text) == false)
            {
                lsUser.Items.Clear();
                foreach (string user in listBoxUser)

                {
                    string[] splitText = user.Split('.');
                    if (splitText[1].Trim().StartsWith(txtSearchUsername.Text))
                    {
                        lsUser.Items.Add(user);
                    }
                }
            }
            else if (txtSearchUsername.Text == "")
            {
                lsUser.Items.Clear();
                foreach (string user in listBoxUser)
                {
                    lsUser.Items.Add(user);
                }
            }
        }
        private void DoClickUpdateUser(object? sender, EventArgs e)
        {
            if (effectedUser != null)
            {
                if (txtUsername.Text == "" || txtUsername.Text.Trim().Length > 100)
                {
                    MessageBox.Show("Username is required or username too long", "Creating",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (txtPassword.Text == "" || txtPassword.Text.Trim().Length > 100)
                {
                    MessageBox.Show("Password is required or password too long", "Creating",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                effectedUser.Username = txtUsername.Text.Trim();
                effectedUser.Password = txtPassword.Text.Trim();
                effectedUser.StaffID = int.Parse(cBoxStaffID.SelectedValue.ToString().Trim());
                effectedUser.StaffNameKH = txtStaffNameKH.Text.Trim();
                effectedUser.StaffPosition = txtStaffPosition.Text.Trim();
                try
                {
                    var result = UserFunc.UpdateUser(Program.Connection, effectedUser);
                    if (result == true)
                        MessageBox.Show($"Successfully updated an existing user with the id {effectedUser.UserID}");
                    foreach (string checkUser in listBoxUser)
                    {
                        string[] splitText = checkUser.Split('.');
                        if (splitText[0].Trim().Equals(effectedUser.UserID.ToString()))
                        {
                            indexOfUpdateUser = listBoxUser.IndexOf(checkUser);
                            listBoxUser.Remove(checkUser);
                            break;
                        }
                    }
                    listBoxUser.Insert(indexOfUpdateUser, $"{effectedUser.UserID}. {effectedUser.Username}");

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to update an existing user > {ex.Message}");
                }
                LoadingDataUser();
            }

        }
        private void DoClickInsertUser(object? sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtUsername.Text.Trim().Length > 100)
            {
                MessageBox.Show("Username is required or username too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtPassword.Text == "" || txtPassword.Text.Trim().Length > 100)
            {
                MessageBox.Show("Password is required or password too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (cBoxStaffID.SelectedItem == null)
            {
                MessageBox.Show("Staff Gender is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            string? staffID = cBoxStaffID.SelectedItem.ToString();
            if (staffID == null) return;
            User newUser = new User()
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                StaffID = int.Parse(staffID.Trim()),
                StaffNameKH = txtStaffNameKH.Text.Trim(),
                StaffPosition = txtStaffPosition.Text.Trim(),
            };
            try
            {
                var result = UserFunc.AddUser(Program.Connection, newUser);
                if (result == true)
                    MessageBox.Show($"Successfully inserted user with the id {txtUserID.Text}");
                listBoxUser.Add($"{txtUserID.Text}. {newUser.Username}");

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            LoadingDataUser();
        }
        private void DoClickNewFormInput(object? sender, EventArgs e)
        {

            txtUserID.Text = (UserCount + 1).ToString();
            txtUsername.Clear();
            txtPassword.Clear();
            cBoxStaffID.SelectedItem = null;
            txtStaffNameKH.Clear();
            txtStaffPosition.Clear();
            lsUser.ClearSelected();
        }
        private void Select_Handling_StaffID(object? sender, EventArgs e)
        {
            if (cBoxStaffID.SelectedItem != null)
            {
                string? staffID = cBoxStaffID.SelectedItem.ToString();
                if (staffID == null) return;

                try
                {
                    effectedStaff = StaffFunc.GetOneStaffNameKHandPosition(Program.Connection, int.Parse(staffID.Trim()));
                    txtStaffNameKH.Text = effectedStaff.StaffNameKH;
                    txtStaffPosition.Text = effectedStaff.StaffPosition;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}");
                }

            }
        }
        private void Select_Handling_User(object? sender, EventArgs e)
        {
            if (lsUser.SelectedItems != null)
            {
                if (lsUser.SelectedIndex != -1)
                {
                    string? staffData = lsUser.SelectedItems[0].ToString();
                    if (staffData == null) return;
                    string[] tempData = staffData.Split('.');
                    try
                    {
                        effectedUser = UserFunc.GetOneUser(Program.Connection, int.Parse(tempData[0].Trim()));
                        txtUserID.Text = effectedUser.UserID.ToString();
                        txtUsername.Text = effectedUser.Username;
                        cBoxStaffID.SelectedItem = effectedUser.StaffID.ToString();
                        txtStaffNameKH.Text = effectedUser.StaffNameKH;
                        txtStaffPosition.Text = effectedUser.StaffPosition;
                        if (userVerify.StaffPosition == "Administrator")
                        {
                            btnInsert.Enabled = true;
                            if (userVerify.UserID == effectedUser.UserID)
                            {
                                txtPassword.Text = effectedUser.Password;
                                txtPassword.Enabled = true;
                            }
                            else
                            {
                                txtPassword.Text = "";
                                txtPassword.Enabled = false;
                            }

                        }
                        else if (userVerify.UserID == effectedUser.UserID)
                        {
                            btnUpdate.Enabled = true;
                            txtPassword.Text = effectedUser.Password;
                            cBoxStaffID.Enabled = false;
                            txtPassword.Enabled = true;

                        }
                        else
                        {
                            btnInsert.Enabled = false;
                            btnUpdate.Enabled = false;
                            txtPassword.Text = "";
                            cBoxStaffID.Enabled = false;
                            txtPassword.Enabled = false;

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
        private void UserForm_Load(object sender, EventArgs e)
        {
            LoadingDataStaffID();
            LoadingDataUser();
            txtUserID.Text = (UserCount + 1).ToString();
            foreach (string user in lsUser.Items)
            {

                listBoxUser.Add(user);

                txtSearchUsername.CharacterCasing = CharacterCasing.Lower;
            }
            if (userVerify.StaffPosition == "Administrator")
            {
                btnInsert.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }
        private void LoadingDataStaffID()
        {
            try
            {
                var result = StaffFunc.GetAllStaffID(Program.Connection);
                List<string> ls = new List<string>();
                foreach (var staff in result)
                {
                    ls.Add(staff.StaffID.ToString());
                }
                cBoxStaffID.DataSource = ls;
                cBoxStaffID.SelectedIndex = -1;
                txtStaffNameKH.Clear();
                txtStaffPosition.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving staff ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadingDataUser()
        {
            try
            {
                var result = UserFunc.GetAllUser(Program.Connection);
                if (result.LastOrDefault() != null) { UserCount = result.LastOrDefault().UserID; }
                else { UserCount = 0; }
                lsUser.Items.Clear();
                foreach (var user in result)
                {

                    lsUser.Items.Add($"{user.UserID}. {user.Username}");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving user", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
