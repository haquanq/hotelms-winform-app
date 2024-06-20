using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormDashboard : Form
    {
        public static FormDashboard _self;
        public DataTable dtbExpectedArrival = new DataTable();
        public DataTable dtbExpectedDeparture = new DataTable();
        public FormDashboard()
        {
            InitializeComponent();
            _self = this;

            DataTable dtbSearchType1 = new DataTable();
            dtbSearchType1.Columns.Add("value", typeof(string));
            dtbSearchType1.Columns.Add("text", typeof(string));
            dtbSearchType1.Rows.Add("id", "Reservation ID");
            dtbSearchType1.Rows.Add("rooms", "Room Code");
            dtbSearchType1.Rows.Add("customer_name", "Customer Name");
            cbbSearchType1.DataSource = dtbSearchType1;
            cbbSearchType1.DisplayMember = "text";
            cbbSearchType1.ValueMember = "value";

            DataTable dtbSearchType2 = new DataTable();
            dtbSearchType2.Columns.Add("value", typeof(string));
            dtbSearchType2.Columns.Add("text", typeof(string));
            dtbSearchType2.Rows.Add("id", "Reservation ID");
            dtbSearchType2.Rows.Add("rooms", "Room Code");
            dtbSearchType2.Rows.Add("customer_name", "Customer Name");
            cbbSearchType2.DataSource = dtbSearchType2;
            cbbSearchType2.DisplayMember = "text";
            cbbSearchType2.ValueMember = "value";

            grvExpectedArrival.Columns["arrival_time1"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvExpectedDeaprture.Columns["departure_time2"].DefaultCellStyle.Format = "dd-MM-yyyy";
        }
        private void FormDashboard_Load(object sender, EventArgs e)
        {
            HandleUserPermission();
            LoadRoomStatusAndReservation();
        }
        private void HandleUserPermission()
        {
            if (Enum.TryParse(FormLogin.currentUser.role, out StaffRole role))
            {
                if (role == StaffRole.MANAGER)
                {
                    btnReadyRoom.Visible = false;
                    btnCreateReaservation.Visible = true;
                }
                if (role == StaffRole.RECEPTIONIST)
                {
                    btnReadyRoom.Visible = false;
                    btnCreateReaservation.Visible = true;
                }
                if (role == StaffRole.ADMIN)
                {
                    btnReadyRoom.Visible = true;
                    btnCreateReaservation.Visible = false;
                }
                if (role == StaffRole.HOUSEKEEPER)
                {
                    btnReadyRoom.Visible = true;
                    btnCreateReaservation.Visible = false;
                }
            }
        }


        public void LoadRoomStatusAndReservation()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select " +
                    " count(*) as total_room, " +
                    " sum(case when status = 'READY' then 1 else 0 end) as ready, " +
                    " sum(case when status = 'VACANT_DIRTY' then 1 else 0 end) as vacant_dirty, " +
                    " sum(case when status = 'VACANT_CLEAN' then 1 else 0 end) as vacant_clean, " +
                    " sum(case when status = 'BOOKED' then 1 else 0 end) as booked, " +
                    " sum(case when status = 'OCCUPIED' then 1 else 0 end) as occupied from room";

                using (var dr = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(dr);
                    dr.Close();

                    TotalRoomLabel.Text = dt.Rows[0]["total_room"].ToString();
                    ReadyLabel.Text = dt.Rows[0]["ready"].ToString();
                    DirtyVacantLabel.Text = dt.Rows[0]["vacant_dirty"].ToString();
                    CleanVacantLabel.Text = dt.Rows[0]["vacant_clean"].ToString();
                    OccupiedLabel.Text = dt.Rows[0]["occupied"].ToString();
                    BookedLabel.Text = dt.Rows[0]["booked"].ToString();
                }


                cmd.Parameters.Clear();
                cmd.CommandText = "select a.id, STRING_AGG(c.room_code, '\r\n') as rooms, d.first_name + ' ' + d.last_name as customer_name, a.arrival_time, a.departure_time from reservation a " +
                    " join reservation_room b on a.id = b.reservation_id " +
                    " join room c on b.room_id = c.id " +
                    " join customer d on a.customer_id = d.id " +
                    " where a.status = @status " +
                    " group by a.id, a.arrival_time, a.departure_time, d.first_name, d.last_name";

                cmd.Parameters.AddWithValue("@status", "PENDING");
                using (var drExpectedArrival = cmd.ExecuteReader())
                {
                    dtbExpectedArrival.Clear();
                    dtbExpectedArrival.Load(drExpectedArrival);
                    grvExpectedArrival.DataSource = dtbExpectedArrival;
                    lblExpectedArrival.Text = $"Expected Arrival ({dtbExpectedArrival.Rows.Count})";
                }

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@status", "CHECKED_IN");
                using (var drExpectedDeparture = cmd.ExecuteReader())
                {
                    dtbExpectedDeparture.Clear();
                    dtbExpectedDeparture.Load(drExpectedDeparture);
                    grvExpectedDeaprture.DataSource = dtbExpectedDeparture;
                    lblExpectedDeparture.Text = $"Expected Departure ({dtbExpectedDeparture.Rows.Count})";
                }

                conn.Close();
            }

        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            var f = new FormReservationCreate();
            f.ShowDialog();
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbExpectedArrival);
            dv.RowFilter = $"CONVERT({cbbSearchType1.SelectedValue}, 'System.String') LIKE '%{txtSearch1.Text}%'";
            grvExpectedArrival.DataSource = dv;

        }

        private void btnSearch2_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbExpectedArrival);
            dv.RowFilter = $"CONVERT({cbbSearchType2.SelectedValue}, 'System.String') LIKE '%{txtSearch2.Text}%'";
            grvExpectedDeaprture.DataSource = dv;
        }

        private void btnTotalRoom_Click(object sender, EventArgs e)
        {
            FormHome._self.NavigateToRoomWithStatus(null);
        }

        private void btnDirtyVacantRoom_Click(object sender, EventArgs e)
        {
            FormHome._self.NavigateToRoomWithStatus(RoomStatus.VACANT_DIRTY.ToString());
        }

        private void btnCleanVacantRoom_Click(object sender, EventArgs e)
        {
            FormHome._self.NavigateToRoomWithStatus(RoomStatus.VACANT_CLEAN.ToString());
        }

        private void btnBookedRoom_Click(object sender, EventArgs e)
        {
            FormHome._self.NavigateToRoomWithStatus(RoomStatus.BOOKED.ToString());
        }

        private void btnOccupiedRoom_Click(object sender, EventArgs e)
        {
            FormHome._self.NavigateToRoomWithStatus(RoomStatus.OCCUPIED.ToString());
        }

        private void btnReadyRoom_Click(object sender, EventArgs e)
        {
            FormHome._self.NavigateToRoomWithStatus(RoomStatus.READY.ToString());
        }
    }
}
