using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormHotelService : Form
    {
        public static FormHotelService _self;
        public static DataTable dtbHotelService = new DataTable();
        public FormHotelService()
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
        }

        private void FormHotelService_Load(object sender, EventArgs e)
        {
            HandleUserPermission();
            LoadAllHotelService();
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

        public void LoadAllHotelService()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var da = new SqlDataAdapter("select * from hotel_service", conn))
            {
                dtbHotelService.Clear();
                da.Fill(dtbHotelService);
                grvHotelSerivce.DataSource = dtbHotelService;
                lblRowCount.Text = $"{dtbHotelService.Rows.Count} services";
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var f = new FormHotelServiceCreate();
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grvHotelSerivce.CurrentRow == null) return;
            var f = new FormHotelSerivceUpdate(grvHotelSerivce.CurrentRow.Cells["id"].Value.ToString());
            f.ShowDialog();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grvHotelSerivce.ClearSelection();
            grvHotelSerivce.CurrentCell = grvHotelSerivce[0, 0];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grvHotelSerivce.CurrentRow.Index;
            if (i > 0)
            {
                grvHotelSerivce.CurrentCell = grvHotelSerivce[0, i - 1];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(grvHotelSerivce.CurrentRow.Index.ToString());
            if (i < grvHotelSerivce.RowCount - 1)
            {
                grvHotelSerivce.CurrentCell = grvHotelSerivce[0, i + 1];
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grvHotelSerivce.CurrentCell = grvHotelSerivce[0, grvHotelSerivce.RowCount - 1];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbHotelService);
            dv.RowFilter = $"CONVERT({cbbSearchType.SelectedValue}, 'System.String') LIKE '%{txtSearch.Text}%'";
            grvHotelSerivce.DataSource = dv;
        }
    }
}
