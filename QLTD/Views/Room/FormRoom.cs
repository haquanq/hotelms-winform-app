using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormRoom : Form
    {
        private DataTable dtbRoom = new DataTable();
        public static FormRoom _self;
        string roomStatus;

        public FormRoom(string roomStatus)
        {
            InitializeComponent();
            _self = this;
            this.roomStatus = roomStatus;

            DataTable dtbSearchType = new DataTable();
            dtbSearchType.Columns.Add("value", typeof(string));
            dtbSearchType.Columns.Add("text", typeof(string));
            dtbSearchType.Rows.Add("id", "Room ID");
            dtbSearchType.Rows.Add("room_code", "Room code");
            dtbSearchType.Rows.Add("floor_number", "Floor number");
            dtbSearchType.Rows.Add("room_type_id", "Room type ID");
            dtbSearchType.Rows.Add("room_type_title", "Room type title");
            cbbSearchType.DataSource = dtbSearchType;
            cbbSearchType.DisplayMember = "text";
            cbbSearchType.ValueMember = "value";

            DataTable dtbStatusFilter = new DataTable();
            dtbStatusFilter.Columns.Add("value", typeof(string));
            dtbStatusFilter.Columns.Add("text", typeof(string));
            dtbStatusFilter.Rows.Add("All", "All");
            dtbStatusFilter.Rows.Add("READY", "Ready to use");
            dtbStatusFilter.Rows.Add("VACANT_DIRTY", "Dirty rooms");
            dtbStatusFilter.Rows.Add("VACANT_CLEAN", "Clean rooms");
            dtbStatusFilter.Rows.Add("BOOKED", "Booked rooms");
            dtbStatusFilter.Rows.Add("OCCUPIED", "Occupied rooms");
            dtbStatusFilter.Rows.Add("MAINTAINENCE", "Maintainence");
            cbbStatusFilter.DataSource = dtbStatusFilter;
            cbbStatusFilter.DisplayMember = "text";
            cbbStatusFilter.ValueMember = "value";

            grvRoom.Columns["price_per_night"].DefaultCellStyle.Format = "##,0 vnd";
            grvRoom.Columns["created_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvRoom.Columns["updated_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
        }

        private void FormRoom_Load(object sender, EventArgs e)
        {
            HandleUserPermission();
            LoadAllRoomsAndRoomType();

            if (roomStatus != null)
            {
                cbbStatusFilter.SelectedValue = roomStatus;
                HandleRoomStatusAndRoomTypeFilter();
            }
        }

        private void HandleUserPermission()
        {
            if (Enum.TryParse(FormLogin.currentUser.role, out StaffRole role))
            {
                if (role == StaffRole.MANAGER)
                {
                    btnCreate.Visible = true;
                    btnUpdate.Visible = true;
                }
                if (role == StaffRole.RECEPTIONIST)
                {
                    btnCreate.Visible = true;
                    btnUpdate.Visible = true;
                }
                if (role == StaffRole.HOUSEKEEPER)
                {
                    btnCreate.Visible = false;
                    btnUpdate.Visible = false;
                }
                if (role == StaffRole.ADMIN)
                {
                    btnCreate.Visible = false;
                    btnUpdate.Visible = false;
                }
            }
        }

        public void LoadAllRoomsAndRoomType()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select a.id, a.room_code, a.floor_number, a.created_at, a.updated_at, " +
                   " b.id as room_type_id, b.title as room_type_title, b.detail as room_type_detail , b.price_per_night, a.status " +
                   " from room a left join room_type b on a.room_type_id = b.id";

                using (var dr = cmd.ExecuteReader())
                {
                    dtbRoom.Clear();
                    dtbRoom.Load(dr);
                    grvRoom.DataSource = dtbRoom;
                    lblRowCount.Text = $"{dtbRoom.Rows.Count} rooms";
                }

                cmd.CommandText = "select title from room_type";
                using (var dr = cmd.ExecuteReader())
                {
                    var dtbRoomType = new DataTable();
                    dtbRoomType.Load(dr);
                    DataRow row = dtbRoomType.NewRow();
                    row["title"] = "All";

                    dtbRoomType.Rows.InsertAt(row, 0);
                    cbbRoomTypeFilter.DataSource = dtbRoomType;
                    cbbRoomTypeFilter.DisplayMember = "title";
                    cbbRoomTypeFilter.ValueMember = "title";
                }
                conn.Close();
            }
        }

        private void HandleRoomStatusAndRoomTypeFilter()
        {
            DataView dv = new DataView(dtbRoom);
            int x = cbbStatusFilter.SelectedIndex;
            int y = cbbRoomTypeFilter.SelectedIndex;

            if (x == 0 && y == 0)
            {
                grvRoom.DataSource = dtbRoom;
            }
            if (x == 0 && y != 0)
            {
                dv.RowFilter = $"room_type_title = '{cbbRoomTypeFilter.SelectedValue}'";
                grvRoom.DataSource = dv;
            }
            if (x != 0 && y == 0)
            {
                dv.RowFilter = $"status = '{cbbStatusFilter.SelectedValue}'";
                grvRoom.DataSource = dv;
            }
            if (x != 0 && y != 0)
            {
                dv.RowFilter = $"status = '{cbbStatusFilter.SelectedValue}' " +
                    $"AND room_type_title = '{cbbRoomTypeFilter.SelectedValue}'";
                grvRoom.DataSource = dv;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grvRoom.ClearSelection();
            grvRoom.CurrentCell = grvRoom[0, 0];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grvRoom.CurrentRow.Index;
            if (i > 0)
            {
                grvRoom.CurrentCell = grvRoom[0, i - 1];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(grvRoom.CurrentRow.Index.ToString());
            if (i < grvRoom.RowCount - 1)
            {
                grvRoom.CurrentCell = grvRoom[0, i + 1];
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grvRoom.CurrentCell = grvRoom[0, grvRoom.RowCount - 1];
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Form f = new FormRoomCreate();
            f.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbRoom);
            dv.RowFilter = $"CONVERT({cbbSearchType.SelectedValue}, 'System.String') LIKE '%{txtSearch.Text}%'";
            grvRoom.DataSource = dv;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grvRoom.CurrentRow == null) return;
            var f = new FormRoomUpdate(grvRoom.CurrentRow.Cells["id"].Value.ToString());
            f.ShowDialog();
        }

        private void btnRoomDetail_Click(object sender, EventArgs e)
        {
            if (grvRoom.CurrentRow == null) return;
            var f = new FormRoomDetail(grvRoom.CurrentRow.Cells["id"].Value.ToString());
            f.ShowDialog();
        }

        private void cbbStatuFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HandleRoomStatusAndRoomTypeFilter();
        }

        private void cbbRoomTypeFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HandleRoomStatusAndRoomTypeFilter();
        }

        private void btnManageRoomType_Click(object sender, EventArgs e)
        {
            var f = new FormRoomType();
            f.ShowDialog();
        }

        private void btnManageAmenity_Click(object sender, EventArgs e)
        {
            var f = new FormAmenity();
            f.ShowDialog();
        }

        private void grvRoom_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in grvRoom.Rows)
            {
                if (Enum.TryParse(row.Cells["status"].Value.ToString(), out RoomStatus status))
                {
                    row.Cells["status"].Style.BackColor = RoomStatusColor.Get(status).Light;
                    row.Cells["status"].Style.ForeColor = Color.FromArgb(38, 38, 38);
                }
            }
        }
    }
}
