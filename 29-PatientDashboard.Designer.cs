﻿namespace FinalProjectHMS
{
    partial class PatientDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDashboard));
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
            lbl_AdminViewDocTitle = new Label();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            sidebar.SuspendLayout();
            pnl_MenuBar.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_Menu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            sidebar.Size = new Size(90, 815);
            sidebar.TabIndex = 40;
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
            // lbl_AdminViewDocTitle
            // 
            lbl_AdminViewDocTitle.AutoSize = true;
            lbl_AdminViewDocTitle.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_AdminViewDocTitle.Location = new Point(445, 50);
            lbl_AdminViewDocTitle.Name = "lbl_AdminViewDocTitle";
            lbl_AdminViewDocTitle.Size = new Size(294, 35);
            lbl_AdminViewDocTitle.TabIndex = 72;
            lbl_AdminViewDocTitle.Text = "-Suwasewa Hospital - ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(429, 130);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(310, 274);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 73;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(216, 451);
            label2.Name = "label2";
            label2.Size = new Size(796, 31);
            label2.TabIndex = 74;
            label2.Text = "Your sanctuary of healing, where hope thrives and wellness blooms";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(342, 513);
            label3.Name = "label3";
            label3.Size = new Size(553, 69);
            label3.TabIndex = 74;
            label3.Text = "To be the epitome of compassionate care and medical excellence,\r\n                  pioneering innovations and fostering\r\n                                 health equity for all.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(992, 678);
            label4.Name = "label4";
            label4.Size = new Size(147, 23);
            label4.TabIndex = 74;
            label4.Text = "Vidya Mawatha,";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label5.Location = new Point(992, 709);
            label5.Name = "label5";
            label5.Size = new Size(109, 23);
            label5.TabIndex = 74;
            label5.Text = "Colombo 07";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label6.Location = new Point(992, 740);
            label6.Name = "label6";
            label6.Size = new Size(93, 23);
            label6.TabIndex = 74;
            label6.Text = "Sri Lanka";
            // 
            // PatientDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 253, 254);
            ClientSize = new Size(1239, 815);
            Controls.Add(sidebar);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(lbl_AdminViewDocTitle);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "PatientDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management System";
            Load += PatientDashboard_Load;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label lbl_AdminViewDocTitle;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}