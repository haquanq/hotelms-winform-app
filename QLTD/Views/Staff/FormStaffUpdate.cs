using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormStaffUpdate : Form
    {
        private string selectedStaffId;
        public FormStaffUpdate(string selectedStaffId)
        {
            InitializeComponent();
            this.selectedStaffId = selectedStaffId;

            DataTable dtbStatus = new DataTable();
            dtbStatus.Columns.Add("value", typeof(string));
            dtbStatus.Columns.Add("text", typeof(string));
            dtbStatus.Rows.Add(StaffStatus.ACTIVATED.ToString(), "Activated");
            dtbStatus.Rows.Add(StaffStatus.DEACTIVATED.ToString(), "Deactivated");
            cbbStatus.DataSource = dtbStatus;
            cbbStatus.DisplayMember = "text";
            cbbStatus.ValueMember = "value";

            DataTable dtbRole = new DataTable();
            dtbRole.Columns.Add("value", typeof(string));
            dtbRole.Columns.Add("text", typeof(string));
            dtbRole.Rows.Add(StaffRole.RECEPTIONIST.ToString(), "Receptionist");
            dtbRole.Rows.Add(StaffRole.HOUSEKEEPER.ToString(), "HouseKeeper");
            dtbRole.Rows.Add(StaffRole.MANAGER.ToString(), "Manager");
            dtbRole.Rows.Add(StaffRole.ADMIN.ToString(), "Admin");
            cbbRole.DataSource = dtbRole;
            cbbRole.DisplayMember = "text";
            cbbRole.ValueMember = "value";

            dtpDob.CustomFormat = "dd-MM-yyyy";
        }

        private void FormStaffUpdate_Load(object sender, EventArgs e)
        {
            HandleUserPermission();
            LoadStaffById();
        }

        private void LoadStaffById()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select * from staff where id=@staff_id";
                cmd.Parameters.AddWithValue("staff_id", selectedStaffId);
                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(reader);
                    var cells = dt.Rows[0];

                    lblCustomerId.Text = cells["id"].ToString();
                    txtFirstName.Text = cells["first_name"].ToString();
                    txtLastName.Text = cells["last_name"].ToString();
                    dtpDob.Value = DateTime.Parse(cells["dob"].ToString());
                    txtEmail.Text = cells["email"].ToString();
                    txtPhone.Text = cells["phone"].ToString();
                    txtPassword.Text = cells["pw"].ToString();
                    cbbStatus.SelectedValue = cells["status"].ToString();
                    cbbRole.SelectedValue = cells["role"].ToString();
                    lblCreatedAt.Text = DateTime.Parse(cells["created_at"].ToString()).ToString("dd-MM-yyyy HH:mm");
                    lblUpdatedAt.Text = DateTime.Parse(cells["updated_at"].ToString()).ToString("dd-MM-yyyy HH:mm");
                    HandleStaffStatusChange(cells["status"].ToString());
                }
                conn.Close();
            }
        }

        private void HandleStaffStatusChange(string status)
        {
            if (Enum.TryParse(status, out StaffStatus s))
            {
                lblStaffstatus.Text = s.ToString();
                lblStaffstatus.ForeColor = StaffStatusColor.Get(s).Dark;
                pnStaffStatus.BackColor = StaffStatusColor.Get(s).Dark;
            }
        }

        private void HandleUserPermission()
        {
            if (Enum.TryParse(FormLogin.currentUser.role, out StaffRole role))
            {
                if (role == StaffRole.ADMIN)
                {
                    txtPassword.Visible = true;
                    lblPw.Visible = true;
                    cbbRole.Enabled = true;
                    cbbStatus.Enabled = true;
                    btnDelete.Enabled = true;
                }
                else
                {
                    txtPassword.Visible = false;
                    lblPw.Visible = false;
                    cbbRole.Enabled = false;
                    cbbStatus.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to save these changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {
                using (var conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = $"update staff set pw=@pw, first_name=@first_name, last_name=@last_name, dob=@dob, role=@role, " +
                    $" phone=@phone, email=@email, status=@status, updated_at=@updated_at where id=@staff_id";

                    cmd.Parameters.AddWithValue("first_name", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("last_name", txtLastName.Text);
                    cmd.Parameters.AddWithValue("dob", dtpDob.Value);
                    cmd.Parameters.AddWithValue("phone", txtPhone.Text);
                    cmd.Parameters.AddWithValue("email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("status", cbbStatus.SelectedValue);
                    cmd.Parameters.AddWithValue("role", cbbRole.SelectedValue);
                    cmd.Parameters.AddWithValue("pw", txtPassword.Text);
                    cmd.Parameters.AddWithValue("updated_at", DateTime.Now);
                    cmd.Parameters.AddWithValue("staff_id", selectedStaffId);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Changes saved successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormStaff._self.LoadAllStaff();
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
            DialogResult res = MessageBox.Show("Do you want to delete this staff?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {
                using (var conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "delete from customer where id = @staff_idj";
                    cmd.Parameters.AddWithValue("@staff_id", selectedStaffId);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Staff deleted successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormStaff._self.LoadAllStaff();
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
            HandleStaffStatusChange(cbbStatus.SelectedValue.ToString());
        }
    }
}
