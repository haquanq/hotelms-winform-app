using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormHotelSerivceUpdate : Form
    {
        private string selectedHotelServiceId;
        public FormHotelSerivceUpdate(string selectedHotelServiceId)
        {
            InitializeComponent();
            this.selectedHotelServiceId = selectedHotelServiceId;
        }

        private void FormHotelServiceEdit_Load(object sender, EventArgs e)
        {
            LoadHotelServiceById(selectedHotelServiceId);
        }

        private void LoadHotelServiceById(string hotelServiceId)
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select * from hotel_service where id=@id";
                cmd.Parameters.AddWithValue("id", hotelServiceId);
                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(reader);
                    var cells = dt.Rows[0];

                    lblHotelServiceId.Text = cells["id"].ToString();
                    txtTitle.Text = cells["title"].ToString();
                    txtDetail.Text = cells["detail"].ToString();
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
                    cmd.CommandText = $"update hotel_service set title=@title, detail=@detail where id=@id ";
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@detail", txtDetail.Text);
                    cmd.Parameters.AddWithValue("@id", selectedHotelServiceId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Changes saved successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormHotelService._self.LoadAllHotelService();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred!");
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {
                using (var conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = $"delete from hotel_service where id=@id ";
                    cmd.Parameters.AddWithValue("@id", selectedHotelServiceId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Hotel service deleted successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormHotelService._self.LoadAllHotelService();
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
    }
}
