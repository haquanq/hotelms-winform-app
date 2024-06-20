using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormHotelServiceUsageCreate : Form
    {

        private DataTable dtbReservation = new DataTable();
        private DataTable dtbHotelService = new DataTable();

        public FormHotelServiceUsageCreate()
        {
            InitializeComponent();

            DataTable dtbSearchTypeReservation = new DataTable();
            dtbSearchTypeReservation.Columns.Add("value", typeof(string));
            dtbSearchTypeReservation.Columns.Add("text", typeof(string));
            dtbSearchTypeReservation.Rows.Add("id", "Reservation ID");
            dtbSearchTypeReservation.Rows.Add("rooms", "Room Code");
            dtbSearchTypeReservation.Rows.Add("customer_name", "Customer Name");
            cbbSearchTypeReservation.DataSource = dtbSearchTypeReservation;
            cbbSearchTypeReservation.DisplayMember = "text";
            cbbSearchTypeReservation.ValueMember = "value";

            DataTable dtbSearchTypeService = new DataTable();
            dtbSearchTypeService.Columns.Add("value", typeof(string));
            dtbSearchTypeService.Columns.Add("text", typeof(string));
            dtbSearchTypeService.Rows.Add("id", "Service ID");
            dtbSearchTypeService.Rows.Add("title", "Title");
            cbbSearchTypeService.DataSource = dtbSearchTypeService;
            cbbSearchTypeService.DisplayMember = "text";
            cbbSearchTypeService.ValueMember = "value";

            grvReservation.Columns["created_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvReservation.Columns["updated_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvReservation.Columns["arrival_time"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
            grvReservation.Columns["departure_time"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
            grvReservation.Columns["checked_in_at"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
            dtpStartedAt.CustomFormat = "dd-MM-yyyy HH:mm";
            dtpEndedAt.CustomFormat = "dd-MM-yyyy HH:mm";
        }

        private void FormRoom_Load(object sender, EventArgs e)
        {
            LoadReservationAndnHotelService();
        }

        public void LoadReservationAndnHotelService()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = $"select a.id, d.first_name + ' ' + d.last_name as customer_name, STRING_AGG(c.room_code, '\r\n') as rooms, " +
                        " a.created_at, a.updated_at, a.arrival_time, a.departure_time, a.checked_in_at" +
                        " from reservation a " +
                        " left join reservation_room b on a.id = b.reservation_id " +
                        " left join room c on b.room_id = c.id " +
                        " left join customer d on a.customer_id = d.id " +
                        " where a.status = 'CHECKED_IN'" +
                        " group by a.id, d.first_name, d.last_name, a.created_at, a.updated_at, a.arrival_time, a.departure_time, a.checked_in_at";
                using (var reader = cmd.ExecuteReader())
                {
                    dtbReservation.Clear();
                    dtbReservation.Load(reader);
                    grvReservation.DataSource = dtbReservation;
                }

                cmd.CommandText = "select * from hotel_service";
                using (var reader = cmd.ExecuteReader())
                {
                    dtbHotelService.Clear();
                    dtbHotelService.Load(reader);
                    grvHotelSerivce.DataSource = dtbHotelService;
                }
                conn.Close();
            }

            if (Enum.TryParse(ReservationStatus.CHECKED_IN.ToString(), out ReservationStatus reservationStatus))
            {
                lblReservationStatus.Text = reservationStatus.ToString();
                lblReservationStatus.ForeColor = ReservationStatusColor.Get(reservationStatus).Dark;
                pnReservationStatus.BackColor = ReservationStatusColor.Get(reservationStatus).Dark;
            }

            if (grvReservation.CurrentRow != null)
            {
                lblReservationId.Text = grvReservation.CurrentRow.Cells["id2"].Value.ToString();
            }
            if (grvHotelSerivce.CurrentRow != null)
            {
                lblServiceId.Text = grvHotelSerivce.CurrentRow.Cells["id1"].Value.ToString();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearchService_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbHotelService);
            dv.RowFilter = $"{cbbSearchTypeService.SelectedValue} LIKE '%{txtSearchService.Text}%'";
            grvHotelSerivce.DataSource = dv;
        }

        private void btnSearchReservation_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbReservation);
            dv.RowFilter = $"{cbbSearchTypeReservation.SelectedValue} LIKE '%{txtSearchReservation.Text}%'";
            grvReservation.DataSource = dv;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to create this service usage?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {

                using (var conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "insert into hotel_service_usage (reservation_id, hotel_service_id, started_at, ended_at, created_at, updated_at, price, status) " +
                        " values (@reservation_id, @hotel_service_id, @started_at, @ended_at, @created_at, @updated_at, @price, @status)";
                    cmd.Parameters.AddWithValue("@reservation_id", lblReservationId.Text);
                    cmd.Parameters.AddWithValue("@hotel_service_id", lblServiceId.Text);
                    cmd.Parameters.AddWithValue("@started_at", dtpStartedAt.Value);
                    cmd.Parameters.AddWithValue("@ended_at", dtpEndedAt.Value);
                    cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                    cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@status", "PENDING");
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                this.Close();
                MessageBox.Show("Hotel service usage created successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormHotelServiceUsage._self?.LoadAllHotelServiceUsage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred!");
            }

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void grvHotelSerivce_SelectionChanged(object sender, EventArgs e)
        {
            if (grvHotelSerivce.CurrentRow != null)
            {
                lblServiceId.Text = grvHotelSerivce.CurrentRow.Cells["id1"].Value.ToString();
            }
        }

        private void grvReservation_SelectionChanged(object sender, EventArgs e)
        {
            if (grvReservation.CurrentRow != null)
            {
                lblReservationId.Text = grvReservation.CurrentRow.Cells["id2"].Value.ToString();
            }
        }
    }
}
