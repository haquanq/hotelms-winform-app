using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormReservationServiceUsage : Form
    {
        public static FormReservationServiceUsage _self;
        public static DataTable dtbHotelServiceUsage = new DataTable();
        private string selectedReservationId;
        private int totalBalance = 0;
        public FormReservationServiceUsage(string selectedReservationId)
        {
            InitializeComponent();
            _self = this;
            this.selectedReservationId = selectedReservationId;

            DataTable dtbSearchType = new DataTable();
            dtbSearchType.Columns.Add("value", typeof(string));
            dtbSearchType.Columns.Add("text", typeof(string));
            dtbSearchType.Rows.Add("id", "Service ID");
            dtbSearchType.Rows.Add("title", "Title");
            cbbSearchType.DataSource = dtbSearchType;
            cbbSearchType.DisplayMember = "text";
            cbbSearchType.ValueMember = "value";

            DataTable dtbStatusFilter = new DataTable();
            dtbStatusFilter.Columns.Add("value", typeof(string));
            dtbStatusFilter.Columns.Add("text", typeof(string));
            dtbStatusFilter.Rows.Add("All", "All");
            dtbStatusFilter.Rows.Add("PENDING", "Pending");
            dtbStatusFilter.Rows.Add("COMPLETED", "Completed");
            cbbStatusFilter.DataSource = dtbStatusFilter;
            cbbStatusFilter.DisplayMember = "text";
            cbbStatusFilter.ValueMember = "value";

            grvHotelServiceUsage.Columns["created_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvHotelServiceUsage.Columns["updated_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvHotelServiceUsage.Columns["started_at"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
            grvHotelServiceUsage.Columns["ended_at"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
            grvHotelServiceUsage.Columns["price"].DefaultCellStyle.Format = "##,0 vnd";

            lblReservationId.Text = selectedReservationId.ToString();
        }

        private void FormHotelService_Load(object sender, EventArgs e)
        {
            HandleCurrentUserPermission();
            LoadReservationAndHotelServiceUsage();
        }

        private void HandleCurrentUserPermission()
        {
            if (Enum.TryParse(FormLogin.currentUser.role, out StaffRole role))
            {
                if (role == StaffRole.MANAGER)
                {
                    btnHotelServiceUsageCreate.Visible = true;
                    btnHotelServiceUsageUpdate.Visible = true;
                }
                if (role == StaffRole.RECEPTIONIST)
                {
                    btnHotelServiceUsageCreate.Visible = true;
                    btnHotelServiceUsageUpdate.Visible = true;
                }
                if (role == StaffRole.HOUSEKEEPER)
                {
                    btnHotelServiceUsageCreate.Visible = false;
                    btnHotelServiceUsageUpdate.Visible = false;
                }
                if (role == StaffRole.ADMIN)
                {
                    btnHotelServiceUsageCreate.Visible = false;
                    btnHotelServiceUsageUpdate.Visible = false;
                }
            }
        }

        public void LoadReservationAndHotelServiceUsage()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();

                cmd.CommandText = "select a.id, b.title as service_title, " +
                    " a.started_at, a.ended_at, a.created_at, a.updated_at, a.price, a.status " +
                    " from hotel_service_usage a " +
                    " left join hotel_service b on a.hotel_service_id = b.id " +
                    " left join reservation c on a.reservation_id = c.id " +
                    " left join customer d on c.customer_id = d.id where a.reservation_id=@reservation_id";
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                using (var dr = cmd.ExecuteReader())
                {
                    dtbHotelServiceUsage.Clear();
                    dtbHotelServiceUsage.Load(dr);
                    grvHotelServiceUsage.DataSource = dtbHotelServiceUsage;
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "select b.id, b.first_name + ' ' + b.last_name as customer_name, " +
                    " b.phone, b.email, b.status as customer_status, a.arrival_time, a.departure_time, " +
                    " a.checked_in_at, a.checked_out_at, a.status as reservation_status from reservation a " +
                    " left join customer b on a.customer_id = b.id where a.id=@reservation_id";
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                using (var dr = cmd.ExecuteReader())
                {
                    var dtbReservation = new DataTable();
                    dtbReservation.Load(dr);
                    var cells = dtbReservation.Rows[0];
                    lblCustomerId.Text = cells["id"].ToString();
                    lblCustomerName.Text = cells["customer_name"].ToString();
                    lblCustomerEmail.Text = cells["email"].ToString();
                    lblCustomerPhone.Text = cells["phone"].ToString();

                    lblArrival.Text = DateTime.Parse(cells["arrival_time"].ToString()).ToString("dd-MM-yyyy HH:mm");
                    lblDeparture.Text = DateTime.Parse(cells["departure_time"].ToString()).ToString("dd-MM-yyyy HH:mm");
                    string checkInTime = cells["checked_in_at"].ToString();
                    string checkOutTime = cells["checked_out_at"].ToString();
                    lblCheckedIn.Text = checkInTime != "" ? DateTime.Parse(checkInTime).ToString("dd-MM-yyyy HH:mm") : "";
                    lblCheckedOut.Text = checkOutTime != "" ? DateTime.Parse(checkOutTime).ToString("dd-MM-yyyy HH:mm") : "";

                    if (Enum.TryParse(cells["reservation_status"].ToString(), out ReservationStatus reservationStatus))
                    {
                        lblReservationStatus.Text = reservationStatus.ToString();
                        lblReservationStatus.ForeColor = ReservationStatusColor.Get(reservationStatus).Dark;
                        pnReservationStatus.BackColor = ReservationStatusColor.Get(reservationStatus).Dark;

                        if (reservationStatus == ReservationStatus.CHECKED_OUT)
                        {
                            btnHotelServiceUsageCreate.Visible = false;
                            btnHotelServiceUsageUpdate.Visible = false;
                        }
                    }

                    if (Enum.TryParse(cells["customer_status"].ToString(), out CustomerStatus customerStatus))
                    {
                        lblCustomerStatus.Text = customerStatus.ToString();
                        lblCustomerStatus.ForeColor = CustomerStatusColor.Get(customerStatus).Dark;
                        pnCustomerStatus.BackColor = CustomerStatusColor.Get(customerStatus).Dark;
                    }
                }
                conn.Close();
            }

            foreach (DataRow row in dtbHotelServiceUsage.Rows)
            {
                int price = Convert.ToInt32(row["price"]);
                if (row["status"].ToString() != HotelServiceUsageStatus.COMPLETED.ToString())
                    continue;
                totalBalance += price;
            }
            lblTotalBalance.Text = "Total Balance: " + Helper.NumberToVND(totalBalance);

        }

        private void btnCreateHotelServiceUsage_Click(object sender, EventArgs e)
        {
            var f = new FormReservationServiceUsageCreate(selectedReservationId);
            f.ShowDialog();
        }

        private void btnUpdateHotelServiceUsage_Click(object sender, EventArgs e)
        {
            if (grvHotelServiceUsage.CurrentRow == null) return;
            var f = new FormHotelServiceUsageUpdate(grvHotelServiceUsage.CurrentRow.Cells["id"].Value.ToString());
            f.ShowDialog();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grvHotelServiceUsage.ClearSelection();
            grvHotelServiceUsage.CurrentCell = grvHotelServiceUsage[0, 0];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grvHotelServiceUsage.CurrentRow.Index;
            if (i > 0)
            {
                grvHotelServiceUsage.CurrentCell = grvHotelServiceUsage[0, i - 1];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(grvHotelServiceUsage.CurrentRow.Index.ToString());
            if (i < grvHotelServiceUsage.RowCount - 1)
            {
                grvHotelServiceUsage.CurrentCell = grvHotelServiceUsage[0, i + 1];
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grvHotelServiceUsage.CurrentCell = grvHotelServiceUsage[0, grvHotelServiceUsage.RowCount - 1];
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbHotelServiceUsage);
            dv.RowFilter = $"CONVERT({cbbSearchType.SelectedValue}, 'System.String') LIKE '%{txtSearch.Text}%'";
            grvHotelServiceUsage.DataSource = dv;
        }

        private void grvHotelServiceUsage_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow row in grvHotelServiceUsage.Rows)
            {
                if (Enum.TryParse(row.Cells["status"].Value.ToString(), out HotelServiceUsageStatus status))
                {
                    row.Cells["status"].Style.BackColor = HotelServiceUsageStatusColor.Get(status).Light;
                    row.Cells["status"].Style.ForeColor = Color.FromArgb(38, 38, 38);
                    row.Cells["status"].Style.Padding = new Padding(8, 8, 8, 8);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbStatusFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbHotelServiceUsage);
            int x = cbbStatusFilter.SelectedIndex;

            if (x == 0)
            {
                grvHotelServiceUsage.DataSource = dtbHotelServiceUsage;
            }
            else
            {
                dv.RowFilter = $"status = '{cbbStatusFilter.SelectedValue}'";
                grvHotelServiceUsage.DataSource = dv;
            }
        }
    }
}
