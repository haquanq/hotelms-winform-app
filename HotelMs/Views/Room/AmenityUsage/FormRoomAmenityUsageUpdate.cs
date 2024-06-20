using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormRoomAmenityUsageUpdate : Form
    {
        private DataTable dtbAmenity = new DataTable();
        private string selecetedRoomAmenityUsageId;
        public FormRoomAmenityUsageUpdate(string selectedRoomAmenityUsageId)
        {
            InitializeComponent();
            this.selecetedRoomAmenityUsageId = selectedRoomAmenityUsageId;

            DataTable dtbSearchType = new DataTable();
            dtbSearchType.Columns.Add("value", typeof(string));
            dtbSearchType.Columns.Add("text", typeof(string));
            dtbSearchType.Rows.Add("id", "Amenity ID");
            dtbSearchType.Rows.Add("title", "Title");
            cbbSearchType.DataSource = dtbSearchType;
            cbbSearchType.DisplayMember = "text";
            cbbSearchType.ValueMember = "value";

            DataTable dtbStatus = new DataTable();
            dtbStatus.Columns.Add("value", typeof(string));
            dtbStatus.Columns.Add("text", typeof(string));
            dtbStatus.Rows.Add("PENDING", "Pending");
            dtbStatus.Rows.Add("USED", "Used");
            dtbStatus.Rows.Add("UNUSED", "Unused");
            cbbAmenityUsageStatus.DataSource = dtbStatus;
            cbbAmenityUsageStatus.DisplayMember = "text";
            cbbAmenityUsageStatus.ValueMember = "value";

            grvAmenity.Columns["price"].DefaultCellStyle.Format = "##,0 vnd";
        }

        private void FormRoomAmenityUsageUpdate_Load(object sender, EventArgs e)
        {
            LoadRoomAmenityUsageById(selecetedRoomAmenityUsageId);
        }

        private void LoadRoomAmenityUsageById(string roomAmenityUsageId)
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();

                cmd.CommandText = "select a.id,  a.reservation_id, a.room_id, b.room_code, b.floor_number, " +
                    " a.amenity_id, c.title as amenity_title, c.is_chargable, a.price, a.status, b.status as room_status from room_amenity_usage a " +
                    " left join room b on a.room_id = b.id " +
                    " left join amenity c on a.amenity_id = c.id where a.id = @room_amenity_usage_id";
                cmd.Parameters.AddWithValue("@room_amenity_usage_id", roomAmenityUsageId);
                using (var dr = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(dr);
                    var cells = dt.Rows[0];
                    lblServiceUsageId.Text = cells["id"].ToString();
                    lblReservationId.Text = cells["reservation_id"].ToString();
                    lblRoomId.Text = cells["room_id"].ToString();
                    lblRoomCode.Text = cells["room_code"].ToString();
                    lblRoomFloor.Text = cells["floor_number"].ToString();
                    lblAmenityId.Text = cells["amenity_id"].ToString();
                    lblAmenityTitle.Text = cells["amenity_title"].ToString();
                    lblChargable.Text = cells["is_chargable"].ToString();
                    txtAmenityPrice.Text = cells["price"].ToString();
                    cbbAmenityUsageStatus.SelectedValue = cells["status"].ToString();

                    if (Enum.TryParse(cbbAmenityUsageStatus.SelectedValue.ToString(), out RoomAmenityUsageStatus usageStatus))
                    {
                        lblRoomAmenityUsageStatus.Text = usageStatus.ToString();
                        lblRoomAmenityUsageStatus.ForeColor = RoomAmenityUsageStatusColor.Get(usageStatus).Dark;
                        pnRoomAmenityUsageStatus.BackColor = RoomAmenityUsageStatusColor.Get(usageStatus).Dark;
                    }

                    if (Enum.TryParse(cells["room_status"].ToString(), out RoomStatus roomStatus))
                    {
                        lblRoomStatus.Text = roomStatus.ToString();
                        lblRoomStatus.ForeColor = RoomStatusColor.Get(roomStatus).Dark;
                        pnRoomStatus.BackColor = RoomStatusColor.Get(roomStatus).Dark;
                    }
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "select * from amenity where id not in " +
                " (select amenity_id from room_amenity_usage where reservation_id=@reservation_id and room_id=@room_id )";
                cmd.Parameters.AddWithValue("@reservation_id", lblReservationId.Text);
                cmd.Parameters.AddWithValue("@room_id", lblRoomId.Text);
                using (var dr = cmd.ExecuteReader())
                {
                    dtbAmenity.Clear();
                    dtbAmenity.Load(dr);
                    grvAmenity.DataSource = dtbAmenity;
                }
                conn.Close();
            }

            grvAmenity.ClearSelection();
            foreach (DataGridViewRow row in grvAmenity.Rows)
            {
                if (row.Cells["id"].Value.ToString() == lblAmenityId.Text)
                    row.Selected = true;
            }

        }

        private void HandleAmaneitySelectionChange()
        {
            if (grvAmenity.CurrentRow == null) return;
            var cells = grvAmenity.CurrentRow.Cells;
            string amenityId = cells["id"].Value.ToString();
            string amenityTitle = cells["title"].Value.ToString();
            string amenityPrice = cells["price"].Value.ToString();
            string chargable = cells["is_chargable"].Value.ToString();

            if (amenityId == lblAmenityId.Text) return;

            lblAmenityId.Text = amenityId;
            lblAmenityTitle.Text = amenityTitle;
            txtAmenityPrice.Text = amenityPrice;
            lblChargable.Text = chargable;
            cbbAmenityUsageStatus.SelectedValue = "PENDING";
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
                    cmd.CommandText = $"update room_amenity_usage set amenity_id=@amenity_id, price=@price, status=@status where id=@room_amenity_usage_id";
                    cmd.Parameters.AddWithValue("@room_amenity_usage_id", selecetedRoomAmenityUsageId);
                    cmd.Parameters.AddWithValue("@amenity_id", lblAmenityId.Text);
                    cmd.Parameters.AddWithValue("@price", txtAmenityPrice.Text);
                    cmd.Parameters.AddWithValue("@status", cbbAmenityUsageStatus.SelectedValue);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Changes saved successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormReservationDetail._self.LoadReservationAmenityUsageByRoom(lblRoomId.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred!");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to delete this amenity usage?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {

                using (var conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = $"delete from room_amenity_usage where id = '{selecetedRoomAmenityUsageId}' ";
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Amenity usage deleted successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormReservationDetail._self.LoadReservationAmenityUsageByRoom(lblRoomId.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred!");
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void grvAmenity_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleAmaneitySelectionChange();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbAmenity);
            dv.RowFilter = $"CONVERT({cbbSearchType.SelectedValue},'System.String') LIKE '%{txtSearch.Text}%'";
            grvAmenity.DataSource = dv;
        }

        private void cbbStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Enum.TryParse(cbbAmenityUsageStatus.SelectedValue.ToString(), out RoomAmenityUsageStatus status))
            {
                lblRoomAmenityUsageStatus.Text = status.ToString();
                lblRoomAmenityUsageStatus.ForeColor = RoomAmenityUsageStatusColor.Get(status).Dark;
                pnRoomAmenityUsageStatus.BackColor = RoomAmenityUsageStatusColor.Get(status).Dark;
            }
        }
    }
}
