namespace FinalProjectHMS
{
    partial class ManageBills
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBills));
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
            lbl_AdminViewDocTitle = new Label();
            label2 = new Label();
            txt_RoomNumber = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            txt_AmountPerDay = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txt_AdditionalCost = new TextBox();
            label11 = new Label();
            label12 = new Label();
            txt_DaysOfStay = new TextBox();
            button8 = new Button();
            label13 = new Label();
            dataGridView1 = new DataGridView();
            lbl_searchPatientName = new Label();
            label14 = new Label();
            txt_PatientNIC = new TextBox();
            button9 = new Button();
            lbl_showRoomNumber = new Label();
            lbl_showRoomType = new Label();
            lbl_showRoomACType = new Label();
            lbl_showAvailability = new Label();
            lbl_TotalAmout = new Label();
            btn_Search = new Button();
            button7 = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            sidebar.Size = new Size(164, 815);
            sidebar.TabIndex = 35;
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
            // lbl_AdminViewDocTitle
            // 
            lbl_AdminViewDocTitle.AutoSize = true;
            lbl_AdminViewDocTitle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_AdminViewDocTitle.Location = new Point(441, 28);
            lbl_AdminViewDocTitle.Name = "lbl_AdminViewDocTitle";
            lbl_AdminViewDocTitle.Size = new Size(294, 70);
            lbl_AdminViewDocTitle.TabIndex = 72;
            lbl_AdminViewDocTitle.Text = "-Suwasewa Hospital - \r\n   Bill Management";
            lbl_AdminViewDocTitle.Click += lbl_AdminViewDocTitle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(288, 172);
            label2.Name = "label2";
            label2.Size = new Size(158, 23);
            label2.TabIndex = 73;
            label2.Text = "Room Number   : ";
            // 
            // txt_RoomNumber
            // 
            txt_RoomNumber.FormattingEnabled = true;
            txt_RoomNumber.Items.AddRange(new object[] { "Room 01", "Room 02", "Room 03", "Room 04", "Room 05", "Room 06", "Room 07", "Room 08", "Room 09", "Room 10" });
            txt_RoomNumber.Location = new Point(441, 167);
            txt_RoomNumber.Margin = new Padding(3, 4, 3, 4);
            txt_RoomNumber.Name = "txt_RoomNumber";
            txt_RoomNumber.Size = new Size(138, 28);
            txt_RoomNumber.TabIndex = 74;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(289, 388);
            label6.Name = "label6";
            label6.Size = new Size(177, 23);
            label6.TabIndex = 75;
            label6.Text = "Availability            : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(289, 348);
            label5.Name = "label5";
            label5.Size = new Size(176, 23);
            label5.TabIndex = 76;
            label5.Text = "A/C or Non A/C    : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(288, 303);
            label4.Name = "label4";
            label4.Size = new Size(178, 23);
            label4.TabIndex = 77;
            label4.Text = "Room Type            : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(288, 256);
            label3.Name = "label3";
            label3.Size = new Size(178, 23);
            label3.TabIndex = 78;
            label3.Text = "Room Number       : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(295, 503);
            label7.Name = "label7";
            label7.Size = new Size(187, 23);
            label7.TabIndex = 75;
            label7.Text = "Amount  (/Day)       : ";
            // 
            // txt_AmountPerDay
            // 
            txt_AmountPerDay.Location = new Point(514, 500);
            txt_AmountPerDay.Margin = new Padding(3, 4, 3, 4);
            txt_AmountPerDay.Name = "txt_AmountPerDay";
            txt_AmountPerDay.Size = new Size(137, 27);
            txt_AmountPerDay.TabIndex = 79;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(471, 503);
            label8.Name = "label8";
            label8.Size = new Size(37, 23);
            label8.TabIndex = 75;
            label8.Text = "Rs.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(295, 552);
            label9.Name = "label9";
            label9.Size = new Size(185, 23);
            label9.TabIndex = 75;
            label9.Text = "Additional Costs     : ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(471, 551);
            label10.Name = "label10";
            label10.Size = new Size(37, 23);
            label10.TabIndex = 75;
            label10.Text = "Rs.";
            // 
            // txt_AdditionalCost
            // 
            txt_AdditionalCost.Location = new Point(514, 547);
            txt_AdditionalCost.Margin = new Padding(3, 4, 3, 4);
            txt_AdditionalCost.Name = "txt_AdditionalCost";
            txt_AdditionalCost.Size = new Size(137, 27);
            txt_AdditionalCost.TabIndex = 79;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(295, 703);
            label11.Name = "label11";
            label11.Size = new Size(185, 23);
            label11.TabIndex = 75;
            label11.Text = "Total Amount          : ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(294, 591);
            label12.Name = "label12";
            label12.Size = new Size(184, 23);
            label12.TabIndex = 75;
            label12.Text = "Days of Stay           : ";
            // 
            // txt_DaysOfStay
            // 
            txt_DaysOfStay.Location = new Point(513, 585);
            txt_DaysOfStay.Margin = new Padding(3, 4, 3, 4);
            txt_DaysOfStay.Name = "txt_DaysOfStay";
            txt_DaysOfStay.Size = new Size(137, 27);
            txt_DaysOfStay.TabIndex = 79;
            // 
            // button8
            // 
            button8.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(712, 703);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(86, 31);
            button8.TabIndex = 80;
            button8.Text = "Paid";
            button8.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(471, 703);
            label13.Name = "label13";
            label13.Size = new Size(37, 23);
            label13.TabIndex = 75;
            label13.Text = "Rs.";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(936, 167);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(267, 572);
            dataGridView1.TabIndex = 82;
            // 
            // lbl_searchPatientName
            // 
            lbl_searchPatientName.AutoSize = true;
            lbl_searchPatientName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_searchPatientName.Location = new Point(936, 131);
            lbl_searchPatientName.Name = "lbl_searchPatientName";
            lbl_searchPatientName.Size = new Size(168, 23);
            lbl_searchPatientName.TabIndex = 81;
            lbl_searchPatientName.Text = "Recently Paid Bills";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(295, 459);
            label14.Name = "label14";
            label14.Size = new Size(183, 23);
            label14.TabIndex = 75;
            label14.Text = "Patient NIC            : ";
            // 
            // txt_PatientNIC
            // 
            txt_PatientNIC.Location = new Point(514, 459);
            txt_PatientNIC.Margin = new Padding(3, 4, 3, 4);
            txt_PatientNIC.Name = "txt_PatientNIC";
            txt_PatientNIC.Size = new Size(137, 27);
            txt_PatientNIC.TabIndex = 79;
            // 
            // button9
            // 
            button9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button9.Location = new Point(936, 67);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(155, 55);
            button9.TabIndex = 80;
            button9.Text = "View Paid Bills";
            button9.UseVisualStyleBackColor = true;
            // 
            // lbl_showRoomNumber
            // 
            lbl_showRoomNumber.AutoSize = true;
            lbl_showRoomNumber.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showRoomNumber.Location = new Point(473, 258);
            lbl_showRoomNumber.Name = "lbl_showRoomNumber";
            lbl_showRoomNumber.Size = new Size(117, 23);
            lbl_showRoomNumber.TabIndex = 78;
            lbl_showRoomNumber.Text = "Sample Data";
            // 
            // lbl_showRoomType
            // 
            lbl_showRoomType.AutoSize = true;
            lbl_showRoomType.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showRoomType.Location = new Point(473, 303);
            lbl_showRoomType.Name = "lbl_showRoomType";
            lbl_showRoomType.Size = new Size(117, 23);
            lbl_showRoomType.TabIndex = 78;
            lbl_showRoomType.Text = "Sample Data";
            // 
            // lbl_showRoomACType
            // 
            lbl_showRoomACType.AutoSize = true;
            lbl_showRoomACType.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showRoomACType.Location = new Point(471, 349);
            lbl_showRoomACType.Name = "lbl_showRoomACType";
            lbl_showRoomACType.Size = new Size(117, 23);
            lbl_showRoomACType.TabIndex = 78;
            lbl_showRoomACType.Text = "Sample Data";
            // 
            // lbl_showAvailability
            // 
            lbl_showAvailability.AutoSize = true;
            lbl_showAvailability.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showAvailability.Location = new Point(471, 389);
            lbl_showAvailability.Name = "lbl_showAvailability";
            lbl_showAvailability.Size = new Size(117, 23);
            lbl_showAvailability.TabIndex = 78;
            lbl_showAvailability.Text = "Sample Data";
            // 
            // lbl_TotalAmout
            // 
            lbl_TotalAmout.AutoSize = true;
            lbl_TotalAmout.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TotalAmout.Location = new Point(514, 703);
            lbl_TotalAmout.Name = "lbl_TotalAmout";
            lbl_TotalAmout.Size = new Size(117, 23);
            lbl_TotalAmout.TabIndex = 78;
            lbl_TotalAmout.Text = "Sample Data";
            // 
            // btn_Search
            // 
            btn_Search.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Search.Location = new Point(618, 165);
            btn_Search.Margin = new Padding(3, 4, 3, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(86, 31);
            btn_Search.TabIndex = 80;
            btn_Search.Text = "Update";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += button7_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(471, 634);
            button7.Name = "button7";
            button7.Size = new Size(126, 37);
            button7.TabIndex = 83;
            button7.Text = "Calculate";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_1;
            // 
            // ManageBills
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 253, 254);
            ClientSize = new Size(1239, 815);
            Controls.Add(button7);
            Controls.Add(sidebar);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_searchPatientName);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(btn_Search);
            Controls.Add(txt_DaysOfStay);
            Controls.Add(txt_AdditionalCost);
            Controls.Add(txt_PatientNIC);
            Controls.Add(txt_AmountPerDay);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label9);
            Controls.Add(label14);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbl_TotalAmout);
            Controls.Add(lbl_showAvailability);
            Controls.Add(lbl_showRoomACType);
            Controls.Add(lbl_showRoomType);
            Controls.Add(lbl_showRoomNumber);
            Controls.Add(label3);
            Controls.Add(txt_RoomNumber);
            Controls.Add(label2);
            Controls.Add(lbl_AdminViewDocTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ManageBills";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management System";
            Load += ManageBills_Load;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Panel panel9;
        private Button button6;
        private Label lbl_AdminViewDocTitle;
        private Label label2;
        private ComboBox txt_RoomNumber;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private TextBox txt_AmountPerDay;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txt_AdditionalCost;
        private Label label11;
        private Label label12;
        private TextBox txt_DaysOfStay;
        private Button button8;
        private Label label13;
        private DataGridView dataGridView1;
        private Label lbl_searchPatientName;
        private Label label14;
        private TextBox txt_PatientNIC;
        private Button button9;
        private Label lbl_showRoomNumber;
        private Label lbl_showRoomType;
        private Label lbl_showRoomACType;
        private Label lbl_showAvailability;
        private Label lbl_TotalAmout;
        private Button btn_Search;
        private Button button7;
    }
}