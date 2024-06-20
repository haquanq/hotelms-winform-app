using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormReservationUpdate : Form
    {
        private DataTable dtbAvailableRoom = new DataTable();
        private DataTable dtbSelectedRoom = new DataTable();

        private string selectedReservationId;
        public FormReservationUpdate(string selectedReservationId)
        {
            InitializeComponent();
            this.selectedReservationId = selectedReservationId;

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

            dtpArrivalTime.CustomFormat = "dd-MM-yyyy HH:mm";
            dtpDepartureTime.CustomFormat = "dd-MM-yyyy HH:mm";
            grvAvailableRoom.Columns["a_price_per_night"].DefaultCellStyle.Format = "##,0 vnd";
            grvSelectedRoom.Columns["price_per_night"].DefaultCellStyle.Format = "##,0 vnd";
        }

        private void FormReservationCreate_Load(object sender, EventArgs e)
        {
            LoadReservationDetail();
            HandleReservationStatusChange();
        }

        private void LoadReservationDetail()
        {

            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select a.id, a.room_code, a.floor_number,b.id as room_type_id, b.title as room_type_title, b.price_per_night " +
                     " from room a left join room_type b on a.room_type_id = b.id where a.status=@room_status ";
                cmd.Parameters.AddWithValue("room_status", RoomStatus.READY.ToString());
                using (var dr = cmd.ExecuteReader())
                {
                    dtbAvailableRoom.Clear();
                    dtbAvailableRoom.Load(dr);
                    grvAvailableRoom.DataSource = dtbAvailableRoom;
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "select a.id, a.room_code, a.floor_number,b.id as room_type_id, b.title as room_type_title, b.price_per_night " +
                     " from room a left join room_type b on a.room_type_id = b.id where a.id in (select room_id from reservation_room where reservation_id=@reservation_id) ";
                cmd.Parameters.AddWithValue("reservation_id", selectedReservationId);
                using (var dr = cmd.ExecuteReader())
                {
                    dtbSelectedRoom.Clear();
                    dtbSelectedRoom.Load(dr);
                    grvSelectedRoom.DataSource = dtbSelectedRoom;

                    foreach (DataRow r in dtbSelectedRoom.Rows)
                    {
                        dtbAvailableRoom.Rows.Add(r.ItemArray);
                    }
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "select id, title from room_type";
                using (var dr = cmd.ExecuteReader())
                {
                    DataTable dtbRoomType = new DataTable();
                    dtbRoomType.Load(dr);
                    DataRow row = dtbRoomType.NewRow();

                    row["title"] = "All";
                    dtbRoomType.Rows.InsertAt(row, 0);
                    cbbRoomTypeFilter.DataSource = dtbRoomType;
                    cbbRoomTypeFilter.DisplayMember = "title";
                    cbbRoomTypeFilter.ValueMember = "id";
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "select * from reservation where id=@id";
                cmd.Parameters.AddWithValue("@id", selectedReservationId);

                using (var dr = cmd.ExecuteReader())
                {
                    var dtbReservation = new DataTable();
                    dtbReservation.Load(dr);

                    var cells = dtbReservation.Rows[0];
                    lblResId.Text = cells["id"].ToString();
                    lblCustomerId.Text = cells["customer_id"].ToString();
                    dtpArrivalTime.Value = DateTime.Parse(cells["arrival_time"].ToString());
                    dtpDepartureTime.Value = DateTime.Parse(cells["departure_time"].ToString());

                    lblResStatus.Text = cells["status"].ToString();
                    if (Enum.TryParse(lblResStatus.Text, out ReservationStatus s))
                    {
                        lblResStatus.ForeColor = ReservationStatusColor.Get(s).Dark;
                        pnResStatus.BackColor = ReservationStatusColor.Get(s).Dark;
                    }
                }
                cmd.Parameters.Clear();
                cmd.CommandText = "select * from customer where id=@id";
                cmd.Parameters.AddWithValue("@id", lblCustomerId.Text);

                using (var dr = cmd.ExecuteReader())
                {
                    DataTable dtbCustomer = new DataTable();
                    dtbCustomer.Load(dr);

                    var cells = dtbCustomer.Rows[0];
                    lblPid.Text = cells["pid"].ToString();
                    lblFirstName.Text = cells["first_name"].ToString();
                    lblLastName.Text = cells["last_name"].ToString();
                    lblPhone.Text = cells["phone"].ToString();
                    lblEmail.Text = cells["email"].ToString();
                }

                conn.Close();
            }
        }

        private void HandleReservationStatusChange()
        {
            bool validValue = Enum.TryParse(lblResStatus.Text, out ReservationStatus reservationStatus);
            if (!validValue) return;

            if (reservationStatus == ReservationStatus.CHECKED_IN)
            {
                btnRoomRemove.Visible = false;
                btnRoomAdd.Visible = false;
                dtpArrivalTime.Enabled = false;
                btnDelete.Visible = false;
            }

            if (reservationStatus == ReservationStatus.PENDING)
            {
                btnRoomRemove.Visible = true;
                btnRoomAdd.Visible = true;
                btnDelete.Visible = true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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

            DialogResult res = MessageBox.Show("Do you want to save these changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            if (lblResStatus.Text == ReservationStatus.PENDING.ToString())
            {
                UpdateAllChanges();
            }
            else if (lblResStatus.Text == ReservationStatus.CHECKED_IN.ToString())
            {
                UpdateDepartureTime();
            }
        }

        private void UpdateDepartureTime()
        {
            try
            {
                using (var conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "update reservation set departure_time=@departure_time, " +
                        " updated_at=@updated_at where id=@reservation_id";
                    cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                    cmd.Parameters.AddWithValue("@departure_time", dtpDepartureTime.Value);
                    cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Changes saveed successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormReservation._self.LoadAllReservations();
                FormDashboard._self.LoadRoomStatusAndReservation();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
            }

        }

        private void UpdateAllChanges()
        {
            SqlTransaction transaction = null;

            try
            {
                using (var conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    cmd.Transaction = transaction;
                    cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                    cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);

                    cmd.CommandText = "update room set status=@room_status, updated_at=@updated_at where id in " +
                        " (select room_id from reservation_room where reservation_id=@reservation_id)";
                    cmd.Parameters.AddWithValue("@room_status", RoomStatus.READY.ToString());
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "delete from reservation_room where reservation_id=@reservation_id";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "delete from room_amenity_usage where reservation_id=@reservation_id";
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "update reservation set arrival_time=@arrival_time, departure_time=@departure_time, " +
                        " updated_at=@updated_at where id=@reservation_id";
                    cmd.Parameters.AddWithValue("@arrival_time", dtpArrivalTime.Value);
                    cmd.Parameters.AddWithValue("@departure_time", dtpDepartureTime.Value);
                    cmd.ExecuteNonQuery();


                    foreach (DataRow row in dtbSelectedRoom.Rows)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = $"insert into reservation_room (reservation_id, room_id, price_per_night) values " +
                            $" (@reservation_id, @room_id, @price_per_night); " +
                            $" update room set status = 'BOOKED' where id = @room_id";
                        cmd.Parameters.AddWithValue("@room_id", row["id"]);
                        cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                        cmd.Parameters.AddWithValue("@price_per_night", row["price_per_night"]);
                        cmd.ExecuteNonQuery();

                        DataTable dtbRoomAmenityUsage = new DataTable();
                        dtbRoomAmenityUsage.Columns.Add(new DataColumn("reservation_id", typeof(int)) { DefaultValue = selectedReservationId });
                        dtbRoomAmenityUsage.Columns.Add(new DataColumn("status", typeof(string)) { DefaultValue = "PENDING" });
                        cmd.Parameters.Clear();
                        cmd.CommandText = $"select a.room_id, a.amenity_id, b.price from room_amenity a join amenity b on a.amenity_id = b.id where room_id = '{row["id"]}'";
                        SqlDataReader dr = cmd.ExecuteReader();
                        dtbRoomAmenityUsage.Load(dr);
                        dr.Close();

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

                MessageBox.Show("Changes saved successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormReservation._self.LoadAllReservations();
                FormDashboard._self.LoadRoomStatusAndReservation();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
                transaction.Rollback();
                transaction.Dispose();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to delete this reservation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            SqlTransaction transaction = null;

            try
            {
                using (var conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    cmd.Transaction = transaction;

                    cmd.CommandText = "update room set status=@room_status, updated_at=@updated_at where id in " +
                        " (select room_id from reservation_room where reservation_id=@reservation_id)";

                    cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                    cmd.Parameters.AddWithValue("@room_status", RoomStatus.READY.ToString());
                    cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "delete from reservation where id=@reservation_id";
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    conn.Close();
                }

                MessageBox.Show("Reservation deleted successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormReservation._self.LoadAllReservations();
                FormDashboard._self.LoadRoomStatusAndReservation();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
                transaction.Rollback();
                transaction.Dispose();
            }
        }

        private void cbbRoomTypeFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbAvailableRoom);
            int y = cbbRoomTypeFilter.SelectedIndex;

            if (y == 0)
            {
                grvAvailableRoom.DataSource = dtbAvailableRoom;
            }
            else
            {
                dv.RowFilter = $"room_type_title = '{cbbRoomTypeFilter.SelectedValue}'";
                grvAvailableRoom.DataSource = dv;
            }
        }

        private void btnRoomSearch_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbAvailableRoom);
            dv.RowFilter = $"CONVERT({cbbSearchType.SelectedValue},'System.String') LIKE '%{txtSearch.Text}%'";
            grvAvailableRoom.DataSource = dv;
        }

        private void btnRoomAdd_Click(object sender, EventArgs e)
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

        private void btnRoomRemove_Click(object sender, EventArgs e)
        {
            if (grvSelectedRoom.CurrentRow == null) return;
            DataRow row = ((DataRowView)grvSelectedRoom.CurrentRow.DataBoundItem).Row;
            dtbSelectedRoom.Rows.Remove(row);
        }

        private void btnCustomerDetail_Click(object sender, EventArgs e)
        {
            var f = new FormCustomerDetail(lblCustomerId.Text);
            f.ShowDialog();
        }

        private void btnRoomDetail_Click(object sender, EventArgs e)
        {
            if (grvAvailableRoom.CurrentRow == null) return;
            var f = new FormRoomDetail(grvAvailableRoom.CurrentRow.Cells["aid"].Value.ToString());
            f.ShowDialog();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
