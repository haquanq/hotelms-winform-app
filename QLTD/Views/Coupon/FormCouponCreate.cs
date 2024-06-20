using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormCouponCreate : Form
    {
        public FormCouponCreate()
        {
            InitializeComponent();
            dtpCouponExpireTime.CustomFormat = "dd-MM-yyyy HH:mm";
        }

        private void btnCouponCreate_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Do you want to create this coupon?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.No) return;

            try
            {
                using (var conn = new SqlConnection(Helper.GetConString()))
                using (var cmd = conn.CreateCommand())
                {
                    conn.Open();
                    cmd.CommandText = "insert into discount_coupon (title, detail, coupon_code, require_min_balance, usage_limit, rate_percent, status, expired_at, created_at, updated_at) values " +
                            " (@title, @detail, @coupon_code, @require_min_balance, @usage_count, @rate_percent, @status, @expired_at, @created_at, @updated_at)";
                    cmd.Parameters.AddWithValue("@title", txtCouponTitle.Text);
                    cmd.Parameters.AddWithValue("@detail", txtCouponDetail.Text);
                    cmd.Parameters.AddWithValue("@coupon_code", txtCouponCode.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@require_min_balance", txtCouponMinBalance.Text);
                    cmd.Parameters.AddWithValue("@rate_percent", numCouponRatePercent.Value);
                    cmd.Parameters.AddWithValue("@usage_count", numCouponUsageLimit.Value);
                    cmd.Parameters.AddWithValue("@status", CouponStatus.AVAILABLE.ToString());
                    cmd.Parameters.AddWithValue("@expired_at", dtpCouponExpireTime.Value);
                    cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                    cmd.Parameters.AddWithValue("@updated_at", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                MessageBox.Show("Coupon created successfully!", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormCoupon._self?.LoadAllCoupons();
                FormReservationCheckOut._self?.LoadReservationAndAvailableCoupon();
                this.Close();
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

    }
}
