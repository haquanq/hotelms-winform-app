using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormStaffCreate : Form
    {
        public FormStaffCreate()
        {
            InitializeComponent();

            DataTable dtbRole = new DataTable();
            dtbRole.Columns.Add("value", typeof(string));
            dtbRole.Columns.Add("text", typeof(string));
            dtbRole.Rows.Add(StaffRole.RECEPTIONIST.ToString(), "Receptionist");
            dtbRole.Rows.Add(StaffRole.HOUSEKEEPER.ToString(), "HouseKeeper");
            dtbRole.Rows.Add(StaffRole.MANAGER.ToString(), "Manager");
            cbbRole.DataSource = dtbRole;
            cbbRole.DisplayMember = "text";
            cbbRole.ValueMember = "value";

            dtpDob.CustomFormat = "dd-MM-yyyy";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to create this staff?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {
                using (var conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "insert into staff (pw, first_name, last_name, dob, phone, email, role, status, created_at, updated_at) values " +
                    " (@pw, @first_name, @last_name, @dob, @phone, @email, @role, @status, GETDATE(), GETDATE())";

                    cmd.Parameters.AddWithValue("@pw", "1");
                    cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@last_name", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@dob", dtpDob.Value);
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@status", StaffStatus.ACTIVATED.ToString());
                    cmd.Parameters.AddWithValue("@role", cbbRole.SelectedValue);

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("New staff created successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormStaff._self.LoadAllStaff();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred!");
            }

        }
    }
}
