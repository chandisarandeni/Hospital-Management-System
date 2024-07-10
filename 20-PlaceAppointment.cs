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
    public partial class PlaceAppointment : Form
    {
        bool sidebarExpand;
        public PlaceAppointment()
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

        private void PlaceAppointment_Load(object sender, EventArgs e)
        {
            sidebarTimer.Start();
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

        private void button7_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string CS = @"Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();
                    string PatientName = txt_PatientName.Text;
                    string NIC = txt_PatientNIC.Text;
                    DateTime AppointmentDate;
                    if (!DateTime.TryParse(txt_AppointmentDate.Text, out AppointmentDate))
                    {
                        // Handle the case where the input is not a valid DateTime
                        MessageBox.Show("Invalid date format!");
                        return;
                    }
                    string DoctorName = txt_DocName.Text;

                    string stm = "INSERT INTO appointmentAndPrescriptions (PatientName, NIC, AppointmentDate, DoctorName) VALUES(@PatientName, @NIC, @AppointmentDate, @DoctorName)";

                    using (SqlCommand cmd = new SqlCommand(stm, con))
                    {
                        cmd.Parameters.AddWithValue("@PatientName", PatientName);
                        cmd.Parameters.AddWithValue("@NIC", NIC);
                        cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
                        cmd.Parameters.AddWithValue("@DoctorName", DoctorName);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data Saved Successfully !");

                            txt_PatientName.Text = "";
                            txt_PatientNIC.Text = "";
                            txt_AppointmentDate.Text = "";
                            txt_DocName.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to save data !");

                            txt_PatientName.Text = "";
                            txt_PatientNIC.Text = "";
                            txt_AppointmentDate.Text = "";
                            txt_DocName.Text = "";
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
