namespace Cafe_OrderPoints_System
{
    partial class Options
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnMakeOrder = new Button();
            btnAddCustomer = new Button();
            btnShowHistory = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 7);
            label1.Name = "label1";
            label1.Size = new Size(267, 30);
            label1.TabIndex = 0;
            label1.Text = "   “Enter and unwind. Here, even the smallest\r\n snack and simplest drink can brighten your day.”";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 46);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 1;
            label2.Text = "“Taste joy, one sip at a time.”";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 117);
            label3.Name = "label3";
            label3.Size = new Size(268, 15);
            label3.TabIndex = 2;
            label3.Text = "Hello, Dear Customer, what would you like to do?";
            // 
            // btnMakeOrder
            // 
            btnMakeOrder.Location = new Point(134, 146);
            btnMakeOrder.Margin = new Padding(3, 2, 3, 2);
            btnMakeOrder.Name = "btnMakeOrder";
            btnMakeOrder.Size = new Size(172, 29);
            btnMakeOrder.TabIndex = 3;
            btnMakeOrder.Text = "Make an Order";
            btnMakeOrder.UseVisualStyleBackColor = true;
            btnMakeOrder.Click += btnMakeOrder_Click;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(134, 194);
            btnAddCustomer.Margin = new Padding(3, 2, 3, 2);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(172, 29);
            btnAddCustomer.TabIndex = 4;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // btnShowHistory
            // 
            btnShowHistory.Location = new Point(134, 241);
            btnShowHistory.Margin = new Padding(3, 2, 3, 2);
            btnShowHistory.Name = "btnShowHistory";
            btnShowHistory.Size = new Size(172, 29);
            btnShowHistory.TabIndex = 5;
            btnShowHistory.Text = "Show Purchase History";
            btnShowHistory.UseVisualStyleBackColor = true;
            btnShowHistory.Click += btnHistory_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(134, 289);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(172, 29);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pexels_thelazyartist_1471120;
            ClientSize = new Size(462, 338);
            Controls.Add(btnLogout);
            Controls.Add(btnShowHistory);
            Controls.Add(btnAddCustomer);
            Controls.Add(btnMakeOrder);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Options";
            Text = "Options";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnMakeOrder;
        private Button btnAddCustomer;
        private Button btnShowHistory;
        private Button btnLogout;
    }
}