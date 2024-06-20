using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormReservationServiceUsageCreate : Form
    {

        private DataTable dtbHotelService = new DataTable();
        private string selecetedReservationId;

        public FormReservationServiceUsageCreate(string selecetedReservationId)
        {
            InitializeComponent();
            this.selecetedReservationId = selecetedReservationId;
        }

        private void FormReservationServiceUsageCreate_Load(object sender, EventArgs e)
        {
            LoadReservationAndAvailableHotelService();

            dtpStartedAt.CustomFormat = "dd-MM-yyyy HH:mm";
            dtpEndedAt.CustomFormat = "dd-MM-yyyy HH:mm";

            DataTable dtbSearchTypeService = new DataTable();
            dtbSearchTypeService.Columns.Add("value", typeof(string));
            dtbSearchTypeService.Columns.Add("text", typeof(string));
            dtbSearchTypeService.Rows.Add("id", "Service ID");
            dtbSearchTypeService.Rows.Add("title", "Title");
            cbbSearchTypeService.DataSource = dtbSearchTypeService;
            cbbSearchTypeService.DisplayMember = "text";
            cbbSearchTypeService.ValueMember = "value";
        }

        public void LoadReservationAndAvailableHotelService()
        {

            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select a.id, b.first_name + ' ' + b.last_name as customer_name, a.status " +
                    " from reservation a left join customer b on a.customer_id = b.id where a.id=@reservation_id";
                cmd.Parameters.AddWithValue("@reservation_id", selecetedReservationId);

                using (var dr = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(dr);
                    var cells = dt.Rows[0];

                    lblReservationId.Text = cells["id"].ToString();
                    lblCustomerName.Text = cells["customer_name"].ToString();

                    if (Enum.TryParse(cells["status"].ToString(), out ReservationStatus s))
                    {
                        lblReservationStatus.Text = s.ToString();
                        lblReservationStatus.ForeColor = ReservationStatusColor.Get(s).Dark;
                        pnReservationStatus.BackColor = ReservationStatusColor.Get(s).Dark;
                    }
                }

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


        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to create this service usage?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.GetConString()))
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
                FormReservationServiceUsage._self.LoadReservationAndHotelServiceUsage();
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
    }
}
