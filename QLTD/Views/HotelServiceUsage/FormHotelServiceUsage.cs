using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormHotelServiceUsage : Form
    {
        public static FormHotelServiceUsage _self;
        public static DataTable dtbHotelServiceUsage = new DataTable();
        public FormHotelServiceUsage()
        {
            InitializeComponent();
            _self = this;

            DataTable dtbSearchType = new DataTable();
            dtbSearchType.Columns.Add("value", typeof(string));
            dtbSearchType.Columns.Add("text", typeof(string));
            dtbSearchType.Rows.Add("id", "Service ID");
            dtbSearchType.Rows.Add("title", "Title");
            cbbSearchType.DataSource = dtbSearchType;
            cbbSearchType.DisplayMember = "text";
            cbbSearchType.ValueMember = "value";

            DataTable dtbStatusFilter = new DataTable();
            dtbStatusFilter.Columns.Add("value", typeof(string));
            dtbStatusFilter.Columns.Add("text", typeof(string));
            dtbStatusFilter.Rows.Add("All", "All");
            dtbStatusFilter.Rows.Add("PENDING", "Pending");
            dtbStatusFilter.Rows.Add("COMPLETED", "Completed");
            cbbStatusFilter.DataSource = dtbStatusFilter;
            cbbStatusFilter.DisplayMember = "text";
            cbbStatusFilter.ValueMember = "value";

            grvHotelServiceUsage.Columns["created_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvHotelServiceUsage.Columns["updated_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvHotelServiceUsage.Columns["started_at"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
            grvHotelServiceUsage.Columns["ended_at"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
            grvHotelServiceUsage.Columns["price"].DefaultCellStyle.Format = "##,0 vnd";
        }

        private void FormHotelServiceUsage_Load(object sender, EventArgs e)
        {
            HandleUserPermission();
            LoadAllHotelServiceUsage();
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

        public void LoadAllHotelServiceUsage()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select a.id, d.first_name + ' ' + d.last_name as customer_name, b.title as service_title, " +
                    " a.started_at, a.ended_at, a.created_at, a.updated_at, a.price, a.status " +
                    " from hotel_service_usage a " +
                    " left join hotel_service b on a.hotel_service_id = b.id " +
                    " left join reservation c on a.reservation_id = c.id " +
                    " left join customer d on c.customer_id = d.id";
                using (var dr = cmd.ExecuteReader())
                {
                    dtbHotelServiceUsage.Clear();
                    dtbHotelServiceUsage.Load(dr);
                    grvHotelServiceUsage.DataSource = dtbHotelServiceUsage;
                    lblRowCount.Text = $"{dtbHotelServiceUsage.Rows.Count} usages";
                }
                conn.Close();
            }

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var f = new FormHotelServiceUsageCreate();
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grvHotelServiceUsage.CurrentRow == null) return;
            var f = new FormHotelServiceUsageUpdate(grvHotelServiceUsage.CurrentRow.Cells["id"].Value.ToString());
            f.ShowDialog();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grvHotelServiceUsage.ClearSelection();
            grvHotelServiceUsage.CurrentCell = grvHotelServiceUsage[0, 0];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grvHotelServiceUsage.CurrentRow.Index;
            if (i > 0)
            {
                grvHotelServiceUsage.CurrentCell = grvHotelServiceUsage[0, i - 1];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(grvHotelServiceUsage.CurrentRow.Index.ToString());
            if (i < grvHotelServiceUsage.RowCount - 1)
            {
                grvHotelServiceUsage.CurrentCell = grvHotelServiceUsage[0, i + 1];
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grvHotelServiceUsage.CurrentCell = grvHotelServiceUsage[0, grvHotelServiceUsage.RowCount - 1];
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbHotelServiceUsage);
            dv.RowFilter = $"CONVERT({cbbSearchType.SelectedValue}, 'System.String') LIKE '%{txtSearch.Text}%'";
            grvHotelServiceUsage.DataSource = dv;
        }

        private void grvHotelServiceUsage_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow row in grvHotelServiceUsage.Rows)
            {
                if (Enum.TryParse(row.Cells["status"].Value.ToString(), out HotelServiceUsageStatus status))
                {
                    row.Cells["status"].Style.BackColor = HotelServiceUsageStatusColor.Get(status).Light;
                    row.Cells["status"].Style.ForeColor = Color.FromArgb(38, 38, 38);
                    row.Cells["status"].Style.Padding = new Padding(8, 8, 8, 8);
                }
            }
        }

        private void btnManageHotelService_Click(object sender, EventArgs e)
        {
            var f = new FormHotelService();
            f.ShowDialog();
        }

        private void cbbStatusFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbHotelServiceUsage);
            int x = cbbStatusFilter.SelectedIndex;

            if (x == 0)
            {
                grvHotelServiceUsage.DataSource = dtbHotelServiceUsage;
            }
            else
            {
                dv.RowFilter = $"status = '{cbbStatusFilter.SelectedValue}'";
                grvHotelServiceUsage.DataSource = dv;
            }
        }
    }
}
