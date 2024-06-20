using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormAmenityCreate : Form
    {
        public FormAmenityCreate()
        {
            InitializeComponent();

            DataTable dtbChargable = new DataTable();
            dtbChargable.Columns.Add("value", typeof(int));
            dtbChargable.Columns.Add("text", typeof(string));
            dtbChargable.Rows.Add(0, "Free");
            dtbChargable.Rows.Add(1, "Charge");
            cbbChargable.DataSource = dtbChargable;
            cbbChargable.ValueMember = "value";
            cbbChargable.DisplayMember = "text";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Do you want to create this amenity?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new SqlConnection(Helper.GetConString()))
                    using (var cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        cmd.CommandText = "insert into amenity (title, detail, price, is_chargable) values " +
                            " (@title, @detail, @price, @is_chargable)";
                        cmd.Parameters.AddWithValue("title", txtTitle.Text);
                        cmd.Parameters.AddWithValue("detail", txtDetail.Text);
                        cmd.Parameters.AddWithValue("price", txtPrice.Text);
                        cmd.Parameters.AddWithValue("is_chargable", cbbChargable.SelectedValue);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    MessageBox.Show("Amenity created successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormAmenity._self.LoadAllAmenities();
                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error ocurred!");
                }
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
