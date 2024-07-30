using SFaSMS.Forms;
using SFaSMS.Models;
using SFaSMS.Utils;

namespace SFaSMS
{
    public partial class LoginForm : Form
    {
        const String username = "Admin";
        const String password = "admin12345";
        private LoadingForm loadingFormReference;
        private DatabaseConnectionForm databaseConnectionFormReference;
        public static User userVerify = null;
        public LoginForm(LoadingForm loadingForm, DatabaseConnectionForm databaseConnectionForm)
        {
            InitializeComponent();
            Program.ConnectToDB();

            btnLogin.Click += DoClickLogin;
            this.loadingFormReference = loadingForm;
            this.databaseConnectionFormReference = databaseConnectionForm;
            this.FormClosed += new FormClosedEventHandler(LoginForm_FormClosed);
            chBShowPassword.CheckedChanged += CheckedShowPassword;
            btnBack.Click += DoClickBack;
        }

        private void DoClickBack(object? sender, EventArgs e)
        {
            databaseConnectionFormReference.Show();
            this.Hide();
        }

        private void CheckedShowPassword(object? sender, EventArgs e)
        {
            if (chBShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void DoClickLogin(object? sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Invalid Username and Password");
            }
            Login login = new Login();
            login._username = txtUsername.Text;
            login._password = txtPassword.Text;
            if (login._username != "" && login._password != "")
                userVerify = LoginFunc.VerifiedCredentials(Program.Connection, login);
            if (userVerify != null)
            {
                MainForm mainForm = new MainForm(this.loadingFormReference, databaseConnectionFormReference, this);
                mainForm.Show();
                txtUsername.Clear();
                txtPassword.Clear();
                this.Hide();
            }
            else
            {
                txtPassword.Clear();
                labelShowMessage.ForeColor = Color.Red;
                labelShowMessage.Text = "The username or password you entered is incorrect. Please try again";
            }
        }
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            databaseConnectionFormReference.Close();
            loadingFormReference.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
