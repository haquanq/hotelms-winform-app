using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormReservationCreate : Form
    {
        public DataTable dtbAvailableRoom = new DataTable();
        public DataTable dtbSelectedRoom = new DataTable();
        public DataTable dtbCustomer = new DataTable();
        public FormReservationCreate()
        {
            InitializeComponent();

            DataTable dtbSearchType = new DataTable();
            dtbSearchType.Columns.Add("value", typeof(string));
            dtbSearchType.Columns.Add("text", typeof(string));
            dtbSearchType.Rows.Add("id", "Room ID");
            dtbSearchType.Rows.Add("room_code", "Room code");
            dtbSearchType.Rows.Add("floor_number", "Floor number");
            dtbSearchType.Rows.Add("room_type_id", "Room type ID");
            dtbSearchType.Rows.Add("room_type_title", "Room type title");
            cbbRoomSearchType.DataSource = dtbSearchType;
            cbbRoomSearchType.DisplayMember = "text";
            cbbRoomSearchType.ValueMember = "value";

            dtpArrivalTime.CustomFormat = "dd-MM-yyyy HH:mm";
            dtpDepartureTime.CustomFormat = "dd-MM-yyyy HH:mm";
            grvAvailableRoom.Columns["a_price_per_night"].DefaultCellStyle.Format = "##,0 vnd";
            grvSelectedRoom.Columns["price_per_night"].DefaultCellStyle.Format = "##,0 vnd";
        }

        private void FormReservationCreate_Load(object sender, EventArgs e)
        {
            LoadAvailableRoomAndRoomType();
        }


        private void LoadAvailableRoomAndRoomType()
        {

            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select a.id, a.room_code, a.floor_number,b.id as room_type_id, b.title as room_type_title, b.price_per_night " +
                    " from room a left join room_type b on a.room_type_id = b.id where a.status =@room_status ";
                cmd.Parameters.AddWithValue("room_status", RoomStatus.READY.ToString());
                using (var reader = cmd.ExecuteReader())
                {
                    dtbAvailableRoom.Clear();
                    dtbAvailableRoom.Load(reader);
                    grvAvailableRoom.DataSource = dtbAvailableRoom;

                    dtbSelectedRoom = dtbAvailableRoom.Clone();
                    grvSelectedRoom.DataSource = dtbSelectedRoom;
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "select id, title from room_type";
                using (var reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    DataRow row = dt.NewRow();
                    row["title"] = "All";
                    dt.Rows.InsertAt(row, 0);
                    cbbRoomTypeFilter.DataSource = dt;
                    cbbRoomTypeFilter.DisplayMember = "title";
                    cbbRoomTypeFilter.ValueMember = "id";
                }

                conn.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            if (dtbCustomer.Rows.Count == 0)
            {
                MessageBox.Show("Customer's information is not valid!", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpDepartureTime.Value < dtpArrivalTime.Value)
            {
                MessageBox.Show("Departure time can't be smaller than arrival!", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtbSelectedRoom.Rows.Count == 0)
            {
                MessageBox.Show("Must select a room!", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int reservationDayCount = (dtpDepartureTime.Value - dtpArrivalTime.Value).Days;
            if (reservationDayCount < 1)
            {
                MessageBox.Show("Reservation period must be atlest 1 day!", "INVALID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult res = MessageBox.Show("Do you want to create this reservation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            SqlTransaction transaction = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    cmd.Transaction = transaction;

                    cmd.CommandText = "insert into reservation (customer_id, staff_id, arrival_time, departure_time, status, created_at, updated_at) values"
                    + " (@customer_id, @staff_id, @arrival_time, @departure_time, @status, @created_at, @updated_at); select SCOPE_IDENTITY()";
                    cmd.Parameters.AddWithValue("@customer_id", txtCustomerId.Text);
                    cmd.Parameters.AddWithValue("@staff_id", FormLogin.currentUser.id);
                    cmd.Parameters.AddWithValue("@arrival_time", dtpArrivalTime.Value);
                    cmd.Parameters.AddWithValue("@departure_time", dtpDepartureTime.Value);
                    cmd.Parameters.AddWithValue("@status", "PENDING");
                    cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                    cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                    int reservationId = Convert.ToInt32(cmd.ExecuteScalar());

                    foreach (DataRow row in dtbSelectedRoom.Rows)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = $"insert into reservation_room (reservation_id, room_id, price_per_night) values " +
                            $" (@reservation_id, @room_id, @price_per_night); " +
                            $" update room set status=@room_status, updated_at=@updated_at where id = @room_id";
                        cmd.Parameters.AddWithValue("room_id", row["id"]);
                        cmd.Parameters.AddWithValue("room_status", RoomStatus.BOOKED.ToString());
                        cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                        cmd.Parameters.AddWithValue("reservation_id", reservationId);
                        cmd.Parameters.AddWithValue("price_per_night", row["price_per_night"]);
                        cmd.ExecuteNonQuery();

                        DataTable dtbRoomAmenityUsage = new DataTable();
                        dtbRoomAmenityUsage.Columns.Add(new DataColumn("reservation_id", typeof(int)) { DefaultValue = reservationId });
                        dtbRoomAmenityUsage.Columns.Add(new DataColumn("status", typeof(string)) { DefaultValue = RoomAmenityUsageStatus.PENDING.ToString() });
                        cmd.Parameters.Clear();
                        cmd.CommandText = $"select a.room_id, a.amenity_id, b.price from room_amenity a join amenity b on a.amenity_id = b.id where room_id = '{row["id"]}'";
                        using (var reader = cmd.ExecuteReader())
                        {
                            dtbRoomAmenityUsage.Load(reader);
                        }

                        SqlBulkCopy cp = new SqlBulkCopy(conn, SqlBulkCopyOptions.KeepIdentity, transaction);
                        cp.ColumnMappings.Add("reservation_id", "reservation_id");
                        cp.ColumnMappings.Add("room_id", "room_id");
                        cp.ColumnMappings.Add("amenity_id", "amenity_id");
                        cp.ColumnMappings.Add("price", "price");
                        cp.ColumnMappings.Add("status", "status");
                        cp.DestinationTableName = "dbo.room_amenity_usage";
                        cp.WriteToServer(dtbRoomAmenityUsage);
                    }

                    transaction.Commit();
                    conn.Close();
                }

                MessageBox.Show("Reservation created successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormDashboard._self?.LoadRoomStatusAndReservation();
                FormReservation._self?.LoadAllReservations();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
                transaction.Rollback();
                transaction.Dispose();
            }
        }


        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select * from customer where id = @customer_id " +
                    " and id not in (select customer_id from reservation " +
                    " where customer_id = @customer_id and status in ('PENDING', 'CHECKED_IN'))";
                cmd.Parameters.AddWithValue("@customer_id", txtCustomerId.Text);

                using (var dr = cmd.ExecuteReader())
                {
                    dtbCustomer.Clear();
                    dtbCustomer.Load(dr);
                }

                conn.Close();
            }

            if (dtbCustomer.Rows.Count == 0)
            {
                MessageBox.Show("No customer found!", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var cells = dtbCustomer.Rows[0];
            lblPid.Text = cells["pid"].ToString();
            lblFirstName.Text = cells["first_name"].ToString();
            lblLastName.Text = cells["last_name"].ToString();
            lblPhone.Text = cells["phone"].ToString();
            lblEmail.Text = cells["email"].ToString();
            lblAddress.Text = cells["address"].ToString();
            txtCustomerId.Enabled = false;

            if (Enum.TryParse(cells["status"].ToString(), out CustomerStatus customerStatus))
            {
                lblCustomerStatus.Text = customerStatus.ToString().ToLower();
                lblCustomerStatus.ForeColor = CustomerStatusColor.Get(customerStatus).Dark;
                pnCustomerStatus.BackColor = CustomerStatusColor.Get(customerStatus).Dark;
            }
        }

        private void cbbRoomTypeFitler_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbAvailableRoom);
            int y = cbbRoomTypeFilter.SelectedIndex;

            if (y == 0)
            {
                grvAvailableRoom.DataSource = dtbAvailableRoom;
            }
            else
            {
                dv.RowFilter = $"room_type_id = '{cbbRoomTypeFilter.SelectedValue}'";
                grvAvailableRoom.DataSource = dv;
            }

        }

        private void btnSearchRoom_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbAvailableRoom);
            dv.RowFilter = $"CONVERT({cbbRoomSearchType.SelectedValue}, 'System.String') LIKE '%{txtSearch.Text}%'";
            grvAvailableRoom.DataSource = dv;
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (grvAvailableRoom.CurrentRow == null) return;

            DataRow currentRow = ((DataRowView)grvAvailableRoom.CurrentRow.DataBoundItem).Row;
            DataRow[] found = dtbSelectedRoom.Select($"id = {currentRow["id"]}");

            if (found.Length != 0)
            {
                MessageBox.Show("Room already added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dtbSelectedRoom.NewRow();
            row["id"] = currentRow["id"];
            row["room_code"] = currentRow["room_code"];
            row["floor_number"] = currentRow["floor_number"];
            row["room_type_title"] = currentRow["room_type_title"];
            row["price_per_night"] = currentRow["price_per_night"];
            dtbSelectedRoom.Rows.Add(row);
        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            if (grvSelectedRoom.CurrentRow == null) return;
            DataRow row = ((DataRowView)grvSelectedRoom.CurrentRow.DataBoundItem).Row;
            dtbSelectedRoom.Rows.Remove(row);
        }

        private void btnMoreCustomerDetail_Click(object sender, EventArgs e)
        {
            if (dtbCustomer.Rows.Count == 0) return;
            var f = new FormCustomerDetail(txtCustomerId.Text);
            f.ShowDialog();
        }

        private void btnChangeCustomer_Click(object sender, EventArgs e)
        {
            txtCustomerId.Enabled = true;
            dtbCustomer.Clear();

            lblCustomerStatus.ForeColor = Color.FromArgb(38, 38, 38);
            pnCustomerStatus.BackColor = Color.Transparent;
            lblCustomerStatus.Text = "STATUS";
        }

        private void btnMoreRoomDetail_Click(object sender, EventArgs e)
        {
            if (grvAvailableRoom.CurrentRow == null) return;
            var f = new FormRoomDetail(grvAvailableRoom.CurrentRow.Cells["aid"].Value.ToString());
            f.ShowDialog();
        }
    }
}
