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
    public partial class DoctorPrescriptions : Form
    {
        bool sidebarExpand;
        public DoctorPrescriptions()
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

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            ChooseLogin1 chooseLogin1 = new ChooseLogin1();
            chooseLogin1.Show();
            this.Hide();
        }

        private void DoctorPrescriptions_Load(object sender, EventArgs e)
        {
            sidebarTimer.Start();

            lbl_AppointmentNumber.Text = "";
            lbl_PatientName.Text = "";
            lbl_NIC.Text = "";
            lbl_AppointmentDate.Text = "";
            lbl_DoctorName.Text = "";
        }

        private void btn_Dashboard_Click(object sender, EventArgs e)
        {
            DoctorDashboard doctorDashboard = new DoctorDashboard();
            doctorDashboard.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoctorAppointments doctorAppointments = new DoctorAppointments();
            doctorAppointments.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DoctorPrescriptions doctorPrescriptions = new DoctorPrescriptions();
            doctorPrescriptions.Show();
            this.Hide();
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

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

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            try
            {
                string CS = @"Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();
                    string Prescription = txt_Prescription.Text;
                    string Diagnosis = txt_Diagnosis.Text;
                    string AppointmentNumber = txt_AppointmentNumber.Text;

                    // Use UPDATE statement to modify existing records
                    string stm = "UPDATE appointmentAndPrescriptions SET Prescription = @Prescription, Diagnosis = @Diagnosis WHERE AppointmentNumber = @AppointmentNumber";

                    using (SqlCommand cmd = new SqlCommand(stm, con))
                    {
                        cmd.Parameters.AddWithValue("@Prescription", Prescription);
                        cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                        cmd.Parameters.AddWithValue("@AppointmentNumber", AppointmentNumber);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Saved Successfully!");

                            txt_Prescription.Clear();
                            txt_Diagnosis.Clear();
                            txt_AppointmentNumber.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save data!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DoctorPrescriptions doctorPrescriptions = new DoctorPrescriptions();
            doctorPrescriptions.Show();
            this.Hide();
        }
    }
}
