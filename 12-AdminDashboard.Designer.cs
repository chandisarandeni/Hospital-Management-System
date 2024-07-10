namespace FinalProjectHMS
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            sidebarTimer = new System.Windows.Forms.Timer(components);
            pnl_MenuBar = new Panel();
            panel8 = new Panel();
            btn_Menu = new PictureBox();
            pictureBox1 = new PictureBox();
            panel7 = new Panel();
            btn_Logout = new Button();
            label1 = new Label();
            lbl_userIdShow = new Label();
            lbl_UserID = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btn_Dashboard = new Button();
            button5 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            sidebar = new FlowLayoutPanel();
            panel9 = new Panel();
            button6 = new Button();
            grid_AvailableRooms = new DataGridView();
            lbl_AvailableRooms = new Label();
            lbl_UpcomingAppointments = new Label();
            grid_upcomingAppointmentsForDoctors = new DataGridView();
            btn_viewRooms = new Button();
            btn_Add = new PictureBox();
            label2 = new Label();
            grid_RecentAddedPatients = new DataGridView();
            label3 = new Label();
            grid_RecentPatientAppointments = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btn_PatientRemove = new PictureBox();
            btn_AddAppointments = new PictureBox();
            btn_RemoveAppointment = new PictureBox();
            pnl_MenuBar.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Menu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            sidebar.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_AvailableRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_upcomingAppointmentsForDoctors).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Add).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_RecentAddedPatients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_RecentPatientAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_PatientRemove).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_AddAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_RemoveAppointment).BeginInit();
            SuspendLayout();
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
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
            // button2
            // 
            button2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-6, -8);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Padding = new Padding(19, 0, 0, 0);
            button2.Size = new Size(341, 92);
            button2.TabIndex = 1;
            button2.Text = "                   Patient";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-6, -8);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Padding = new Padding(19, 0, 0, 0);
            button1.Size = new Size(341, 92);
            button1.TabIndex = 1;
            button1.Text = "                   Doctor";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            // button5
            // 
            button5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-6, -8);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Padding = new Padding(19, 0, 0, 0);
            button5.Size = new Size(341, 92);
            button5.TabIndex = 1;
            button5.Text = "                   Room";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
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
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 310);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 73);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 391);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(293, 73);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 472);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(293, 73);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Location = new Point(3, 553);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(293, 73);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Location = new Point(3, 634);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(293, 73);
            panel6.TabIndex = 2;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(151, 207, 239);
            sidebar.Controls.Add(pnl_MenuBar);
            sidebar.Controls.Add(panel1);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel9);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Margin = new Padding(3, 4, 3, 4);
            sidebar.MaximumSize = new Size(297, 815);
            sidebar.MinimumSize = new Size(90, 815);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(297, 815);
            sidebar.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(button6);
            panel9.Location = new Point(3, 715);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(293, 73);
            panel9.TabIndex = 2;
            // 
            // button6
            // 
            button6.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-6, -8);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Padding = new Padding(19, 0, 0, 0);
            button6.Size = new Size(341, 92);
            button6.TabIndex = 1;
            button6.Text = "                   Bills";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // grid_AvailableRooms
            // 
            grid_AvailableRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_AvailableRooms.Location = new Point(931, 63);
            grid_AvailableRooms.Margin = new Padding(3, 4, 3, 4);
            grid_AvailableRooms.Name = "grid_AvailableRooms";
            grid_AvailableRooms.RowHeadersWidth = 51;
            grid_AvailableRooms.Size = new Size(274, 719);
            grid_AvailableRooms.TabIndex = 2;
            // 
            // lbl_AvailableRooms
            // 
            lbl_AvailableRooms.AutoSize = true;
            lbl_AvailableRooms.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_AvailableRooms.Location = new Point(931, 33);
            lbl_AvailableRooms.Name = "lbl_AvailableRooms";
            lbl_AvailableRooms.Size = new Size(150, 23);
            lbl_AvailableRooms.TabIndex = 3;
            lbl_AvailableRooms.Text = "Available Rooms";
            // 
            // lbl_UpcomingAppointments
            // 
            lbl_UpcomingAppointments.AutoSize = true;
            lbl_UpcomingAppointments.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_UpcomingAppointments.Location = new Point(304, 532);
            lbl_UpcomingAppointments.Name = "lbl_UpcomingAppointments";
            lbl_UpcomingAppointments.Size = new Size(314, 23);
            lbl_UpcomingAppointments.TabIndex = 3;
            lbl_UpcomingAppointments.Text = "Upcoming Appointments for Doctors";
            // 
            // grid_upcomingAppointmentsForDoctors
            // 
            grid_upcomingAppointmentsForDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_upcomingAppointmentsForDoctors.Location = new Point(304, 565);
            grid_upcomingAppointmentsForDoctors.Margin = new Padding(3, 4, 3, 4);
            grid_upcomingAppointmentsForDoctors.Name = "grid_upcomingAppointmentsForDoctors";
            grid_upcomingAppointmentsForDoctors.RowHeadersWidth = 51;
            grid_upcomingAppointmentsForDoctors.Size = new Size(552, 216);
            grid_upcomingAppointmentsForDoctors.TabIndex = 2;
            // 
            // btn_viewRooms
            // 
            btn_viewRooms.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_viewRooms.Location = new Point(1107, 733);
            btn_viewRooms.Margin = new Padding(3, 4, 3, 4);
            btn_viewRooms.Name = "btn_viewRooms";
            btn_viewRooms.Size = new Size(86, 31);
            btn_viewRooms.TabIndex = 4;
            btn_viewRooms.Text = "View";
            btn_viewRooms.UseVisualStyleBackColor = true;
            btn_viewRooms.Click += btn_viewRooms_Click;
            // 
            // btn_Add
            // 
            btn_Add.Image = (Image)resources.GetObject("btn_Add.Image");
            btn_Add.Location = new Point(739, 61);
            btn_Add.Margin = new Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(57, 72);
            btn_Add.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Add.TabIndex = 5;
            btn_Add.TabStop = false;
            btn_Add.Click += btn_Add_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(304, 32);
            label2.Name = "label2";
            label2.Size = new Size(217, 23);
            label2.TabIndex = 3;
            label2.Text = "Recently Added Patients";
            // 
            // grid_RecentAddedPatients
            // 
            grid_RecentAddedPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_RecentAddedPatients.Location = new Point(304, 63);
            grid_RecentAddedPatients.Margin = new Padding(3, 4, 3, 4);
            grid_RecentAddedPatients.Name = "grid_RecentAddedPatients";
            grid_RecentAddedPatients.RowHeadersWidth = 51;
            grid_RecentAddedPatients.Size = new Size(429, 204);
            grid_RecentAddedPatients.TabIndex = 2;
            grid_RecentAddedPatients.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(304, 285);
            label3.Name = "label3";
            label3.Size = new Size(256, 23);
            label3.TabIndex = 3;
            label3.Text = "Recent Patient Appointments";
            // 
            // grid_RecentPatientAppointments
            // 
            grid_RecentPatientAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_RecentPatientAppointments.Location = new Point(304, 311);
            grid_RecentPatientAppointments.Margin = new Padding(3, 4, 3, 4);
            grid_RecentPatientAppointments.Name = "grid_RecentPatientAppointments";
            grid_RecentPatientAppointments.RowHeadersWidth = 51;
            grid_RecentPatientAppointments.Size = new Size(429, 217);
            grid_RecentPatientAppointments.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(754, 137);
            label4.Name = "label4";
            label4.Size = new Size(38, 19);
            label4.TabIndex = 3;
            label4.Text = "Add";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(829, 137);
            label5.Name = "label5";
            label5.Size = new Size(68, 19);
            label5.TabIndex = 3;
            label5.Text = "Remove";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(754, 388);
            label6.Name = "label6";
            label6.Size = new Size(38, 19);
            label6.TabIndex = 3;
            label6.Text = "Add";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(829, 388);
            label7.Name = "label7";
            label7.Size = new Size(68, 19);
            label7.TabIndex = 3;
            label7.Text = "Remove";
            // 
            // btn_PatientRemove
            // 
            btn_PatientRemove.Image = (Image)resources.GetObject("btn_PatientRemove.Image");
            btn_PatientRemove.Location = new Point(819, 61);
            btn_PatientRemove.Margin = new Padding(3, 4, 3, 4);
            btn_PatientRemove.Name = "btn_PatientRemove";
            btn_PatientRemove.Size = new Size(65, 72);
            btn_PatientRemove.SizeMode = PictureBoxSizeMode.Zoom;
            btn_PatientRemove.TabIndex = 6;
            btn_PatientRemove.TabStop = false;
            btn_PatientRemove.Click += btn_PatientRemove_Click;
            // 
            // btn_AddAppointments
            // 
            btn_AddAppointments.Image = (Image)resources.GetObject("btn_AddAppointments.Image");
            btn_AddAppointments.Location = new Point(739, 311);
            btn_AddAppointments.Margin = new Padding(3, 4, 3, 4);
            btn_AddAppointments.Name = "btn_AddAppointments";
            btn_AddAppointments.Size = new Size(57, 67);
            btn_AddAppointments.SizeMode = PictureBoxSizeMode.Zoom;
            btn_AddAppointments.TabIndex = 7;
            btn_AddAppointments.TabStop = false;
            btn_AddAppointments.Click += btn_AddAppointments_Click;
            // 
            // btn_RemoveAppointment
            // 
            btn_RemoveAppointment.Image = (Image)resources.GetObject("btn_RemoveAppointment.Image");
            btn_RemoveAppointment.Location = new Point(827, 311);
            btn_RemoveAppointment.Margin = new Padding(3, 4, 3, 4);
            btn_RemoveAppointment.Name = "btn_RemoveAppointment";
            btn_RemoveAppointment.Size = new Size(57, 67);
            btn_RemoveAppointment.SizeMode = PictureBoxSizeMode.Zoom;
            btn_RemoveAppointment.TabIndex = 7;
            btn_RemoveAppointment.TabStop = false;
            btn_RemoveAppointment.Click += btn_RemoveAppointment_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 253, 254);
            ClientSize = new Size(1239, 815);
            Controls.Add(btn_RemoveAppointment);
            Controls.Add(btn_AddAppointments);
            Controls.Add(btn_PatientRemove);
            Controls.Add(sidebar);
            Controls.Add(btn_Add);
            Controls.Add(btn_viewRooms);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lbl_UpcomingAppointments);
            Controls.Add(lbl_AvailableRooms);
            Controls.Add(grid_RecentPatientAppointments);
            Controls.Add(grid_RecentAddedPatients);
            Controls.Add(grid_upcomingAppointmentsForDoctors);
            Controls.Add(grid_AvailableRooms);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management System";
            Load += AdminDashboard_Load;
            pnl_MenuBar.ResumeLayout(false);
            pnl_MenuBar.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btn_Menu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_AvailableRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_upcomingAppointmentsForDoctors).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Add).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_RecentAddedPatients).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_RecentPatientAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_PatientRemove).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_AddAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_RemoveAppointment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer sidebarTimer;
        private Panel pnl_MenuBar;
        private Panel panel8;
        private PictureBox btn_Menu;
        private PictureBox pictureBox1;
        private Panel panel7;
        private Button btn_Logout;
        private Label label1;
        private Label lbl_userIdShow;
        private Label lbl_UserID;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button btn_Dashboard;
        private Button button5;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private FlowLayoutPanel sidebar;
        private DataGridView grid_AvailableRooms;
        private Label lbl_AvailableRooms;
        private Label lbl_UpcomingAppointments;
        private DataGridView grid_upcomingAppointmentsForDoctors;
        private Button btn_viewRooms;
        private PictureBox btn_Add;
        private Label label2;
        private DataGridView grid_RecentAddedPatients;
        private Label label3;
        private DataGridView grid_RecentPatientAppointments;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox btn_PatientRemove;
        private Panel panel9;
        private Button button6;
        private PictureBox btn_AddAppointments;
        private PictureBox btn_RemoveAppointment;
    }
}