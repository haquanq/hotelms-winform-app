using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormCoupon : Form
    {
        public static FormCoupon _self;
        public static DataTable dtbCoupon = new DataTable();
        public FormCoupon()
        {
            InitializeComponent();
            _self = this;

            grvCoupon.Columns["expired_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvCoupon.Columns["created_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvCoupon.Columns["updated_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvCoupon.Columns["require_min_balance"].DefaultCellStyle.Format = "##,0 vnd";

            DataTable dtbSearchType = new DataTable();
            dtbSearchType.Columns.Add("value", typeof(string));
            dtbSearchType.Columns.Add("text", typeof(string));
            dtbSearchType.Rows.Add("id", "Counpon ID");
            dtbSearchType.Rows.Add("title", "Title");
            cbbCouponSearchType.DataSource = dtbSearchType;
            cbbCouponSearchType.DisplayMember = "text";
            cbbCouponSearchType.ValueMember = "value";

            DataTable dtbStatusFilter = new DataTable();
            dtbStatusFilter.Columns.Add("value", typeof(string));
            dtbStatusFilter.Columns.Add("text", typeof(string));
            dtbStatusFilter.Rows.Add("All", "All");
            dtbStatusFilter.Rows.Add("AVAILABLE", "Available");
            dtbStatusFilter.Rows.Add("UNAVAILABLE", "Unavailable");
            dtbStatusFilter.Rows.Add("EXPIRED", "Expired");
            dtbStatusFilter.Rows.Add("USED", "Used");
            cbbCouponStatusFilter.DataSource = dtbStatusFilter;
            cbbCouponStatusFilter.DisplayMember = "text";
            cbbCouponStatusFilter.ValueMember = "value";
        }

        private void FormCoupon_Load(object sender, EventArgs e)
        {
            HandleUserPermission();
            LoadAllCoupons();
        }

        private void HandleUserPermission()
        {
            if (Enum.TryParse(FormLogin.currentUser.role, out StaffRole role))
            {
                if (role == StaffRole.MANAGER)
                {
                    btnCouponCreate.Visible = true;
                    btnCouponUpdate.Visible = true;
                }
                if (role == StaffRole.RECEPTIONIST)
                {
                    btnCouponCreate.Visible = true;
                    btnCouponUpdate.Visible = true;
                }
                if (role == StaffRole.HOUSEKEEPER)
                {
                    btnCouponCreate.Visible = false;
                    btnCouponUpdate.Visible = false;
                }
                if (role == StaffRole.ADMIN)
                {
                    btnCouponCreate.Visible = false;
                    btnCouponUpdate.Visible = false;
                }
            }
        }

        public void LoadAllCoupons()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select id, coupon_code, title, rate_percent, require_min_balance, " +
                    " usage_limit, expired_at, created_at, updated_at, status from discount_coupon";
                using (var drCoupon = cmd.ExecuteReader())
                {
                    dtbCoupon.Clear();
                    dtbCoupon.Load(drCoupon);
                    grvCoupon.DataSource = dtbCoupon;
                    lblRowCount.Text = $"{dtbCoupon.Rows.Count} coupons";
                }
                conn.Close();
            }
        }

        private void btnCouponCreate_Click(object sender, EventArgs e)
        {
            var f = new FormCouponCreate();
            f.ShowDialog();
        }

        private void btnCouponUpdate_Click(object sender, EventArgs e)
        {
            if (grvCoupon.CurrentRow == null) return;
            var f = new FormCouponUpdate(grvCoupon.CurrentRow.Cells["id"].Value.ToString());
            f.ShowDialog();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grvCoupon.ClearSelection();
            grvCoupon.CurrentCell = grvCoupon[0, 0];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grvCoupon.CurrentRow.Index;
            if (i > 0)
            {
                grvCoupon.CurrentCell = grvCoupon[0, i - 1];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(grvCoupon.CurrentRow.Index.ToString());
            if (i < grvCoupon.RowCount - 1)
            {
                grvCoupon.CurrentCell = grvCoupon[0, i + 1];
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grvCoupon.CurrentCell = grvCoupon[0, grvCoupon.RowCount - 1];
        }

        private void btnCouponSearch_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbCoupon);
            dv.RowFilter = $"{cbbCouponSearchType.SelectedValue} LIKE '%{txtCouponSearch.Text}%'";
            grvCoupon.DataSource = dv;
        }

        private void cbbCouponStatusFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbCoupon);
            int x = cbbCouponStatusFilter.SelectedIndex;

            if (x == 0)
            {
                grvCoupon.DataSource = dtbCoupon;
            }
            else
            {
                dv.RowFilter = $"status = '{cbbCouponStatusFilter.SelectedValue}' ";
                grvCoupon.DataSource = dv;
            }
        }

        private void grvCoupon_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            foreach (DataGridViewRow row in grvCoupon.Rows)
            {
                if (Enum.TryParse(row.Cells["status"].Value.ToString(), out CouponStatus status))
                {
                    row.Cells["status"].Style.BackColor = CouponStatusColor.Get(status).Light;
                    row.Cells["status"].Style.ForeColor = Color.FromArgb(38, 38, 38);
                }
            }
        }
    }
}
