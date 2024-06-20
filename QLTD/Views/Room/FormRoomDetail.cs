using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormRoomDetail : Form
    {
        public static FormRoomDetail _self;

        private DataTable dtbReservationHistory = new DataTable();
        private string selectedRoomId;

        public FormRoomDetail(string selectedRoomId)
        {
            InitializeComponent();
            _self = this;
            this.selectedRoomId = selectedRoomId;

            DataTable dtbSearchType = new DataTable();
            dtbSearchType.Columns.Add("value", typeof(string));
            dtbSearchType.Columns.Add("text", typeof(string));
            dtbSearchType.Rows.Add("id", "Reservation ID");
            dtbSearchType.Rows.Add("staff_id", "Staff ID");
            dtbSearchType.Rows.Add("staff_name", "Staff Name");
            dtbSearchType.Rows.Add("customer_id", "Customer ID");
            dtbSearchType.Rows.Add("customer_name", "Customer Name");
            cbbSearchType.DataSource = dtbSearchType;
            cbbSearchType.DisplayMember = "text";
            cbbSearchType.ValueMember = "value";

            DataTable dtbStatusFilter = new DataTable();
            dtbStatusFilter.Columns.Add("value", typeof(string));
            dtbStatusFilter.Columns.Add("text", typeof(string));
            dtbStatusFilter.Rows.Add("All", "All");
            dtbStatusFilter.Rows.Add("PENDING", "Pending");
            dtbStatusFilter.Rows.Add("CHECKED_IN", "Checked in");
            dtbStatusFilter.Rows.Add("CHECKED_OUT", "Checked out");
            dtbStatusFilter.Rows.Add("CANCELLED", "Canceled");
            cbbStatusFilter.DataSource = dtbStatusFilter;
            cbbStatusFilter.DisplayMember = "text";
            cbbStatusFilter.ValueMember = "value";

            grvReservation.Columns["total_price"].DefaultCellStyle.Format = "##,0 vnd";
            grvReservation.Columns["created_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvReservation.Columns["updated_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvReservation.Columns["arrival_time"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
            grvReservation.Columns["departure_time"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
            grvReservation.Columns["checked_in_at"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
            grvReservation.Columns["checked_out_at"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
        }

        private void FormRoomDetail_Load(object sender, EventArgs e)
        {
            HandleUserPermission();
            LoadRoomDetail();
            LoadRoomReservatioHistory();
        }

        private void HandleUserPermission()
        {
            if (Enum.TryParse(FormLogin.currentUser.role, out StaffRole role))
            {
                if (role == StaffRole.MANAGER)
                {
                    btnMakeClean.Visible = false;
                    btnMakeReady.Visible = true;
                }
                if (role == StaffRole.RECEPTIONIST)
                {
                    btnMakeClean.Visible = false;
                    btnMakeReady.Visible = true;
                }
                if (role == StaffRole.HOUSEKEEPER)
                {
                    btnMakeClean.Visible = true;
                    btnMakeReady.Visible = false;
                }
                if (role == StaffRole.ADMIN)
                {
                    btnMakeClean.Visible = false;
                    btnMakeReady.Visible = false;
                }
            }
        }

        private void HandleRoomStatusChange(string status)
        {
            if (Enum.TryParse(status, out RoomStatus s))
            {
                lblRoomStatus.Text = s.ToString();
                lblRoomStatus.ForeColor = RoomStatusColor.Get(s).Dark;
                pnRoomStatus.BackColor = RoomStatusColor.Get(s).Dark;

                if (s == RoomStatus.VACANT_DIRTY)
                {
                    btnMakeClean.Visible = btnMakeClean.Visible ? true : false;
                    btnMakeReady.Visible = false;
                }
                else if (s == RoomStatus.VACANT_CLEAN)
                {
                    btnMakeClean.Visible = false;
                    btnMakeReady.Visible = btnMakeReady.Visible ? true : false;
                }
                else
                {
                    btnMakeClean.Visible = false;
                    btnMakeReady.Visible = false;
                }
            }
        }

        public void LoadRoomDetail()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select a.id, a.room_code, a.floor_number, b.title as room_type_title, " +
                    " b.price_per_night, a.created_at, a.updated_at, a.status from room a join room_type b on a.room_type_id = b.id where a.id=@room_id";
                cmd.Parameters.AddWithValue("@room_id", selectedRoomId);

                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(reader);

                    var cells = dt.Rows[0];
                    lblRoomId.Text = cells["id"].ToString();
                    lblRoomCode.Text = cells["room_code"].ToString();
                    lblFloorNumber.Text = cells["floor_number"].ToString();
                    lblRoomType.Text = cells["room_type_title"].ToString();
                    lblPrice.Text = Helper.NumberToVND(Convert.ToInt32(cells["price_per_night"]));
                    lblCreatedAt.Text = DateTime.Parse(cells["created_at"].ToString()).ToString("dd-MM-yyyy HH:mm");
                    lblUpdatedAt.Text = DateTime.Parse(cells["updated_at"].ToString()).ToString("dd-MM-yyyy HH:mm");

                    HandleRoomStatusChange(cells["status"].ToString());
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "select STRING_AGG(b.title, '\r\n') as amenities from room_amenity a " +
                    " left join amenity b on a.amenity_id = b.id where a.room_id=@room_id";
                cmd.Parameters.AddWithValue("@room_id", selectedRoomId);
                lblAmenity.Text = cmd.ExecuteScalar().ToString();

                conn.Close();
            }
        }

        public void LoadRoomReservatioHistory()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select b.id, b.arrival_time, b.departure_time, b.checked_in_at, b.checked_out_at, " +
                    " b.created_at, b.updated_at, b.status, b.total_price, c.first_name + ' ' + c.last_name as customer_name from reservation_room a" +
                    " left join reservation b on a.reservation_id = b.id" +
                    " left join customer c on b.customer_id = c.id where a.room_id=@room_id";
                cmd.Parameters.AddWithValue("@room_id", selectedRoomId);
                using (var dr = cmd.ExecuteReader())
                {
                    dtbReservationHistory.Clear();
                    dtbReservationHistory.Load(dr);
                    grvReservation.DataSource = dtbReservationHistory;
                    lblRowCount.Text = $"{dtbReservationHistory.Rows.Count} reservations";
                }

                conn.Close();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbReservationHistory);
            dv.RowFilter = $"CONVERT({cbbSearchType.SelectedValue},'System.String') LIKE '%{txtSearch.Text}%'";
            grvReservation.DataSource = dv;
        }

        private void cbbStatusFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbReservationHistory);
            int x = cbbStatusFilter.SelectedIndex;

            if (x == 0)
            {
                grvReservation.DataSource = dtbReservationHistory;
            }
            else
            {
                dv.RowFilter = $"status = '{cbbStatusFilter.SelectedValue}'";
                grvReservation.DataSource = dv;
            }
        }

        private void btnMoreDetail_Click(object sender, EventArgs e)
        {
            if (grvReservation.CurrentRow == null) return;
            var f = new FormReservationDetail(grvReservation.CurrentRow.Cells["id"].Value.ToString());
            f.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grvReservation_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow row in grvReservation.Rows)
            {
                if (Enum.TryParse(row.Cells["status"].Value.ToString(), out ReservationStatus status))
                {
                    row.Cells["status"].Style.BackColor = ReservationStatusColor.Get(status).Light;
                    row.Cells["status"].Style.ForeColor = Color.FromArgb(38, 38, 38);
                }
            }
        }

        private void btnMakeClean_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to clean this room?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "update room set status=@status where id=@room_id";
                cmd.Parameters.AddWithValue("@room_id", selectedRoomId);
                cmd.Parameters.AddWithValue("@status", RoomStatus.VACANT_CLEAN.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            LoadRoomDetail();
            FormRoom._self.LoadAllRoomsAndRoomType();
        }

        private void btnMakeReady_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to make this room available?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "update room set status=@status where id=@room_id";
                cmd.Parameters.AddWithValue("@room_id", selectedRoomId);
                cmd.Parameters.AddWithValue("@status", RoomStatus.READY.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            LoadRoomDetail();
            FormRoom._self.LoadAllRoomsAndRoomType();
        }
    }
}
