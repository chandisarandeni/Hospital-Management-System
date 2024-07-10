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
    public partial class RemoveAppointment : Form
    {
        bool sidebarExpand;
        public RemoveAppointment()
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

        private void RemoveAppointment_Load(object sender, EventArgs e)
        {
            sidebarTimer.Start();

            // Clear labels if no data found
            lbl_showAppointmentNumber.Text = "";
            lbl_showPatientName.Text = "";
            lbl_showPatientNIC.Text = "";
            lbl_showAppointmentDate.Text = "";
            lbl_showDocName.Text = "";
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            ChooseLogin1 chooseLogin1 = new ChooseLogin1();
            chooseLogin1.Show();
            this.Hide();
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

        private void button6_Click(object sender, EventArgs e)
        {
            ManageBills manageBills = new ManageBills();
            manageBills.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ManageAppointments manageAppointments = new ManageAppointments();
            manageAppointments.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string CS = @"Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();
                    string stm = "SELECT * FROM appointmentAndPrescriptions WHERE AppointmentNumber = @AppointmentNumber";

                    using (SqlCommand cmd = new SqlCommand(stm, con))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentNumber", txt_SearchAppointment.Text);
                        // Set parameter values
                        cmd.Parameters.AddWithValue("@AppointmetnNumber", txt_SearchAppointment.Text);

                        // Execute the command
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Show patient details after searching patient
                                lbl_showAppointmentNumber.Text = reader["AppointmentNumber"].ToString();
                                lbl_showPatientName.Text = reader["PatientName"].ToString();
                                lbl_showPatientNIC.Text = reader["NIC"].ToString();
                                lbl_showAppointmentDate.Text = ((DateTime)reader["AppointmentDate"]).ToShortDateString();
                                lbl_showDocName.Text = reader["DoctorName"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No data found for the given NIC or Mobile number.");
                                // Clear labels if no data found
                                lbl_showAppointmentNumber.Text = "";
                                lbl_showPatientName.Text = "";
                                lbl_showPatientNIC.Text = "";
                                lbl_showAppointmentDate.Text = "";
                                lbl_showDocName.Text = "";
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

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string CS = @"Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();
                    string AppointmentNumber = txt_SearchAppointment.Text;
                    string stm = "DELETE FROM appointmentAndPrescriptions WHERE AppointmentNumber = @AppointmentNumber";

                    using (SqlCommand cmd = new SqlCommand(stm, con))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentNumber", AppointmentNumber);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Appointment Deleted Successfully !");

                            // Clear labels if no data found
                            lbl_showAppointmentNumber.Text = "";
                            lbl_showPatientName.Text = "";
                            lbl_showPatientNIC.Text = "";
                            lbl_showAppointmentDate.Text = "";
                            lbl_showDocName.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to Delete Appointment !");
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
