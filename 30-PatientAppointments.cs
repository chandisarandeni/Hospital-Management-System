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
    public partial class PatientAppointments : Form
    {
        bool sidebarExpand;
        public PatientAppointments()
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

        private void PatientAppointments_Load(object sender, EventArgs e)
        {
            sidebarTimer.Start();

            lbl_showPatientName.Text = "";
            lbl_showPatientNIC.Text = "";
            //lbl_showPatientAddress.Text = "";
            //lbl_showPatientGender.Text = "";
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            ChooseLogin1 chooseLogin1 = new ChooseLogin1();
            chooseLogin1.Show();
            this.Hide();
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            PatientDashboard patientDashboard = new PatientDashboard();
            patientDashboard.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PatientAppointments patientAppointments = new PatientAppointments();
            patientAppointments.Show();
            this.Hide();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PatientPrescriptions patientPrescriptions = new PatientPrescriptions();
            patientPrescriptions.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            //Show Doctor Details
            try
            {
                string CS = @"Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();
                    string stm = "SELECT * FROM appointmentAndPrescriptions WHERE AppointmentNumber = @AppointmentNumber AND NIC = '953210987V'";

                    using (SqlCommand cmd = new SqlCommand(stm, con))
                    {
                        // Set parameter values
                        cmd.Parameters.AddWithValue("@AppointmentNumber", txt_AppointmentNumber.Text);

                        // Execute the command
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Show doctor details after searching doctor
                                //lbl_DocID.Text = reader["DocID"].ToString(); // Assuming there's a DocID column in DoctorDetails table
                                lbl_showPatientName.Text = reader["PatientName"].ToString();
                                lbl_showPatientNIC.Text = reader["NIC"].ToString();
                                //lbl_showPatientAddress.Text = reader["PatientAddress"].ToString();
                                //lbl_showPatientGender.Text = reader["Gender"].ToString();

                                lbl_SearchInstruction.Hide();

                                //Show DataGrid
                                string connectionString1 = "Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                                using (SqlConnection conn1 = new SqlConnection(connectionString1))
                                {

                                    conn1.Open();
                                    string query1 = "SELECT * FROM appointmentAndPrescriptions WHERE NIC = '953210987V'";
                                    using (SqlCommand cmd1 = new SqlCommand(query1, conn1))
                                    {
                                        cmd1.Parameters.AddWithValue("@AppointmentNumber", txt_AppointmentNumber.Text);
                                        using (SqlDataReader reader1 = cmd1.ExecuteReader())
                                        {
                                            DataTable table1 = new DataTable();
                                            table1.Load(reader1);

                                            grid_upcomingAppointments.DataSource = table1;
                                        }
                                    }

                                }


                            }
                            else
                            {
                                MessageBox.Show("No data found for the given NIC or Mobile number.");
                                // Clear labels if no data found
                                //lbl_DocID.Text = "";
                                lbl_showPatientName.Text = "";
                                lbl_showPatientNIC.Text = "";
                                //lbl_showPatientAddress.Text = "";
                                //lbl_showPatientGender.Text = "";
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
