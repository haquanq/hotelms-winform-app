using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormAmenity : Form
    {
        public static FormAmenity _self;
        public static DataTable dtbAmenity = new DataTable();
        public FormAmenity()
        {
            InitializeComponent();
            _self = this;

            DataTable dtbSearchType = new DataTable();
            dtbSearchType.Columns.Add("value", typeof(string));
            dtbSearchType.Columns.Add("text", typeof(string));
            dtbSearchType.Rows.Add("id", "Amenity ID");
            dtbSearchType.Rows.Add("title", "Title");
            cbbSearchType.DataSource = dtbSearchType;
            cbbSearchType.DisplayMember = "text";
            cbbSearchType.ValueMember = "value";

            DataTable dtbChargable = new DataTable();
            dtbChargable.Columns.Add("value", typeof(int));
            dtbChargable.Columns.Add("text", typeof(string));
            dtbChargable.Rows.Add(1000, "All");
            dtbChargable.Rows.Add(0, "Free");
            dtbChargable.Rows.Add(1, "Charge");
            cbbChargable.DataSource = dtbChargable;
            cbbChargable.ValueMember = "value";
            cbbChargable.DisplayMember = "text";

            grvAmenity.Columns["price"].DefaultCellStyle.Format = "##,0 vnd";
        }

        private void FormAmentiy_Load(object sender, EventArgs e)
        {
            HandleCurrentUserPermission();
            LoadAllAmenities();
        }

        private void HandleCurrentUserPermission()
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

        public void LoadAllAmenities()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var da = new SqlDataAdapter("select * from amenity", conn))
            {
                conn.Open();
                dtbAmenity.Clear();
                da.Fill(dtbAmenity);
                grvAmenity.DataSource = dtbAmenity;
                lblRowCount.Text = $"{dtbAmenity.Rows.Count} types";
                conn.Close();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var f = new FormAmenityCreate();
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grvAmenity.CurrentRow == null) return;
            var f = new FormAmenityUpdate(grvAmenity.CurrentRow.Cells["id"].Value.ToString());
            f.ShowDialog();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grvAmenity.ClearSelection();
            grvAmenity.CurrentCell = grvAmenity[0, 0];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grvAmenity.CurrentRow.Index;
            if (i > 0)
            {
                grvAmenity.CurrentCell = grvAmenity[0, i - 1];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(grvAmenity.CurrentRow.Index.ToString());
            if (i < grvAmenity.RowCount - 1)
            {
                grvAmenity.CurrentCell = grvAmenity[0, i + 1];
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grvAmenity.CurrentCell = grvAmenity[0, grvAmenity.RowCount - 1];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbAmenity);
            dv.RowFilter = $"CONVERT({cbbSearchType.SelectedValue}, 'System.String') LIKE '%{txtSearch.Text}%'";
            grvAmenity.DataSource = dv;
        }

        private void cbbChargable_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbAmenity);
            int x = cbbChargable.SelectedIndex;

            if (x == 0)
            {
                grvAmenity.DataSource = dtbAmenity;
            }
            else
            {
                dv.RowFilter = $"is_chargable = {Convert.ToBoolean(cbbChargable.SelectedValue)} ";
                grvAmenity.DataSource = dv;
            }

        }
    }
}
