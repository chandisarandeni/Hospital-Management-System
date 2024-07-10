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
    public partial class PatientPrescriptions : Form
    {
        bool sidebarExpand;
        public PatientPrescriptions()
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

        private void PatientPrescriptions_Load(object sender, EventArgs e)
        {
            sidebarTimer.Start();

            lbl_AppointmentNumber.Text = "";
            lbl_PatientName.Text = "";
            lbl_NIC.Text = "";
            lbl_AppointmentDate.Text = "";
            lbl_DoctorName.Text = "";
            lbl_Prescription.Text = "";
            lbl_Diagnosis.Text = "";
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

        private void button4_Click(object sender, EventArgs e)
        {
            PatientPrescriptions patientPrescriptions = new PatientPrescriptions();
            patientPrescriptions.Show();
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
                    string stm = "SELECT * FROM appointmentAndPrescriptions WHERE AppointmentNumber = @AppointmentNumber AND NIC = '953210987V'";

                    using (SqlCommand cmd = new SqlCommand(stm, con))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentNumber", txt_AppointmentNumber.Text.Trim());

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate labels with data from the database
                                lbl_AppointmentNumber.Text = reader["AppointmentNumber"].ToString();
                                lbl_PatientName.Text = reader["PatientName"].ToString();
                                lbl_NIC.Text = reader["NIC"].ToString();
                                lbl_AppointmentDate.Text = ((DateTime)reader["AppointmentDate"]).ToShortDateString();
                                lbl_DoctorName.Text = reader["DoctorName"].ToString();
                                lbl_Prescription.Text = reader["Prescription"].ToString();
                                lbl_Diagnosis.Text = reader["Diagnosis"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No data found for the given Appointment Number.");
                                //ClearLabels(); // Clear labels if no data found

                                lbl_AppointmentNumber.Text = "";
                                lbl_PatientName.Text = "";
                                lbl_NIC.Text = "";
                                lbl_AppointmentDate.Text = "";
                                lbl_DoctorName.Text = "";
                                lbl_Prescription.Text = "";
                                lbl_Diagnosis.Text = "";
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
