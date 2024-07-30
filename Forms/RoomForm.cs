using SFaSMS.Models;
using SFaSMS.Utils;

namespace SFaSMS
{
    public partial class RoomForm : Form
    {
        private MainForm mainFormReference;
        Room? effectedRoom = null;
        List<DataGridViewRow> dataGridRoom = new List<DataGridViewRow>();
        int RoomCount = 0;
        int indexOfUpdateRoom;
        public RoomForm(MainForm mainform)
        {
            InitializeComponent();
            mainFormReference = mainform;
            this.FormClosed += new FormClosedEventHandler((_, _) => mainFormReference.Show());
            btnClose.Click += (_, _) => this.Close();
            btnNew.Click += DoClickNewFormInput;
            btnInsert.Click += DoClickInsertRoom;
            btnUpdate.Click += DoClickUpdateRoom;
            txtSearchRoom.TextChanged += SearchChangedFunc;
            dgvRoom.CellClick += Select_Handling_Room;
            dataGridRoom.Clear();
        }
        private void Select_Handling_Room(object? sender, EventArgs e)
        {
            if (dgvRoom.CurrentRow == null) return;
            int no = (int)dgvRoom.CurrentRow.Cells["RoomNo"].Value;
            try
            {
                effectedRoom = RoomFunc.GetOneRoom(Program.Connection, no);
                txtRoomNo.Text = effectedRoom.RoomNo.ToString();
                txtRoomNumber.Text = effectedRoom.RoomNumber.ToString();
                txtBuildingNumber.Text = effectedRoom.BuildingLetter;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Here: {ex.Message}");
            }
        }
        private void SearchChangedFunc(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchRoom.Text) == false)
            {
                dgvRoom.Rows.Clear();
                foreach (DataGridViewRow room in dataGridRoom)
                {
                    if (room.Cells[1].Value.ToString().StartsWith(txtSearchRoom.Text))
                    {
                        dgvRoom.Rows.Add(room);
                    }
                }
            }
            else if (txtSearchRoom.Text == "")
            {
                dgvRoom.Rows.Clear();
                foreach (DataGridViewRow room in dataGridRoom)
                {
                    dgvRoom.Rows.Add(room);
                }
            }
        }

        private void DoClickUpdateRoom(object? sender, EventArgs e)
        {
            if (effectedRoom != null)
            {
                if (int.TryParse(txtRoomNumber.Text, out int roomNumber) == false)
                {
                    MessageBox.Show("Room Number is required or room number is wrong", "Creating",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (txtBuildingNumber.Text == "" || txtBuildingNumber.Text.Trim().Length > 10)
                {
                    MessageBox.Show("Building Letter is required or building letter too long", "Creating",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                effectedRoom.RoomNumber = roomNumber;
                effectedRoom.BuildingLetter = txtBuildingNumber.Text.Trim();
                try
                {
                    var result = RoomFunc.UpdateRoom(Program.Connection, effectedRoom);
                    if (result == true)
                        MessageBox.Show($"Successfully updated an existing room with the no {effectedRoom.RoomNo}");
                    DataGridViewRow tempDataGridViewRow = new DataGridViewRow();
                    tempDataGridViewRow.CreateCells(dgvRoom);
                    tempDataGridViewRow.Cells[0].Value = effectedRoom.RoomNo;
                    tempDataGridViewRow.Cells[1].Value = effectedRoom.RoomNumber;
                    tempDataGridViewRow.Cells[2].Value = effectedRoom.BuildingLetter;
                    foreach (DataGridViewRow checkRoom in dataGridRoom)
                    {
                        if (int.Parse(checkRoom.Cells[0].Value.ToString().Trim()) == effectedRoom.RoomNo)
                        {
                            checkRoom.Cells[1].Value = tempDataGridViewRow.Cells[1].Value;
                            checkRoom.Cells[2].Value = tempDataGridViewRow.Cells[2].Value;
                            break;
                        }

                    }
                }
                catch (Exception ex)
                {
                MessageBox.Show($"Failed to update an existing room > {ex.Message}");
            }
            LoadingDataRoom();
        }
    }

    private void DoClickInsertRoom(object? sender, EventArgs e)
    {

        if (int.TryParse(txtRoomNumber.Text, out int roomNumber) == false)
        {
            MessageBox.Show("Room Number is required or room number is wrong", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        if (txtBuildingNumber.Text == "" || txtBuildingNumber.Text.Trim().Length > 10)
        {
            MessageBox.Show("Building Letter is required or building letter too long", "Creating",
            MessageBoxButtons.OK, MessageBoxIcon.Stop);
            return;
        }
        Room newRoom = new Room()
        {

            RoomNumber = roomNumber,
            BuildingLetter = txtBuildingNumber.Text.Trim(),
        };
        try
        {
            var result = RoomFunc.AddRoom(Program.Connection, newRoom);
            if (result == true)
                MessageBox.Show($"Successfully inserted room with the no {txtRoomNo.Text}");
            DataGridViewRow tempDataGridViewRow = new DataGridViewRow();
            tempDataGridViewRow.CreateCells(dgvRoom);
            tempDataGridViewRow.Cells[0].Value = txtRoomNo.Text;
            tempDataGridViewRow.Cells[1].Value = newRoom.RoomNumber;
            tempDataGridViewRow.Cells[2].Value = newRoom.BuildingLetter;
            dataGridRoom.Add(tempDataGridViewRow);
        }
        catch (Exception ex) { MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        LoadingDataRoom();
    }

    private void DoClickNewFormInput(object? sender, EventArgs e)
    {
        txtRoomNo.Text = (RoomCount + 1).ToString();
        txtRoomNumber.Clear();
        txtBuildingNumber.Clear();
    }

    private void RoomForm_Load(object sender, EventArgs e)
    {
        LoadingDataRoom();
        txtRoomNo.Text = (RoomCount + 1).ToString();
        foreach (DataGridViewRow room in dgvRoom.Rows)
        {
            dataGridRoom.Add(room);
            txtSearchRoom.CharacterCasing = CharacterCasing.Lower;
        }
    }
    private void LoadingDataRoom()
    {
        try
        {
            var result = RoomFunc.GetAllRoom(Program.Connection);
            if (result.LastOrDefault() != null) { RoomCount = result.LastOrDefault().RoomNo; }
            else { RoomCount = 0; }
            dgvRoom.Rows.Clear();
            foreach (var room in result)
            {
                dgvRoom.Rows.Add(room.RoomNo, room.RoomNumber, room.BuildingLetter);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Retriving Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
}
