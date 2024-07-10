﻿namespace FinalProjectHMS
{
    partial class DocForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocForgotPassword));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_NIC = new TextBox();
            label5 = new Label();
            txt_SecretPin = new TextBox();
            btn_Previous = new Button();
            btn_Submit = new Button();
            btn_Cancel = new Button();
            btn_NIC_Clear = new Button();
            btn_SecretPinClear = new Button();
            btn_Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(331, -56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(443, 369);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(432, 258);
            label1.Name = "label1";
            label1.Size = new Size(234, 31);
            label1.TabIndex = 1;
            label1.Text = "Forgot Password ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(334, 292);
            label2.Name = "label2";
            label2.Size = new Size(439, 19);
            label2.TabIndex = 2;
            label2.Text = "*Please enter your NIC and secret pin number to reset password";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(352, 320);
            label3.Name = "label3";
            label3.Size = new Size(405, 15);
            label3.TabIndex = 3;
            label3.Text = "(If you forgot your secret pin number please contact the admin) 011* *** ***";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(299, 381);
            label4.Name = "label4";
            label4.Size = new Size(47, 24);
            label4.TabIndex = 4;
            label4.Text = "NIC";
            // 
            // txt_NIC
            // 
            txt_NIC.Location = new Point(418, 385);
            txt_NIC.Name = "txt_NIC";
            txt_NIC.Size = new Size(356, 23);
            txt_NIC.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(299, 436);
            label5.Name = "label5";
            label5.Size = new Size(102, 24);
            label5.TabIndex = 4;
            label5.Text = "Secret Pin";
            // 
            // txt_SecretPin
            // 
            txt_SecretPin.Location = new Point(417, 436);
            txt_SecretPin.Name = "txt_SecretPin";
            txt_SecretPin.Size = new Size(356, 23);
            txt_SecretPin.TabIndex = 5;
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
            btn_Previous.Click += btn_Previous_Click;
            // 
            // btn_Submit
            // 
            btn_Submit.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_Submit.Location = new Point(472, 489);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(75, 23);
            btn_Submit.TabIndex = 6;
            btn_Submit.Text = "Submit";
            btn_Submit.UseVisualStyleBackColor = true;
            btn_Submit.Click += btn_Submit_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_Cancel.Location = new Point(622, 489);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(75, 23);
            btn_Cancel.TabIndex = 6;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // btn_NIC_Clear
            // 
            btn_NIC_Clear.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_NIC_Clear.Location = new Point(822, 385);
            btn_NIC_Clear.Name = "btn_NIC_Clear";
            btn_NIC_Clear.Size = new Size(75, 23);
            btn_NIC_Clear.TabIndex = 7;
            btn_NIC_Clear.Text = "Clear";
            btn_NIC_Clear.UseVisualStyleBackColor = true;
            btn_NIC_Clear.Click += btn_NIC_Clear_Click;
            // 
            // btn_SecretPinClear
            // 
            btn_SecretPinClear.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold);
            btn_SecretPinClear.Location = new Point(822, 435);
            btn_SecretPinClear.Name = "btn_SecretPinClear";
            btn_SecretPinClear.Size = new Size(75, 23);
            btn_SecretPinClear.TabIndex = 8;
            btn_SecretPinClear.Text = "Clear";
            btn_SecretPinClear.UseVisualStyleBackColor = true;
            btn_SecretPinClear.Click += btn_SecretPinClear_Click;
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
            // DocForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1084, 611);
            Controls.Add(btn_Exit);
            Controls.Add(btn_SecretPinClear);
            Controls.Add(btn_NIC_Clear);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Submit);
            Controls.Add(btn_Previous);
            Controls.Add(txt_SecretPin);
            Controls.Add(txt_NIC);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "DocForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hospital Management System";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_NIC;
        private Label label5;
        private TextBox txt_SecretPin;
        private Button btn_Previous;
        private Button btn_Submit;
        private Button btn_Cancel;
        private Button btn_NIC_Clear;
        private Button btn_SecretPinClear;
        private Button btn_Exit;
    }
}