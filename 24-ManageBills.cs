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
    public partial class ManageBills : Form
    {
        bool sidebarExpand;
        public ManageBills()
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

        private void ManageBills_Load(object sender, EventArgs e)
        {
            sidebarTimer.Start();

            // Clear labels if no data found
            lbl_showRoomNumber.Text = "";
            lbl_showRoomType.Text = "";
            lbl_showRoomACType.Text = "";
            lbl_showAvailability.Text = "";
            lbl_TotalAmout.Text = "";
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

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string CS = @"Data Source=DESKTOP-3RD2OGB;Initial Catalog=CSE_FinalHMS;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

                using (SqlConnection con = new SqlConnection(CS))
                {
                    con.Open();
                    string stm = "SELECT * FROM RoomManagement WHERE RoomNumber = @RoomNumber";

                    using (SqlCommand cmd = new SqlCommand(stm, con))
                    {
                        // Set parameter values
                        cmd.Parameters.AddWithValue("@RoomNumber", txt_RoomNumber.Text);

                        // Execute the command
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Show patient details after searching patient
                                lbl_showRoomNumber.Text = reader["RoomNumber"].ToString();
                                lbl_showRoomType.Text = reader["RoomType"].ToString();
                                lbl_showRoomACType.Text = reader["ACorNonAC"].ToString();
                                lbl_showAvailability.Text = reader["RoomStatus"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No data found for the given NIC or Mobile number.");
                                // Clear labels if no data found
                                lbl_showRoomNumber.Text = "";
                                lbl_showRoomType.Text = "";
                                lbl_showRoomACType.Text = "";
                                lbl_showAvailability.Text = "";
                                lbl_TotalAmout.Text = "";
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

        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_AdminViewDocTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
