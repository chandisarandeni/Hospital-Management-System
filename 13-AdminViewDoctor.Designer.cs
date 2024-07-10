namespace FinalProjectHMS
{
    partial class AdminViewDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminViewDoctor));
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
            btn_Remove = new PictureBox();
            btn_Add = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            lbl_searchDocName = new Label();
            txt_DocMobile = new TextBox();
            label2 = new Label();
            txt_DocNIC = new TextBox();
            lbl_doctorDetails = new Label();
            lbl_FullName = new Label();
            lbl_NIC = new Label();
            label7 = new Label();
            btn_Search = new Button();
            lbl_Address = new Label();
            label3 = new Label();
            lbl_UpcomingAppointments = new Label();
            grid_upcomingAppointments = new DataGridView();
            lbl_showDocName = new Label();
            lbl_showDocNIC = new Label();
            lbl_showDocAddress = new Label();
            lbl_showDocMobile = new Label();
            grid_upcomingAppointmentsForDoctors = new DataGridView();
            label6 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)btn_Remove).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_Add).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_upcomingAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_upcomingAppointmentsForDoctors).BeginInit();
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
            sidebar.Size = new Size(297, 815);
            sidebar.TabIndex = 2;
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
            lbl_AdminViewDocTitle.Location = new Point(520, 17);
            lbl_AdminViewDocTitle.Name = "lbl_AdminViewDocTitle";
            lbl_AdminViewDocTitle.Size = new Size(294, 70);
            lbl_AdminViewDocTitle.TabIndex = 3;
            lbl_AdminViewDocTitle.Text = "-Suwasewa Hospital - \r\n      Doctor Portal";
            // 
            // btn_Remove
            // 
            btn_Remove.Image = (Image)resources.GetObject("btn_Remove.Image");
            btn_Remove.Location = new Point(1123, 119);
            btn_Remove.Margin = new Padding(3, 4, 3, 4);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(57, 72);
            btn_Remove.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Remove.TabIndex = 8;
            btn_Remove.TabStop = false;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // btn_Add
            // 
            btn_Add.Image = (Image)resources.GetObject("btn_Add.Image");
            btn_Add.Location = new Point(1035, 119);
            btn_Add.Margin = new Padding(3, 4, 3, 4);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(57, 72);
            btn_Add.SizeMode = PictureBoxSizeMode.Zoom;
            btn_Add.TabIndex = 9;
            btn_Add.TabStop = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(1125, 195);
            label5.Name = "label5";
            label5.Size = new Size(68, 19);
            label5.TabIndex = 6;
            label5.Text = "Remove";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1050, 195);
            label4.Name = "label4";
            label4.Size = new Size(38, 19);
            label4.TabIndex = 7;
            label4.Text = "Add";
            // 
            // lbl_searchDocName
            // 
            lbl_searchDocName.AutoSize = true;
            lbl_searchDocName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_searchDocName.Location = new Point(255, 173);
            lbl_searchDocName.Name = "lbl_searchDocName";
            lbl_searchDocName.Size = new Size(143, 23);
            lbl_searchDocName.TabIndex = 7;
            lbl_searchDocName.Text = "Doctor Mobile :";
            // 
            // txt_DocMobile
            // 
            txt_DocMobile.Location = new Point(398, 168);
            txt_DocMobile.Margin = new Padding(3, 4, 3, 4);
            txt_DocMobile.Name = "txt_DocMobile";
            txt_DocMobile.Size = new Size(338, 27);
            txt_DocMobile.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(255, 236);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 7;
            label2.Text = "Doctor NIC     :";
            // 
            // txt_DocNIC
            // 
            txt_DocNIC.Location = new Point(398, 231);
            txt_DocNIC.Margin = new Padding(3, 4, 3, 4);
            txt_DocNIC.Name = "txt_DocNIC";
            txt_DocNIC.Size = new Size(338, 27);
            txt_DocNIC.TabIndex = 10;
            // 
            // lbl_doctorDetails
            // 
            lbl_doctorDetails.AutoSize = true;
            lbl_doctorDetails.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_doctorDetails.Location = new Point(251, 317);
            lbl_doctorDetails.Name = "lbl_doctorDetails";
            lbl_doctorDetails.Size = new Size(132, 23);
            lbl_doctorDetails.TabIndex = 7;
            lbl_doctorDetails.Text = "Doctor Details";
            // 
            // lbl_FullName
            // 
            lbl_FullName.AutoSize = true;
            lbl_FullName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_FullName.Location = new Point(251, 372);
            lbl_FullName.Name = "lbl_FullName";
            lbl_FullName.Size = new Size(131, 23);
            lbl_FullName.TabIndex = 7;
            lbl_FullName.Text = "Name             :";
            // 
            // lbl_NIC
            // 
            lbl_NIC.AutoSize = true;
            lbl_NIC.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NIC.Location = new Point(251, 416);
            lbl_NIC.Name = "lbl_NIC";
            lbl_NIC.Size = new Size(132, 23);
            lbl_NIC.TabIndex = 7;
            lbl_NIC.Text = "NIC                :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(541, 207);
            label7.Name = "label7";
            label7.Size = new Size(26, 19);
            label7.TabIndex = 7;
            label7.Text = "or";
            // 
            // btn_Search
            // 
            btn_Search.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Search.Location = new Point(777, 231);
            btn_Search.Margin = new Padding(3, 4, 3, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(86, 31);
            btn_Search.TabIndex = 11;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // lbl_Address
            // 
            lbl_Address.AutoSize = true;
            lbl_Address.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Address.Location = new Point(250, 453);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.Size = new Size(135, 23);
            lbl_Address.TabIndex = 7;
            lbl_Address.Text = "Address          :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(250, 497);
            label3.Name = "label3";
            label3.Size = new Size(130, 23);
            label3.TabIndex = 7;
            label3.Text = "Mobile           :";
            // 
            // lbl_UpcomingAppointments
            // 
            lbl_UpcomingAppointments.AutoSize = true;
            lbl_UpcomingAppointments.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_UpcomingAppointments.Location = new Point(251, 557);
            lbl_UpcomingAppointments.Name = "lbl_UpcomingAppointments";
            lbl_UpcomingAppointments.Size = new Size(126, 23);
            lbl_UpcomingAppointments.TabIndex = 13;
            lbl_UpcomingAppointments.Text = "Appointments";
            // 
            // grid_upcomingAppointments
            // 
            grid_upcomingAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_upcomingAppointments.Location = new Point(255, 593);
            grid_upcomingAppointments.Margin = new Padding(3, 4, 3, 4);
            grid_upcomingAppointments.Name = "grid_upcomingAppointments";
            grid_upcomingAppointments.RowHeadersWidth = 51;
            grid_upcomingAppointments.Size = new Size(621, 197);
            grid_upcomingAppointments.TabIndex = 12;
            // 
            // lbl_showDocName
            // 
            lbl_showDocName.AutoSize = true;
            lbl_showDocName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showDocName.Location = new Point(398, 372);
            lbl_showDocName.Name = "lbl_showDocName";
            lbl_showDocName.Size = new Size(125, 23);
            lbl_showDocName.TabIndex = 7;
            lbl_showDocName.Text = "Sample Name";
            // 
            // lbl_showDocNIC
            // 
            lbl_showDocNIC.AutoSize = true;
            lbl_showDocNIC.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showDocNIC.Location = new Point(398, 416);
            lbl_showDocNIC.Name = "lbl_showDocNIC";
            lbl_showDocNIC.Size = new Size(183, 23);
            lbl_showDocNIC.TabIndex = 7;
            lbl_showDocNIC.Text = "Sample NIC Number";
            // 
            // lbl_showDocAddress
            // 
            lbl_showDocAddress.AutoSize = true;
            lbl_showDocAddress.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showDocAddress.Location = new Point(398, 453);
            lbl_showDocAddress.Name = "lbl_showDocAddress";
            lbl_showDocAddress.Size = new Size(143, 23);
            lbl_showDocAddress.TabIndex = 7;
            lbl_showDocAddress.Text = "Sample Address";
            // 
            // lbl_showDocMobile
            // 
            lbl_showDocMobile.AutoSize = true;
            lbl_showDocMobile.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showDocMobile.Location = new Point(398, 497);
            lbl_showDocMobile.Name = "lbl_showDocMobile";
            lbl_showDocMobile.Size = new Size(183, 23);
            lbl_showDocMobile.TabIndex = 7;
            lbl_showDocMobile.Text = "Sample Specilization";
            // 
            // grid_upcomingAppointmentsForDoctors
            // 
            grid_upcomingAppointmentsForDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_upcomingAppointmentsForDoctors.Location = new Point(917, 259);
            grid_upcomingAppointmentsForDoctors.Margin = new Padding(3, 4, 3, 4);
            grid_upcomingAppointmentsForDoctors.Name = "grid_upcomingAppointmentsForDoctors";
            grid_upcomingAppointmentsForDoctors.RowHeadersWidth = 51;
            grid_upcomingAppointmentsForDoctors.Size = new Size(264, 523);
            grid_upcomingAppointmentsForDoctors.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(917, 236);
            label6.Name = "label6";
            label6.Size = new Size(280, 19);
            label6.TabIndex = 13;
            label6.Text = "Upcoming Appointments for Doctors";
            // 
            // lbl_SearchInstruction
            // 
            lbl_SearchInstruction.AutoSize = true;
            lbl_SearchInstruction.BackColor = SystemColors.ButtonShadow;
            lbl_SearchInstruction.Location = new Point(356, 687);
            lbl_SearchInstruction.Name = "lbl_SearchInstruction";
            lbl_SearchInstruction.Size = new Size(389, 20);
            lbl_SearchInstruction.TabIndex = 40;
            lbl_SearchInstruction.Text = "Search from NIC or Mobile number to view appointments";
            // 
            // AdminViewDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 253, 254);
            ClientSize = new Size(1239, 815);
            Controls.Add(lbl_SearchInstruction);
            Controls.Add(sidebar);
            Controls.Add(label6);
            Controls.Add(grid_upcomingAppointmentsForDoctors);
            Controls.Add(lbl_UpcomingAppointments);
            Controls.Add(grid_upcomingAppointments);
            Controls.Add(btn_Search);
            Controls.Add(txt_DocNIC);
            Controls.Add(txt_DocMobile);
            Controls.Add(btn_Remove);
            Controls.Add(btn_Add);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(lbl_Address);
            Controls.Add(lbl_NIC);
            Controls.Add(lbl_showDocMobile);
            Controls.Add(lbl_showDocAddress);
            Controls.Add(lbl_showDocNIC);
            Controls.Add(lbl_showDocName);
            Controls.Add(lbl_FullName);
            Controls.Add(lbl_doctorDetails);
            Controls.Add(lbl_searchDocName);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(lbl_AdminViewDocTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AdminViewDoctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management System";
            Load += AdminViewDoctor_Load;
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
            ((System.ComponentModel.ISupportInitialize)btn_Remove).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_Add).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_upcomingAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_upcomingAppointmentsForDoctors).EndInit();
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
        private PictureBox btn_Remove;
        private PictureBox btn_Add;
        private Label label5;
        private Label label4;
        private Label lbl_searchDocName;
        private TextBox txt_DocMobile;
        private Label label2;
        private TextBox txt_DocNIC;
        private Label lbl_doctorDetails;
        private Label lbl_FullName;
        private Label lbl_NIC;
        private Label label7;
        private Button btn_Search;
        private Label lbl_Address;
        private Label label3;
        private Label lbl_UpcomingAppointments;
        private DataGridView grid_upcomingAppointments;
        private Label lbl_showDocName;
        private Label lbl_showDocNIC;
        private Label lbl_showDocAddress;
        private Label lbl_showDocMobile;
        private DataGridView grid_upcomingAppointmentsForDoctors;
        private Label label6;
        private Panel panel9;
        private Button button6;
        private Label lbl_SearchInstruction;
    }
}