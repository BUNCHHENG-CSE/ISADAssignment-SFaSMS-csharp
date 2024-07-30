using SFaSMS.Forms;
using SFaSMS.Utils;

namespace SFaSMS
{
    public partial class MainForm : Form
    {
        private LoadingForm loadingFormReference;
        private LoginForm loginFormReference;
        private DatabaseConnectionForm databaseConnectionFormReference;
        public MainForm(LoadingForm loadingForm, DatabaseConnectionForm databaseConnectionForm, LoginForm login)
        {
            InitializeComponent();
            loadingFormReference = loadingForm;
            loginFormReference = login;
            databaseConnectionFormReference = databaseConnectionForm;
            this.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);
            btnStudent.Click += DoClickStudentForm;
            btnStaff.Click += DoClickStaffForm;
            btnLecturer.Click += DoClickLecturerForm;
            btnSubject.Click += (_, _) => { this.Hide(); new SubjectForm(this).Show(); };
            btnRoom.Click += (_, _) => { this.Hide(); new RoomForm(this).Show(); };
            btnMajor.Click += (_, _) => { this.Hide(); new MajorForm(this).Show(); };
            btnStudentSummary.Click += (_, _) => { this.Hide(); new StudentSummaryForm(this).Show(); };
            btnSchedule.Click += (_, _) => { this.Hide(); new ScheduleForm(this).Show(); };
            btnPayment.Click += (_, _) => { this.Hide(); new PaymentForm(this).Show(); };
            btnExam.Click += (_, _) => { this.Hide(); new ExamForm(this).Show(); };
            btnUser.Click += (_, _) => { this.Hide(); new UserForm(this).Show(); };
            btnPaymentStatus.Click += (_, _) => { this.Hide(); new PaymentStatusForm(this).Show(); };
            btnAttendance.Click += (_, _) => { this.Hide(); new AttendanceForm(this).Show(); };
            btnLogout.Click += (_, _) => { this.Hide(); loginFormReference.Show(); };
            labelStudentAmount.Text = "0";
            labelLecturerAmount.Text = "0";
            labelStaffAmount.Text = "0";

        }

        private void DoClickLecturerForm(object? sender, EventArgs e)
        {
            LecturerForm lecturerForm = new LecturerForm(this);
            lecturerForm.LecturerAmountChanged += (sender, result) =>
            {
                if (result)
                    LoadingLecturerAmount();
            };
            lecturerForm.Show();
            this.Hide();
        }

        private void DoClickStaffForm(object? sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm(this);
            staffForm.StaffAmountChanged += (sender, result) =>
            {
                if (result)
                    LoadingStaffAmount();
            };
            staffForm.Show();
            this.Hide();
        }

        private void DoClickStudentForm(object? sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm(this);
            studentForm.StudentAmountChanged += (sender, result) =>
            {
                if (result)
                    LoadingStudentAmount();

            };
            studentForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loadingFormReference.Close();
            loginFormReference.Close();
            databaseConnectionFormReference.Close();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadingStudentAmount();
            LoadingLecturerAmount();
            LoadingStaffAmount();
        }
        private void LoadingStudentAmount()
        {
            var studentCount = StudentFunc.GetAllStudentID(Program.Connection);
            labelStudentAmount.Text = studentCount.Count().ToString();

        }
        private void LoadingLecturerAmount()
        {
            var lecturerCount = LecturerFunc.GetAllLecturerID(Program.Connection);
            labelLecturerAmount.Text = lecturerCount.Count().ToString();

        }
        private void LoadingStaffAmount()
        {
            var staffCount = StaffFunc.GetAllStaffID(Program.Connection);
            labelStaffAmount.Text = staffCount.Count().ToString();
        }
    }
}
