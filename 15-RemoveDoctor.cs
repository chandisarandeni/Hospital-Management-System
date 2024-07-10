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
    public partial class RemoveDoctor : Form
    {
        bool sidebarExpand;
        public RemoveDoctor()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width += 10; // Increase the width by 10
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width -= 10; // Decrease the width by 10
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void RemoveDoctor_Load(object sender, EventArgs e)
        {
            sidebarTimer.Start();

            lbl_showDocName.Text = "";
            lbl_showDocAddress.Text = "";
            lbl_showDocNIC.Text = "";
            lbl_showDocMobile.Text = "";
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminViewDoctor adminViewDoctor = new AdminViewDoctor();
            adminViewDoctor.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminViewDoctor adminViewDoctor = new AdminViewDoctor();
            adminViewDoctor.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            ChooseLogin1 chooseLogin = new ChooseLogin1();
            chooseLogin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminViewPatient adminViewPatient = new AdminViewPatient();
            adminViewPatient.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageAppointments manageAppointments = new ManageAppointments();
            manageAppointments.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewPrescription viewPrescription = new ViewPrescription();
            viewPrescription.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageRooms manageRooms = new ManageRooms();
            manageRooms.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ManageBills manageBills = new ManageBills();
            manageBills.Show();
            this.Hide();
        }

        private void btn_viewAppointments_Click(object sender, EventArgs e)
        {
            try
            {
                string CS = @"Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();
                    string NIC = txt_DocNIC.Text;
                    string Mobile = txt_Mobile.Text;
                    string stm = "DELETE FROM DoctorDetails WHERE NIC = @NIC OR Mobile = @Mobile";

                    using (SqlCommand cmd = new SqlCommand(stm, con))
                    {
                        cmd.Parameters.AddWithValue("@NIC", NIC);
                        cmd.Parameters.AddWithValue("@Mobile", Mobile);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Deleted Successfully !");
                        }
                        else
                        {
                            MessageBox.Show("Failed to Delete data !");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string CS = @"Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();
                    string stm = "SELECT * FROM DoctorDetails WHERE NIC = @NIC OR Mobile = @Mobile";

                    using (SqlCommand cmd = new SqlCommand(stm, con))
                    {
                        // Set parameter values
                        cmd.Parameters.AddWithValue("@NIC", txt_DocNIC.Text);
                        cmd.Parameters.AddWithValue("@Mobile", txt_Mobile.Text);

                        // Execute the command
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Show doctor details after searching doctor
                                //lbl_DocID.Text = reader["DocID"].ToString(); // Assuming there's a DocID column in DoctorDetails table
                                lbl_showDocName.Text = reader["DocName"].ToString();
                                lbl_showDocNIC.Text = reader["NIC"].ToString();
                                lbl_showDocAddress.Text = reader["DocAddress"].ToString();
                                lbl_showDocMobile.Text = reader["Mobile"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No data found for the given NIC or Mobile number.");
                                // Clear labels if no data found
                                //lbl_DocID.Text = "";
                                lbl_showDocName.Text = "";
                                lbl_showDocNIC.Text = "";
                                lbl_showDocAddress.Text = "";
                                lbl_showDocMobile.Text = "";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}
