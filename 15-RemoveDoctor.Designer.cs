namespace FinalProjectHMS
{
    partial class RemoveDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveDoctor));
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
            btn_Search = new Button();
            txt_DocNIC = new TextBox();
            txt_Mobile = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lbl_Address = new Label();
            lbl_NIC = new Label();
            lbl_showDocMobile = new Label();
            lbl_showDocAddress = new Label();
            lbl_showDocNIC = new Label();
            lbl_showDocName = new Label();
            lbl_FullName = new Label();
            lbl_doctorDetails = new Label();
            lbl_searchDocName = new Label();
            label7 = new Label();
            lbl_AdminViewDocTitle = new Label();
            button6 = new Button();
            btn_viewAppointments = new Button();
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
            sidebar.TabIndex = 4;
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
            // btn_Search
            // 
            btn_Search.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Search.Location = new Point(840, 292);
            btn_Search.Margin = new Padding(3, 4, 3, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(86, 31);
            btn_Search.TabIndex = 26;
            btn_Search.Text = "Search";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // txt_DocNIC
            // 
            txt_DocNIC.Location = new Point(461, 292);
            txt_DocNIC.Margin = new Padding(3, 4, 3, 4);
            txt_DocNIC.Name = "txt_DocNIC";
            txt_DocNIC.Size = new Size(338, 27);
            txt_DocNIC.TabIndex = 24;
            // 
            // txt_Mobile
            // 
            txt_Mobile.Location = new Point(461, 229);
            txt_Mobile.Margin = new Padding(3, 4, 3, 4);
            txt_Mobile.Name = "txt_Mobile";
            txt_Mobile.Size = new Size(338, 27);
            txt_Mobile.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(318, 297);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 12;
            label2.Text = "Doctor NIC   :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(313, 546);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 13;
            label3.Text = "Mobile            :";
            // 
            // lbl_Address
            // 
            lbl_Address.AutoSize = true;
            lbl_Address.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Address.Location = new Point(313, 502);
            lbl_Address.Name = "lbl_Address";
            lbl_Address.Size = new Size(135, 23);
            lbl_Address.TabIndex = 14;
            lbl_Address.Text = "Address          :";
            // 
            // lbl_NIC
            // 
            lbl_NIC.AutoSize = true;
            lbl_NIC.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NIC.Location = new Point(314, 464);
            lbl_NIC.Name = "lbl_NIC";
            lbl_NIC.Size = new Size(132, 23);
            lbl_NIC.TabIndex = 15;
            lbl_NIC.Text = "NIC                :";
            // 
            // lbl_showDocMobile
            // 
            lbl_showDocMobile.AutoSize = true;
            lbl_showDocMobile.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showDocMobile.Location = new Point(461, 546);
            lbl_showDocMobile.Name = "lbl_showDocMobile";
            lbl_showDocMobile.Size = new Size(15, 23);
            lbl_showDocMobile.TabIndex = 16;
            lbl_showDocMobile.Text = ".";
            // 
            // lbl_showDocAddress
            // 
            lbl_showDocAddress.AutoSize = true;
            lbl_showDocAddress.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showDocAddress.Location = new Point(461, 502);
            lbl_showDocAddress.Name = "lbl_showDocAddress";
            lbl_showDocAddress.Size = new Size(15, 23);
            lbl_showDocAddress.TabIndex = 17;
            lbl_showDocAddress.Text = ".";
            // 
            // lbl_showDocNIC
            // 
            lbl_showDocNIC.AutoSize = true;
            lbl_showDocNIC.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showDocNIC.Location = new Point(461, 464);
            lbl_showDocNIC.Name = "lbl_showDocNIC";
            lbl_showDocNIC.Size = new Size(15, 23);
            lbl_showDocNIC.TabIndex = 18;
            lbl_showDocNIC.Text = ".";
            // 
            // lbl_showDocName
            // 
            lbl_showDocName.AutoSize = true;
            lbl_showDocName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_showDocName.Location = new Point(461, 420);
            lbl_showDocName.Name = "lbl_showDocName";
            lbl_showDocName.Size = new Size(15, 23);
            lbl_showDocName.TabIndex = 19;
            lbl_showDocName.Text = ".";
            // 
            // lbl_FullName
            // 
            lbl_FullName.AutoSize = true;
            lbl_FullName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_FullName.Location = new Point(314, 420);
            lbl_FullName.Name = "lbl_FullName";
            lbl_FullName.Size = new Size(131, 23);
            lbl_FullName.TabIndex = 20;
            lbl_FullName.Text = "Name             :";
            // 
            // lbl_doctorDetails
            // 
            lbl_doctorDetails.AutoSize = true;
            lbl_doctorDetails.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_doctorDetails.Location = new Point(314, 379);
            lbl_doctorDetails.Name = "lbl_doctorDetails";
            lbl_doctorDetails.Size = new Size(132, 23);
            lbl_doctorDetails.TabIndex = 21;
            lbl_doctorDetails.Text = "Doctor Details";
            // 
            // lbl_searchDocName
            // 
            lbl_searchDocName.AutoSize = true;
            lbl_searchDocName.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_searchDocName.Location = new Point(318, 235);
            lbl_searchDocName.Name = "lbl_searchDocName";
            lbl_searchDocName.Size = new Size(134, 23);
            lbl_searchDocName.TabIndex = 22;
            lbl_searchDocName.Text = "Doctor Name :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(603, 268);
            label7.Name = "label7";
            label7.Size = new Size(26, 19);
            label7.TabIndex = 23;
            label7.Text = "or";
            // 
            // lbl_AdminViewDocTitle
            // 
            lbl_AdminViewDocTitle.AutoSize = true;
            lbl_AdminViewDocTitle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_AdminViewDocTitle.Location = new Point(461, 39);
            lbl_AdminViewDocTitle.Name = "lbl_AdminViewDocTitle";
            lbl_AdminViewDocTitle.Size = new Size(294, 70);
            lbl_AdminViewDocTitle.TabIndex = 27;
            lbl_AdminViewDocTitle.Text = "-Suwasewa Hospital - \r\n       Remove Doctor";
            // 
            // button6
            // 
            button6.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(585, 673);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 36);
            button6.TabIndex = 28;
            button6.Text = "Cancel";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btn_viewAppointments
            // 
            btn_viewAppointments.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_viewAppointments.Location = new Point(461, 673);
            btn_viewAppointments.Margin = new Padding(3, 4, 3, 4);
            btn_viewAppointments.Name = "btn_viewAppointments";
            btn_viewAppointments.Size = new Size(86, 36);
            btn_viewAppointments.TabIndex = 29;
            btn_viewAppointments.Text = "Remove";
            btn_viewAppointments.UseVisualStyleBackColor = true;
            btn_viewAppointments.Click += btn_viewAppointments_Click;
            // 
            // RemoveDoctor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 253, 254);
            ClientSize = new Size(1239, 815);
            Controls.Add(button6);
            Controls.Add(btn_viewAppointments);
            Controls.Add(lbl_AdminViewDocTitle);
            Controls.Add(btn_Search);
            Controls.Add(txt_DocNIC);
            Controls.Add(txt_Mobile);
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
            Controls.Add(sidebar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "RemoveDoctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management System";
            Load += RemoveDoctor_Load;
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
        private Button btn_Search;
        private TextBox txt_DocNIC;
        private TextBox txt_Mobile;
        private Label label2;
        private Label label3;
        private Label lbl_Address;
        private Label lbl_NIC;
        private Label lbl_showDocMobile;
        private Label lbl_showDocAddress;
        private Label lbl_showDocNIC;
        private Label lbl_showDocName;
        private Label lbl_FullName;
        private Label lbl_doctorDetails;
        private Label lbl_searchDocName;
        private Label label7;
        private Label lbl_AdminViewDocTitle;
        private Button button6;
        private Button btn_viewAppointments;
        private Panel panel9;
        private Button button7;
    }
}