namespace Cafe_OrderPoints_System
{
    partial class LogIn
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
            btnSignup = new Button();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(174, 297);
            btnSignup.Margin = new Padding(3, 2, 3, 2);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(93, 29);
            btnSignup.TabIndex = 0;
            btnSignup.Text = "SIGN UP";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(200, 166);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 26);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "LOG IN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 280);
            label1.Name = "label1";
            label1.Size = new Size(176, 15);
            label1.TabIndex = 2;
            label1.Text = "Don't have an account? sign up!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 86);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 5;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 129);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(156, 84);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(192, 23);
            txtUsername.TabIndex = 7;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(156, 127);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(192, 23);
            txtPassword.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 597);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 9;
            label4.Text = "Username:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(418, 92);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 10;
            label5.Text = "Username:";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pexels_thelazyartist_1471120;
            ClientSize = new Size(461, 335);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(btnSignup);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LogIn";
            Text = "LogIn";
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignup;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label4;
        private Label label5;
    }
}