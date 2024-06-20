using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormHome : Form
    {
        Form currentForm = null;
        public static FormHome _self;
        public FormHome()
        {
            InitializeComponent();
            _self = this;
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            string name = FormLogin.currentUser.name;
            string role = FormLogin.currentUser.role;
            string de = FormLogin.currentUser.phone;
            lblAccount.Text = $"{name}\n{role}\n{de}";

            if (Enum.TryParse(role, out StaffRole r))
                HandlePermission(r);

            NavigateToForm(new FormDashboard());
            btnDashboard.Enabled = false;
            btnDashboard.BackColor = SystemColors.Control;

            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "update discount_coupon set status=@status1, updated_at=GETDATE() " +
                    " where expired_at < GETDATE() and status=@status2";
                cmd.Parameters.AddWithValue("status1", CouponStatus.EXPIRED.ToString());
                cmd.Parameters.AddWithValue("status2", CouponStatus.AVAILABLE.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();

            }

        }

        private void HandlePermission(StaffRole role)
        {
            if (role == StaffRole.MANAGER)
            {
                btnReport.Visible = true;
                btnStaff.Visible = true;
            }
            if (role == StaffRole.RECEPTIONIST)
            {
                btnReport.Visible = true;
                btnStaff.Visible = true;
            }
            if (role == StaffRole.HOUSEKEEPER)
            {
                btnReport.Visible = false;
                btnStaff.Visible = false;
            }

            if (role == StaffRole.ADMIN)
            {
                btnReport.Visible = false;
                btnStaff.Visible = true;
            }
        }

        private void NavigateToForm(Form f)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            Container.Controls.Clear();
            currentForm = f;
            currentForm.Dock = DockStyle.Fill;
            currentForm.TopLevel = false;
            currentForm.TopMost = true;
            Container.Controls.Add(currentForm);
            currentForm.Show();
        }

        private void HandleButtonSelectionChange(object sender, EventArgs e)
        {
            foreach (Control c in pnHomeMenu.Controls)
            {
                c.BackColor = Color.SteelBlue;
                c.Enabled = true;
            }
            Control click = (Control)sender;
            click.BackColor = SystemColors.Control;
            click.Enabled = false;
        }

        public void NavigateToRoomWithStatus(string s)
        {
            NavigateToForm(new FormRoom(s));
            HandleButtonSelectionChange(btnRoom, null);
        }

        private void GuestBtn_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FormCustomer());
            HandleButtonSelectionChange(btnCustomer, null);
        }

        private void ServiceBtn_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FormHotelServiceUsage());
            HandleButtonSelectionChange(btnService, null);
        }
        private void btnReservation_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FormReservation());
            HandleButtonSelectionChange(btnRerservation, null);
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FormDashboard());
            HandleButtonSelectionChange(btnDashboard, null);
        }
        private void btnRoom_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FormRoom(null));
            HandleButtonSelectionChange(btnRoom, null);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FormStaff());
            HandleButtonSelectionChange(btnStaff, null);
        }
        private void CouponBtn_Click(object sender, EventArgs e)
        {

            NavigateToForm(new FormCoupon());
            HandleButtonSelectionChange(btnCoupon, null);
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            NavigateToForm(new FormReport());
            HandleButtonSelectionChange(btnReport, null);
        }

        private void SignOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin f = new FormLogin();
            f.Show();
        }

    }
}
