using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormRoomUpdate : Form
    {
        public static DataTable dtbRoomAmenity = new DataTable();
        public static DataTable dtbAvailableAmenity = new DataTable();
        private string selectedRoomId;
        public FormRoomUpdate(string selectedRoomId)
        {
            InitializeComponent();
            this.selectedRoomId = selectedRoomId;

            grvAvailableAmenity.Columns["price2"].DefaultCellStyle.Format = "##,0 vnd";
            grvRoomAmenity.Columns["price1"].DefaultCellStyle.Format = "##,0 vnd";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRoomUpdate_Load(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("select * from amenity", conn))
                {
                    dtbAvailableAmenity.Clear();
                    da.Fill(dtbAvailableAmenity);
                    grvAvailableAmenity.DataSource = dtbAvailableAmenity;

                }
                using (SqlDataAdapter da = new SqlDataAdapter("select id, title from room_type", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbbRoomType.DataSource = dt;
                    cbbRoomType.DisplayMember = "title";
                    cbbRoomType.ValueMember = "id";
                }
                string sql = "select b.id, b.title,b.detail, b.price,b.is_chargable from room_amenity a " +
                    $" left join amenity b on a.amenity_id = b.id where room_id = '{selectedRoomId}'";

                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    dtbRoomAmenity.Clear();
                    da.Fill(dtbRoomAmenity);
                    grvRoomAmenity.DataSource = dtbRoomAmenity;
                }

                using (SqlDataAdapter da = new SqlDataAdapter($"select * from room where id = '{selectedRoomId}'", conn))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    var cells = dt.Rows[0];
                    lblRoomId.Text = cells["id"].ToString();
                    txtRoomCode.Text = cells["room_code"].ToString();
                    txtFloorNumber.Value = Convert.ToInt32(cells["floor_number"]);
                    cbbRoomType.SelectedValue = cells["room_type_id"].ToString();

                    lblRoomStatus.Text = cells["status"].ToString();
                    if (Enum.TryParse(lblRoomStatus.Text, out RoomStatus s))
                    {
                        lblRoomStatus.ForeColor = RoomStatusColor.Get(s).Dark;
                        pnRoomStatus.BackColor = RoomStatusColor.Get(s).Dark;
                    }
                }
                conn.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to save these changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

                    cmd.CommandText = $"update room set room_type_id=@room_type_id, room_code=@room_code, floor_number=@floor_number, updated_at=@updated_at where id = @room_id";
                    cmd.Parameters.AddWithValue("@room_type_id", cbbRoomType.SelectedValue);
                    cmd.Parameters.AddWithValue("@room_code", txtRoomCode.Text);
                    cmd.Parameters.AddWithValue("@room_id", selectedRoomId);
                    cmd.Parameters.AddWithValue("@floor_number", txtFloorNumber.Value);
                    cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.CommandText = "delete from room_amenity where room_id=@room_id";
                    cmd.Parameters.AddWithValue("@room_id", selectedRoomId);
                    cmd.ExecuteNonQuery();


                    cmd.CommandText = "insert into room_amenity values (@room_id, @amenity_id)";
                    foreach (DataRow row in dtbRoomAmenity.Rows)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@room_id", selectedRoomId);
                        cmd.Parameters.AddWithValue("amenity_id", row["id"]);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    conn.Close();
                }

                FormRoom._self.LoadAllRoomsAndRoomType();
                MessageBox.Show("Changes saved successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred!");
                transaction.Rollback();
                transaction.Dispose();
            }
        }

        private void btnAddAmenity_Click(object sender, EventArgs e)
        {
            if (grvAvailableAmenity.CurrentRow == null) return;
            DataRow currentRow = ((DataRowView)grvAvailableAmenity.CurrentRow.DataBoundItem).Row;
            DataRow[] found = dtbRoomAmenity.Select($"id = {currentRow["id"]}");

            if (found.Length != 0)
            {
                MessageBox.Show("Amenity already added", "Added", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var row = dtbRoomAmenity.NewRow();
                row["id"] = currentRow["id"];
                row["title"] = currentRow["title"];
                row["price"] = currentRow["price"];
                row["detail"] = currentRow["detail"];
                row["is_chargable"] = currentRow["is_chargable"];
                dtbRoomAmenity.Rows.Add(row);
            }
        }

        private void btnRemoveAmenity_Click(object sender, EventArgs e)
        {
            if (grvRoomAmenity.CurrentRow == null) return;
            DataRow row = ((DataRowView)grvRoomAmenity.CurrentRow.DataBoundItem).Row;
            dtbRoomAmenity.Rows.Remove(row);

        }

        private void btnMoreDetail_Click(object sender, EventArgs e)
        {
            if (grvAvailableAmenity.CurrentRow == null) return;
            var f = new FormAmenityUpdate(grvAvailableAmenity.CurrentRow.Cells["id2"].Value.ToString());
            f.ShowDialog();

        }
    }
}
