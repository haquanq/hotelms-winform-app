using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormAmenityUpdate : Form
    {
        private string selectedAmenityId;
        public FormAmenityUpdate(string selectedAmenityId)
        {
            InitializeComponent();
            this.selectedAmenityId = selectedAmenityId;

            DataTable dtbChargableOption = new DataTable();
            dtbChargableOption.Columns.Add("value", typeof(int));
            dtbChargableOption.Columns.Add("text", typeof(string));
            dtbChargableOption.Rows.Add(0, "Free");
            dtbChargableOption.Rows.Add(1, "Charge");
            cbbChargable.DataSource = dtbChargableOption;
            cbbChargable.ValueMember = "value";
            cbbChargable.DisplayMember = "text";
        }

        private void FormAmenityUpdate_Load(object sender, EventArgs e)
        {
            LoadAmenityById(selectedAmenityId);
        }

        private void LoadAmenityById(string amenityId)
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select * from amenity where id=@amenity_id";
                cmd.Parameters.AddWithValue("amenity_id", selectedAmenityId);
                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(reader);
                    var cells = dt.Rows[0];
                    lblAmenityId.Text = cells["id"].ToString();
                    txtTitle.Text = cells["title"].ToString();
                    txtDetail.Text = cells["detail"].ToString();
                    txtPrice.Text = cells["price"].ToString();
                    cbbChargable.SelectedValue = cells["is_chargable"];
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
                    cmd.CommandText = $"update amenity set title=@title, detail=@detail, price=@price, " +
                        $" is_chargable=@is_chargable where id=@amenity_id";
                    cmd.Parameters.AddWithValue("title", txtTitle);
                    cmd.Parameters.AddWithValue("detail", txtDetail);
                    cmd.Parameters.AddWithValue("price", txtPrice);
                    cmd.Parameters.AddWithValue("is_chargable", cbbChargable.SelectedValue);
                    cmd.Parameters.AddWithValue("amenity_id", selectedAmenityId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                this.Close();
                MessageBox.Show("Changes saved successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAmenity._self.LoadAllAmenities();
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
                    cmd.CommandText = "delete from amenity where id=@amenity_id ";
                    cmd.Parameters.AddWithValue("amenity_id", selectedAmenityId);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                this.Close();
                MessageBox.Show("Amenity deleted successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAmenity._self.LoadAllAmenities();
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

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
