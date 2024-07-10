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
    public partial class AdminNewPassword : Form
    {
        public AdminNewPassword()
        {
            InitializeComponent();
        }

        private void btn_newPasswordClear_Click(object sender, EventArgs e)
        {
            txt_NewPassword.Text = "";
            txt_NIC.Text = "";
        }

        private void btn_confirmPasswordClear_Click(object sender, EventArgs e)
        {
            txt_ConfirmPassword.Text = "";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            AdminNewPassword adminNewPassword = new AdminNewPassword();
            adminNewPassword.Show();
            this.Hide();
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (txt_NewPassword.Text == txt_ConfirmPassword.Text)
            {
                string CS = @"Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                try
                {
                    using (SqlConnection con = new SqlConnection(CS))
                    {
                        con.Open();
                        string stm = "UPDATE AdminData SET AdminPassword = @AdminPassword WHERE NIC = @NIC";
                        using (SqlCommand cmd = new SqlCommand(stm, con))
                        {
                            cmd.Parameters.AddWithValue("@AdminPassword", txt_NewPassword.Text);
                            cmd.Parameters.AddWithValue("@NIC", txt_NIC.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password updated successfully!");

                                AdminLogin adminLogin = new AdminLogin();
                                adminLogin.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update password.");

                                txt_NIC.Text = "";
                                txt_NewPassword.Text = "";
                                txt_ConfirmPassword.Text = "";

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("New password and confirm password do not match.");
            }
        }
    }
}
