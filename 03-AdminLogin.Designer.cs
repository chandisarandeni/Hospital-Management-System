namespace FinalProjectHMS
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            pictureBox1 = new PictureBox();
            btn_Previous = new Button();
            btn_ClearAdminPassword = new Button();
            btn_ClearAdminUsername = new Button();
            btn_AdminCancel = new Button();
            btn_AdminSubmit = new Button();
            txt_AdminPassword = new TextBox();
            txt_AdminUsername = new TextBox();
            lbl_login = new Label();
            lbl_DocPassword = new Label();
            lbl_DocUsername = new Label();
            lbl_ForgotPassword1 = new Label();
            lbl_ForgotPassword = new Label();
            btn_Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(478, 52);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 313);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_Previous
            // 
            btn_Previous.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_Previous.Location = new Point(69, 707);
            btn_Previous.Margin = new Padding(3, 4, 3, 4);
            btn_Previous.Name = "btn_Previous";
            btn_Previous.Size = new Size(86, 31);
            btn_Previous.TabIndex = 16;
            btn_Previous.Text = "Previous";
            btn_Previous.UseVisualStyleBackColor = true;
            btn_Previous.Click += btn_Previous_Click;
            // 
            // btn_ClearAdminPassword
            // 
            btn_ClearAdminPassword.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_ClearAdminPassword.Location = new Point(859, 531);
            btn_ClearAdminPassword.Margin = new Padding(3, 4, 3, 4);
            btn_ClearAdminPassword.Name = "btn_ClearAdminPassword";
            btn_ClearAdminPassword.Size = new Size(86, 31);
            btn_ClearAdminPassword.TabIndex = 14;
            btn_ClearAdminPassword.Text = "Clear";
            btn_ClearAdminPassword.UseVisualStyleBackColor = true;
            btn_ClearAdminPassword.Click += btn_ClearAdminPassword_Click;
            // 
            // btn_ClearAdminUsername
            // 
            btn_ClearAdminUsername.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_ClearAdminUsername.Location = new Point(859, 449);
            btn_ClearAdminUsername.Margin = new Padding(3, 4, 3, 4);
            btn_ClearAdminUsername.Name = "btn_ClearAdminUsername";
            btn_ClearAdminUsername.Size = new Size(86, 31);
            btn_ClearAdminUsername.TabIndex = 15;
            btn_ClearAdminUsername.Text = "Clear";
            btn_ClearAdminUsername.UseVisualStyleBackColor = true;
            btn_ClearAdminUsername.Click += btn_ClearAdminUsername_Click;
            // 
            // btn_AdminCancel
            // 
            btn_AdminCancel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_AdminCancel.Location = new Point(664, 601);
            btn_AdminCancel.Margin = new Padding(3, 4, 3, 4);
            btn_AdminCancel.Name = "btn_AdminCancel";
            btn_AdminCancel.Size = new Size(86, 31);
            btn_AdminCancel.TabIndex = 12;
            btn_AdminCancel.Text = "Cancel";
            btn_AdminCancel.UseVisualStyleBackColor = true;
            btn_AdminCancel.Click += btn_AdminCancel_Click;
            // 
            // btn_AdminSubmit
            // 
            btn_AdminSubmit.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_AdminSubmit.Location = new Point(527, 601);
            btn_AdminSubmit.Margin = new Padding(3, 4, 3, 4);
            btn_AdminSubmit.Name = "btn_AdminSubmit";
            btn_AdminSubmit.Size = new Size(86, 31);
            btn_AdminSubmit.TabIndex = 13;
            btn_AdminSubmit.Text = "Submit";
            btn_AdminSubmit.UseVisualStyleBackColor = true;
            btn_AdminSubmit.Click += btn_AdminSubmit_Click;
            // 
            // txt_AdminPassword
            // 
            txt_AdminPassword.Location = new Point(472, 532);
            txt_AdminPassword.Margin = new Padding(3, 4, 3, 4);
            txt_AdminPassword.Name = "txt_AdminPassword";
            txt_AdminPassword.Size = new Size(369, 27);
            txt_AdminPassword.TabIndex = 10;
            txt_AdminPassword.TextChanged += txt_AdminPassword_TextChanged;
            // 
            // txt_AdminUsername
            // 
            txt_AdminUsername.Location = new Point(472, 451);
            txt_AdminUsername.Margin = new Padding(3, 4, 3, 4);
            txt_AdminUsername.Name = "txt_AdminUsername";
            txt_AdminUsername.Size = new Size(369, 27);
            txt_AdminUsername.TabIndex = 11;
            txt_AdminUsername.TextChanged += txt_AdminUsername_TextChanged;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_login.Location = new Point(561, 369);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(111, 42);
            lbl_login.TabIndex = 7;
            lbl_login.Text = "Login";
            // 
            // lbl_DocPassword
            // 
            lbl_DocPassword.AutoSize = true;
            lbl_DocPassword.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_DocPassword.Location = new Point(317, 527);
            lbl_DocPassword.Name = "lbl_DocPassword";
            lbl_DocPassword.Size = new Size(127, 31);
            lbl_DocPassword.TabIndex = 8;
            lbl_DocPassword.Text = "Password";
            // 
            // lbl_DocUsername
            // 
            lbl_DocUsername.AutoSize = true;
            lbl_DocUsername.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_DocUsername.Location = new Point(317, 445);
            lbl_DocUsername.Name = "lbl_DocUsername";
            lbl_DocUsername.Size = new Size(132, 31);
            lbl_DocUsername.TabIndex = 9;
            lbl_DocUsername.Text = "Username";
            // 
            // lbl_ForgotPassword1
            // 
            lbl_ForgotPassword1.AutoSize = true;
            lbl_ForgotPassword1.Cursor = Cursors.Hand;
            lbl_ForgotPassword1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_ForgotPassword1.Location = new Point(651, 657);
            lbl_ForgotPassword1.Name = "lbl_ForgotPassword1";
            lbl_ForgotPassword1.Size = new Size(83, 19);
            lbl_ForgotPassword1.TabIndex = 17;
            lbl_ForgotPassword1.Text = "click here";
            lbl_ForgotPassword1.Click += lbl_ForgotPassword1_Click;
            // 
            // lbl_ForgotPassword
            // 
            lbl_ForgotPassword.AutoSize = true;
            lbl_ForgotPassword.Cursor = Cursors.Hand;
            lbl_ForgotPassword.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ForgotPassword.Location = new Point(527, 657);
            lbl_ForgotPassword.Name = "lbl_ForgotPassword";
            lbl_ForgotPassword.Size = new Size(150, 19);
            lbl_ForgotPassword.TabIndex = 18;
            lbl_ForgotPassword.Text = "Forgot Password ?";
            lbl_ForgotPassword.Click += lbl_ForgotPassword_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(1120, 33);
            btn_Exit.Margin = new Padding(3, 4, 3, 4);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(86, 40);
            btn_Exit.TabIndex = 19;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1239, 815);
            Controls.Add(btn_Exit);
            Controls.Add(lbl_ForgotPassword1);
            Controls.Add(lbl_ForgotPassword);
            Controls.Add(btn_Previous);
            Controls.Add(btn_ClearAdminPassword);
            Controls.Add(btn_ClearAdminUsername);
            Controls.Add(btn_AdminCancel);
            Controls.Add(btn_AdminSubmit);
            Controls.Add(txt_AdminPassword);
            Controls.Add(txt_AdminUsername);
            Controls.Add(lbl_login);
            Controls.Add(lbl_DocPassword);
            Controls.Add(lbl_DocUsername);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimizeBox = false;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management System";
            Load += AdminLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_Previous;
        private Button btn_ClearAdminPassword;
        private Button btn_ClearAdminUsername;
        private Button btn_AdminCancel;
        private Button btn_AdminSubmit;
        private TextBox txt_AdminPassword;
        private TextBox txt_AdminUsername;
        private Label lbl_login;
        private Label lbl_DocPassword;
        private Label lbl_DocUsername;
        private Label lbl_ForgotPassword1;
        private Label lbl_ForgotPassword;
        private Button btn_Exit;
    }
}