using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormCustomerDetail : Form
    {
        public static FormCustomerDetail _self;
        private DataTable dtbReservation = new DataTable();
        private string selectedCustomerId;

        public FormCustomerDetail(string selectedCustomerId)
        {
            InitializeComponent();
            _self = this;
            this.selectedCustomerId = selectedCustomerId;

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
        private void FormCustomerDetail_Load(object sender, EventArgs e)
        {
            LoadCustomerDetailById(selectedCustomerId);
        }

        private void LoadCustomerDetailById(string customerId)
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select * from customer where id=@customer_id";
                cmd.Parameters.AddWithValue("@customer_id", customerId);

                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(reader);

                    var cells = dt.Rows[0];
                    lblCustomerId.Text = cells["id"].ToString();
                    lblPid.Text = cells["pid"].ToString();
                    lblFirstName.Text = cells["first_name"].ToString();
                    lblLastName.Text = cells["last_name"].ToString();
                    lblPhone.Text = cells["phone"].ToString();
                    lblEmail.Text = cells["email"].ToString();
                    lblAddress.Text = cells["address"].ToString();
                    lblCreatedAt.Text = DateTime.Parse(cells["created_at"].ToString()).ToString("dd-MM-yyyy HH:mm");
                    lblUpdatedAt.Text = DateTime.Parse(cells["updated_at"].ToString()).ToString("dd-MM-yyyy HH:mm");

                    if (Enum.TryParse(cells["status"].ToString(), out CustomerStatus customerStatus))
                    {
                        lblCustomerStatus.Text = customerStatus.ToString();
                        lblCustomerStatus.ForeColor = CustomerStatusColor.Get(customerStatus).Dark;
                        pnCustomerStatus.BackColor = CustomerStatusColor.Get(customerStatus).Dark;
                    }
                }

                cmd.CommandText = $"select a.id, STRING_AGG(c.room_code, '\r\n') as rooms, " +
                        " a.created_at, a.updated_at, a.arrival_time, a.departure_time, " +
                        " a.checked_in_at,a.checked_out_at, a.status, a.total_price from reservation a " +
                        " join reservation_room b on a.id = b.reservation_id " +
                        " join room c on b.room_id = c.id " +
                        " where customer_id = @customer_id" +
                        " group by a.id, a.created_at, a.updated_at, a.arrival_time, a.departure_time, " +
                        " a.checked_in_at,a.checked_out_at, a.status, a.total_price ";
                using (var reader = cmd.ExecuteReader())
                {
                    dtbReservation.Clear();
                    dtbReservation.Load(reader);
                    grvReservation.DataSource = dtbReservation;
                    lblRowCount.Text = $"{dtbReservation.Rows.Count} reservations";
                }
                conn.Close();
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbReservation);
            dv.RowFilter = $"{cbbSearchType.SelectedValue} LIKE '%{txtSearch.Text}%'";
            grvReservation.DataSource = dv;
        }

        private void cbbStatusFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbReservation);
            int x = cbbStatusFilter.SelectedIndex;

            if (x == 0)
            {
                grvReservation.DataSource = dtbReservation;
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
    }
}
