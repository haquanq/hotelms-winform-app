using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();

            dtpReportRoomFrom.CustomFormat = "dd-MM-yyyy";
            dtpReportRoomTo.CustomFormat = "dd-MM-yyyy";
            dtpReportHotelFrom.CustomFormat = "dd-MM-yyyy";
            dtpReportHotelTo.CustomFormat = "dd-MM-yyyy";
            dtpReportCustomerFrom.CustomFormat = "dd-MM-yyyy";
            dtpReportCustomerTo.CustomFormat = "dd-MM-yyyy";

            DataTable dtbReportHotelPeriod = new DataTable();
            dtbReportHotelPeriod.Columns.Add("value", typeof(string));
            dtbReportHotelPeriod.Columns.Add("text", typeof(string));
            dtbReportHotelPeriod.Rows.Add("custom", "Custom");
            dtbReportHotelPeriod.Rows.Add("1", "Jannuary");
            dtbReportHotelPeriod.Rows.Add("2", "February");
            dtbReportHotelPeriod.Rows.Add("3", "March");
            dtbReportHotelPeriod.Rows.Add("4", "April");
            dtbReportHotelPeriod.Rows.Add("5", "May");
            dtbReportHotelPeriod.Rows.Add("6", "June");
            dtbReportHotelPeriod.Rows.Add("7", "July");
            dtbReportHotelPeriod.Rows.Add("8", "August");
            dtbReportHotelPeriod.Rows.Add("9", "September");
            dtbReportHotelPeriod.Rows.Add("10", "October");
            dtbReportHotelPeriod.Rows.Add("11", "November");
            dtbReportHotelPeriod.Rows.Add("12", "December");
            dtbReportHotelPeriod.Rows.Add("q1", "1st Quarter");
            dtbReportHotelPeriod.Rows.Add("q2", "2nd Quarter");
            dtbReportHotelPeriod.Rows.Add("q3", "3rd Quarter");
            dtbReportHotelPeriod.Rows.Add("q4", "4th Quarter");
            cbbReportHotelPeriod.DataSource = dtbReportHotelPeriod;
            cbbReportHotelPeriod.DisplayMember = "text";
            cbbReportHotelPeriod.ValueMember = "value";


            DataTable dtbReportRoomPeriod = new DataTable();
            dtbReportRoomPeriod.Columns.Add("value", typeof(string));
            dtbReportRoomPeriod.Columns.Add("text", typeof(string));
            dtbReportRoomPeriod.Rows.Add("custom", "Custom");
            dtbReportRoomPeriod.Rows.Add("1", "Jannuary");
            dtbReportRoomPeriod.Rows.Add("2", "February");
            dtbReportRoomPeriod.Rows.Add("3", "March");
            dtbReportRoomPeriod.Rows.Add("4", "April");
            dtbReportRoomPeriod.Rows.Add("5", "May");
            dtbReportRoomPeriod.Rows.Add("6", "June");
            dtbReportRoomPeriod.Rows.Add("7", "July");
            dtbReportRoomPeriod.Rows.Add("8", "August");
            dtbReportRoomPeriod.Rows.Add("9", "September");
            dtbReportRoomPeriod.Rows.Add("10", "October");
            dtbReportRoomPeriod.Rows.Add("11", "November");
            dtbReportRoomPeriod.Rows.Add("12", "December");
            dtbReportRoomPeriod.Rows.Add("q1", "1st Quarter");
            dtbReportRoomPeriod.Rows.Add("q2", "2nd Quarter");
            dtbReportRoomPeriod.Rows.Add("q3", "3rd Quarter");
            dtbReportRoomPeriod.Rows.Add("q4", "4th Quarter");
            cbbReportRoomPeriod.DataSource = dtbReportRoomPeriod;
            cbbReportRoomPeriod.DisplayMember = "text";
            cbbReportRoomPeriod.ValueMember = "value";

            DataTable dtbReportCustomerPeriod = new DataTable();
            dtbReportCustomerPeriod.Columns.Add("value", typeof(string));
            dtbReportCustomerPeriod.Columns.Add("text", typeof(string));
            dtbReportCustomerPeriod.Rows.Add("custom", "Custom");
            dtbReportCustomerPeriod.Rows.Add("1", "Jannuary");
            dtbReportCustomerPeriod.Rows.Add("2", "February");
            dtbReportCustomerPeriod.Rows.Add("3", "March");
            dtbReportCustomerPeriod.Rows.Add("4", "April");
            dtbReportCustomerPeriod.Rows.Add("5", "May");
            dtbReportCustomerPeriod.Rows.Add("6", "June");
            dtbReportCustomerPeriod.Rows.Add("7", "July");
            dtbReportCustomerPeriod.Rows.Add("8", "August");
            dtbReportCustomerPeriod.Rows.Add("9", "September");
            dtbReportCustomerPeriod.Rows.Add("10", "October");
            dtbReportCustomerPeriod.Rows.Add("11", "November");
            dtbReportCustomerPeriod.Rows.Add("12", "December");
            dtbReportCustomerPeriod.Rows.Add("q1", "1st Quarter");
            dtbReportCustomerPeriod.Rows.Add("q2", "2nd Quarter");
            dtbReportCustomerPeriod.Rows.Add("q3", "3rd Quarter");
            dtbReportCustomerPeriod.Rows.Add("q4", "4th Quarter");
            cbbReportCustomerPeriod.DataSource = dtbReportCustomerPeriod;
            cbbReportCustomerPeriod.DisplayMember = "text";
            cbbReportCustomerPeriod.ValueMember = "value";

            DataTable dtbCustomerStatusFitler = new DataTable();
            dtbCustomerStatusFitler.Columns.Add("value", typeof(string));
            dtbCustomerStatusFitler.Columns.Add("text", typeof(string));
            dtbCustomerStatusFitler.Rows.Add("All", "All");
            dtbCustomerStatusFitler.Rows.Add("NEW", "New");
            dtbCustomerStatusFitler.Rows.Add("COMMON", "Common");
            dtbCustomerStatusFitler.Rows.Add("VIP", "Vip");
            cbbCustomerStatusFilter.DataSource = dtbCustomerStatusFitler;
            cbbCustomerStatusFilter.DisplayMember = "text";
            cbbCustomerStatusFilter.ValueMember = "value";

            DataTable dtbStaffStatusFilter = new DataTable();
            dtbStaffStatusFilter.Columns.Add("value", typeof(string));
            dtbStaffStatusFilter.Columns.Add("text", typeof(string));
            dtbStaffStatusFilter.Rows.Add("All", "All");
            dtbStaffStatusFilter.Rows.Add("ACTIVATED", "Activated");
            dtbStaffStatusFilter.Rows.Add("DEACTIVATED", "Deactivated");
            cbbStaffStatusFilter2.DataSource = dtbStaffStatusFilter;
            cbbStaffStatusFilter2.DisplayMember = "text";
            cbbStaffStatusFilter2.ValueMember = "value";

            DataTable dtbRoomStatusFilter = new DataTable();
            dtbRoomStatusFilter.Columns.Add("value", typeof(string));
            dtbRoomStatusFilter.Columns.Add("text", typeof(string));
            dtbRoomStatusFilter.Rows.Add("All", "All");
            dtbRoomStatusFilter.Rows.Add("READY", "Ready to use");
            dtbRoomStatusFilter.Rows.Add("VACANT_DIRTY", "Dirty rooms");
            dtbRoomStatusFilter.Rows.Add("CLEAN_VACANT", "Clean rooms");
            dtbRoomStatusFilter.Rows.Add("BOOKED", "Booked rooms");
            dtbRoomStatusFilter.Rows.Add("OCCUPIED", "Occupied rooms");
            dtbRoomStatusFilter.Rows.Add("MAINTAINENCE", "Maintainence");
            cbbRoomStatusFilter2.DataSource = dtbRoomStatusFilter;
            cbbRoomStatusFilter2.DisplayMember = "text";
            cbbRoomStatusFilter2.ValueMember = "value";

            DataTable dtbCustomerStatusFitler2 = new DataTable();
            dtbCustomerStatusFitler2.Columns.Add("value", typeof(string));
            dtbCustomerStatusFitler2.Columns.Add("text", typeof(string));
            dtbCustomerStatusFitler2.Rows.Add("All", "All");
            dtbCustomerStatusFitler2.Rows.Add("NEW", "New");
            dtbCustomerStatusFitler2.Rows.Add("COMMON", "Common");
            dtbCustomerStatusFitler2.Rows.Add("VIP", "Vip");
            cbbCustomerStatusFilter2.DataSource = dtbCustomerStatusFitler2;
            cbbCustomerStatusFilter2.DisplayMember = "text";
            cbbCustomerStatusFilter2.ValueMember = "value";

        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            LoadAllRoomType();
        }

        private void LoadAllRoomType()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = $"select id, title from room_type";
                using (var dr = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(dr);
                    DataRow row = dt.NewRow();
                    row["title"] = "All";
                    row["id"] = 9999999;
                    dt.Rows.InsertAt(row, 0);
                    cbbRoomTypeFilter.DataSource = dt;
                    cbbRoomTypeFilter.DisplayMember = "title";
                    cbbRoomTypeFilter.ValueMember = "id";
                }
                conn.Close();
            }
        }

        private void cbbReportRoomPeriod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string select = cbbReportRoomPeriod.SelectedValue.ToString();
            var from = DateTime.Now;
            var to = DateTime.Now;

            if (select == "custom")
            {
                dtpReportRoomFrom.Enabled = true;
                dtpReportRoomTo.Enabled = true;
                from = DateTime.Now;
                to = DateTime.Now;
            }
            else
            {
                if (select.Length == 1)
                {

                    from = new DateTime(DateTime.Now.Year, Convert.ToInt32(select), 1);
                    to = from.AddMonths(1).AddDays(-1);
                }
                if (select.StartsWith("q"))
                {
                    var dict = new Dictionary<string, int>() {
                    { "q1", 1 },
                    { "q2", 4 },
                    { "q3", 7 },
                    { "q4", 10 },
                        };
                    from = new DateTime(DateTime.Now.Year, dict[select], 1);
                    to = from.AddMonths(3).AddDays(-1);
                }
                dtpReportRoomFrom.Enabled = false;
                dtpReportRoomTo.Enabled = false;
                dtpReportRoomFrom.Value = from;
                dtpReportRoomTo.Value = to;
            }
        }

        private void btnReportRoomRevenue_Click(object sender, EventArgs e)
        {
            var dtbRoomRevenue = new DataTable();
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {

                conn.Open();
                cmd.CommandText = "begin " +
                        " with completed_reservation as " +
                        " ( select a.id as reservation_id, b.rate_percent as discount_percent, " +
                        " DATEDIFF(day, a.checked_in_at, a.checked_out_at) as duration " +
                        " from reservation a " +
                        " left join discount_coupon b on a.discount_coupon_id = b.id " +
                        " where a.status = @status and a.checked_out_at between @from and @to) " +

                        " select a.room_code, a.floor_number, b.title as room_type, " +
                        " COALESCE(sum(case when d.discount_percent is not null  " +
                        " then c.price_per_night * d.duration * (100-d.discount_percent)/100  " +
                        " else c.price_per_night * d.duration end), 0) as revenue " +
                        " from room a " +
                        " left join room_type b on a.room_type_id = b.id " +
                        " left join reservation_room c on a.id = c.room_id " +
                        " left join completed_reservation d on c.reservation_id = d.reservation_id ";
                cmd.Parameters.AddWithValue("@status", ReservationStatus.CHECKED_OUT.ToString());
                cmd.Parameters.AddWithValue("@from", dtpReportRoomFrom.Value);
                cmd.Parameters.AddWithValue("@to", dtpReportRoomTo.Value);
                if (cbbRoomTypeFilter.SelectedIndex != 0)
                {
                    cmd.CommandText += " where a.room_type_id=@room_type_id";
                    cmd.Parameters.AddWithValue("@room_type_id", cbbRoomTypeFilter.SelectedValue);
                }
                cmd.CommandText += " group by a.room_code, a.floor_number, b.title end";

                using (var dr = cmd.ExecuteReader())
                {
                    dtbRoomRevenue.Load(dr);
                }
                conn.Close();
            }

            if (dtbRoomRevenue.Rows.Count == 0)
            {
                MessageBox.Show("No record found to be reported!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var viewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local,
            };

            viewer.LocalReport.ReportPath = Path.Combine(Application.StartupPath, @"../../Views/Report/ReportRoomRevenue.rdlc");
            viewer.LocalReport.SetParameters(new ReportParameter[]
            {
                    new ReportParameter("current_date", DateTime.Now.ToString("dd/MM/yyyy")),
                    new ReportParameter("from_date", dtpReportRoomFrom.Value.ToString("dd-MM-yyyy")),
                    new ReportParameter("to_date", dtpReportRoomTo.Value.ToString("dd-MM-yyyy")),
                    new ReportParameter("staff_creator_name", FormLogin.currentUser.name),
                    new ReportParameter("room_type", cbbRoomTypeFilter.Text),
            });
            viewer.LocalReport.DataSources.Add(new ReportDataSource("DS", dtbRoomRevenue));
            viewer.RefreshReport();

            var bytes = viewer.LocalReport.Render("PDF", "", out _, out _, out _, out _, out _);

            Helper.SaveReportFileToFolders(bytes);
        }

        private void cbbReportCustomerPeriod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string select = cbbReportCustomerPeriod.SelectedValue.ToString();
            var from = DateTime.Now;
            var to = DateTime.Now;

            if (select == "custom")
            {
                dtpReportCustomerFrom.Enabled = true;
                dtpReportCustomerTo.Enabled = true;
                from = DateTime.Now;
                to = DateTime.Now;
            }
            else
            {
                if (select.Length == 1)
                {

                    from = new DateTime(DateTime.Now.Year, Convert.ToInt32(select), 1);
                    to = from.AddMonths(1).AddDays(-1);
                }
                if (select.StartsWith("q"))
                {
                    var dict = new Dictionary<string, int>() {
                    { "q1", 1 },
                    { "q2", 4 },
                    { "q3", 7 },
                    { "q4", 10 },
                        };
                    from = new DateTime(DateTime.Now.Year, dict[select], 1);
                    to = from.AddMonths(3).AddDays(-1);
                }
                dtpReportCustomerFrom.Enabled = false;
                dtpReportCustomerTo.Enabled = false;
                dtpReportCustomerFrom.Value = from;
                dtpReportCustomerTo.Value = to;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dtbCustomerBalance = new DataTable();
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {

                conn.Open();
                cmd.CommandText = "select a.id, a.first_name + ' ' + a.last_name as full_name, " +
                    " a.address, a.phone, a.email, sum(b.total_price) as balance from customer a  " +
                    " join reservation b on a.id = b.customer_id " +
                    " where b.status=@reservation_status and b.checked_out_at between @from and @to ";

                cmd.Parameters.AddWithValue("@reservation_status", ReservationStatus.CHECKED_OUT.ToString());
                cmd.Parameters.AddWithValue("@from", dtpReportCustomerFrom.Value);
                cmd.Parameters.AddWithValue("@to", dtpReportCustomerTo.Value);

                if (cbbCustomerStatusFilter.SelectedIndex != 0)
                {
                    cmd.CommandText += " and a.status=@customer_status";
                    cmd.Parameters.AddWithValue("@customer_status", cbbCustomerStatusFilter.SelectedValue);
                }
                cmd.CommandText += " group by a.id, a.first_name, a.last_name, a.address, a.phone, a.email";

                using (var dr = cmd.ExecuteReader())
                {
                    dtbCustomerBalance.Load(dr);
                }
                conn.Close();

            }

            if (dtbCustomerBalance.Rows.Count == 0)
            {
                MessageBox.Show("No record found to be reported!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var viewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local,
            };

            viewer.LocalReport.ReportPath = Path.Combine(Application.StartupPath, @"../../Views/Report/ReportCustomerBalance.rdlc");
            viewer.LocalReport.SetParameters(new ReportParameter[]
            {
                    new ReportParameter("current_date", DateTime.Now.ToString("dd/MM/yyyy")),
                    new ReportParameter("from_date", dtpReportRoomFrom.Value.ToString("dd-MM-yyyy")),
                    new ReportParameter("to_date", dtpReportRoomTo.Value.ToString("dd-MM-yyyy")),
                    new ReportParameter("staff_creator_name", FormLogin.currentUser.name),
                    new ReportParameter("customer_status", cbbCustomerStatusFilter.Text),
            });
            viewer.LocalReport.DataSources.Add(new ReportDataSource("DS", dtbCustomerBalance));
            viewer.RefreshReport();

            var bytes = viewer.LocalReport.Render("PDF", "", out _, out _, out _, out _, out _);

            Helper.SaveReportFileToFolders(bytes);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dtbCustomer = new DataTable();
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {

                conn.Open();
                cmd.CommandText = "select a.id, a.first_name + ' ' + a.last_name as name, " +
                    " a.address, a.phone, a.email, a.status from customer a";
                if (cbbCustomerStatusFilter2.SelectedIndex != 0)
                {
                    cmd.CommandText += " where a.status=@status";
                    cmd.Parameters.AddWithValue("@status", cbbCustomerStatusFilter.SelectedValue);
                }
                using (var dr = cmd.ExecuteReader())
                {
                    dtbCustomer.Load(dr);
                }
                conn.Close();
            }

            if (dtbCustomer.Rows.Count == 0)
            {
                MessageBox.Show("No record found to be reported!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var viewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local,
            };

            viewer.LocalReport.ReportPath = Path.Combine(Application.StartupPath, @"../../Views/Report/ReportCustomerList.rdlc");
            viewer.LocalReport.SetParameters(new ReportParameter[]
            {
                    new ReportParameter("current_date", DateTime.Now.ToString("dd/MM/yyyy")),
                    new ReportParameter("staff_creator_name", FormLogin.currentUser.name),
                    new ReportParameter("customer_status", cbbCustomerStatusFilter2.Text),
                    new ReportParameter("customer_count", dtbCustomer.Rows.Count.ToString() + " customers"),
            });
            viewer.LocalReport.DataSources.Add(new ReportDataSource("DS", dtbCustomer));
            viewer.RefreshReport();

            var bytes = viewer.LocalReport.Render("PDF", "", out _, out _, out _, out _, out _);

            Helper.SaveReportFileToFolders(bytes);
        }

        private void btnReportStaff_Click(object sender, EventArgs e)
        {

            var dtbStaff = new DataTable();
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {

                conn.Open();
                cmd.CommandText = "select a.id, a.first_name + ' ' + a.last_name as name, " +
                    " a.dob, a.phone, a.email, a.role, a.status from staff a";
                if (cbbCustomerStatusFilter2.SelectedIndex != 0)
                {
                    cmd.CommandText += " where a.status=@status";
                    cmd.Parameters.AddWithValue("@status", cbbStaffStatusFilter2.SelectedValue);
                }
                using (var dr = cmd.ExecuteReader())
                {
                    dtbStaff.Load(dr);
                }
                conn.Close();
            }

            if (dtbStaff.Rows.Count == 0)
            {
                MessageBox.Show("No record found to be reported!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var viewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local,
            };

            viewer.LocalReport.ReportPath = Path.Combine(Application.StartupPath, @"../../Views/Report/ReportStaffList.rdlc");
            viewer.LocalReport.SetParameters(new ReportParameter[]
            {
                    new ReportParameter("current_date", DateTime.Now.ToString("dd/MM/yyyy")),
                    new ReportParameter("staff_creator_name", FormLogin.currentUser.name),
                    new ReportParameter("staff_status", cbbStaffStatusFilter2.Text),
                    new ReportParameter("staff_count", dtbStaff.Rows.Count.ToString() + " staff"),
            });
            viewer.LocalReport.DataSources.Add(new ReportDataSource("DS", dtbStaff));
            viewer.RefreshReport();

            var bytes = viewer.LocalReport.Render("PDF", "", out _, out _, out _, out _, out _);

            Helper.SaveReportFileToFolders(bytes);

        }

        private void btnReportRoomList_Click(object sender, EventArgs e)
        {
            var dtbRoom = new DataTable();
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {

                conn.Open();
                cmd.CommandText = "select a.id, a.room_code, a.floor_number, b.title as room_type, b.price_per_night, a.status from room a " +
                    " left join room_type b on a.room_type_id = b.id";
                if (cbbCustomerStatusFilter2.SelectedIndex != 0)
                {
                    cmd.CommandText += " where a.status=@status";
                    cmd.Parameters.AddWithValue("@status", cbbRoomStatusFilter2.SelectedValue);
                }
                using (var dr = cmd.ExecuteReader())
                {
                    dtbRoom.Load(dr);
                }
                conn.Close();
            }

            if (dtbRoom.Rows.Count == 0)
            {
                MessageBox.Show("No record found to be reported!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var viewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local,
            };

            viewer.LocalReport.ReportPath = Path.Combine(Application.StartupPath, @"../../Views/Report/ReportRoomList.rdlc");
            viewer.LocalReport.SetParameters(new ReportParameter[]
            {
                    new ReportParameter("current_date", DateTime.Now.ToString("dd/MM/yyyy")),
                    new ReportParameter("staff_creator_name", FormLogin.currentUser.name),
                    new ReportParameter("room_status", cbbStaffStatusFilter2.Text),
                    new ReportParameter("room_count", dtbRoom.Rows.Count.ToString() + " rooms"),
            });
            viewer.LocalReport.DataSources.Add(new ReportDataSource("DS", dtbRoom));
            viewer.RefreshReport();

            var bytes = viewer.LocalReport.Render("PDF", "", out _, out _, out _, out _, out _);

            Helper.SaveReportFileToFolders(bytes);

        }

        private void btnReportHotelRevenue_Click(object sender, EventArgs e)
        {
            var dtbHotelRevenue = new DataTable();
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {

                conn.Open();
                cmd.CommandText = "select a.id, b.first_name + ' ' + b.last_name as customer_name, a.checked_in_at, a.checked_out_at, a.total_price from reservation a " +
                    " left join customer b on a.customer_id = b.id where a.status=@status and a.checked_out_at between @from and @to";
                cmd.Parameters.AddWithValue("@status", ReservationStatus.CHECKED_OUT.ToString());
                cmd.Parameters.AddWithValue("@from", dtpReportHotelFrom.Value);
                cmd.Parameters.AddWithValue("@to", dtpReportHotelTo.Value);
                using (var dr = cmd.ExecuteReader())
                {
                    dtbHotelRevenue.Load(dr);
                }
                conn.Close();
            }

            if (dtbHotelRevenue.Rows.Count == 0)
            {
                MessageBox.Show("No record found to be reported!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var viewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Local,
            };

            viewer.LocalReport.ReportPath = Path.Combine(Application.StartupPath, @"../../Views/Report/ReportHotelRevenue.rdlc");
            viewer.LocalReport.SetParameters(new ReportParameter[]
            {
                    new ReportParameter("current_date", DateTime.Now.ToString("dd/MM/yyyy")),
                    new ReportParameter("staff_creator_name", FormLogin.currentUser.name),
                    new ReportParameter("from_date", dtpReportHotelFrom.Text),
                    new ReportParameter("to_date", dtpReportHotelTo.Text),
            });
            viewer.LocalReport.DataSources.Add(new ReportDataSource("DS", dtbHotelRevenue));
            viewer.RefreshReport();

            var bytes = viewer.LocalReport.Render("PDF", "", out _, out _, out _, out _, out _);

            Helper.SaveReportFileToFolders(bytes);

        }

        private void cbbReportHotelPeriod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string select = cbbReportHotelPeriod.SelectedValue.ToString();
            var from = DateTime.Now;
            var to = DateTime.Now;

            if (select == "custom")
            {
                dtpReportHotelFrom.Enabled = true;
                dtpReportHotelTo.Enabled = true;
                from = DateTime.Now;
                to = DateTime.Now;
            }
            else
            {
                if (select.Length == 1)
                {

                    from = new DateTime(DateTime.Now.Year, Convert.ToInt32(select), 1);
                    to = from.AddMonths(1).AddDays(-1);
                }
                if (select.StartsWith("q"))
                {
                    var dict = new Dictionary<string, int>() {
                    { "q1", 1 },
                    { "q2", 4 },
                    { "q3", 7 },
                    { "q4", 10 },
                        };
                    from = new DateTime(DateTime.Now.Year, dict[select], 1);
                    to = from.AddMonths(3).AddDays(-1);
                }
                dtpReportHotelFrom.Enabled = false;
                dtpReportHotelTo.Enabled = false;
                dtpReportHotelFrom.Value = from;
                dtpReportHotelTo.Value = to;
            }

        }
    }
}
