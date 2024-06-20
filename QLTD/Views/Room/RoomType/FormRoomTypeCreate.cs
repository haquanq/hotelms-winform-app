using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormRoomTypeCreate : Form
    {
        public FormRoomTypeCreate()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Do you want to create this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new SqlConnection(Helper.GetConString()))
                    using (var cmd = conn.CreateCommand())
                    {
                        conn.Open();
                        cmd.CommandText = "insert into room_type (title, detail, price_per_night) values " +
                            " (@title, @detail, @price_per_night)";
                        cmd.Parameters.AddWithValue("title", txtTitle.Text);
                        cmd.Parameters.AddWithValue("detail", txtDetail.Text);
                        cmd.Parameters.AddWithValue("price_per_night", txtPrice.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    MessageBox.Show("Room type created successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormRoomType._self.LoadAllRoomTypes();
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
