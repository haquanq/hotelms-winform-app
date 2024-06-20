using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormReservationCheckOut : Form
    {
        public static FormReservationCheckOut _self;
        public DataTable dtbCoupon = new DataTable();
        private string selectedReservationId;
        private int couponMinBalance;
        private int couponRate;
        private int reservationTotalBalance;
        public FormReservationCheckOut(string selectedReservationId)
        {
            InitializeComponent();
            _self = this;
            this.selectedReservationId = selectedReservationId;

            DataTable dtbSearchType = new DataTable();
            dtbSearchType.Columns.Add("value", typeof(string));
            dtbSearchType.Columns.Add("text", typeof(string));
            dtbSearchType.Rows.Add("id", "Counpon ID");
            dtbSearchType.Rows.Add("title", "Title");
            cbbSearchType.DataSource = dtbSearchType;
            cbbSearchType.DisplayMember = "text";
            cbbSearchType.ValueMember = "value";

            grvCoupon.Columns["expired_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvCoupon.Columns["created_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvCoupon.Columns["updated_at"].DefaultCellStyle.Format = "dd-MM-yyyy";
            grvCoupon.Columns["require_min_balance"].DefaultCellStyle.Format = "##,0 vnd";

            lblCouponStatus.Text = CouponStatus.AVAILABLE.ToString();
            lblCouponStatus.ForeColor = CouponStatusColor.Get(CouponStatus.AVAILABLE).Dark;
            pnCouponStatus.BackColor = CouponStatusColor.Get(CouponStatus.AVAILABLE).Dark;
        }

        private void FormHotelService_Load(object sender, EventArgs e)
        {
            LoadReservationAndAvailableCoupon();
        }

        private void HandleCouponSelectionChange()
        {
            if (grvCoupon.CurrentRow == null) return;
            var cells = grvCoupon.CurrentRow.Cells;

            couponMinBalance = Convert.ToInt32(cells["require_min_balance"].Value);
            couponRate = Convert.ToInt32(cells["rate_percent"].Value);

            lblCouponId.Text = cells["id"].Value.ToString();
            lblCouponCode.Text = cells["coupon_code"].Value.ToString();
            lblCouponTitle.Text = cells["title"].Value.ToString();
            lblCouponDetail.Text = cells["detail"].Value?.ToString();
            lblRate.Text = cells["rate_percent"].Value.ToString();
            lblUsageLimit.Text = cells["usage_limit"].Value.ToString();
            lblMinBalance.Text = Helper.NumberToVND(Convert.ToInt32(cells["require_min_balance"].Value));
        }

        public void LoadReservationAndAvailableCoupon()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select id, coupon_code, title, detail, rate_percent, require_min_balance, " +
                    " usage_limit, expired_at, created_at, updated_at from discount_coupon where status=@status and usage_limit > 0";
                cmd.Parameters.AddWithValue("@status", CouponStatus.AVAILABLE.ToString());
                using (var reader = cmd.ExecuteReader())
                {
                    dtbCoupon.Clear();
                    dtbCoupon.Load(reader);
                    grvCoupon.DataSource = dtbCoupon;
                    lblRowCount.Text = $"{dtbCoupon.Rows.Count} coupons";
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "select a.id, b.first_name + ' ' + b.last_name as customer_name, " +
                    " b.phone, b.email, b.status as customer_status, a.arrival_time, a.departure_time, " +
                    " a.checked_in_at, a.checked_out_at, a.status as reservation_status from reservation a " +
                    " left join customer b on a.customer_id = b.id where a.id=@reservation_id";
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(reader);
                    var cells = dt.Rows[0];

                    lblReservationId.Text = cells["id"].ToString();
                    lblCustomerName.Text = cells["customer_name"].ToString();
                    lblCheckedIn.Text = DateTime.Parse(cells["checked_in_at"].ToString()).ToString("dd-MM-yyyy HH:mm");
                    lblCheckedOut.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm");

                    if (Enum.TryParse(cells["reservation_status"].ToString(), out ReservationStatus reservationStatus))
                    {
                        lblReservationStatus.Text = reservationStatus.ToString();
                        lblReservationStatus.ForeColor = ReservationStatusColor.Get(reservationStatus).Dark;
                        pnReservationStatus.BackColor = ReservationStatusColor.Get(reservationStatus).Dark;
                    }
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "select * from room_amenity_usage where status=@status and reservation_id=@reservation_id";
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                cmd.Parameters.AddWithValue("@status", RoomAmenityUsageStatus.PENDING.ToString());
                var needAllRoomChecked = cmd.ExecuteScalar();
                conn.Close();

                if (needAllRoomChecked != null)
                {
                    btnComplete.Visible = false;
                    MessageBox.Show("Need to check all room's amenity usages before check out!", "Rule", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    lblTotalBalance.Text = Helper.NumberToVND(CalculateReservationTotalBalance());
                    btnComplete.Visible = true;
                }
            }

        }

        private double CalculateReservationTotalBalance()
        {
            int totalAmenityPrice = 0;
            int totalHotelServicePrice = 0;
            int totalRoomPrice = 0;

            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select sum(a.price) from room_amenity_usage a " +
                    " left join amenity b on a.amenity_id = b.id " +
                    " where b.is_chargable=1 and a.status=@status and a.reservation_id=@reservation_id";
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                cmd.Parameters.AddWithValue("@status", RoomAmenityUsageStatus.USED.ToString());
                var amenityUsageResult = cmd.ExecuteScalar();
                if (!(amenityUsageResult is DBNull))
                {
                    totalAmenityPrice = Convert.ToInt32(amenityUsageResult);
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "select sum(price) from hotel_service_usage where status=@status and reservation_id=@reservation_id";
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                cmd.Parameters.AddWithValue("@status", HotelServiceUsageStatus.COMPLETED.ToString());
                var hotelServiceResult = cmd.ExecuteScalar();
                if (!(hotelServiceResult is DBNull))
                {
                    totalHotelServicePrice = Convert.ToInt32(hotelServiceResult);
                }

                cmd.Parameters.Clear();
                cmd.CommandText = "select sum(a.price_per_night * DATEDIFF(DAY, b.checked_in_at, GETDATE())) " +
                    " from reservation_room a left join reservation b on a.reservation_id = b.id where reservation_id=@reservation_id";
                cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                totalRoomPrice = Convert.ToInt32(cmd.ExecuteScalar());

                conn.Close();
            }

            reservationTotalBalance = totalAmenityPrice + totalHotelServicePrice + totalRoomPrice;
            return reservationTotalBalance;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            var f = new FormCouponCreate();
            f.ShowDialog();
        }

        private void btnUpdateCoupon_Click(object sender, EventArgs e)
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

        private void searchBtn_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(dtbCoupon);
            dv.RowFilter = $"{cbbSearchType.SelectedValue} LIKE '%{txtSearch.Text}%'";
            grvCoupon.DataSource = dv;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grvCoupon_SelectionChanged(object sender, EventArgs e)
        {
            HandleCouponSelectionChange();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (ckbUseCoupon.Checked)
            {
                if (reservationTotalBalance >= couponMinBalance)
                {
                    reservationTotalBalance -= (reservationTotalBalance * couponRate) / 100;
                }
                else
                {
                    MessageBox.Show("Coupon minimum balance did not meet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            DialogResult res = MessageBox.Show("Do you want to check out this reservation?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            SqlTransaction transaction = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    transaction = conn.BeginTransaction();
                    cmd.Transaction = transaction;

                    cmd.CommandText = "update room set status=@status " +
                        " where id in (select room_id from reservation_room where reservation_id=@reservation_id)";
                    cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                    cmd.Parameters.AddWithValue("@status", RoomStatus.VACANT_DIRTY.ToString());
                    cmd.ExecuteNonQuery();

                    cmd.Parameters.Clear();
                    cmd.CommandText = "update reservation set status=@status, total_price=@total_price, checked_out_at=@checked_out_at where id=@reservation_id ";

                    if (ckbUseCoupon.Checked)
                    {
                        cmd.CommandText = "update reservation set status=@status, checked_out_at=@checked_out_at, discount_coupon_id=@discount_coupon_id, " +
                                " total_price=@total_price where id=@reservation_id ";
                        cmd.Parameters.AddWithValue("@discount_coupon_id", lblCouponId.Text);
                    }

                    cmd.Parameters.AddWithValue("@reservation_id", selectedReservationId);
                    cmd.Parameters.AddWithValue("@total_price", reservationTotalBalance);
                    cmd.Parameters.AddWithValue("@checked_out_at", DateTime.Now);
                    cmd.Parameters.AddWithValue("@status", ReservationStatus.CHECKED_OUT.ToString());
                    cmd.ExecuteNonQuery();

                    if (ckbUseCoupon.Checked)
                    {
                        cmd.Parameters.Clear();
                        cmd.CommandText = "update discount_coupon set updated_at=GETDATE(), usage_limit=usage_limit-1, " +
                            " status = case when usage_limit-1=0 then @status1 else status end " +
                            " where id=@discount_coupon_id and status=@status2";
                        cmd.Parameters.AddWithValue("@discount_coupon_id", lblCouponId.Text);
                        cmd.Parameters.AddWithValue("@status1", CouponStatus.USED.ToString());
                        cmd.Parameters.AddWithValue("@status2", CouponStatus.AVAILABLE.ToString());
                        cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    conn.Close();
                }

                MessageBox.Show("Reservation checked out successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormReservationDetail._self.LoadReservationBySelectedId();
                FormReservation._self?.LoadAllReservations();
                FormDashboard._self?.LoadRoomStatusAndReservation();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!");
                transaction.Rollback();
                transaction.Dispose();
            }

        }
    }
}
