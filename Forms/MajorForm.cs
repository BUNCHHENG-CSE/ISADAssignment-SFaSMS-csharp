using SFaSMS.Models;
using SFaSMS.Utils;

namespace SFaSMS
{
    public partial class MajorForm : Form
    {
        private MainForm mainFormReference;
        Major? effectedMajor = null;
        List<DataGridViewRow> dataGridMajor = new List<DataGridViewRow>();
        int MajorCount = 0;
        int indexOfUpdateMajor;

        public MajorForm(MainForm mainform)
        {
            InitializeComponent();
            mainFormReference = mainform;
            this.FormClosed += new FormClosedEventHandler((_, _) => mainFormReference.Show());
            btnClose.Click += (_, _) => this.Close();
            btnNew.Click += DoClickNewFormInput;
            btnInsert.Click += DoClickInsertMajor;
            btnUpdate.Click += DoClickUpdateMajor;
            txtSearchMajor.TextChanged += SearchChangedFunc;
            dgvMajor.CellClick += Select_Handling_Major;
            dataGridMajor.Clear();
        }
        private void Select_Handling_Major(object? sender, EventArgs e)
        {
            if (dgvMajor.CurrentRow == null) return;
            int id = (int)dgvMajor.CurrentRow.Cells["MajorID"].Value;
            try
            {
                effectedMajor = MajorFunc.GetOneMajor(Program.Connection, id);
                txtMajorID.Text = effectedMajor.MajorID.ToString();
                txtMajorNameKH.Text = effectedMajor.MajorNameKH;
                txtMajorNameEN.Text = effectedMajor.MajorNameEN;
                txtMajorNameAbb.Text = effectedMajor.MajorNameAbbreviation;
                txtMajorCost.Text = effectedMajor.MajorCost.ToString();
                txtMajorDescription.Text = effectedMajor.MajorDescription;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Here: {ex.Message}");
            }
        }
        private void SearchChangedFunc(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchMajor.Text) == false)
            {
                dgvMajor.Rows.Clear();
                foreach (DataGridViewRow major in dataGridMajor)
                {
                    if (major.Cells[1].Value.ToString().StartsWith(txtSearchMajor.Text))
                    {
                        dgvMajor.Rows.Add(major);

                    }
                }
            }
            else if (txtSearchMajor.Text == "")
            {
                dgvMajor.Rows.Clear();
                foreach (DataGridViewRow major in dataGridMajor)
                {
                    dgvMajor.Rows.Add(major);
                }
            }
        }
        private void DoClickUpdateMajor(object? sender, EventArgs e)
        {
            if (effectedMajor != null)
            {
                if (txtMajorNameKH.Text == "" || txtMajorNameKH.Text.Trim().Length > 100)
                {
                    MessageBox.Show("Major Name KH is required or name too long", "Creating",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (txtMajorNameEN.Text == "" || txtMajorNameEN.Text.Trim().Length > 70)
                {
                    MessageBox.Show("Major Name EN is required or name too long", "Creating",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (txtMajorNameAbb.Text == "" || txtMajorNameAbb.Text.Trim().Length > 5)
                {
                    MessageBox.Show("Major Name Abbreviation is required or name abbreviation too long ", "Creating",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (txtMajorDescription.Text.Trim().Length > 200)
                {
                    MessageBox.Show("Major description too long ", "Creating",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                effectedMajor.MajorNameKH = txtMajorNameKH.Text.Trim();
                effectedMajor.MajorNameEN = txtMajorNameEN.Text.Trim();

                effectedMajor.MajorNameAbbreviation = txtMajorNameAbb.Text.Trim();
                if (decimal.TryParse(txtMajorCost.Text.Trim(), out decimal majorcost) == false) MessageBox.Show("Major Cost is Requried to be not string");
                effectedMajor.MajorCost = majorcost;
                effectedMajor.MajorDescription = txtMajorDescription.Text.Trim();
                try
                {
                    var result = MajorFunc.UpdateMajor(Program.Connection, effectedMajor);
                    if (result == true)
                        MessageBox.Show($"Successfully updated an existing major with the id {effectedMajor.MajorID}");
                   
                    DataGridViewRow tempDataGridViewRow = new DataGridViewRow();
                    tempDataGridViewRow.CreateCells(dgvMajor);
                    tempDataGridViewRow.Cells[0].Value = effectedMajor.MajorID;
                    tempDataGridViewRow.Cells[1].Value = effectedMajor.MajorNameKH;
                    tempDataGridViewRow.Cells[2].Value = effectedMajor.MajorNameEN;
                    tempDataGridViewRow.Cells[3].Value = effectedMajor.MajorNameAbbreviation;
                    tempDataGridViewRow.Cells[4].Value = effectedMajor.MajorCost;
                    tempDataGridViewRow.Cells[5].Value = effectedMajor.MajorDescription;

                    foreach (DataGridViewRow checkMajor in dataGridMajor)
                    {
                        if (int.Parse(checkMajor.Cells[0].Value.ToString()) == effectedMajor.MajorID)
                        {
                            checkMajor.Cells[1].Value = tempDataGridViewRow.Cells[1].Value;
                            checkMajor.Cells[2].Value = tempDataGridViewRow.Cells[2].Value;
                            checkMajor.Cells[3].Value = tempDataGridViewRow.Cells[3].Value;
                            checkMajor.Cells[4].Value = tempDataGridViewRow.Cells[4].Value;
                            checkMajor.Cells[5].Value = tempDataGridViewRow.Cells[5].Value;
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to update an existing major > {ex.Message}");
                }
                LoadingDataMajor();
            }
        }
        private void DoClickInsertMajor(object? sender, EventArgs e)
        {
            if (txtMajorNameKH.Text == ""|| txtMajorNameKH.Text.Trim().Length>100)
            {
                MessageBox.Show("Major Name KH is required or name too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtMajorNameEN.Text == "" || txtMajorNameEN.Text.Trim().Length>70)
            {
                MessageBox.Show("Major Name EN is required or name too long", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (txtMajorNameAbb.Text == "" || txtMajorNameAbb.Text.Trim().Length>5)
            {
                MessageBox.Show("Major Name Abbreviation is required or name abbreviation too long ", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if ( txtMajorDescription.Text.Trim().Length > 200)
            {
                MessageBox.Show("Major description too long ", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (decimal.TryParse(txtMajorCost.Text.Trim(), out decimal majorcost) == false)
            {
                MessageBox.Show("Major Cost is required", "Creating",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Major newMajor = new Major()
            {
                MajorNameKH = txtMajorNameKH.Text.Trim(),
                MajorNameEN = txtMajorNameEN.Text.Trim(),
                MajorNameAbbreviation = txtMajorNameAbb.Text.Trim(),
                MajorCost = majorcost,
                MajorDescription = txtMajorDescription.Text.Trim(),
            };
            try
            {
                var result = MajorFunc.AddMajor(Program.Connection, newMajor);
                if (result == true)
                    MessageBox.Show($"Successfully inserted major with the id {txtMajorID.Text}");
                DataGridViewRow tempDataGridViewRow = new DataGridViewRow();
                tempDataGridViewRow.CreateCells(dgvMajor);
                tempDataGridViewRow.Cells[0].Value = txtMajorID.Text;
                tempDataGridViewRow.Cells[1].Value = newMajor.MajorNameKH;
                tempDataGridViewRow.Cells[2].Value = newMajor.MajorNameEN;
                tempDataGridViewRow.Cells[3].Value = newMajor.MajorNameAbbreviation;
                tempDataGridViewRow.Cells[4].Value = newMajor.MajorCost;
                tempDataGridViewRow.Cells[5].Value = newMajor.MajorDescription;
                dataGridMajor.Add(tempDataGridViewRow);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            LoadingDataMajor();
        }
        private void DoClickNewFormInput(object? sender, EventArgs e)
        {
            txtMajorID.Text = (MajorCount + 1).ToString();
            txtMajorNameKH.Clear();
            txtMajorNameEN.Clear();
            txtMajorNameAbb.Clear();
            txtMajorCost.Clear();
            txtMajorDescription.Clear();
        }
        private void LoadingDataMajor()
        {
            try
            {
                var result = MajorFunc.GetAllMajor(Program.Connection);
                if (result.LastOrDefault() != null) { MajorCount = result.LastOrDefault().MajorID; }
                else { MajorCount = 0; }
                dgvMajor.Rows.Clear();
                foreach (var major in result)
                {
                    dgvMajor.Rows.Add(major.MajorID, major.MajorNameKH, major.MajorNameEN, major.MajorNameAbbreviation, major.MajorCost, major.MajorDescription);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Retrieving Major", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MajorForm_Load(object sender, EventArgs e)
        {
            LoadingDataMajor();
            txtMajorID.Text = (MajorCount + 1).ToString();
            foreach (DataGridViewRow major in dgvMajor.Rows)
            {
                dataGridMajor.Add(major);
                txtSearchMajor.CharacterCasing = CharacterCasing.Lower;
            }
        }
    }
}