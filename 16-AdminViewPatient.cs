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
    public partial class AdminViewPatient : Form
    {
        bool sidebarExpand;
        public AdminViewPatient()
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

        private void AdminViewPatient_Load(object sender, EventArgs e)
        {
            lbl_showPatientName.Text = "";
            lbl_showPatientNIC.Text = "";
            lbl_showPatientAddress.Text = "";
            lbl_showPatientGender.Text = "";

            sidebarTimer.Start();
            //string message = "Search for view Appointmets";
            lbl_SearchInstruction.Show();
            // Recently Added Patients
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            PatientRegistration patientRegistration = new PatientRegistration();
            patientRegistration.Show();
            this.Hide();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
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
            /*ManageAppointments manageAppointments = new ManageAppointments();
            manageAppointments.Show();
            this.Hide();*/
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
                    string stm = "SELECT * FROM PatientData WHERE NIC = @NIC";

                    using (SqlCommand cmd = new SqlCommand(stm, con))
                    {
                        // Set parameter values
                        cmd.Parameters.AddWithValue("@NIC", txt_PatientNIC.Text);

                        // Execute the command
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Show doctor details after searching doctor
                                //lbl_DocID.Text = reader["DocID"].ToString(); // Assuming there's a DocID column in DoctorDetails table
                                lbl_showPatientName.Text = reader["PatientName"].ToString();
                                lbl_showPatientNIC.Text = reader["NIC"].ToString();
                                lbl_showPatientAddress.Text = reader["PatientAddress"].ToString();
                                lbl_showPatientGender.Text = reader["Gender"].ToString();

                                lbl_SearchInstruction.Hide();

                                //Show DataGrid
                                string connectionString1 = "Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                                using (SqlConnection conn1 = new SqlConnection(connectionString1))
                                {

                                    conn1.Open();
                                    string query1 = "SELECT AppointmentNumber,PatientName, NIC,AppointmentDate FROM appointmentAndPrescriptions WHERE NIC = @NIC";
                                    using (SqlCommand cmd1 = new SqlCommand(query1, conn1))
                                    {
                                        cmd1.Parameters.AddWithValue("@NIC", txt_PatientNIC.Text);
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
                                lbl_showPatientAddress.Text = "";
                                lbl_showPatientGender.Text = "";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            //lbl_UpcomingAppointments.Text = "Upcoming Appointments";

        }
    }
    }
