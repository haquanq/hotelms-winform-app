using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormHotelServiceCreate : Form
    {
        public FormHotelServiceCreate()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Do you want to create this service?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {
                using (var conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "insert into hotel_service (title, detail) values (@title, @detail)";
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@detail", txtDetail.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                this.Close();
                MessageBox.Show("Hotel service created successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormHotelService._self.LoadAllHotelService();

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
    }
}
