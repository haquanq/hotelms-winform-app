using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormRoomType : Form
    {
        public static FormRoomType _self;
        public static DataTable dtbRoomType = new DataTable();
        public FormRoomType()
        {
            InitializeComponent();
            _self = this;

            DataTable dtbSearchType = new DataTable();
            dtbSearchType.Columns.Add("value", typeof(string));
            dtbSearchType.Columns.Add("text", typeof(string));
            dtbSearchType.Rows.Add("id", "Room Type ID");
            dtbSearchType.Rows.Add("title", "Title");
            cbbSearchType.DataSource = dtbSearchType;
            cbbSearchType.DisplayMember = "text";
            cbbSearchType.ValueMember = "value";

            grvRoomType.Columns["price_per_night"].DefaultCellStyle.Format = "##,0 vnd";
        }

        private void FormHotelService_Load(object sender, EventArgs e)
        {
            HandleUserPermission();
            LoadAllRoomTypes();
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


        public void LoadAllRoomTypes()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var da = new SqlDataAdapter("select * from room_type", conn))
            {
                conn.Open();
                dtbRoomType.Clear();
                da.Fill(dtbRoomType);
                grvRoomType.DataSource = dtbRoomType;
                lblRowCount.Text = $"{dtbRoomType.Rows.Count} types";
                conn.Close();
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var f = new FormRoomTypeCreate();
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (grvRoomType.CurrentRow == null) return;
            var f = new FormRoomTypeUpdate(grvRoomType.CurrentRow.Cells["id"].Value.ToString());
            f.ShowDialog();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grvRoomType.ClearSelection();
            grvRoomType.CurrentCell = grvRoomType[0, 0];
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int i = grvRoomType.CurrentRow.Index;
            if (i > 0)
            {
                grvRoomType.CurrentCell = grvRoomType[0, i - 1];
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt16(grvRoomType.CurrentRow.Index.ToString());
            if (i < grvRoomType.RowCount - 1)
            {
                grvRoomType.CurrentCell = grvRoomType[0, i + 1];
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grvRoomType.CurrentCell = grvRoomType[0, grvRoomType.RowCount - 1];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbRoomType);
            dv.RowFilter = $"CONVERT({cbbSearchType.SelectedValue}, 'System.String') LIKE '%{txtSearch.Text}%'";
            grvRoomType.DataSource = dv;
        }
    }
}
