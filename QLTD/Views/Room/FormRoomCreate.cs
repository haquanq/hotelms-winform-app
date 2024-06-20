using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormRoomCreate : Form
    {
        public static DataTable dtbRoomAmenity = new DataTable();
        public static DataTable dtbAvailableAmenity = new DataTable();

        public FormRoomCreate()
        {
            InitializeComponent();

            grvAvailableAmenity.Columns["price2"].DefaultCellStyle.Format = "##,0 vnd";
            grvRoomAmenity.Columns["price1"].DefaultCellStyle.Format = "##,0 vnd";
        }

        private void FormRoomCreate_Load(object sender, EventArgs e)
        {
            LoadAllRoomTypesAndAvailableAmenity();
        }

        public void LoadAllRoomTypesAndAvailableAmenity()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            {
                conn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter("select * from amenity", conn))
                {
                    dtbAvailableAmenity.Clear();
                    da.Fill(dtbAvailableAmenity);
                    grvAvailableAmenity.DataSource = dtbAvailableAmenity;

                    dtbRoomAmenity = dtbAvailableAmenity.Clone();
                    grvRoomAmenity.DataSource = dtbRoomAmenity;
                }
                using (SqlDataAdapter da = new SqlDataAdapter("select id, title from room_type", conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cbbRoomType.DataSource = dt;
                    cbbRoomType.DisplayMember = "title";
                    cbbRoomType.ValueMember = "id";
                }
                conn.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to save to database!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            SqlTransaction transaction = null;
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    cmd.Transaction = transaction;

                    cmd.CommandText = $"insert into room (room_type_id, room_code, floor_number, status, created_at, updated_at) values " +
                    " (@room_type_id, @room_code, @floor_number, @status, @created_at, @updated_at); select SCOPE_IDENTITY()";
                    cmd.Parameters.AddWithValue("@room_type_id", cbbRoomType.SelectedValue);
                    cmd.Parameters.AddWithValue("@room_code", txtRoomCode.Text);
                    cmd.Parameters.AddWithValue("@floor_number", txtFloorNumber.Value);
                    cmd.Parameters.AddWithValue("@status", "READY");
                    cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                    cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                    int roomId = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd.CommandText = $"insert into room_amenity values ({roomId}, @amenity_id)";
                    foreach (DataRow row in dtbRoomAmenity.Rows)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("amenity_id", row["id"]);
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    conn.Close();
                }

                FormRoom._self.LoadAllRoomsAndRoomType();
                MessageBox.Show("New room saved successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnUpdateAmenity_Click(object sender, EventArgs e)
        {
            if (grvAvailableAmenity.CurrentRow == null) return;
            var f = new FormAmenityUpdate(grvAvailableAmenity.CurrentRow.Cells["id2"].Value.ToString());
            f.ShowDialog();
        }
    }
}
