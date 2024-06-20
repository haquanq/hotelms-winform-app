using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormCustomerCreate : Form
    {
        public FormCustomerCreate()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to create this customer?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {
                using (var conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "insert into customer (pid, first_name, last_name, address, phone, email, status, created_at, updated_at) values " +
                    " (@pid, @first_name, @last_name, @address, @phone, @email, @status, @created_at, @updated_at)";

                    cmd.Parameters.AddWithValue("@pid", txtPid.Text);
                    cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@status", CustomerStatus.NEW.ToString());
                    cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                    cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Customer created successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormCustomer._self.LoadAllCustomer();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred!");
            }
        }
    }
}
