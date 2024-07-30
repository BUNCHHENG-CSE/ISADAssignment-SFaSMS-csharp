using SFaSMS.Models;
using SFaSMS.Utils;

namespace SFaSMS
{
    public partial class SubjectForm : Form
    {
        private MainForm mainFormReference;
        Subject? effectedSubject = null;
        List<DataGridViewRow> dataGridSubject = new List<DataGridViewRow>();
        int SubjectCount = 0;
        int indexOfUpdateSubject;
        public SubjectForm(MainForm mainform)
        {
            InitializeComponent();
            mainFormReference = mainform;
            this.FormClosed += new FormClosedEventHandler((_, _) => mainFormReference.Show());
            btnClose.Click += (_, _) => this.Close();
            btnNew.Click += DoClickNewFormInput;
            btnInsert.Click += DoClickInsertSubject;
            btnUpdate.Click += DoClickUpdateSubject;
            txtSearchSubject.TextChanged += SearchChangedFunc;
            dgvSubject.CellClick += Select_Handling_Subject;
            dataGridSubject.Clear();
        }
        private void Select_Handling_Subject(object? sender, EventArgs e)
        {
            if (dgvSubject.CurrentRow == null) return;
            int id = (int)dgvSubject.CurrentRow.Cells["SubjectID"].Value;
            try
            {
                effectedSubject = SubjectFunc.GetOneSubject(Program.Connection, id);
                txtSubjectID.Text = effectedSubject.SubjectID.ToString();
                txtSubjectName.Text = effectedSubject.SubjectName;
                txtSubjectDescription.Text = effectedSubject.SubjectDescription;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Here: {ex.Message}");
            }
        }
        private void SearchChangedFunc(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchSubject.Text) == false)
            {
                dgvSubject.Rows.Clear();
                foreach (DataGridViewRow subject in dataGridSubject)
                {
                    if (subject.Cells[1].Value.ToString().ToLower().StartsWith(txtSearchSubject.Text))
                    {
                        dgvSubject.Rows.Add(subject);
                    }
                }
            }
            else if (txtSearchSubject.Text == "")
            {
                dgvSubject.Rows.Clear();
                foreach (DataGridViewRow subject in dataGridSubject)
                {
                    dgvSubject.Rows.Add(subject);
                }
            }
        }
        private void DoClickUpdateSubject(object? sender, EventArgs e)
        {
            if (effectedSubject != null)
            {
                if (txtSubjectName.Text == "" || txtSubjectName.Text.Trim().Length > 50)
                {
                    MessageBox.Show("Subject Name is required or name too long", "Creating",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (txtSubjectDescription.Text.Trim().Length > 100)
                {
                    MessageBox.Show("Subject description too long", "Creating",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                effectedSubject.SubjectName = txtSubjectName.Text.Trim();
                effectedSubject.SubjectDescription = txtSubjectDescription.Text.Trim();
                try
                {
                    var result = SubjectFunc.UpdateSubject(Program.Connection, effectedSubject);
                    if (result == true)
                        MessageBox.Show($"Successfully updated an existing subject with the id {effectedSubject.SubjectID}");
                    DataGridViewRow tempDataGridViewRow = new DataGridViewRow();
                    tempDataGridViewRow.CreateCells(dgvSubject);
                    tempDataGridViewRow.Cells[0].Value = effectedSubject.SubjectID;
                    tempDataGridViewRow.Cells[1].Value = effectedSubject.SubjectName;
                    tempDataGridViewRow.Cells[2].Value = effectedSubject.SubjectDescription;
                    foreach (DataGridViewRow checkSubject in dataGridSubject)
                    {
                        if (int.Parse(checkSubject.Cells[0].Value.ToString()) == effectedSubject.SubjectID)
                        {
                            checkSubject.Cells[1].Value = tempDataGridViewRow.Cells[1].Value;
                            checkSubject.Cells[2].Value = tempDataGridViewRow.Cells[2].Value;
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to update an existing subject > {ex.Message}");
                }
                LoadingDataSubject();
            }
        }
        private void DoClickInsertSubject(object? sender, EventArgs e)
        {
            if (txtSubjectName.Text == ""|| txtSubjectName.Text.Trim().Length > 50)
            {
                MessageBox.Show("Subject Name is required or name too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtSubjectDescription.Text.Trim().Length > 100)
            {
                MessageBox.Show("Subject description too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            Subject newSubject = new Subject()
            {
                SubjectName = txtSubjectName.Text.Trim(),
                SubjectDescription = txtSubjectDescription.Text.Trim(),
            };
            try
            {
                var result = SubjectFunc.AddSubject(Program.Connection, newSubject);
                if (result == true)
                    MessageBox.Show($"Successfully inserted subject with the id {txtSubjectID.Text}");

                DataGridViewRow tempDataGridViewRow = new DataGridViewRow();
                tempDataGridViewRow.CreateCells(dgvSubject);
                tempDataGridViewRow.Cells[0].Value = txtSubjectID.Text;
                tempDataGridViewRow.Cells[1].Value = newSubject.SubjectName;
                tempDataGridViewRow.Cells[2].Value = newSubject.SubjectDescription;
                dataGridSubject.Add(tempDataGridViewRow);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            LoadingDataSubject();
        }
        private void DoClickNewFormInput(object? sender, EventArgs e)
        {
            txtSubjectID.Text = (SubjectCount + 1).ToString();
            txtSubjectName.Clear();
            txtSubjectDescription.Clear();
        }
        private void SubjectForm_Load(object sender, EventArgs e)
        {
            LoadingDataSubject();
            txtSubjectID.Text = (SubjectCount + 1).ToString();
            foreach (DataGridViewRow subject in dgvSubject.Rows)
            {
                dataGridSubject.Add(subject);
                txtSearchSubject.CharacterCasing = CharacterCasing.Lower;
            }
        }
        private void LoadingDataSubject()
        {
            try
            {
                var result = SubjectFunc.GetAllSubject(Program.Connection);
                if (result.LastOrDefault() != null) { SubjectCount = result.LastOrDefault().SubjectID; }
                else { SubjectCount = 0; }
                dgvSubject.Rows.Clear();
                foreach (var subject in result)
                {
                    dgvSubject.Rows.Add(subject.SubjectID, subject.SubjectName, subject.SubjectDescription);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
