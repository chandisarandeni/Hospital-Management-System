namespace FinalProjectHMS
{
    partial class DoctorLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorLogin));
            pic_Doctor = new PictureBox();
            lbl_DocUsername = new Label();
            txt_DocUsername = new TextBox();
            lbl_login = new Label();
            lbl_DocPassword = new Label();
            txt_DocPassword = new TextBox();
            btn_DocSubmit = new Button();
            btn_DocCancel = new Button();
            btn_ClearDocUsername = new Button();
            btn_ClearDocPassword = new Button();
            btn_Previous = new Button();
            lbl_ForgotPassword = new Label();
            lbl_ForgotPassword1 = new Label();
            btn_Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_Doctor).BeginInit();
            SuspendLayout();
            // 
            // pic_Doctor
            // 
            pic_Doctor.Image = (Image)resources.GetObject("pic_Doctor.Image");
            pic_Doctor.Location = new Point(414, 41);
            pic_Doctor.Name = "pic_Doctor";
            pic_Doctor.Size = new Size(243, 235);
            pic_Doctor.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Doctor.TabIndex = 0;
            pic_Doctor.TabStop = false;
            pic_Doctor.Click += pictureBox1_Click;
            // 
            // lbl_DocUsername
            // 
            lbl_DocUsername.AutoSize = true;
            lbl_DocUsername.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_DocUsername.Location = new Point(278, 336);
            lbl_DocUsername.Name = "lbl_DocUsername";
            lbl_DocUsername.Size = new Size(100, 24);
            lbl_DocUsername.TabIndex = 2;
            lbl_DocUsername.Text = "Username";
            lbl_DocUsername.Click += lbl_ChooseIdenty_Click;
            // 
            // txt_DocUsername
            // 
            txt_DocUsername.Location = new Point(414, 340);
            txt_DocUsername.Name = "txt_DocUsername";
            txt_DocUsername.Size = new Size(323, 23);
            txt_DocUsername.TabIndex = 3;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_login.Location = new Point(492, 279);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(86, 32);
            lbl_login.TabIndex = 2;
            lbl_login.Text = "Login";
            lbl_login.Click += lbl_ChooseIdenty_Click;
            // 
            // lbl_DocPassword
            // 
            lbl_DocPassword.AutoSize = true;
            lbl_DocPassword.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_DocPassword.Location = new Point(278, 397);
            lbl_DocPassword.Name = "lbl_DocPassword";
            lbl_DocPassword.Size = new Size(96, 24);
            lbl_DocPassword.TabIndex = 2;
            lbl_DocPassword.Text = "Password";
            lbl_DocPassword.Click += lbl_ChooseIdenty_Click;
            // 
            // txt_DocPassword
            // 
            txt_DocPassword.Location = new Point(414, 401);
            txt_DocPassword.Name = "txt_DocPassword";
            txt_DocPassword.Size = new Size(323, 23);
            txt_DocPassword.TabIndex = 3;
            // 
            // btn_DocSubmit
            // 
            btn_DocSubmit.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_DocSubmit.Location = new Point(462, 453);
            btn_DocSubmit.Name = "btn_DocSubmit";
            btn_DocSubmit.Size = new Size(75, 23);
            btn_DocSubmit.TabIndex = 4;
            btn_DocSubmit.Text = "Submit";
            btn_DocSubmit.UseVisualStyleBackColor = true;
            btn_DocSubmit.Click += btn_DocSubmit_Click;
            // 
            // btn_DocCancel
            // 
            btn_DocCancel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_DocCancel.Location = new Point(582, 453);
            btn_DocCancel.Name = "btn_DocCancel";
            btn_DocCancel.Size = new Size(75, 23);
            btn_DocCancel.TabIndex = 4;
            btn_DocCancel.Text = "Cancel";
            btn_DocCancel.UseVisualStyleBackColor = true;
            btn_DocCancel.Click += btn_DocCancel_Click;
            // 
            // btn_ClearDocUsername
            // 
            btn_ClearDocUsername.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_ClearDocUsername.Location = new Point(753, 339);
            btn_ClearDocUsername.Name = "btn_ClearDocUsername";
            btn_ClearDocUsername.Size = new Size(75, 23);
            btn_ClearDocUsername.TabIndex = 5;
            btn_ClearDocUsername.Text = "Clear";
            btn_ClearDocUsername.UseVisualStyleBackColor = true;
            btn_ClearDocUsername.Click += btn_ClearDocUsername_Click;
            // 
            // btn_ClearDocPassword
            // 
            btn_ClearDocPassword.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_ClearDocPassword.Location = new Point(753, 400);
            btn_ClearDocPassword.Name = "btn_ClearDocPassword";
            btn_ClearDocPassword.Size = new Size(75, 23);
            btn_ClearDocPassword.TabIndex = 5;
            btn_ClearDocPassword.Text = "Clear";
            btn_ClearDocPassword.UseVisualStyleBackColor = true;
            btn_ClearDocPassword.Click += btn_ClearDocUsername_Click;
            // 
            // btn_Previous
            // 
            btn_Previous.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_Previous.Location = new Point(60, 530);
            btn_Previous.Name = "btn_Previous";
            btn_Previous.Size = new Size(75, 23);
            btn_Previous.TabIndex = 6;
            btn_Previous.Text = "Previous";
            btn_Previous.UseVisualStyleBackColor = true;
            btn_Previous.Click += btn_Previous_Click_1;
            // 
            // lbl_ForgotPassword
            // 
            lbl_ForgotPassword.AutoSize = true;
            lbl_ForgotPassword.Cursor = Cursors.Hand;
            lbl_ForgotPassword.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_ForgotPassword.Location = new Point(462, 494);
            lbl_ForgotPassword.Name = "lbl_ForgotPassword";
            lbl_ForgotPassword.Size = new Size(108, 15);
            lbl_ForgotPassword.TabIndex = 7;
            lbl_ForgotPassword.Text = "Forgot Password ?";
            lbl_ForgotPassword.Click += lbl_ForgotPassword_Click;
            // 
            // lbl_ForgotPassword1
            // 
            lbl_ForgotPassword1.AutoSize = true;
            lbl_ForgotPassword1.Cursor = Cursors.Hand;
            lbl_ForgotPassword1.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_ForgotPassword1.Location = new Point(571, 494);
            lbl_ForgotPassword1.Name = "lbl_ForgotPassword1";
            lbl_ForgotPassword1.Size = new Size(63, 15);
            lbl_ForgotPassword1.TabIndex = 7;
            lbl_ForgotPassword1.Text = "click here";
            lbl_ForgotPassword1.Click += lbl_ForgotPassword1_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Location = new Point(980, 25);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(75, 30);
            btn_Exit.TabIndex = 14;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // DoctorLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 611);
            Controls.Add(btn_Exit);
            Controls.Add(lbl_ForgotPassword1);
            Controls.Add(lbl_ForgotPassword);
            Controls.Add(btn_Previous);
            Controls.Add(btn_ClearDocPassword);
            Controls.Add(btn_ClearDocUsername);
            Controls.Add(btn_DocCancel);
            Controls.Add(btn_DocSubmit);
            Controls.Add(txt_DocPassword);
            Controls.Add(txt_DocUsername);
            Controls.Add(lbl_login);
            Controls.Add(lbl_DocPassword);
            Controls.Add(lbl_DocUsername);
            Controls.Add(pic_Doctor);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DoctorLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management System";
            Load += DoctorLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pic_Doctor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_Doctor;
        private Label lbl_DocUsername;
        private TextBox txt_DocUsername;
        private Label lbl_login;
        private Label lbl_DocPassword;
        private TextBox txt_DocPassword;
        private Button btn_DocSubmit;
        private Button btn_DocCancel;
        private Button btn_ClearDocUsername;
        private Button btn_ClearDocPassword;
        private Button btn_Previous;
        private Label lbl_ForgotPassword;
        private Label lbl_ForgotPassword1;
        private Button btn_Exit;
    }
}