using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormStaff : Form
    {
        public static DataTable dtbStaff = new DataTable();
        public static FormStaff _self;
        public FormStaff()
        {
            InitializeComponent();
            _self = this;

            DataTable dtbSearchType = new DataTable();
            dtbSearchType.Columns.Add("value", typeof(string));
            dtbSearchType.Columns.Add("text", typeof(string));
            dtbSearchType.Rows.Add("id", "Staff ID");
            dtbSearchType.Rows.Add("full_name", "Full name");
            dtbSearchType.Rows.Add("phone", "Phone");
            dtbSearchType.Rows.Add("email", "Email");
            cbbSearchType.DataSource = dtbSearchType;
            cbbSearchType.DisplayMember = "text";
            cbbSearchType.ValueMember = "value";

            DataTable dtbRoleFIlter = new DataTable();
            dtbRoleFIlter.Columns.Add("value", typeof(string));
            dtbRoleFIlter.Columns.Add("text", typeof(string));
            dtbRoleFIlter.Rows.Add("All", "All");
            dtbRoleFIlter.Rows.Add("RECEPTIONIST", "Receptionist");
            dtbRoleFIlter.Rows.Add("MANAGER", "Manager");
            dtbRoleFIlter.Rows.Add("HOUSEKEEPER", "Housekeeper");
            dtbRoleFIlter.Rows.Add("ADMIN", "Admin");
            cbbRoleFilter.DataSource = dtbRoleFIlter;
            cbbRoleFilter.DisplayMember = "text";
            cbbRoleFilter.ValueMember = "value";

            DataTable dtbStatus = new DataTable();
            dtbStatus.Columns.Add("value", typeof(string));
            dtbStatus.Columns.Add("text", typeof(string));
            dtbStatus.Rows.Add("All", "All");
            dtbStatus.Rows.Add("ACTIVATED", "Activated");
            dtbStatus.Rows.Add("DEACTIVATED", "Deactivated");
            cbbStatusFilter.DataSource = dtbStatus;
            cbbStatusFilter.DisplayMember = "text";
            cbbStatusFilter.ValueMember = "value";

            grvStaff.Columns["dob"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvStaff.Columns["created_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvStaff.Columns["updated_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
        }
        private void FormStaff_Load(object sender, EventArgs e)
        {
            HandleUserPermission();
            LoadAllStaff();
        }

        private void HandleUserPermission()
        {
            if (Enum.TryParse(FormLogin.currentUser.role, out StaffRole role))
            {
                if (role == StaffRole.ADMIN)
                {
                    btnUpdate.Visible = true;
                    btnCreate.Visible = true;
                }
                if (role == StaffRole.MANAGER)
                {
                    btnUpdate.Visible = true;
                    btnCreate.Visible = false;
                }
                if (role == StaffRole.RECEPTIONIST)
                {
                    btnUpdate.Visible = false;
                    btnCreate.Visible = false;
                }
                if (role == StaffRole.HOUSEKEEPER)
                {
                    btnUpdate.Visible = false;
                    btnCreate.Visible = false;
                }
            }
        }


        public void LoadAllStaff()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select id, first_name + ' ' + last_name as full_name, dob, " +
                    " phone, email, role, created_at, updated_at ,status from staff";
                using (var reader = cmd.ExecuteReader())
                {
                    dtbStaff.Clear();
                    dtbStaff.Load(reader);
                    grvStaff.DataSource = dtbStaff;
                    lblRowCount.Text = $"{dtbStaff.Rows.Count} employees";
                }
                conn.Close();
            }
        }

        private void HandleRoleAndStatusFilter()
        {
            DataView dv = new DataView(dtbStaff);
            int x = cbbStatusFilter.SelectedIndex;
            int y = cbbRoleFilter.SelectedIndex;

            if (x == 0 && y == 0)
            {
                grvStaff.DataSource = dtbStaff;
            }
            if (x == 0 && y != 0)
            {
                dv.RowFilter = $"role = '{cbbRoleFilter.SelectedValue}'";
                grvStaff.DataSource = dv;
            }
            if (x != 0 && y == 0)
            {
                dv.RowFilter = $"status = '{cbbStatusFilter.SelectedValue}'";
                grvStaff.DataSource = dv;
            }
            if (x != 0 && y != 0)
            {
                dv.RowFilter = $"status = '{cbbStatusFilter.SelectedValue}' " +
                    $"AND role = '{cbbRoleFilter.SelectedValue}'";
                grvStaff.DataSource = dv;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grvStaff.ClearSelection();
            grvStaff.CurrentCell = grvStaff[0, 0];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grvStaff.CurrentRow.Index;
            if (i > 0)
            {
                grvStaff.CurrentCell = grvStaff[0, i - 1];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(grvStaff.CurrentRow.Index.ToString());
            if (i < grvStaff.RowCount - 1)
            {
                grvStaff.CurrentCell = grvStaff[0, i + 1];
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grvStaff.CurrentCell = grvStaff[0, grvStaff.RowCount - 1];
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormStaffCreate f = new FormStaffCreate();
            f.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbStaff);
            dv.RowFilter = $"CONVERT({cbbSearchType.SelectedValue}, 'System.String') LIKE '%{txtSearch.Text}%'";
            grvStaff.DataSource = dv;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grvStaff.CurrentRow == null) return;
            var f = new FormStaffUpdate(grvStaff.CurrentRow.Cells["id"].Value.ToString());
            f.ShowDialog();
        }

        private void grvStaff_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow row in grvStaff.Rows)
            {
                if (Enum.TryParse(row.Cells["status"].Value.ToString(), out StaffStatus status))
                {
                    row.Cells["status"].Style.BackColor = StaffStatusColor.Get(status).Light;
                    row.Cells["status"].Style.ForeColor = Color.FromArgb(38, 38, 38);
                }
            }

        }

        private void cbbRoleFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HandleRoleAndStatusFilter();
        }

        private void cbbStatusFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HandleRoleAndStatusFilter();
        }
    }
}
