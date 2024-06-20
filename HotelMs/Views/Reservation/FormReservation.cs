using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormReservation : Form
    {
        public static DataTable dtbReservation = new DataTable();
        public static FormReservation _self;

        public FormReservation()
        {
            InitializeComponent();
            _self = this;

            DataTable dtbSearchType = new DataTable();
            dtbSearchType.Columns.Add("value", typeof(string));
            dtbSearchType.Columns.Add("text", typeof(string));
            dtbSearchType.Rows.Add("id", "Reservation ID");
            dtbSearchType.Rows.Add("staff_id", "Staff ID");
            dtbSearchType.Rows.Add("staff_name", "Staff Name");
            dtbSearchType.Rows.Add("customer_id", "Customer ID");
            dtbSearchType.Rows.Add("customer_name", "Customer Name");
            cbbSearchType.DataSource = dtbSearchType;
            cbbSearchType.DisplayMember = "text";
            cbbSearchType.ValueMember = "value";

            DataTable dtbStatusFilter = new DataTable();
            dtbStatusFilter.Columns.Add("value", typeof(string));
            dtbStatusFilter.Columns.Add("text", typeof(string));
            dtbStatusFilter.Rows.Add("All", "All");
            dtbStatusFilter.Rows.Add("PENDING", "Pending");
            dtbStatusFilter.Rows.Add("CHECKED_IN", "Checked in");
            dtbStatusFilter.Rows.Add("CHECKED_OUT", "Checked out");
            dtbStatusFilter.Rows.Add("CANCELLED", "Cancelled");
            cbbStatusFilter.DataSource = dtbStatusFilter;
            cbbStatusFilter.DisplayMember = "text";
            cbbStatusFilter.ValueMember = "value";

            grvReservation.Columns["total_price"].DefaultCellStyle.Format = "##,0 vnd";
            grvReservation.Columns["created_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvReservation.Columns["updated_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvReservation.Columns["arrival_time"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
            grvReservation.Columns["departure_time"].DefaultCellStyle.Format = "dd-MM-yyyy HH:mm";
        }
        private void FormRerservation_Load(object sender, EventArgs e)
        {
            HandleUserPermission();
            LoadAllReservations();
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
                else if (role == StaffRole.RECEPTIONIST)
                {
                    btnCreate.Visible = true;
                    btnUpdate.Visible = true;
                }
                else if (role == StaffRole.HOUSEKEEPER)
                {
                    btnCreate.Visible = false;
                    btnUpdate.Visible = false;
                }
                else if (role == StaffRole.ADMIN)
                {
                    btnCreate.Visible = false;
                    btnUpdate.Visible = false;
                }
            }
        }

        public void LoadAllReservations()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select a.id, b.id as customer_id, b.first_name + ' ' + b.last_name as customer_name, " +
                    "c.id as staff_id, c.first_name + ' ' + c.last_Name as staff_name, " +
                    "arrival_time, departure_time, a.created_at, a.updated_at, a.status, total_price " +
                    "from reservation a  " +
                    "left join customer b on a.customer_id = b.id " +
                    "left join staff c on a.staff_id = c.id";
                using (var dr = cmd.ExecuteReader())
                {
                    dtbReservation.Clear();
                    dtbReservation.Load(dr);
                    grvReservation.DataSource = dtbReservation;
                    lblRowCount.Text = $"{dtbReservation.Rows.Count} reservations";
                }
                conn.Close();
            }
            HandleReservationSelectionChange();
        }
        private void HandleReservationSelectionChange()
        {
            if (grvReservation.CurrentRow == null) return;

            if (Enum.TryParse(grvReservation.CurrentRow.Cells["status"].Value.ToString(), out ReservationStatus status))
            {
                if (status == ReservationStatus.CHECKED_OUT
                    || status == ReservationStatus.CANCELLED)
                {
                    btnUpdate.Visible = false;
                }
                else
                {
                    HandleUserPermission();
                    btnUpdate.Visible = btnUpdate.Visible;
                }
            }
        }


        private void btnFirst_Click(object sender, EventArgs e)
        {
            grvReservation.ClearSelection();
            grvReservation.CurrentCell = grvReservation[0, 0];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grvReservation.CurrentRow.Index;
            if (i > 0)
            {
                grvReservation.CurrentCell = grvReservation[0, i - 1];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(grvReservation.CurrentRow.Index.ToString());
            if (i < grvReservation.RowCount - 1)
            {
                grvReservation.CurrentCell = grvReservation[0, i + 1];
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grvReservation.CurrentCell = grvReservation[0, grvReservation.RowCount - 1];
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var f = new FormReservationCreate();
            f.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbReservation);
            dv.RowFilter = $"CONVERT({cbbSearchType.SelectedValue}, 'System.String') LIKE '%{txtSearch.Text}%'";
            grvReservation.DataSource = dv;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grvReservation.CurrentRow == null) return;
            var f = new FormReservationUpdate(grvReservation.CurrentRow.Cells["id"].Value.ToString());
            f.ShowDialog();
        }

        private void cbbStatusFitler_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbReservation);
            int x = cbbStatusFilter.SelectedIndex;

            if (x == 0)
            {
                grvReservation.DataSource = dtbReservation;
            }
            else
            {
                dv.RowFilter = $"status = '{cbbStatusFilter.SelectedValue}'";
                grvReservation.DataSource = dv;
            }
        }

        private void btnMoreDetail_Click(object sender, EventArgs e)
        {
            if (grvReservation.CurrentRow == null) return;
            var f = new FormReservationDetail(grvReservation.CurrentRow.Cells["id"].Value.ToString());
            f.ShowDialog();
        }

        private void grvReservation_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow row in grvReservation.Rows)
            {
                if (Enum.TryParse(row.Cells["status"].Value.ToString(), out ReservationStatus status))
                {
                    row.Cells["status"].Style.BackColor = ReservationStatusColor.Get(status).Light;
                    row.Cells["status"].Style.ForeColor = Color.FromArgb(38, 38, 38);
                }
            }
        }
        private void grvReservation_SelectionChanged(object sender, EventArgs e)
        {
            HandleReservationSelectionChange();
        }

    }
}
