using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectHMS
{
    public partial class ChooseLogin1 : Form
    {
        public ChooseLogin1()
        {
            InitializeComponent();
        }

        //Admin Login Picture
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            this.Hide();
        }

        // Doctor Login Picture
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

        private void ChooseLogin1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exit Application
        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }
    }
}
