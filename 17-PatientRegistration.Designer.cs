namespace FinalProjectHMS
{
    partial class PatientRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientRegistration));
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
            button7 = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            button6 = new Button();
            btn_viewAppointments = new Button();
            txt_PatientSecretPinIN = new TextBox();
            txt_PatientRePasswordIN = new TextBox();
            txt_PatientPasswordIN = new TextBox();
            txt_PatientAddressIN = new TextBox();
            txt_PatientNICIN = new TextBox();
            txt_PatientNameIN = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            lbl_doctorDetails = new Label();
            lbl_searchDocName = new Label();
            lbl_AdminViewDocTitle = new Label();
            label8 = new Label();
            txt_PatientBirthdayIN = new DateTimePicker();
            txt_PatientGenderIN = new ComboBox();
            label9 = new Label();
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
            sidebar.Size = new Size(90, 815);
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
            panel9.Controls.Add(button7);
            panel9.Location = new Point(3, 715);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(293, 73);
            panel9.TabIndex = 3;
            // 
            // button7
            // 
            button7.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-6, -8);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Padding = new Padding(19, 0, 0, 0);
            button7.Size = new Size(341, 92);
            button7.TabIndex = 1;
            button7.Text = "                   Bills";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // button6
            // 
            button6.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(577, 626);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(102, 36);
            button6.TabIndex = 33;
            button6.Text = "Cancel";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btn_viewAppointments
            // 
            btn_viewAppointments.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_viewAppointments.Location = new Point(437, 626);
            btn_viewAppointments.Margin = new Padding(3, 4, 3, 4);
            btn_viewAppointments.Name = "btn_viewAppointments";
            btn_viewAppointments.Size = new Size(108, 36);
            btn_viewAppointments.TabIndex = 32;
            btn_viewAppointments.Text = "Register";
            btn_viewAppointments.UseVisualStyleBackColor = true;
            btn_viewAppointments.Click += btn_viewAppointments_Click;
            // 
            // txt_PatientSecretPinIN
            // 
            txt_PatientSecretPinIN.Location = new Point(435, 564);
            txt_PatientSecretPinIN.Margin = new Padding(3, 4, 3, 4);
            txt_PatientSecretPinIN.Name = "txt_PatientSecretPinIN";
            txt_PatientSecretPinIN.Size = new Size(90, 27);
            txt_PatientSecretPinIN.TabIndex = 30;
            // 
            // txt_PatientRePasswordIN
            // 
            txt_PatientRePasswordIN.Location = new Point(437, 523);
            txt_PatientRePasswordIN.Margin = new Padding(3, 4, 3, 4);
            txt_PatientRePasswordIN.Name = "txt_PatientRePasswordIN";
            txt_PatientRePasswordIN.Size = new Size(388, 27);
            txt_PatientRePasswordIN.TabIndex = 29;
            // 
            // txt_PatientPasswordIN
            // 
            txt_PatientPasswordIN.Location = new Point(437, 479);
            txt_PatientPasswordIN.Margin = new Padding(3, 4, 3, 4);
            txt_PatientPasswordIN.Name = "txt_PatientPasswordIN";
            txt_PatientPasswordIN.Size = new Size(388, 27);
            txt_PatientPasswordIN.TabIndex = 28;
            // 
            // txt_PatientAddressIN
            // 
            txt_PatientAddressIN.Location = new Point(410, 432);
            txt_PatientAddressIN.Margin = new Padding(3, 4, 3, 4);
            txt_PatientAddressIN.Name = "txt_PatientAddressIN";
            txt_PatientAddressIN.Size = new Size(414, 27);
            txt_PatientAddressIN.TabIndex = 26;
            // 
            // txt_PatientNICIN
            // 
            txt_PatientNICIN.Location = new Point(410, 304);
            txt_PatientNICIN.Margin = new Padding(3, 4, 3, 4);
            txt_PatientNICIN.Name = "txt_PatientNICIN";
            txt_PatientNICIN.Size = new Size(414, 27);
            txt_PatientNICIN.TabIndex = 31;
            // 
            // txt_PatientNameIN
            // 
            txt_PatientNameIN.Location = new Point(410, 256);
            txt_PatientNameIN.Margin = new Padding(3, 4, 3, 4);
            txt_PatientNameIN.Name = "txt_PatientNameIN";
            txt_PatientNameIN.Size = new Size(414, 27);
            txt_PatientNameIN.TabIndex = 25;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(278, 569);
            label7.Name = "label7";
            label7.Size = new Size(149, 23);
            label7.TabIndex = 24;
            label7.Text = "Secret Pin         :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(279, 528);
            label6.Name = "label6";
            label6.Size = new Size(148, 23);
            label6.TabIndex = 23;
            label6.Text = "Re-Password    :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(279, 484);
            label5.Name = "label5";
            label5.Size = new Size(147, 23);
            label5.TabIndex = 22;
            label5.Text = "Password          :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(279, 436);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 20;
            label3.Text = "Address       :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(279, 308);
            label2.Name = "label2";
            label2.Size = new Size(122, 23);
            label2.TabIndex = 19;
            label2.Text = "NIC              :";
            // 
            // lbl_doctorDetails
            // 
            lbl_doctorDetails.AutoSize = true;
            lbl_doctorDetails.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_doctorDetails.Location = new Point(279, 260);
            lbl_doctorDetails.Name = "lbl_doctorDetails";
            lbl_doctorDetails.Size = new Size(126, 23);
            lbl_doctorDetails.TabIndex = 18;
            lbl_doctorDetails.Text = "Name            :";
            // 
            // lbl_searchDocName
            // 
            lbl_searchDocName.AutoSize = true;
            lbl_searchDocName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_searchDocName.ForeColor = Color.Red;
            lbl_searchDocName.Location = new Point(279, 204);
            lbl_searchDocName.Name = "lbl_searchDocName";
            lbl_searchDocName.Size = new Size(388, 23);
            lbl_searchDocName.TabIndex = 17;
            lbl_searchDocName.Text = "* Please fill in this form to create an account ";
            // 
            // lbl_AdminViewDocTitle
            // 
            lbl_AdminViewDocTitle.AutoSize = true;
            lbl_AdminViewDocTitle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_AdminViewDocTitle.Location = new Point(472, 50);
            lbl_AdminViewDocTitle.Name = "lbl_AdminViewDocTitle";
            lbl_AdminViewDocTitle.Size = new Size(294, 70);
            lbl_AdminViewDocTitle.TabIndex = 16;
            lbl_AdminViewDocTitle.Text = "-Suwasewa Hospital - \r\n Patient Registration";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(279, 352);
            label8.Name = "label8";
            label8.Size = new Size(125, 23);
            label8.TabIndex = 19;
            label8.Text = "Birthday       :";
            // 
            // txt_PatientBirthdayIN
            // 
            txt_PatientBirthdayIN.Location = new Point(410, 348);
            txt_PatientBirthdayIN.Margin = new Padding(3, 4, 3, 4);
            txt_PatientBirthdayIN.MaxDate = new DateTime(2024, 4, 10, 0, 0, 0, 0);
            txt_PatientBirthdayIN.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            txt_PatientBirthdayIN.Name = "txt_PatientBirthdayIN";
            txt_PatientBirthdayIN.Size = new Size(228, 27);
            txt_PatientBirthdayIN.TabIndex = 34;
            txt_PatientBirthdayIN.Value = new DateTime(2024, 4, 10, 0, 0, 0, 0);
            // 
            // txt_PatientGenderIN
            // 
            txt_PatientGenderIN.FormattingEnabled = true;
            txt_PatientGenderIN.Items.AddRange(new object[] { "Male", "Female" });
            txt_PatientGenderIN.Location = new Point(410, 392);
            txt_PatientGenderIN.Margin = new Padding(3, 4, 3, 4);
            txt_PatientGenderIN.Name = "txt_PatientGenderIN";
            txt_PatientGenderIN.Size = new Size(138, 28);
            txt_PatientGenderIN.TabIndex = 35;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(279, 397);
            label9.Name = "label9";
            label9.Size = new Size(126, 23);
            label9.TabIndex = 19;
            label9.Text = "Gender         :";
            // 
            // PatientRegistration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 253, 254);
            ClientSize = new Size(1239, 815);
            Controls.Add(txt_PatientGenderIN);
            Controls.Add(sidebar);
            Controls.Add(txt_PatientBirthdayIN);
            Controls.Add(button6);
            Controls.Add(btn_viewAppointments);
            Controls.Add(txt_PatientSecretPinIN);
            Controls.Add(txt_PatientRePasswordIN);
            Controls.Add(txt_PatientPasswordIN);
            Controls.Add(txt_PatientAddressIN);
            Controls.Add(txt_PatientNICIN);
            Controls.Add(txt_PatientNameIN);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(lbl_doctorDetails);
            Controls.Add(lbl_searchDocName);
            Controls.Add(lbl_AdminViewDocTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "PatientRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management System";
            Load += PatientRegistration_Load;
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
        private Button button6;
        private Button btn_viewAppointments;
        private TextBox txt_PatientSecretPinIN;
        private TextBox txt_PatientRePasswordIN;
        private TextBox txt_PatientPasswordIN;
        private TextBox txt_PatientAddressIN;
        private TextBox txt_PatientNICIN;
        private TextBox txt_PatientNameIN;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label lbl_doctorDetails;
        private Label lbl_searchDocName;
        private Label lbl_AdminViewDocTitle;
        private Label label8;
        private DateTimePicker txt_PatientBirthdayIN;
        private ComboBox txt_PatientGenderIN;
        private Label label9;
        private Panel panel9;
        private Button button7;
    }
}