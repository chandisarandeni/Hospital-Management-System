namespace FinalProjectHMS
{
    partial class PatientLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientLogin));
            btn_Previous = new Button();
            btn_ClearPatientPassword = new Button();
            btn_ClearPatientUsername = new Button();
            btn_AdminCancel = new Button();
            btn_AdminSubmit = new Button();
            txt_PatientPassword = new TextBox();
            txt_PatientUsername = new TextBox();
            lbl_login = new Label();
            lbl_PatientPassword = new Label();
            lbl_PatientUsername = new Label();
            pictureBox1 = new PictureBox();
            lbl_ForgotPassword1 = new Label();
            lbl_ForgotPassword = new Label();
            btn_Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Previous
            // 
            btn_Previous.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_Previous.Location = new Point(69, 707);
            btn_Previous.Margin = new Padding(3, 4, 3, 4);
            btn_Previous.Name = "btn_Previous";
            btn_Previous.Size = new Size(86, 31);
            btn_Previous.TabIndex = 27;
            btn_Previous.Text = "Previous";
            btn_Previous.UseVisualStyleBackColor = true;
            btn_Previous.Click += btn_Previous_Click;
            // 
            // btn_ClearPatientPassword
            // 
            btn_ClearPatientPassword.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_ClearPatientPassword.Location = new Point(858, 531);
            btn_ClearPatientPassword.Margin = new Padding(3, 4, 3, 4);
            btn_ClearPatientPassword.Name = "btn_ClearPatientPassword";
            btn_ClearPatientPassword.Size = new Size(86, 31);
            btn_ClearPatientPassword.TabIndex = 25;
            btn_ClearPatientPassword.Text = "Clear";
            btn_ClearPatientPassword.UseVisualStyleBackColor = true;
            btn_ClearPatientPassword.Click += btn_ClearPatientPassword_Click;
            // 
            // btn_ClearPatientUsername
            // 
            btn_ClearPatientUsername.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_ClearPatientUsername.Location = new Point(858, 449);
            btn_ClearPatientUsername.Margin = new Padding(3, 4, 3, 4);
            btn_ClearPatientUsername.Name = "btn_ClearPatientUsername";
            btn_ClearPatientUsername.Size = new Size(86, 31);
            btn_ClearPatientUsername.TabIndex = 26;
            btn_ClearPatientUsername.Text = "Clear";
            btn_ClearPatientUsername.UseVisualStyleBackColor = true;
            btn_ClearPatientUsername.Click += btn_ClearPatientUsername_Click;
            // 
            // btn_AdminCancel
            // 
            btn_AdminCancel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_AdminCancel.Location = new Point(663, 601);
            btn_AdminCancel.Margin = new Padding(3, 4, 3, 4);
            btn_AdminCancel.Name = "btn_AdminCancel";
            btn_AdminCancel.Size = new Size(86, 31);
            btn_AdminCancel.TabIndex = 23;
            btn_AdminCancel.Text = "Cancel";
            btn_AdminCancel.UseVisualStyleBackColor = true;
            btn_AdminCancel.Click += btn_AdminCancel_Click;
            // 
            // btn_AdminSubmit
            // 
            btn_AdminSubmit.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_AdminSubmit.Location = new Point(526, 601);
            btn_AdminSubmit.Margin = new Padding(3, 4, 3, 4);
            btn_AdminSubmit.Name = "btn_AdminSubmit";
            btn_AdminSubmit.Size = new Size(86, 31);
            btn_AdminSubmit.TabIndex = 24;
            btn_AdminSubmit.Text = "Submit";
            btn_AdminSubmit.UseVisualStyleBackColor = true;
            btn_AdminSubmit.Click += btn_AdminSubmit_Click;
            // 
            // txt_PatientPassword
            // 
            txt_PatientPassword.Location = new Point(471, 532);
            txt_PatientPassword.Margin = new Padding(3, 4, 3, 4);
            txt_PatientPassword.Name = "txt_PatientPassword";
            txt_PatientPassword.Size = new Size(369, 27);
            txt_PatientPassword.TabIndex = 21;
            // 
            // txt_PatientUsername
            // 
            txt_PatientUsername.Location = new Point(471, 451);
            txt_PatientUsername.Margin = new Padding(3, 4, 3, 4);
            txt_PatientUsername.Name = "txt_PatientUsername";
            txt_PatientUsername.Size = new Size(369, 27);
            txt_PatientUsername.TabIndex = 22;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_login.Location = new Point(560, 369);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(111, 42);
            lbl_login.TabIndex = 18;
            lbl_login.Text = "Login";
            // 
            // lbl_PatientPassword
            // 
            lbl_PatientPassword.AutoSize = true;
            lbl_PatientPassword.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PatientPassword.Location = new Point(315, 527);
            lbl_PatientPassword.Name = "lbl_PatientPassword";
            lbl_PatientPassword.Size = new Size(127, 31);
            lbl_PatientPassword.TabIndex = 19;
            lbl_PatientPassword.Text = "Password";
            // 
            // lbl_PatientUsername
            // 
            lbl_PatientUsername.AutoSize = true;
            lbl_PatientUsername.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_PatientUsername.Location = new Point(315, 445);
            lbl_PatientUsername.Name = "lbl_PatientUsername";
            lbl_PatientUsername.Size = new Size(132, 31);
            lbl_PatientUsername.TabIndex = 20;
            lbl_PatientUsername.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(477, 52);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(278, 313);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // lbl_ForgotPassword1
            // 
            lbl_ForgotPassword1.AutoSize = true;
            lbl_ForgotPassword1.Cursor = Cursors.Hand;
            lbl_ForgotPassword1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_ForgotPassword1.Location = new Point(650, 672);
            lbl_ForgotPassword1.Name = "lbl_ForgotPassword1";
            lbl_ForgotPassword1.Size = new Size(83, 19);
            lbl_ForgotPassword1.TabIndex = 28;
            lbl_ForgotPassword1.Text = "click here";
            lbl_ForgotPassword1.Click += lbl_ForgotPassword1_Click;
            // 
            // lbl_ForgotPassword
            // 
            lbl_ForgotPassword.AutoSize = true;
            lbl_ForgotPassword.Cursor = Cursors.Hand;
            lbl_ForgotPassword.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ForgotPassword.Location = new Point(526, 672);
            lbl_ForgotPassword.Name = "lbl_ForgotPassword";
            lbl_ForgotPassword.Size = new Size(150, 19);
            lbl_ForgotPassword.TabIndex = 29;
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
            btn_Exit.TabIndex = 30;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // PatientLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1239, 815);
            Controls.Add(btn_Exit);
            Controls.Add(lbl_ForgotPassword1);
            Controls.Add(lbl_ForgotPassword);
            Controls.Add(btn_Previous);
            Controls.Add(btn_ClearPatientPassword);
            Controls.Add(btn_ClearPatientUsername);
            Controls.Add(btn_AdminCancel);
            Controls.Add(btn_AdminSubmit);
            Controls.Add(txt_PatientPassword);
            Controls.Add(txt_PatientUsername);
            Controls.Add(lbl_login);
            Controls.Add(lbl_PatientPassword);
            Controls.Add(lbl_PatientUsername);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "PatientLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management System";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Previous;
        private Button btn_ClearPatientPassword;
        private Button btn_ClearPatientUsername;
        private Button btn_AdminCancel;
        private Button btn_AdminSubmit;
        private TextBox txt_PatientPassword;
        private TextBox txt_PatientUsername;
        private Label lbl_login;
        private Label lbl_PatientPassword;
        private Label lbl_PatientUsername;
        private PictureBox pictureBox1;
        private Label lbl_ForgotPassword1;
        private Label lbl_ForgotPassword;
        private Button btn_Exit;
    }
}