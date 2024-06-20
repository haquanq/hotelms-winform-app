using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormHotelServiceUsageUpdate : Form
    {
        private DataTable dtbHotelService = new DataTable();
        private string selectedHotelServiceUsageId;
        public FormHotelServiceUsageUpdate(string selectedHotelServiceUsageId)
        {
            InitializeComponent();
            this.selectedHotelServiceUsageId = selectedHotelServiceUsageId;

            DataTable dtbSearchTypeService = new DataTable();
            dtbSearchTypeService.Columns.Add("value", typeof(string));
            dtbSearchTypeService.Columns.Add("text", typeof(string));
            dtbSearchTypeService.Rows.Add("id", "Service ID");
            dtbSearchTypeService.Rows.Add("title", "Title");
            cbbSearchTypeService.DataSource = dtbSearchTypeService;
            cbbSearchTypeService.DisplayMember = "text";
            cbbSearchTypeService.ValueMember = "value";

            DataTable dtbStatus = new DataTable();
            dtbStatus.Columns.Add("value", typeof(string));
            dtbStatus.Columns.Add("text", typeof(string));
            dtbStatus.Rows.Add("PENDING", "Pending");
            dtbStatus.Rows.Add("COMPLETED", "Completed");
            dtbStatus.Rows.Add("CANCELLED", "Cancelled");
            cbbStatus.DataSource = dtbStatus;
            cbbStatus.DisplayMember = "text";
            cbbStatus.ValueMember = "value";

            dtpStartedAt.CustomFormat = "dd-MM-yyyy HH:mm";
            dtpEndedAt.CustomFormat = "dd-MM-yyyy HH:mm";
        }

        private void FormRoom_Load(object sender, EventArgs e)
        {
            LoadHotelServiceUsageById(selectedHotelServiceUsageId);
        }

        public void LoadHotelServiceUsageById(string hotelServiceUsageId)
        {

            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select a.id, a.hotel_service_id, b.id as reservation_id, c.first_name + ' ' + c.last_name as customer_name, " +
                    " a.started_at, a.ended_at, a.created_at, a.updated_at, a.price, a.status, b.status as reservation_status " +
                    " from hotel_service_usage a " +
                    " left join reservation b on a.reservation_id = b.id " +
                    " left join customer c on b.customer_id = c.id " +
                    " where a.id = @hotel_service_usage_id";
                cmd.Parameters.AddWithValue("@hotel_service_usage_id", hotelServiceUsageId);

                using (var dr = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(dr);
                    var cells = dt.Rows[0];

                    lblServiceUsageId.Text = cells["id"].ToString();
                    lblReservationId.Text = cells["reservation_id"].ToString();
                    lblCustomerName.Text = cells["customer_name"].ToString();
                    lblServiceId.Text = cells["hotel_service_id"].ToString();
                    dtpStartedAt.Value = DateTime.Parse(cells["started_at"].ToString());
                    dtpEndedAt.Value = DateTime.Parse(cells["ended_at"].ToString());
                    txtPrice.Text = cells["price"].ToString();
                    lblCreatedAt.Text = DateTime.Parse(cells["created_at"].ToString()).ToString("dd-MM-yyyy HH:mm");
                    lblUpdatedAt.Text = DateTime.Parse(cells["updated_at"].ToString()).ToString("dd-MM-yyyy HH:mm");

                    if (Enum.TryParse(cells["status"].ToString(), out HotelServiceUsageStatus roomAmenityUsageStatus))
                    {
                        lblHotelServiceUsageStatus.Text = roomAmenityUsageStatus.ToString().ToLower();
                        lblHotelServiceUsageStatus.ForeColor = HotelServiceUsageStatusColor.Get(roomAmenityUsageStatus).Dark;
                        pnHotelServiceUsageStatus.BackColor = HotelServiceUsageStatusColor.Get(roomAmenityUsageStatus).Dark;
                    }

                    if (Enum.TryParse(cells["reservation_status"].ToString(), out ReservationStatus reservationStatus))
                    {
                        lblReservationStatus.Text = reservationStatus.ToString().ToLower();
                        lblReservationStatus.ForeColor = ReservationStatusColor.Get(reservationStatus).Dark;
                        pnReservationStatus.BackColor = ReservationStatusColor.Get(reservationStatus).Dark;
                    }

                }

                cmd.Parameters.Clear();
                cmd.CommandText = "select * from hotel_service";
                using (var dr = cmd.ExecuteReader())
                {
                    dtbHotelService.Clear();
                    dtbHotelService.Load(dr);
                    grvHotelSerivce.DataSource = dtbHotelService;
                }
                conn.Close();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to save these changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {

                using (var conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "update hotel_service_usage set hotel_service_id=@hotel_service_id, " +
                        " started_at=@started_at, ended_at=@ended_at, updated_at=@updated_at, price=@price, status=@status " +
                        " where id=@hotel_service_usage_id";
                    cmd.Parameters.AddWithValue("@hotel_service_id", lblServiceId.Text);
                    cmd.Parameters.AddWithValue("@hotel_service_usage_id", selectedHotelServiceUsageId);
                    cmd.Parameters.AddWithValue("@started_at", dtpStartedAt.Value);
                    cmd.Parameters.AddWithValue("@ended_at", dtpEndedAt.Value);
                    cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@status", cbbStatus.SelectedValue);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                this.Close();
                MessageBox.Show("Changes saved successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormHotelServiceUsage._self?.LoadAllHotelServiceUsage();
                FormReservationServiceUsage._self?.LoadReservationAndHotelServiceUsage();

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
            if (grvHotelSerivce.CurrentRow == null) return;
            lblServiceId.Text = grvHotelSerivce.CurrentRow.Cells["id1"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to delete this hotel service usage?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {
                using (var conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "delete from hotel_service_usage where id=@hotel_service_usage_id";
                    cmd.Parameters.AddWithValue("@hotel_service_usage_id", selectedHotelServiceUsageId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                this.Close();
                MessageBox.Show("Hotel service usage deleted successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormHotelServiceUsage._self?.LoadAllHotelServiceUsage();
                FormReservationServiceUsage._self?.LoadReservationAndHotelServiceUsage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred!");
            }
        }

        private void cbbStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Enum.TryParse(cbbStatus.SelectedValue.ToString(), out HotelServiceUsageStatus roomAmenityUsageStatus))
            {
                lblHotelServiceUsageStatus.Text = roomAmenityUsageStatus.ToString().ToLower();
                lblHotelServiceUsageStatus.ForeColor = HotelServiceUsageStatusColor.Get(roomAmenityUsageStatus).Dark;
                pnHotelServiceUsageStatus.BackColor = HotelServiceUsageStatusColor.Get(roomAmenityUsageStatus).Dark;
            }

        }
    }
}
