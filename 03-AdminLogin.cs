using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;

namespace FinalProjectHMS
{
    public partial class AdminLogin : Form
    {
        //private string connectionString = "Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public AdminLogin()
        {
            InitializeComponent();
        }
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void btn_ClearAdminUsername_Click(object sender, EventArgs e)
        {
            txt_AdminUsername.Text = ""; //Clear TextBox
        }

        private void btn_ClearAdminPassword_Click(object sender, EventArgs e)
        {
            txt_AdminPassword.Text = ""; //Clear TextBox
        }

        private void btn_AdminCancel_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            ChooseLogin1 chooseLogin1 = new ChooseLogin1();
            chooseLogin1.Show();
            this.Hide();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void lbl_ForgotPassword_Click(object sender, EventArgs e)
        {
            AdminForgotPassword adminForgotPassword = new AdminForgotPassword();
            adminForgotPassword.Show();
            this.Hide();
        }

        private void lbl_ForgotPassword1_Click(object sender, EventArgs e)
        {
            AdminForgotPassword adminForgotPassword = new AdminForgotPassword();
            adminForgotPassword.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Submit button of the admin login
        private void btn_AdminSubmit_Click(object sender, EventArgs e)
        {
            //Check username and password and login into the system
            string CS = @"Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            var con = new SqlConnection(CS);

            try
            {
                con.Open();
                string stm = "SELECT NIC, AdminPassword FROM AdminData WHERE NIC = @NIC AND AdminPassword = @AdminPassword";
                var cmd = new SqlCommand(stm, con);

                cmd.Parameters.AddWithValue("@NIC", txt_AdminUsername.Text);
                cmd.Parameters.AddWithValue("@AdminPassword", txt_AdminPassword.Text);

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    AdminDashboard adminDashboard = new AdminDashboard(); // Login successful, open the admin dashboard
                    adminDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");    //Error Login

                    txt_AdminUsername.Clear();
                    txt_AdminPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }


            //--------Temp code for testing
            //AdminDashboard adminDashboard = new AdminDashboard();
            //adminDashboard.Show();
            //this.Hide();


            //Admin Login Error Message (Null field) Pop-up
            /*if (txt_AdminUsername.Text == "" && txt_AdminPassword.Text == "")
            {
                MessageBox.Show("Please Enter the Username and Password Before You Login..!");
            }
            else if (txt_AdminUsername.Text == "")
            {
                MessageBox.Show("Username Cannot Be Blank");
            }
            else if (txt_AdminPassword.Text == "")
            {
                MessageBox.Show("Please Enter the Correct Password!");
            }*/
        }

        private void txt_AdminUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_AdminPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
