using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormCouponUpdate : Form
    {
        private string selectedCouponId;
        public FormCouponUpdate(string selectedCouponId)
        {
            InitializeComponent();
            this.selectedCouponId = selectedCouponId;

            DataTable dtbStatus = new DataTable();
            dtbStatus.Columns.Add("value", typeof(string));
            dtbStatus.Columns.Add("text", typeof(string));
            dtbStatus.Rows.Add("AVAILABLE", "Avalable");
            dtbStatus.Rows.Add("UNAVAILABLE", "Unavalable");
            dtbStatus.Rows.Add("EXPIRED", "Expired");
            dtbStatus.Rows.Add("USED", "Used");
            cbbStatus.DataSource = dtbStatus;
            cbbStatus.DisplayMember = "text";
            cbbStatus.ValueMember = "value";

            dtpExpireTime.CustomFormat = "dd-MM-yyyy HH:mm";
        }

        private void FormCouponUpdate_Load(object sender, EventArgs e)
        {
            LoadCouponById();
        }

        private void LoadCouponById()
        {
            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "select * from discount_coupon where id=@coupon_id";
                cmd.Parameters.AddWithValue("coupon_id", selectedCouponId);
                using (var reader = cmd.ExecuteReader())
                {
                    var dt = new DataTable();
                    dt.Load(reader);
                    var cells = dt.Rows[0];

                    lblCouponId.Text = cells["id"].ToString();
                    txtTitle.Text = cells["title"].ToString();
                    txtDetail.Text = cells["detail"].ToString();
                    txtMinBalance.Text = cells["require_min_balance"].ToString();
                    txtCouponCode.Text = cells["coupon_code"].ToString();
                    numRate.Value = Convert.ToInt32(cells["rate_percent"]);
                    numUsageCount.Value = Convert.ToInt32(cells["usage_limit"]);
                    dtpExpireTime.Value = DateTime.Parse(cells["expired_at"].ToString());
                    lblCreatedAt.Text = DateTime.Parse(cells["created_at"].ToString()).ToString("dd-MM-yyyy HH:mm");
                    lblUpdatedAt.Text = DateTime.Parse(cells["updated_at"].ToString()).ToString("dd-MM-yyyy HH:mm");

                    if (Enum.TryParse(cells["status"].ToString(), out CouponStatus couponStatus))
                    {
                        cbbStatus.SelectedValue = couponStatus;
                        lblCouponStatus.Text = couponStatus.ToString();
                        lblCouponStatus.ForeColor = CouponStatusColor.Get(couponStatus).Dark;
                        pnCouponStatus.BackColor = CouponStatusColor.Get(couponStatus).Dark;
                    }
                }
                conn.Close();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to save these changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {
                using (var conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "update discount_coupon set title=@title, detail=@detail, coupon_code=@coupon_code, require_min_balance=@min_bal, " +
                        " rate_percent=@rate, expired_at=@expired_at, updated_at=GETDATE(), status=@status where id = @coupon_id";

                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@detail", txtDetail.Text);
                    cmd.Parameters.AddWithValue("@coupon_code", txtCouponCode.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@min_bal", txtMinBalance.Text);
                    cmd.Parameters.AddWithValue("@rate", numRate.Value);
                    cmd.Parameters.AddWithValue("@expired_at", dtpExpireTime.Value);
                    cmd.Parameters.AddWithValue("@status", cbbStatus.SelectedValue);
                    cmd.Parameters.AddWithValue("@coupon_id", lblCouponId.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                this.Close();
                MessageBox.Show("Changes saved successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormCoupon._self?.LoadAllCoupons();
                FormReservationCheckOut._self?.LoadReservationAndAvailableCoupon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred!");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Do you want to delete this record!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {
                using (var conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = $"delete from discount_coupon where id=@coupon_id ";
                    cmd.Parameters.AddWithValue("@coupon_id", lblCouponId.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                this.Close();
                MessageBox.Show("Coupon deleted successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormCoupon._self?.LoadAllCoupons();
                FormReservationCheckOut._self?.LoadReservationAndAvailableCoupon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ocurred!");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (Enum.TryParse(cbbStatus.SelectedValue.ToString(), out CouponStatus couponStatus))
            {
                lblCouponStatus.Text = couponStatus.ToString();
                lblCouponStatus.ForeColor = CouponStatusColor.Get(couponStatus).Dark;
                pnCouponStatus.BackColor = CouponStatusColor.Get(couponStatus).Dark;
            }
        }
    }
}
