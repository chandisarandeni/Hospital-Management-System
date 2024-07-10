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
    public partial class PatientLogin : Form
    {
        public PatientLogin()
        {
            InitializeComponent();
        }

        private void btn_ClearPatientUsername_Click(object sender, EventArgs e)
        {
            txt_PatientUsername.Text = "";
        }

        private void btn_ClearPatientPassword_Click(object sender, EventArgs e)
        {
            txt_PatientPassword.Text = "";
        }

        private void btn_AdminCancel_Click(object sender, EventArgs e)
        {
            PatientLogin patientLogin = new PatientLogin();
            patientLogin.Show();
            this.Hide();
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            ChooseLogin1 chooseLogin1 = new ChooseLogin1();
            chooseLogin1.Show();
            this.Hide();
        }

        private void lbl_ForgotPassword_Click(object sender, EventArgs e)
        {
            PatientForgotPassword patientForgotPassword = new PatientForgotPassword();
            patientForgotPassword.Show();
            this.Hide();
        }

        private void lbl_ForgotPassword1_Click(object sender, EventArgs e)
        {
            PatientForgotPassword patientForgotPassword = new PatientForgotPassword();
            patientForgotPassword.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_AdminSubmit_Click(object sender, EventArgs e)
        {
            // Check the login
            string CS = @"Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection con = new SqlConnection(CS))
            {
                try
                {
                    con.Open();
                    string stm = "SELECT NIC, PatientPassword FROM PatientData WHERE NIC = @NIC AND PatientPassword = @PatientPassword";
                    SqlCommand cmd = new SqlCommand(stm, con);

                    cmd.Parameters.AddWithValue("@NIC", txt_PatientUsername.Text);
                    cmd.Parameters.AddWithValue("@PatientPassword", txt_PatientPassword.Text);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Login successful, open the patient dashboard
                        PatientDashboard patientDashboard = new PatientDashboard();
                        patientDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password");

                        txt_PatientUsername.Clear();
                        txt_PatientPassword.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                //Patient Login Error Message (Null field) Pop-up
                /*if (txt_PatientUsername.Text == "" && txt_PatientPassword.Text == "")
                {
                    MessageBox.Show("Please Enter the Username and Password Before You Login..!");
                }
                else if (txt_PatientUsername.Text == "")
                {
                    MessageBox.Show("Username Cannot Be Blank");
                }
                else if (txt_PatientPassword.Text == "")
                {
                    MessageBox.Show("Please Enter the Correct Password!");
                }*/
            }
        }
    }
}
