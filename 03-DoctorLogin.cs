using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectHMS
{
    public partial class DoctorLogin : Form
    {
        public DoctorLogin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void DoctorLogin_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ChooseIdenty_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btn_DocCancel_Click(object sender, EventArgs e)
        {
            DoctorLogin doctorLogin = new DoctorLogin();
            doctorLogin.Show();
            this.Hide();
        }

        private void btn_ClearDocUsername_Click(object sender, EventArgs e)
        {
            txt_DocUsername.Text = ""; //Clear TextBox
            txt_DocPassword.Text = "";
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            ChooseLogin chooseLogin = new ChooseLogin();
            chooseLogin.Show();
            this.Hide();
        }

        //Submit button of the admin login
        private void btn_DocSubmit_Click(object sender, EventArgs e)
        {
            //Check the login
            string CS = @"Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            var con = new SqlConnection(CS);

            try
            {
                con.Open();
                string stm = "SELECT * FROM DoctorDetails WHERE NIC = @NIC AND DocPassword = @DocPassword";
                var cmd = new SqlCommand(stm, con);

                cmd.Parameters.AddWithValue("@NIC", txt_DocUsername.Text);
                cmd.Parameters.AddWithValue("@DocPassword", txt_DocPassword.Text);

                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    // Login successful, open the admin dashboard
                    DoctorDashboard dashboard = new DoctorDashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");

                    txt_DocUsername.Text = "";
                    txt_DocPassword.Text = "";
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

            //Doctor Login Error Message (Null field) Pop-up
            /*if (txt_DocUsername.Text == "" && txt_DocPassword.Text == "")
            {
                MessageBox.Show("Please Enter the Username and Password Before You Login..!");
            }
            else if (txt_DocUsername.Text == "")
            {
                MessageBox.Show("Username Cannot Be Blank");
            }
            else if (txt_DocPassword.Text == "")
            {
                MessageBox.Show("Please Enter the Correct Password!");
            }

            // Doctor Login
            DoctorDashboard doctorDashboard = new DoctorDashboard();
            doctorDashboard.Show();
            this.Hide();*/
        }

        private void btn_Previous_Click_1(object sender, EventArgs e)
        {
            ChooseLogin1 chooseLogin1 = new ChooseLogin1();
            chooseLogin1.Show();
            this.Hide();
        }

        private void lbl_ForgotPassword_Click(object sender, EventArgs e)
        {
            DocForgotPassword docForgotPassword = new DocForgotPassword();
            docForgotPassword.Show();
            this.Hide();
        }

        private void lbl_ForgotPassword1_Click(object sender, EventArgs e)
        {
            DocForgotPassword docForgotPassword = new DocForgotPassword();
            docForgotPassword.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
