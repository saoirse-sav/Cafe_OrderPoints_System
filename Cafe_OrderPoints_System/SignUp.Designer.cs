namespace Cafe_OrderPoints_System
{
    partial class SignUp
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
            btnSignUp = new Button();
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtConfirm = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(270, 243);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(94, 29);
            btnSignUp.TabIndex = 0;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 73);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(202, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(231, 27);
            txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 114);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(123, 153);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 194);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(202, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(231, 27);
            txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(202, 111);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(231, 27);
            txtUsername.TabIndex = 7;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(202, 191);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(231, 27);
            txtConfirm.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(188, 20);
            label5.TabIndex = 9;
            label5.Text = "Please fill up the following:";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 318);
            Controls.Add(label5);
            Controls.Add(txtConfirm);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(btnSignUp);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUp;
        private Label label1;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtConfirm;
        private Label label5;
    }
}