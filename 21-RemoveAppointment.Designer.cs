namespace FinalProjectHMS
{
    partial class RemoveAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveAppointment));
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
            btn_Search = new Button();
            txt_SearchAppointment = new TextBox();
            lbl_searchPatientName = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            button7 = new Button();
            button8 = new Button();
            label2 = new Label();
            lbl_showAppointmentNumber = new Label();
            lbl_showPatientName = new Label();
            lbl_showPatientNIC = new Label();
            lbl_showAppointmentDate = new Label();
            lbl_showDocName = new Label();
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
            sidebar.Size = new Size(297, 815);
            sidebar.TabIndex = 32;
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
            lbl_AdminViewDocTitle.Location = new Point(489, 35);
            lbl_AdminViewDocTitle.Name = "lbl_AdminViewDocTitle";
            lbl_AdminViewDocTitle.Size = new Size(294, 70);
            lbl_AdminViewDocTitle.TabIndex = 34;
            lbl_AdminViewDocTitle.Text = "-Suwasewa Hospital - \r\n     Appointments";
            // 
            // btn_Search
            // 
            btn_Search.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Search.Location = new Point(851, 220);
            btn_Search.Margin = new Padding(3, 4, 3, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(86, 31);
            btn_Search.TabIndex = 40;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_SearchAppointment
            // 
            txt_SearchAppointment.Location = new Point(498, 220);
            txt_SearchAppointment.Margin = new Padding(3, 4, 3, 4);
            txt_SearchAppointment.Name = "txt_SearchAppointment";
            txt_SearchAppointment.Size = new Size(338, 27);
            txt_SearchAppointment.TabIndex = 38;
            // 
            // lbl_searchPatientName
            // 
            lbl_searchPatientName.AutoSize = true;
            lbl_searchPatientName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_searchPatientName.Location = new Point(303, 220);
            lbl_searchPatientName.Name = "lbl_searchPatientName";
            lbl_searchPatientName.Size = new Size(207, 23);
            lbl_searchPatientName.TabIndex = 36;
            lbl_searchPatientName.Text = "Appointment Number  :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(303, 495);
            label12.Name = "label12";
            label12.Size = new Size(204, 23);
            label12.TabIndex = 62;
            label12.Text = "Doctor Name               :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(303, 451);
            label13.Name = "label13";
            label13.Size = new Size(206, 23);
            label13.TabIndex = 61;
            label13.Text = "Appointment Date       :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(303, 407);
            label14.Name = "label14";
            label14.Size = new Size(207, 23);
            label14.TabIndex = 60;
            label14.Text = "NIC                               :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(303, 359);
            label15.Name = "label15";
            label15.Size = new Size(206, 23);
            label15.TabIndex = 59;
            label15.Text = "Name                            :";
            // 
            // button7
            // 
            button7.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.Location = new Point(635, 576);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(86, 36);
            button7.TabIndex = 73;
            button7.Text = "Cancel";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(511, 576);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(86, 36);
            button8.TabIndex = 72;
            button8.Text = "Romove";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(303, 317);
            label2.Name = "label2";
            label2.Size = new Size(207, 23);
            label2.TabIndex = 36;
            label2.Text = "Appointment Number  :";
            // 
            // lbl_showAppointmentNumber
            // 
            lbl_showAppointmentNumber.AutoSize = true;
            lbl_showAppointmentNumber.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showAppointmentNumber.Location = new Point(516, 317);
            lbl_showAppointmentNumber.Name = "lbl_showAppointmentNumber";
            lbl_showAppointmentNumber.Size = new Size(117, 23);
            lbl_showAppointmentNumber.TabIndex = 36;
            lbl_showAppointmentNumber.Text = "Sample Data";
            // 
            // lbl_showPatientName
            // 
            lbl_showPatientName.AutoSize = true;
            lbl_showPatientName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showPatientName.Location = new Point(516, 359);
            lbl_showPatientName.Name = "lbl_showPatientName";
            lbl_showPatientName.Size = new Size(117, 23);
            lbl_showPatientName.TabIndex = 36;
            lbl_showPatientName.Text = "Sample Data";
            // 
            // lbl_showPatientNIC
            // 
            lbl_showPatientNIC.AutoSize = true;
            lbl_showPatientNIC.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showPatientNIC.Location = new Point(516, 406);
            lbl_showPatientNIC.Name = "lbl_showPatientNIC";
            lbl_showPatientNIC.Size = new Size(117, 23);
            lbl_showPatientNIC.TabIndex = 36;
            lbl_showPatientNIC.Text = "Sample Data";
            // 
            // lbl_showAppointmentDate
            // 
            lbl_showAppointmentDate.AutoSize = true;
            lbl_showAppointmentDate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showAppointmentDate.Location = new Point(516, 451);
            lbl_showAppointmentDate.Name = "lbl_showAppointmentDate";
            lbl_showAppointmentDate.Size = new Size(117, 23);
            lbl_showAppointmentDate.TabIndex = 36;
            lbl_showAppointmentDate.Text = "Sample Data";
            // 
            // lbl_showDocName
            // 
            lbl_showDocName.AutoSize = true;
            lbl_showDocName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showDocName.Location = new Point(516, 493);
            lbl_showDocName.Name = "lbl_showDocName";
            lbl_showDocName.Size = new Size(117, 23);
            lbl_showDocName.TabIndex = 36;
            lbl_showDocName.Text = "Sample Data";
            // 
            // RemoveAppointment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 253, 254);
            ClientSize = new Size(1239, 815);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(sidebar);
            Controls.Add(btn_Search);
            Controls.Add(txt_SearchAppointment);
            Controls.Add(lbl_showDocName);
            Controls.Add(lbl_showAppointmentDate);
            Controls.Add(lbl_showPatientNIC);
            Controls.Add(lbl_showPatientName);
            Controls.Add(lbl_showAppointmentNumber);
            Controls.Add(label2);
            Controls.Add(lbl_searchPatientName);
            Controls.Add(lbl_AdminViewDocTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "RemoveAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management System";
            Load += RemoveAppointment_Load;
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
        private Panel panel9;
        private Button button6;
        private System.Windows.Forms.Timer sidebarTimer;
        private Label lbl_AdminViewDocTitle;
        private Button btn_Search;
        private TextBox txt_SearchAppointment;
        private Label lbl_searchPatientName;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Button button7;
        private Button button8;
        private Label label2;
        private Label lbl_showAppointmentNumber;
        private Label lbl_showPatientName;
        private Label lbl_showPatientNIC;
        private Label lbl_showAppointmentDate;
        private Label lbl_showDocName;
    }
}