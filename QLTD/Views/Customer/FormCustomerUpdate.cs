using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormCustomerUpdate : Form
    {
        private string selectedCustomerId;
        public FormCustomerUpdate(string selectedCustomerId)
        {
            InitializeComponent();
            this.selectedCustomerId = selectedCustomerId;

            DataTable dtbStatus = new DataTable();
            dtbStatus.Columns.Add("value", typeof(string));
            dtbStatus.Columns.Add("text", typeof(string));
            dtbStatus.Rows.Add("NEW", "New");
            dtbStatus.Rows.Add("COMMON", "Common");
            dtbStatus.Rows.Add("VIP", "Vip");
            cbbStatus.DataSource = dtbStatus;
            cbbStatus.DisplayMember = "text";
            cbbStatus.ValueMember = "value";
        }

        private void FormCustomerCreate_Load(object sender, EventArgs e)
        {
            LoadCustomerById(selectedCustomerId);
        }

        private void LoadCustomerById(string customerId)
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select * from customer where id=@customer_id";
                cmd.Parameters.AddWithValue("customer_id", customerId);
                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(reader);
                    var cells = dt.Rows[0];

                    lblCustomerId.Text = cells["id"].ToString();
                    txtPid.Text = cells["pid"].ToString();
                    txtFirstName.Text = cells["first_name"].ToString();
                    txtLastName.Text = cells["last_name"].ToString();
                    txtEmail.Text = cells["email"].ToString();
                    txtPhone.Text = cells["phone"].ToString();
                    txtAddress.Text = cells["address"].ToString();
                    cbbStatus.SelectedValue = cells["status"].ToString();
                    lblCreatedAt.Text = DateTime.Parse(cells["created_at"].ToString()).ToString("dd-MM-yyyy HH:mm");
                    lblUpdatedAt.Text = DateTime.Parse(cells["updated_at"].ToString()).ToString("dd-MM-yyyy HH:mm");

                    if (Enum.TryParse(cells["status"].ToString(), out CustomerStatus customerStatus))
                    {
                        lblCustomerStatus.Text = customerStatus.ToString();
                        lblCustomerStatus.ForeColor = CustomerStatusColor.Get(customerStatus).Dark;
                        pnCustomerStatus.BackColor = CustomerStatusColor.Get(customerStatus).Dark;
                    }
                }
                conn.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to save these changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = $"update customer set pid=@pid, first_name=@first_name, last_name=@last_name, address=@address, " +
                    $" phone=@phone, email=@email, status=@status, updated_at=@updated_at where id=@customer_id";

                    cmd.Parameters.AddWithValue("@pid", txtPid.Text);
                    cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@status", cbbStatus.SelectedValue);
                    cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);
                    cmd.Parameters.AddWithValue("@customer_id", selectedCustomerId);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Changes saved successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormCustomer._self.LoadAllCustomer();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to save these changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "delete from customer where id = @customer_id";
                    cmd.Parameters.AddWithValue("@customer_id", selectedCustomerId);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Customer deleted successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormCustomer._self.LoadAllCustomer();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred!");
            }

        }

        private void cbbStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Enum.TryParse(cbbStatus.SelectedValue.ToString(), out CustomerStatus s))
            {
                lblCustomerStatus.Text = s.ToString();
                lblCustomerStatus.ForeColor = CustomerStatusColor.Get(s).Dark;
                pnCustomerStatus.BackColor = CustomerStatusColor.Get(s).Dark;
            }
        }
    }
}
