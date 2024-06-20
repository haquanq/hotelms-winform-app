using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormReservationDetail : Form
    {
        public static FormReservationDetail _self;
        private DataTable dtbRoom = new DataTable();
        private DataTable dtbAmenityUsage = new DataTable();
        private string selectedReservationId;
        private string viewingRoomId;
        public FormReservationDetail(string selectedReservationId)
        {
            InitializeComponent();
            _self = this;
            this.selectedReservationId = selectedReservationId;

            grvRoom.Columns["price_per_night"].DefaultCellStyle.Format = "##,0 vnd";
            grvAmenityUasge.Columns["price"].DefaultCellStyle.Format = "##,0 vnd";
            lblTotalBalance.Text = "Total balance: Pending";
        }

        private void FormReservationCreate_Load(object sender, EventArgs e)
        {
            LoadReservationBySelectedId();
        }

        private void HandleUserPermission()
        {
            if (Enum.TryParse(FormLogin.currentUser.role, out StaffRole role))
            {
                if (role == StaffRole.MANAGER)
                {
                    btnExportInvoice.Visible = true;
                    btnCheckIn.Visible = true;
                    btnCheckOut.Visible = true;
                    btnCancelReservation.Visible = true;
                    btnAddAmenityUsage.Visible = true;
                    btnUpdateAmenityUsage.Visible = true;
                }
                if (role == StaffRole.RECEPTIONIST)
                {
                    btnExportInvoice.Visible = true;
                    btnCheckIn.Visible = true;
                    btnCheckOut.Visible = true;
                    btnCancelReservation.Visible = true;
                    btnAddAmenityUsage.Visible = true;
                    btnUpdateAmenityUsage.Visible = true;
                }
                if (role == StaffRole.HOUSEKEEPER)
                {
                    btnExportInvoice.Visible = false;
                    btnCheckIn.Visible = false;
                    btnCheckOut.Visible = false;
                    btnCancelReservation.Visible = false;
                    btnAddAmenityUsage.Visible = false;
                    btnUpdateAmenityUsage.Visible = false;
                }
                if (role == StaffRole.ADMIN)
                {
                    btnExportInvoice.Visible = false;
                    btnCheckIn.Visible = false;
                    btnCheckOut.Visible = false;
                    btnCancelReservation.Visible = false;
                    btnAddAmenityUsage.Visible = false;
                    btnUpdateAmenityUsage.Visible = false;
                }
            }
        }
        private void HandleReservationStatusChange()
        {
            bool validValue = Enum.TryParse(lblReservationStatus.Text, out ReservationStatus s);
            if (!validValue) return;

            if (s == ReservationStatus.CHECKED_IN)
            {
                btnAddAmenityUsage.Visible = btnAddAmenityUsage.Visible;
                btnUpdateAmenityUsage.Visible = btnUpdateAmenityUsage.Visible;
                btnManageServiceUsage.Visible = btnManageServiceUsage.Visible;

                btnCheckOut.Visible = btnCheckOut.Visible;
                btnCheckIn.Visible = false;
                btnCancelReservation.Visible = false;
                btnExportInvoice.Visible = false;
            }
            if (s == ReservationStatus.CHECKED_OUT)
            {
                btnAddAmenityUsage.Visible = false;
                btnUpdateAmenityUsage.Visible = false;
                btnManageServiceUsage.Visible = btnManageServiceUsage.Visible;

                btnCheckOut.Visible = false;
                btnCheckIn.Visible = false;
                btnCancelReservation.Visible = false;
                btnExportInvoice.Visible = btnExportInvoice.Visible;
            }
            if (s == ReservationStatus.CANCELLED)
            {
                btnAddAmenityUsage.Visible = false;
                btnUpdateAmenityUsage.Visible = false;
                btnManageServiceUsage.Visible = false;

                btnCheckOut.Visible = false;
                btnCheckIn.Visible = false;
                btnCancelReservation.Visible = false;
                btnExportInvoice.Visible = false;
            }
            if (s == ReservationStatus.PENDING)
            {
                btnAddAmenityUsage.Visible = false;
                btnUpdateAmenityUsage.Visible = false;
                btnManageServiceUsage.Visible = false;

                btnCheckOut.Visible = false;
                btnCheckIn.Visible = btnCheckIn.Visible;
                btnCancelReservation.Visible = btnCancelReservation.Visible;
                btnExportInvoice.Visible = false;
            }
        }


        public void HandleRoomSelectionChange()
        {
            if (grvRoom.CurrentRow == null) return;
            string roomId = grvRoom.CurrentRow.Cells["id"].Value.ToString();
            if (roomId == viewingRoomId) return;
            viewingRoomId = roomId;

            LoadReservationAmenityUsageByRoom(roomId);
        }

        public void LoadReservationAmenityUsageByRoom(string roomId)
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select a.id, b.title, a.price, b.is_chargable, a.status " +
                    " from room_amenity_usage a " +
                    " left join amenity b on a.amenity_id = b.id" +
                    " where reservation_id=@reservation_id and room_id=@room_id";
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                cmd.Parameters.AddWithValue("@room_id", roomId);

                using (var reader = cmd.ExecuteReader())
                {
                    dtbAmenityUsage.Clear();
                    dtbAmenityUsage.Load(reader);
                    grvAmenityUasge.DataSource = dtbAmenityUsage;
                }
                conn.Close();
            }
        }

        public void LoadReservationBySelectedId()
        {
            viewingRoomId = null;
            using (SqlConnection conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                string customerId = null;
                string staffId = null;

                conn.Open();
                cmd.CommandText = "select * from reservation where id=@reservation_id";
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);

                using (var dr = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(dr);

                    var cells = dt.Rows[0];
                    customerId = cells["customer_id"].ToString();
                    staffId = cells["staff_id"].ToString();

                    lblResId.Text = cells["id"].ToString();
                    lblReservationStatus.Text = cells["status"].ToString();
                    lblCreatedAt.Text = DateTime.Parse(cells["created_at"].ToString()).ToString("dd-MM-yyyy HH:mm");
                    lblUpdatedAt.Text = DateTime.Parse(cells["updated_at"].ToString()).ToString("dd-MM-yyyy HH:mm");
                    lblArrival.Text = DateTime.Parse(cells["arrival_time"].ToString()).ToString("dd-MM-yyyy HH:mm");
                    lblDeparture.Text = DateTime.Parse(cells["departure_time"].ToString()).ToString("dd-MM-yyyy HH:mm");
                    string checkInTime = cells["checked_in_at"].ToString();
                    string checkOutTime = cells["checked_out_at"].ToString();
                    lblCheckedIn.Text = checkInTime != "" ? DateTime.Parse(checkInTime).ToString("dd-MM-yyyy HH:mm") : "";
                    lblCheckedOut.Text = checkOutTime != "" ? DateTime.Parse(checkOutTime).ToString("dd-MM-yyyy HH:mm") : "";

                    if (Enum.TryParse(cells["status"].ToString(), out ReservationStatus reservationStatus))
                    {
                        lblReservationStatus.Text = reservationStatus.ToString();
                        lblReservationStatus.ForeColor = ReservationStatusColor.Get(reservationStatus).Dark;
                        pnReservationStatus.BackColor = ReservationStatusColor.Get(reservationStatus).Dark;
                    }

                    if (cells["total_price"].ToString() != "")
                    {
                        lblTotalBalance.Text = $"Total balance: {Helper.NumberToVND(Convert.ToInt32(cells["total_price"]))}";
                    }

                    if (cells["discount_coupon_id"].ToString() != "")
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "select title, rate_percent from discount_coupon where id=@coupon_id";
                        cmd.Parameters.AddWithValue("@coupon_id", cells["discount_coupon_id"]);

                        using (var drDiscount = cmd.ExecuteReader())
                        {
                            var d = new DataTable();
                            d.Load(drDiscount);
                            lblUsingDisscount.Text = $"Using discount: {d.Rows[0]["title"]} ({d.Rows[0]["rate_percent"]}%)";
                        }

                    }
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "select b.id, b.room_code, b.floor_number, " +
                    " c.id as room_type_id, c.title as room_type_title, c.price_per_night from reservation_room a" +
                    " left join room b on a.room_id = b.id" +
                    " left join room_type c on b.room_type_id = c.id where reservation_id=@reservation_id";
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                using (var dr = cmd.ExecuteReader())
                {
                    dtbRoom.Clear();
                    dtbRoom.Load(dr);
                    grvRoom.DataSource = dtbRoom;
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "select id, first_name + ' ' + last_name as full_name, " +
                    " phone, email, status from customer where id=@customer_id";
                cmd.Parameters.AddWithValue("@customer_id", customerId);
                using (var reader = cmd.ExecuteReader())
                {
                    var dtbCustomer = new DataTable();
                    dtbCustomer.Load(reader);
                    var cells = dtbCustomer.Rows[0];

                    lblCustomerId.Text = cells["id"].ToString();
                    lblCustomerName.Text = cells["full_name"].ToString();
                    lblCustomerEmail.Text = cells["email"].ToString();
                    lblCustomerPhone.Text = cells["phone"].ToString();

                    if (Enum.TryParse(cells["status"].ToString(), out CustomerStatus customerStatus))
                    {
                        lblCustomerStatus.Text = customerStatus.ToString();
                        lblCustomerStatus.ForeColor = CustomerStatusColor.Get(customerStatus).Dark;
                        pnCustomerStatus.BackColor = CustomerStatusColor.Get(customerStatus).Dark;
                    }
                }

                cmd.Parameters.Clear();
                cmd.CommandText = $"select id, first_name + ' ' + last_name as full_name from staff where id=@staff_id";
                cmd.Parameters.AddWithValue("@staff_id", staffId);
                using (var drStaff = cmd.ExecuteReader())
                {
                    var dtbStaff = new DataTable();
                    dtbStaff.Load(drStaff);
                    var cells = dtbStaff.Rows[0];
                    lblStaffName.Text = cells["full_name"].ToString() + $" (ID: {cells["id"]})";
                }
                conn.Close();

            }
            HandleRoomSelectionChange();
            HandleUserPermission();
            HandleReservationStatusChange();
        }


        private void grvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleRoomSelectionChange();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateAmenityUsage_Click(object sender, EventArgs e)
        {
            if (grvAmenityUasge.CurrentRow == null) return;
            var f = new FormRoomAmenityUsageUpdate(grvAmenityUasge.CurrentRow.Cells["a_id"].Value.ToString());
            f.ShowDialog();
        }

        private void btnAddAmenityUsage_Click(object sender, EventArgs e)
        {
            if (grvRoom.CurrentRow == null) return;
            var f = new FormRoomAmenityUsageCreate(selectedReservationId.ToString(), grvRoom.CurrentRow.Cells["id"].Value.ToString());
            f.ShowDialog();
        }

        private void btnMoreCustomerDetail_Click(object sender, EventArgs e)
        {
            var f = new FormCustomerDetail(lblCustomerId.Text);
            f.ShowDialog();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to check in this reservation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "update reservation set updated_at=@updated_at, checked_in_at=@checked_in_at, status=@status where id=@reservation_id";
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                cmd.Parameters.AddWithValue("@checked_in_at", DateTime.Now);
                cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                cmd.Parameters.AddWithValue("@status", ReservationStatus.CHECKED_IN.ToString());
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = "update room set status=@status, updated_at=@updated_at where id in" +
                    " (select room_id from reservation_room where reservation_id=@reservation_id)";
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                cmd.Parameters.AddWithValue("@status", RoomStatus.OCCUPIED.ToString());
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            LoadReservationBySelectedId();
            FormReservation._self?.LoadAllReservations();
            FormDashboard._self?.LoadRoomStatusAndReservation();
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to cancel this reservation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();

                cmd.CommandText = "update reservation set updated_at=@updated_at, status=@status where id=@reservation_id";
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                cmd.Parameters.AddWithValue("@status", ReservationStatus.CANCELLED.ToString());
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                cmd.CommandText = "update room set status=@status, updated_at=@updated_at where id in" +
                    " (select room_id from reservation_room where reservation_id=@reservation_id)";
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                cmd.Parameters.AddWithValue("@status", RoomStatus.READY.ToString());
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            LoadReservationBySelectedId();
            FormReservation._self?.LoadAllReservations();
            FormDashboard._self?.LoadRoomStatusAndReservation();
        }

        private void grvAmenityUasge_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow row in grvAmenityUasge.Rows)
            {
                if (Enum.TryParse(row.Cells["status"].Value.ToString(), out RoomAmenityUsageStatus status))
                {
                    row.Cells["status"].Style.BackColor = RoomAmenityUsageStatusColor.Get(status).Light;
                    row.Cells["status"].Style.ForeColor = Color.FromArgb(38, 38, 38);
                }
            }
        }

        private void btnManageServiceUsage_Click(object sender, EventArgs e)
        {
            var f = new FormReservationServiceUsage(selectedReservationId);
            f.ShowDialog();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            var f = new FormReservationCheckOut(selectedReservationId);
            f.ShowDialog();
        }

        private void btnExportInvoice_Click(object sender, EventArgs e)
        {
            var dtbReservationRoom = new DataTable();
            var dtbAmenityUsage = new DataTable();
            var dtbServiceUsage = new DataTable();
            string customerName = "null";
            string customerPhone = "null";
            string customerEmail = "null";
            string customerAddress = "null";
            string checkIn = "null";
            string checkOut = "null";
            string arrivalTime = "null";
            string departureTime = "null";
            string total = "null";

            string couponId = null;

            string discountName = "null";
            string discountRate = "0%";
            string notes = "None.";

            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {

                conn.Open();
                cmd.CommandText = "select c.room_code, d.title as room_type, b.price_per_night, " +
                        " DATEDIFF(day, a.checked_in_at, a.checked_out_at) as duration, " +
                        " DATEDIFF(day, a.checked_in_at, a.checked_out_at) * b.price_per_night as total_price from reservation a " +
                        " join reservation_room b on a.id = b.reservation_id " +
                        " left join room c on b.room_id = c.id " +
                        " left join room_type d on c.room_type_id = d.id " +
                        " where a.id =@reservation_id and a.status=@status";
                cmd.Parameters.AddWithValue("@status", ReservationStatus.CHECKED_OUT.ToString());
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                using (var dr = cmd.ExecuteReader())
                {
                    dtbReservationRoom.Load(dr);
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "select c.room_code, b.title as amenity_name, a.price from room_amenity_usage a " +
                    " left join amenity b on a.amenity_id = b.id left join room c on a.room_id = c.id " +
                    " where a.reservation_id=@reservation_id and a.status=@status and b.is_chargable = '1'";
                cmd.Parameters.AddWithValue("@status", RoomAmenityUsageStatus.USED.ToString());
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                using (var dr = cmd.ExecuteReader())
                {
                    dtbAmenityUsage.Load(dr);
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "select b.title as service_name, a.started_at, a.ended_at, a.price from hotel_service_usage a " +
                    " left join hotel_service b on a.hotel_service_id = b.id " +
                    " where a.reservation_id=@reservation_id and a.status=@status";
                cmd.Parameters.AddWithValue("@status", HotelServiceUsageStatus.COMPLETED.ToString());
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                using (var dr = cmd.ExecuteReader())
                {
                    dtbServiceUsage.Load(dr);
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "select b.first_name + ' ' + b.last_name as name, b.address, b.phone,b.email, " +
                    " a.checked_in_at, a.checked_out_at, a.discount_coupon_id, a.total_price, a.arrival_time, a.departure_time " +
                    " from reservation a join customer b on a.customer_id = b.id " +
                    " where a.id=@reservation_id and a.status=@status";
                cmd.Parameters.AddWithValue("@status", ReservationStatus.CHECKED_OUT.ToString());
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                using (var dr = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(dr);
                    var cells = dt.Rows[0];

                    customerName = cells["name"].ToString();
                    customerAddress = cells["address"].ToString();
                    customerPhone = cells["phone"].ToString();
                    customerEmail = cells["email"].ToString();
                    couponId = cells["discount_coupon_id"].ToString();
                    total = Helper.AddCommaNumber(Convert.ToInt32(cells["total_price"]));
                    checkIn = DateTime.Parse(cells["checked_in_at"].ToString()).ToString("dd/MM/yyyy HH:mm");
                    checkOut = DateTime.Parse(cells["checked_out_at"].ToString()).ToString("dd/MM/yyyy HH:mm");
                    arrivalTime = DateTime.Parse(cells["arrival_time"].ToString()).ToString("dd/MM/yyyy");
                    departureTime = DateTime.Parse(cells["departure_time"].ToString()).ToString("dd/MM/yyyy");
                }

                if (couponId != "")
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "select * from discount_coupon where id=@coupon_id";
                    cmd.Parameters.AddWithValue("@coupon_id", couponId);
                    using (var dr = cmd.ExecuteReader())
                    {
                        var dt = new DataTable();
                        dt.Load(dr);
                        var cells = dt.Rows[0];

                        discountName = cells["title"].ToString();
                        discountRate = cells["rate_percent"].ToString() + "%";
                        notes = $"Used '{discountName}' coupon";
                    }
                }

                conn.Close();
            }

            string subTotal = Helper.AddCommaNumber(
                Convert.ToDouble(
                dtbReservationRoom.AsEnumerable()
                    .Sum(x => x.Field<decimal>("total_price"))
                + dtbAmenityUsage.AsEnumerable()
                    .Sum(x => x.Field<decimal>("price"))
                + dtbServiceUsage.AsEnumerable()
                    .Sum(x => x.Field<int>("price"))
                    )
                 );


            var viewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local,
            };

            viewer.LocalReport.ReportPath = Path.Combine(Application.StartupPath, @"../../Views/Report/InvoiceReservation.rdlc");
            viewer.LocalReport.SetParameters(new ReportParameter[]
            {
                    new ReportParameter("current_date", DateTime.Now.ToString("dd/MM/yyyy")),
                    new ReportParameter("customer_name", customerName),
                    new ReportParameter("customer_address", customerAddress),
                    new ReportParameter("customer_phone", customerPhone),
                    new ReportParameter("customer_email", customerEmail),
                    new ReportParameter("reservation_id", selectedReservationId.ToString()),
                    new ReportParameter("arrival", arrivalTime),
                    new ReportParameter("departure", departureTime),
                    new ReportParameter("check_in", checkIn),
                    new ReportParameter("check_out", checkOut),
                    new ReportParameter("staff_name", FormLogin.currentUser.name),
                    new ReportParameter("sub_total", subTotal),
                    new ReportParameter("discount_rate", discountRate),
                    new ReportParameter("total", total),
                    new ReportParameter("notes", notes),
            });
            viewer.LocalReport.DataSources.Add(new ReportDataSource("reservation_room", dtbReservationRoom));
            viewer.LocalReport.DataSources.Add(new ReportDataSource("room_amenity_usage", dtbAmenityUsage));
            viewer.LocalReport.DataSources.Add(new ReportDataSource("service_usage", dtbServiceUsage));
            viewer.RefreshReport();

            var bytes = viewer.LocalReport.Render("PDF", "", out _, out _, out _, out _, out _);

            Helper.SaveReportFileToFolders(bytes);
        }
    }
}
