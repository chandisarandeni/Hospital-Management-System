using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectHMS
{
    public partial class AdminDashboard : Form
    {
        bool sidebarExpand;
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10; // Decrease the width by 10
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10; // Increase the width by 10
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            PatientRegistration patientRegistration = new PatientRegistration();
            patientRegistration.Show();
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

        private void btn_PatientRemove_Click(object sender, EventArgs e)
        {
            RemovePatient removePatient = new RemovePatient();
            removePatient.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            ChooseLogin1 chooseLogin = new ChooseLogin1();
            chooseLogin.Show();
            this.Hide();

            /*DialogResult Answer = MessageBox.Show("Are you sure want to logout ?");
            if (Answer == DialogResult.Yes)
            {
                AdminLogin adminLogin = new AdminLogin();
                adminLogin.Show();
                this.Hide();
            }
            else if (Answer == DialogResult.Cancel)
            {
                AdminDashboard adminDashboard = new AdminDashboard();
                adminDashboard.Show();
                this.Hide();
            }*/
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

        private void btn_viewAppointments_Click(object sender, EventArgs e)
        {
            ManageAppointments manageAppointments = new ManageAppointments();
            manageAppointments.Show();
            this.Hide();
        }

        private void btn_viewRooms_Click(object sender, EventArgs e)
        {
            ManageRooms manageRooms = new ManageRooms();
            manageRooms.Show();
            this.Hide();
        }

        private void btn_AddAppointments_Click(object sender, EventArgs e)
        {
            PlaceAppointment placeAppointment = new PlaceAppointment();
            placeAppointment.Show();
            this.Hide();
        }

        private void btn_RemoveAppointment_Click(object sender, EventArgs e)
        {
            RemoveAppointment removeAppointment = new RemoveAppointment();
            removeAppointment.Show();
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

            //Show Avilable Rooms
            string connectionString5 = "Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString5))
            {
                conn.Open();
                string query = "SELECT RoomNumber,RoomStatus FROM RoomManagement WHERE RoomStatus = 'Available'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);

                        grid_AvailableRooms.DataSource = table;
                    }
                }
            }

            // Recnet Patient Appointments
            string connectionString = "Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT NIC,PatientName,DoctorName FROM appointmentAndPrescriptions";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable table = new DataTable();
                        table.Load(reader);

                        grid_RecentPatientAppointments.DataSource = table;
                    }
                }
            }

            // Recenly Added Patients
            string connectionString1 = "Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn1 = new SqlConnection(connectionString1))
            {
                conn1.Open();
                string query1 = "SELECT PatientName,Gender,PatientAddress FROM PatientData";
                using (SqlCommand cmd1 = new SqlCommand(query1, conn1))
                {
                    using (SqlDataReader reader1 = cmd1.ExecuteReader())
                    {
                        DataTable table1 = new DataTable();
                        table1.Load(reader1);

                        grid_RecentAddedPatients.DataSource = table1;
                    }
                }
            }

            // Upcoming Appointments for Doctors
            string connectionString2 = "Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn2 = new SqlConnection(connectionString2))
            {
                conn2.Open();
                string query1 = "SELECT DoctorName,PatientName,NIC,AppointmentDate FROM appointmentAndPrescriptions WHERE AppointmentDate = '2024-04-10'";
                using (SqlCommand cmd2 = new SqlCommand(query1, conn2))
                {
                    using (SqlDataReader reader2 = cmd2.ExecuteReader())
                    {
                        DataTable table2 = new DataTable();
                        table2.Load(reader2);

                        grid_upcomingAppointmentsForDoctors.DataSource = table2;
                    }
                }
            }
        }
    }
}
