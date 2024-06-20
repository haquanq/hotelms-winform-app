using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormRoomAmenityUsageCreate : Form
    {
        private DataTable dtbAvailableAmenity = new DataTable();
        private string selectedReservationId;
        private string selectedRoomId;
        public FormRoomAmenityUsageCreate(string selectedReservationId, string selectedRoomId)
        {
            InitializeComponent();
            this.selectedReservationId = selectedReservationId;
            this.selectedRoomId = selectedRoomId;

            DataTable dtbSearchType = new DataTable();
            dtbSearchType.Columns.Add("value", typeof(string));
            dtbSearchType.Columns.Add("text", typeof(string));
            dtbSearchType.Rows.Add("id", "Amenity ID");
            dtbSearchType.Rows.Add("title", "Title");
            cbbSearchType.DataSource = dtbSearchType;
            cbbSearchType.DisplayMember = "text";
            cbbSearchType.ValueMember = "value";

            grvAmenity.Columns["price"].DefaultCellStyle.Format = "##,0 vnd";
        }

        private void FormAmenityUsageCreate_Load(object sender, EventArgs e)
        {
            LoadRoomAndAvalableAmenity();
            HandleAmaneitySelectionChange();
        }

        private void LoadRoomAndAvalableAmenity()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select * from amenity where id not in " +
                    " (select amenity_id from room_amenity_usage where reservation_id=@reservation_id and room_id=@room_id )";
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                cmd.Parameters.AddWithValue("@room_id", selectedRoomId);
                using (var dr = cmd.ExecuteReader())
                {
                    dtbAvailableAmenity.Clear();
                    dtbAvailableAmenity.Load(dr);
                    grvAmenity.DataSource = dtbAvailableAmenity;
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "select * from room where id=@room_id";
                cmd.Parameters.AddWithValue("@room_id", selectedRoomId);

                using (var dr = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(dr);
                    var cells = dt.Rows[0];
                    lblReservationId.Text = selectedReservationId.ToString();
                    lblRoomId.Text = cells["id"].ToString();
                    lblRoomCode.Text = cells["room_code"].ToString();
                    lblRoomFloor.Text = cells["floor_number"].ToString();

                    if (Enum.TryParse(cells["status"].ToString(), out RoomStatus roomStatus))
                    {
                        lblRoomStatus.Text = roomStatus.ToString();
                        lblRoomStatus.ForeColor = RoomStatusColor.Get(roomStatus).Dark;
                        pnRoomStatus.BackColor = RoomStatusColor.Get(roomStatus).Dark;
                    }
                }
                conn.Close();
            }
        }


        private void HandleAmaneitySelectionChange()
        {
            if (grvAmenity.CurrentRow == null) return;
            string amenityId = grvAmenity.CurrentRow.Cells["id"].Value.ToString();
            string amenityTitle = grvAmenity.CurrentRow.Cells["title"].Value.ToString();
            string amenityPrice = grvAmenity.CurrentRow.Cells["price"].Value.ToString();
            string chargable = grvAmenity.CurrentRow.Cells["is_chargable"].Value.ToString();

            if (amenityId == lblAmenityId.Text) return;
            lblAmenityId.Text = amenityId;
            lblAmenityTitle.Text = amenityTitle;
            txtPrice.Text = amenityPrice;
            lblChargable.Text = chargable;
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to create this amenity usage?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            if (grvAmenity.CurrentRow == null)
            {
                MessageBox.Show("No amenity to be added!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                using (var conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "insert into room_amenity_usage (reservation_id, room_id, amenity_id, price, status) values " +
                        " (@reservation_id, @room_id, @amenity_id, @price, @status)";

                    cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                    cmd.Parameters.AddWithValue("@room_id", selectedRoomId);
                    cmd.Parameters.AddWithValue("@amenity_id", lblAmenityId.Text);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@status", RoomAmenityUsageStatus.PENDING.ToString());
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
            DataView dv = new DataView(dtbAvailableAmenity);
            dv.RowFilter = $"CONVERT({cbbSearchType.SelectedValue},'System.String') LIKE '%{txtSearch.Text}%'";
            grvAmenity.DataSource = dv;
        }
    }
}
