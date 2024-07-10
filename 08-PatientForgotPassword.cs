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
    public partial class PatientForgotPassword : Form
    {
        public PatientForgotPassword()
        {
            InitializeComponent();
        }

        private void btn_NIC_Clear_Click(object sender, EventArgs e)
        {
            txt_NIC.Text = "";
        }

        private void btn_SecretPinClear_Click(object sender, EventArgs e)
        {
            txt_SecretPin.Text = "";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            PatientForgotPassword patientForgotPassword = new PatientForgotPassword();
            patientForgotPassword.Show();
            this.Hide();
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            PatientLogin patientLogin = new PatientLogin();
            patientLogin.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string CS = @"Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            try
            {
                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();
                    string stm = "SELECT NIC, SecretPin FROM PatientData WHERE NIC = @NIC AND SecretPin = @SecretPin";
                    using (SqlCommand cmd = new SqlCommand(stm, con))
                    {
                        cmd.Parameters.AddWithValue("@NIC", txt_NIC.Text);
                        cmd.Parameters.AddWithValue("@SecretPin", txt_SecretPin.Text);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Login successful, open the admin dashboard or perform further actions
                                //MessageBox.Show("Login successful!");
                                // Add code here to proceed after successful login
                                PatientNewPassword patientNewPassword = new PatientNewPassword();
                                patientNewPassword.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid NIC or Secret Pin");

                                txt_NIC.Clear();
                                txt_SecretPin.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            /*int charCount;
            charCount = txt_NIC.Text.Length;
            if (charCount == 10 || charCount == 12)
            {

            }
            else
            {
                MessageBox.Show("Plase Enter a Valid NIC Number..!");
            }*/
        }
    }
}
