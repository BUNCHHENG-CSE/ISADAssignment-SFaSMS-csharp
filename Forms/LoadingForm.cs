
using SFaSMS.Forms;

namespace SFaSMS
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
            
            timerLoading.Tick += DoTimerTicker;
            timerLoading.Start();
            
        }
        int startpos = 0;
        private void DoTimerTicker(object? sender, EventArgs e)
        {
            startpos += 4;
            progressBarLoading.Value = startpos;
            if (progressBarLoading.Value == 100)
            {
                progressBarLoading.Value = 0;
                timerLoading.Stop();
                this.Hide();
                DatabaseConnectionForm databaseConnectionForm = new DatabaseConnectionForm(this);
                if (File.Exists($"{Environment.CurrentDirectory}/appSettings.json"))
                {
                    databaseConnectionForm.Hide();
                    LoginForm loginForm = new LoginForm(this, databaseConnectionForm);
                    loginForm.Show();
                }
                else
                {

                databaseConnectionForm.Show();
                }
            }
        }
        
    }
}
