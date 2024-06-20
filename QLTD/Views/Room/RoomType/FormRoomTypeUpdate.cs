using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormRoomTypeUpdate : Form
    {
        private string selectedRoomTypeId;
        public FormRoomTypeUpdate(string selectedRoomTypeId)
        {
            InitializeComponent();
            this.selectedRoomTypeId = selectedRoomTypeId;
        }

        private void FormRoomTypeUpdate_Load(object sender, EventArgs e)
        {
            LoadRoomTypeById(selectedRoomTypeId);
        }

        private void LoadRoomTypeById(string roomTypeId)
        {

            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();

                cmd.CommandText = "select * from room_type where id=@room_type_id";
                cmd.Parameters.AddWithValue("room_type_id", roomTypeId);
                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(reader);
                    var cells = dt.Rows[0];
                    lblRoomTypeId.Text = cells["id"].ToString();
                    txtTitle.Text = cells["title"].ToString();
                    txtDetail.Text = cells["detail"].ToString();
                    txtPrice.Text = cells["price_per_night"].ToString();

                }
                conn.Close();
            }
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
                    cmd.CommandText = "update room_type set title=@title, detail=@detail, " +
                        " price_per_night=@price_per_night where id=@room_type_id";
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@detail", txtDetail.Text);
                    cmd.Parameters.AddWithValue("@price_per_night", txtPrice.Text);
                    cmd.Parameters.AddWithValue("@room_type_id", selectedRoomTypeId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Changes saved successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormRoomType._self.LoadAllRoomTypes();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred!");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {
                using (var conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = $"delete from room_type where id=@room_type_id ";
                    cmd.Parameters.AddWithValue("@room_type_id", selectedRoomTypeId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Room type deteted successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormRoomType._self.LoadAllRoomTypes();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
