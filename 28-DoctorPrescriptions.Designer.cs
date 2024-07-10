namespace FinalProjectHMS
{
    partial class DoctorPrescriptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorPrescriptions));
            sidebarTimer = new System.Windows.Forms.Timer(components);
            sidebar = new FlowLayoutPanel();
            pnl_MenuBar = new Panel();
            panel8 = new Panel();
            btn_Menu = new PictureBox();
            pictureBox1 = new PictureBox();
            panel7 = new Panel();
            btn_Logout = new Button();
            label1 = new Label();
            lbl_userIdShow = new Label();
            lbl_UserID = new Label();
            panel1 = new Panel();
            btn_Dashboard = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            label3 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            btn_Search = new Button();
            txt_AppointmentNumber = new TextBox();
            lbl_DoctorName = new Label();
            lbl_AppointmentDate = new Label();
            lbl_NIC = new Label();
            lbl_PatientName = new Label();
            lbl_AppointmentNumber = new Label();
            label2 = new Label();
            lbl_searchPatientName = new Label();
            label4 = new Label();
            txt_Prescription = new RichTextBox();
            txt_Diagnosis = new RichTextBox();
            btn_Submit = new Button();
            btn_Cancel = new Button();
            lbl_AdminViewDocTitle = new Label();
            sidebar.SuspendLayout();
            pnl_MenuBar.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Menu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(151, 207, 239);
            sidebar.Controls.Add(pnl_MenuBar);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(3, 4, 3, 4);
            sidebar.MaximumSize = new Size(297, 815);
            sidebar.MinimumSize = new Size(90, 815);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(297, 815);
            sidebar.TabIndex = 39;
            sidebar.Paint += sidebar_Paint;
            // 
            // pnl_MenuBar
            // 
            pnl_MenuBar.Controls.Add(panel8);
            pnl_MenuBar.Controls.Add(pictureBox1);
            pnl_MenuBar.Controls.Add(panel7);
            pnl_MenuBar.Controls.Add(label1);
            pnl_MenuBar.Controls.Add(lbl_userIdShow);
            pnl_MenuBar.Controls.Add(lbl_UserID);
            pnl_MenuBar.Location = new Point(3, 4);
            pnl_MenuBar.Margin = new Padding(3, 4, 3, 4);
            pnl_MenuBar.Name = "pnl_MenuBar";
            pnl_MenuBar.Size = new Size(293, 217);
            pnl_MenuBar.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(btn_Menu);
            panel8.Location = new Point(3, 4);
            panel8.Margin = new Padding(3, 4, 3, 4);
            panel8.Name = "panel8";
            panel8.Size = new Size(71, 51);
            panel8.TabIndex = 4;
            // 
            // btn_Menu
            // 
            btn_Menu.Cursor = Cursors.Hand;
            btn_Menu.Image = (Image)resources.GetObject("btn_Menu.Image");
            btn_Menu.Location = new Point(3, 0);
            btn_Menu.Margin = new Padding(3, 4, 3, 4);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.Size = new Size(57, 51);
            btn_Menu.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Menu.TabIndex = 3;
            btn_Menu.TabStop = false;
            btn_Menu.Click += btn_Menu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(114, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(btn_Logout);
            panel7.Location = new Point(0, 153);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(293, 52);
            panel7.TabIndex = 2;
            // 
            // btn_Logout
            // 
            btn_Logout.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Logout.Location = new Point(161, -27);
            btn_Logout.Margin = new Padding(3, 4, 3, 4);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Padding = new Padding(19, 0, 0, 0);
            btn_Logout.Size = new Size(214, 105);
            btn_Logout.TabIndex = 1;
            btn_Logout.Text = "Logout";
            btn_Logout.TextAlign = ContentAlignment.MiddleLeft;
            btn_Logout.UseVisualStyleBackColor = true;
            btn_Logout.Click += btn_Logout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 97);
            label1.Name = "label1";
            label1.Size = new Size(18, 19);
            label1.TabIndex = 0;
            label1.Text = "#";
            // 
            // lbl_userIdShow
            // 
            lbl_userIdShow.AutoSize = true;
            lbl_userIdShow.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_userIdShow.Location = new Point(190, 97);
            lbl_userIdShow.Name = "lbl_userIdShow";
            lbl_userIdShow.Size = new Size(45, 19);
            lbl_userIdShow.TabIndex = 0;
            lbl_userIdShow.Text = "1225";
            // 
            // lbl_UserID
            // 
            lbl_UserID.AutoSize = true;
            lbl_UserID.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_UserID.Location = new Point(110, 97);
            lbl_UserID.Name = "lbl_UserID";
            lbl_UserID.Size = new Size(76, 19);
            lbl_UserID.TabIndex = 0;
            lbl_UserID.Text = "UserID : ";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Dashboard);
            panel1.Location = new Point(3, 229);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 73);
            panel1.TabIndex = 2;
            // 
            // btn_Dashboard
            // 
            btn_Dashboard.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Dashboard.Image = (Image)resources.GetObject("btn_Dashboard.Image");
            btn_Dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Dashboard.Location = new Point(-6, -8);
            btn_Dashboard.Margin = new Padding(3, 4, 3, 4);
            btn_Dashboard.Name = "btn_Dashboard";
            btn_Dashboard.Padding = new Padding(19, 0, 0, 0);
            btn_Dashboard.Size = new Size(341, 92);
            btn_Dashboard.TabIndex = 1;
            btn_Dashboard.Text = "                   Dashboard";
            btn_Dashboard.TextAlign = ContentAlignment.MiddleLeft;
            btn_Dashboard.UseVisualStyleBackColor = true;
            btn_Dashboard.Click += btn_Dashboard_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 310);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(293, 73);
            panel4.TabIndex = 2;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-6, -8);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Padding = new Padding(19, 0, 0, 0);
            button3.Size = new Size(341, 92);
            button3.TabIndex = 1;
            button3.Text = "                   Appointment";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 391);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(293, 73);
            panel5.TabIndex = 2;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-6, -8);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Padding = new Padding(19, 0, 0, 0);
            button4.Size = new Size(341, 92);
            button4.TabIndex = 1;
            button4.Text = "                   Prescription";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(250, 486);
            label3.Name = "label3";
            label3.Size = new Size(124, 23);
            label3.TabIndex = 86;
            label3.Text = "Prescription :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(250, 419);
            label12.Name = "label12";
            label12.Size = new Size(204, 23);
            label12.TabIndex = 87;
            label12.Text = "Doctor Name               :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(250, 375);
            label13.Name = "label13";
            label13.Size = new Size(201, 23);
            label13.TabIndex = 85;
            label13.Text = "Appointment Date      :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(250, 331);
            label14.Name = "label14";
            label14.Size = new Size(202, 23);
            label14.TabIndex = 84;
            label14.Text = "NIC                              :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(250, 283);
            label15.Name = "label15";
            label15.Size = new Size(206, 23);
            label15.TabIndex = 83;
            label15.Text = "Name                            :";
            // 
            // btn_Search
            // 
            btn_Search.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Search.Location = new Point(798, 157);
            btn_Search.Margin = new Padding(3, 4, 3, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(86, 31);
            btn_Search.TabIndex = 82;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_AppointmentNumber
            // 
            txt_AppointmentNumber.Location = new Point(445, 157);
            txt_AppointmentNumber.Margin = new Padding(3, 4, 3, 4);
            txt_AppointmentNumber.Name = "txt_AppointmentNumber";
            txt_AppointmentNumber.Size = new Size(338, 27);
            txt_AppointmentNumber.TabIndex = 81;
            // 
            // lbl_DoctorName
            // 
            lbl_DoctorName.AutoSize = true;
            lbl_DoctorName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_DoctorName.Location = new Point(483, 419);
            lbl_DoctorName.Name = "lbl_DoctorName";
            lbl_DoctorName.Size = new Size(117, 23);
            lbl_DoctorName.TabIndex = 74;
            lbl_DoctorName.Text = "Sample Data";
            // 
            // lbl_AppointmentDate
            // 
            lbl_AppointmentDate.AutoSize = true;
            lbl_AppointmentDate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_AppointmentDate.Location = new Point(483, 374);
            lbl_AppointmentDate.Name = "lbl_AppointmentDate";
            lbl_AppointmentDate.Size = new Size(117, 23);
            lbl_AppointmentDate.TabIndex = 75;
            lbl_AppointmentDate.Text = "Sample Data";
            // 
            // lbl_NIC
            // 
            lbl_NIC.AutoSize = true;
            lbl_NIC.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NIC.Location = new Point(483, 325);
            lbl_NIC.Name = "lbl_NIC";
            lbl_NIC.Size = new Size(117, 23);
            lbl_NIC.TabIndex = 76;
            lbl_NIC.Text = "Sample Data";
            // 
            // lbl_PatientName
            // 
            lbl_PatientName.AutoSize = true;
            lbl_PatientName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PatientName.Location = new Point(483, 283);
            lbl_PatientName.Name = "lbl_PatientName";
            lbl_PatientName.Size = new Size(117, 23);
            lbl_PatientName.TabIndex = 77;
            lbl_PatientName.Text = "Sample Data";
            // 
            // lbl_AppointmentNumber
            // 
            lbl_AppointmentNumber.AutoSize = true;
            lbl_AppointmentNumber.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_AppointmentNumber.Location = new Point(483, 242);
            lbl_AppointmentNumber.Name = "lbl_AppointmentNumber";
            lbl_AppointmentNumber.Size = new Size(117, 23);
            lbl_AppointmentNumber.TabIndex = 78;
            lbl_AppointmentNumber.Text = "Sample Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(250, 242);
            label2.Name = "label2";
            label2.Size = new Size(207, 23);
            label2.TabIndex = 79;
            label2.Text = "Appointment Number  :";
            // 
            // lbl_searchPatientName
            // 
            lbl_searchPatientName.AutoSize = true;
            lbl_searchPatientName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_searchPatientName.Location = new Point(250, 157);
            lbl_searchPatientName.Name = "lbl_searchPatientName";
            lbl_searchPatientName.Size = new Size(207, 23);
            lbl_searchPatientName.TabIndex = 80;
            lbl_searchPatientName.Text = "Appointment Number  :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(250, 568);
            label4.Name = "label4";
            label4.Size = new Size(122, 23);
            label4.TabIndex = 86;
            label4.Text = "Diagnosis     :";
            // 
            // txt_Prescription
            // 
            txt_Prescription.Location = new Point(401, 485);
            txt_Prescription.Name = "txt_Prescription";
            txt_Prescription.Size = new Size(393, 63);
            txt_Prescription.TabIndex = 88;
            txt_Prescription.Text = "";
            // 
            // txt_Diagnosis
            // 
            txt_Diagnosis.Location = new Point(401, 568);
            txt_Diagnosis.Name = "txt_Diagnosis";
            txt_Diagnosis.Size = new Size(393, 186);
            txt_Diagnosis.TabIndex = 88;
            txt_Diagnosis.Text = "";
            // 
            // btn_Submit
            // 
            btn_Submit.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_Submit.Location = new Point(923, 723);
            btn_Submit.Margin = new Padding(3, 4, 3, 4);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(86, 31);
            btn_Submit.TabIndex = 89;
            btn_Submit.Text = "Submit";
            btn_Submit.UseVisualStyleBackColor = true;
            btn_Submit.Click += btn_Submit_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_Cancel.Location = new Point(1042, 723);
            btn_Cancel.Margin = new Padding(3, 4, 3, 4);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(86, 31);
            btn_Cancel.TabIndex = 89;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // lbl_AdminViewDocTitle
            // 
            lbl_AdminViewDocTitle.AutoSize = true;
            lbl_AdminViewDocTitle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_AdminViewDocTitle.Location = new Point(483, 31);
            lbl_AdminViewDocTitle.Name = "lbl_AdminViewDocTitle";
            lbl_AdminViewDocTitle.Size = new Size(294, 70);
            lbl_AdminViewDocTitle.TabIndex = 99;
            lbl_AdminViewDocTitle.Text = "-Suwasewa Hospital - \r\n  Update Prescription";
            // 
            // DoctorPrescriptions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 253, 254);
            ClientSize = new Size(1239, 815);
            Controls.Add(lbl_AdminViewDocTitle);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Submit);
            Controls.Add(txt_Diagnosis);
            Controls.Add(txt_Prescription);
            Controls.Add(sidebar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(btn_Search);
            Controls.Add(txt_AppointmentNumber);
            Controls.Add(lbl_DoctorName);
            Controls.Add(lbl_AppointmentDate);
            Controls.Add(lbl_NIC);
            Controls.Add(lbl_PatientName);
            Controls.Add(lbl_AppointmentNumber);
            Controls.Add(label2);
            Controls.Add(lbl_searchPatientName);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "DoctorPrescriptions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management System";
            Load += DoctorPrescriptions_Load;
            sidebar.ResumeLayout(false);
            pnl_MenuBar.ResumeLayout(false);
            pnl_MenuBar.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_Menu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer sidebarTimer;
        private FlowLayoutPanel sidebar;
        private Panel pnl_MenuBar;
        private Panel panel8;
        private PictureBox btn_Menu;
        private PictureBox pictureBox1;
        private Panel panel7;
        private Button btn_Logout;
        private Label label1;
        private Label lbl_userIdShow;
        private Label lbl_UserID;
        private Panel panel1;
        private Button btn_Dashboard;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private Label label3;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button btn_Search;
        private TextBox txt_AppointmentNumber;
        private Label lbl_DoctorName;
        private Label lbl_AppointmentDate;
        private Label lbl_NIC;
        private Label lbl_PatientName;
        private Label lbl_AppointmentNumber;
        private Label label2;
        private Label lbl_searchPatientName;
        private Label label4;
        private RichTextBox txt_Prescription;
        private RichTextBox txt_Diagnosis;
        private Button btn_Submit;
        private Button btn_Cancel;
        private Label lbl_AdminViewDocTitle;
    }
}