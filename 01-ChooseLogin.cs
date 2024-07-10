using System;
using System.Data;
using System.Data.SqlClient;
using System.Media;
using System.Numerics;
using System.Windows.Forms;

namespace FinalProjectHMS
{
    public partial class ChooseLogin : Form
    {
        //SoundPlayer player;

        public ChooseLogin()
        {
            InitializeComponent();
        }

        private void ChooseLogin_Load(object sender, EventArgs e)
        {
            WinAPI.AnimateWindow(this.Handle,1350, WinAPI.VER_Positive);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {
            ChooseLogin1 chooseLogin1 = new ChooseLogin1();
            chooseLogin1.Show();
            this.Hide();
        }

        //Admin Login Picture
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        //Doctor Login Picture
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DoctorLogin doctorLogin = new DoctorLogin();
            doctorLogin.Show();
            this.Hide();
        }

        //Patient Login Picture
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PatientLogin patientLogin = new PatientLogin();
            patientLogin.Show();
            this.Hide();
        }
    }
}
