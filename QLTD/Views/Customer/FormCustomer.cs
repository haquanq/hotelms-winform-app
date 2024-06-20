using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormCustomer : Form
    {
        public static FormCustomer _self;
        private DataTable dtbCustomer = new DataTable();

        public FormCustomer()
        {
            InitializeComponent();
            _self = this;

            DataTable dtbStatusFitler = new DataTable();
            dtbStatusFitler.Columns.Add("value", typeof(string));
            dtbStatusFitler.Columns.Add("text", typeof(string));
            dtbStatusFitler.Rows.Add("All", "All");
            dtbStatusFitler.Rows.Add("NEW", "New");
            dtbStatusFitler.Rows.Add("COMMON", "Common");
            dtbStatusFitler.Rows.Add("VIP", "Vip");
            cbbStatusFIlter.DataSource = dtbStatusFitler;
            cbbStatusFIlter.DisplayMember = "text";
            cbbStatusFIlter.ValueMember = "value";

            DataTable dtbSearchType = new DataTable();
            dtbSearchType.Columns.Add("value", typeof(string));
            dtbSearchType.Columns.Add("text", typeof(string));
            dtbSearchType.Rows.Add("id", "Customer ID");
            dtbSearchType.Rows.Add("pid", "Identification number");
            dtbSearchType.Rows.Add("full_name", "Full name");
            dtbSearchType.Rows.Add("phone", "Phone");
            dtbSearchType.Rows.Add("email", "Email");
            dtbSearchType.Rows.Add("address", "Address");
            cbbSearchType.DataSource = dtbSearchType;
            cbbSearchType.DisplayMember = "text";
            cbbSearchType.ValueMember = "value";

            grvCustomer.Columns["created_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvCustomer.Columns["updated_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            HandleUserPermission();
            LoadAllCustomer();
        }

        private void HandleUserPermission()
        {
            if (Enum.TryParse(FormLogin.currentUser.role, out StaffRole role))
            {
                if (role == StaffRole.MANAGER)
                {
                    btnCreate.Visible = true;
                    btnUpdate.Visible = true;
                }
                if (role == StaffRole.RECEPTIONIST)
                {
                    btnCreate.Visible = true;
                    btnUpdate.Visible = true;
                }
                if (role == StaffRole.HOUSEKEEPER)
                {
                    btnCreate.Visible = false;
                    btnUpdate.Visible = false;
                }
                if (role == StaffRole.ADMIN)
                {
                    btnCreate.Visible = false;
                    btnUpdate.Visible = false;
                }
            }
        }

        public void LoadAllCustomer()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select id, first_name + ' ' + last_name as full_name, address, email, phone, status, created_at, updated_at from customer";
                using (var reader = cmd.ExecuteReader())
                {
                    dtbCustomer.Clear();
                    dtbCustomer.Load(reader);
                    grvCustomer.DataSource = dtbCustomer;
                    lblRowCount.Text = $"{dtbCustomer.Rows.Count} customers";
                }
                conn.Close();
            }
        }

        private void cbbStatusFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbCustomer);
            int x = cbbStatusFIlter.SelectedIndex;

            if (x == 0)
            {
                grvCustomer.DataSource = dtbCustomer;
            }
            else
            {
                dv.RowFilter = $"status = '{cbbStatusFIlter.SelectedValue}' ";
                grvCustomer.DataSource = dv;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grvCustomer.ClearSelection();
            grvCustomer.CurrentCell = grvCustomer[0, 0];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grvCustomer.CurrentRow.Index;
            if (i > 0)
            {
                grvCustomer.CurrentCell = grvCustomer[0, i - 1];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(grvCustomer.CurrentRow.Index.ToString());
            if (i < grvCustomer.RowCount - 1)
            {
                grvCustomer.CurrentCell = grvCustomer[0, i + 1];
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grvCustomer.CurrentCell = grvCustomer[0, grvCustomer.RowCount - 1];
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormCustomerCreate f = new FormCustomerCreate();
            f.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (grvCustomer.CurrentRow == null) return;
            var f = new FormCustomerDetail(grvCustomer.CurrentRow.Cells["id"].Value.ToString());
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grvCustomer.CurrentRow == null) return;
            var f = new FormCustomerUpdate(grvCustomer.CurrentRow.Cells["id"].Value.ToString());
            f.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbCustomer);
            dv.RowFilter = $"{cbbSearchType.SelectedValue} LIKE '%{txtSearch.Text}%'";
            grvCustomer.DataSource = dv;
        }

        private void grvCustomer_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow row in grvCustomer.Rows)
            {
                if (Enum.TryParse(row.Cells["status"].Value.ToString(), out CustomerStatus status))
                {
                    row.Cells["status"].Style.BackColor = CustomerStatusColor.Get(status).Light;
                    row.Cells["status"].Style.ForeColor = Color.FromArgb(38, 38, 38);
                }
            }

        }
    }
}
