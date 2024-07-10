namespace FinalProjectHMS
{
    partial class AdminViewPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminViewPatient));
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
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            button2 = new Button();
            panel4 = new Panel();
            button3 = new Button();
            panel5 = new Panel();
            button4 = new Button();
            panel6 = new Panel();
            button5 = new Button();
            panel9 = new Panel();
            button6 = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            lbl_AdminViewDocTitle = new Label();
            label6 = new Label();
            grid_RecentAddedPatients = new DataGridView();
            lbl_PlacedAppointments = new Label();
            grid_upcomingAppointments = new DataGridView();
            btn_Search = new Button();
            txt_PatientNIC = new TextBox();
            btn_Remove = new PictureBox();
            btn_Add = new PictureBox();
            label5 = new Label();
            lbl_PatientNIC = new Label();
            label3 = new Label();
            lbl_Address = new Label();
            lbl_NIC = new Label();
            lbl_showPatientGender = new Label();
            lbl_showPatientAddress = new Label();
            lbl_showPatientNIC = new Label();
            lbl_showPatientName = new Label();
            lbl_FullName = new Label();
            lbl_doctorDetails = new Label();
            label4 = new Label();
            lbl_SearchInstruction = new Label();
            sidebar.SuspendLayout();
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
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_RecentAddedPatients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_upcomingAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Remove).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Add).BeginInit();
            SuspendLayout();
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
            sidebar.Size = new Size(153, 815);
            sidebar.TabIndex = 5;
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
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 310);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(293, 73);
            panel2.TabIndex = 2;
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
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Location = new Point(3, 391);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(293, 73);
            panel3.TabIndex = 2;
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
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 472);
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
            panel5.Location = new Point(3, 553);
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
            // panel6
            // 
            panel6.Controls.Add(button5);
            panel6.Location = new Point(3, 634);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(293, 73);
            panel6.TabIndex = 2;
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
            // panel9
            // 
            panel9.Controls.Add(button6);
            panel9.Location = new Point(3, 715);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(293, 73);
            panel9.TabIndex = 3;
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
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // lbl_AdminViewDocTitle
            // 
            lbl_AdminViewDocTitle.AutoSize = true;
            lbl_AdminViewDocTitle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_AdminViewDocTitle.Location = new Point(477, 17);
            lbl_AdminViewDocTitle.Name = "lbl_AdminViewDocTitle";
            lbl_AdminViewDocTitle.Size = new Size(294, 70);
            lbl_AdminViewDocTitle.TabIndex = 6;
            lbl_AdminViewDocTitle.Text = "-Suwasewa Hospital - \r\n     Patient Portal";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(913, 216);
            label6.Name = "label6";
            label6.Size = new Size(217, 23);
            label6.TabIndex = 37;
            label6.Text = "Recently Added Patients";
            // 
            // grid_RecentAddedPatients
            // 
            grid_RecentAddedPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_RecentAddedPatients.Location = new Point(917, 252);
            grid_RecentAddedPatients.Margin = new Padding(3, 4, 3, 4);
            grid_RecentAddedPatients.Name = "grid_RecentAddedPatients";
            grid_RecentAddedPatients.RowHeadersWidth = 51;
            grid_RecentAddedPatients.Size = new Size(264, 523);
            grid_RecentAddedPatients.TabIndex = 35;
            // 
            // lbl_PlacedAppointments
            // 
            lbl_PlacedAppointments.AutoSize = true;
            lbl_PlacedAppointments.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PlacedAppointments.Location = new Point(251, 511);
            lbl_PlacedAppointments.Name = "lbl_PlacedAppointments";
            lbl_PlacedAppointments.Size = new Size(186, 23);
            lbl_PlacedAppointments.TabIndex = 36;
            lbl_PlacedAppointments.Text = "Placed Appointments";
            // 
            // grid_upcomingAppointments
            // 
            grid_upcomingAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_upcomingAppointments.Location = new Point(255, 547);
            grid_upcomingAppointments.Margin = new Padding(3, 4, 3, 4);
            grid_upcomingAppointments.Name = "grid_upcomingAppointments";
            grid_upcomingAppointments.RowHeadersWidth = 51;
            grid_upcomingAppointments.Size = new Size(621, 228);
            grid_upcomingAppointments.TabIndex = 34;
            // 
            // btn_Search
            // 
            btn_Search.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Search.Location = new Point(777, 185);
            btn_Search.Margin = new Padding(3, 4, 3, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(86, 31);
            btn_Search.TabIndex = 33;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_PatientNIC
            // 
            txt_PatientNIC.Location = new Point(424, 186);
            txt_PatientNIC.Margin = new Padding(3, 4, 3, 4);
            txt_PatientNIC.Name = "txt_PatientNIC";
            txt_PatientNIC.Size = new Size(338, 27);
            txt_PatientNIC.TabIndex = 32;
            // 
            // btn_Remove
            // 
            btn_Remove.Image = (Image)resources.GetObject("btn_Remove.Image");
            btn_Remove.Location = new Point(1123, 103);
            btn_Remove.Margin = new Padding(3, 4, 3, 4);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(57, 72);
            btn_Remove.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Remove.TabIndex = 29;
            btn_Remove.TabStop = false;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // btn_Add
            // 
            btn_Add.Image = (Image)resources.GetObject("btn_Add.Image");
            btn_Add.Location = new Point(1035, 103);
            btn_Add.Margin = new Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(57, 72);
            btn_Add.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Add.TabIndex = 30;
            btn_Add.TabStop = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1125, 179);
            label5.Name = "label5";
            label5.Size = new Size(68, 19);
            label5.TabIndex = 15;
            label5.Text = "Remove";
            // 
            // lbl_PatientNIC
            // 
            lbl_PatientNIC.AutoSize = true;
            lbl_PatientNIC.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PatientNIC.Location = new Point(255, 190);
            lbl_PatientNIC.Name = "lbl_PatientNIC";
            lbl_PatientNIC.Size = new Size(173, 23);
            lbl_PatientNIC.TabIndex = 16;
            lbl_PatientNIC.Text = "Patient NIC           :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(250, 451);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 26;
            label3.Text = "Telephone      :";
            // 
            // lbl_Address
            // 
            lbl_Address.AutoSize = true;
            lbl_Address.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Address.Location = new Point(250, 407);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.Size = new Size(135, 23);
            lbl_Address.TabIndex = 25;
            lbl_Address.Text = "Address          :";
            // 
            // lbl_NIC
            // 
            lbl_NIC.AutoSize = true;
            lbl_NIC.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NIC.Location = new Point(251, 370);
            lbl_NIC.Name = "lbl_NIC";
            lbl_NIC.Size = new Size(132, 23);
            lbl_NIC.TabIndex = 24;
            lbl_NIC.Text = "NIC                :";
            // 
            // lbl_showPatientGender
            // 
            lbl_showPatientGender.AutoSize = true;
            lbl_showPatientGender.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showPatientGender.Location = new Point(398, 451);
            lbl_showPatientGender.Name = "lbl_showPatientGender";
            lbl_showPatientGender.Size = new Size(183, 23);
            lbl_showPatientGender.TabIndex = 23;
            lbl_showPatientGender.Text = "Sample Specilization";
            // 
            // lbl_showPatientAddress
            // 
            lbl_showPatientAddress.AutoSize = true;
            lbl_showPatientAddress.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showPatientAddress.Location = new Point(398, 407);
            lbl_showPatientAddress.Name = "lbl_showPatientAddress";
            lbl_showPatientAddress.Size = new Size(143, 23);
            lbl_showPatientAddress.TabIndex = 22;
            lbl_showPatientAddress.Text = "Sample Address";
            // 
            // lbl_showPatientNIC
            // 
            lbl_showPatientNIC.AutoSize = true;
            lbl_showPatientNIC.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showPatientNIC.Location = new Point(398, 370);
            lbl_showPatientNIC.Name = "lbl_showPatientNIC";
            lbl_showPatientNIC.Size = new Size(183, 23);
            lbl_showPatientNIC.TabIndex = 21;
            lbl_showPatientNIC.Text = "Sample NIC Number";
            // 
            // lbl_showPatientName
            // 
            lbl_showPatientName.AutoSize = true;
            lbl_showPatientName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showPatientName.Location = new Point(398, 326);
            lbl_showPatientName.Name = "lbl_showPatientName";
            lbl_showPatientName.Size = new Size(125, 23);
            lbl_showPatientName.TabIndex = 20;
            lbl_showPatientName.Text = "Sample Name";
            // 
            // lbl_FullName
            // 
            lbl_FullName.AutoSize = true;
            lbl_FullName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_FullName.Location = new Point(251, 326);
            lbl_FullName.Name = "lbl_FullName";
            lbl_FullName.Size = new Size(131, 23);
            lbl_FullName.TabIndex = 19;
            lbl_FullName.Text = "Name             :";
            // 
            // lbl_doctorDetails
            // 
            lbl_doctorDetails.AutoSize = true;
            lbl_doctorDetails.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_doctorDetails.Location = new Point(251, 271);
            lbl_doctorDetails.Name = "lbl_doctorDetails";
            lbl_doctorDetails.Size = new Size(135, 23);
            lbl_doctorDetails.TabIndex = 18;
            lbl_doctorDetails.Text = "Patient Details";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1050, 179);
            label4.Name = "label4";
            label4.Size = new Size(38, 19);
            label4.TabIndex = 27;
            label4.Text = "Add";
            // 
            // lbl_SearchInstruction
            // 
            lbl_SearchInstruction.AutoSize = true;
            lbl_SearchInstruction.BackColor = SystemColors.ButtonShadow;
            lbl_SearchInstruction.Location = new Point(373, 650);
            lbl_SearchInstruction.Name = "lbl_SearchInstruction";
            lbl_SearchInstruction.Size = new Size(389, 20);
            lbl_SearchInstruction.TabIndex = 39;
            lbl_SearchInstruction.Text = "Search from NIC or Mobile number to view appointments";
            // 
            // AdminViewPatient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 253, 254);
            ClientSize = new Size(1239, 815);
            Controls.Add(lbl_SearchInstruction);
            Controls.Add(sidebar);
            Controls.Add(label6);
            Controls.Add(grid_RecentAddedPatients);
            Controls.Add(lbl_PlacedAppointments);
            Controls.Add(grid_upcomingAppointments);
            Controls.Add(btn_Search);
            Controls.Add(txt_PatientNIC);
            Controls.Add(btn_Remove);
            Controls.Add(btn_Add);
            Controls.Add(label5);
            Controls.Add(lbl_PatientNIC);
            Controls.Add(label3);
            Controls.Add(lbl_Address);
            Controls.Add(lbl_NIC);
            Controls.Add(lbl_showPatientGender);
            Controls.Add(lbl_showPatientAddress);
            Controls.Add(lbl_showPatientNIC);
            Controls.Add(lbl_showPatientName);
            Controls.Add(lbl_FullName);
            Controls.Add(lbl_doctorDetails);
            Controls.Add(label4);
            Controls.Add(lbl_AdminViewDocTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AdminViewPatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management System";
            Load += AdminViewPatient_Load;
            sidebar.ResumeLayout(false);
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
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_RecentAddedPatients).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_upcomingAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Remove).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Add).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private Panel panel4;
        private Button button3;
        private Panel panel5;
        private Button button4;
        private Panel panel6;
        private Button button5;
        private System.Windows.Forms.Timer sidebarTimer;
        private Label lbl_AdminViewDocTitle;
        private Label label6;
        private DataGridView grid_RecentAddedPatients;
        private Label lbl_PlacedAppointments;
        private DataGridView grid_upcomingAppointments;
        private Button btn_Search;
        private TextBox txt_PatientNIC;
        private PictureBox btn_Remove;
        private PictureBox btn_Add;
        private Label label5;
        private Label lbl_PatientNIC;
        private Label label3;
        private Label lbl_Address;
        private Label lbl_NIC;
        private Label lbl_showPatientGender;
        private Label lbl_showPatientAddress;
        private Label lbl_showPatientNIC;
        private Label lbl_showPatientName;
        private Label lbl_FullName;
        private Label lbl_doctorDetails;
        private Label label4;
        private Panel panel9;
        private Button button6;
        private Label lbl_SearchInstruction;
    }
}