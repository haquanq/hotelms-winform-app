using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelMs
{
    public partial class FormLogin : Form
    {
        public class User
        {
            public string id { get; set; }
            public string name { get; set; }
            public string role { get; set; }
            public string email { get; set; }
            public string phone { get; set; }

        }

        public static User currentUser = new User();

        public FormLogin()
        {
            InitializeComponent();

            txtEmail.Text = "manager";
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 30;
            txtPassword.Text = "1";
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {

            using (var conn = new SqlConnection(Helper.GetConString()))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = $"select * from staff where email=@email and pw=@pw ";
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("pw", txtPassword.Text);
                using (var reader = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Wrong email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (dt.Rows.Count == 1)
                    {
                        var cells = dt.Rows[0];
                        if (cells["status"].ToString() == StaffStatus.DEACTIVATED.ToString())
                        {
                            MessageBox.Show("Account has been deactivated", "Deactivated", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            currentUser.id = cells["id"].ToString();
                            currentUser.name = cells["first_name"].ToString() + ' ' + cells["last_name"].ToString();
                            currentUser.role = cells["role"].ToString();
                            currentUser.email = cells["email"].ToString();
                            currentUser.phone = cells["phone"].ToString();

                            Form f = new FormHome();
                            f.Show();
                            this.Hide();

                        }
                    }

                }

                conn.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
