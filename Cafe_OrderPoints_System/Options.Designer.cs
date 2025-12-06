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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 9);
            label1.Name = "label1";
            label1.Size = new Size(331, 40);
            label1.TabIndex = 0;
            label1.Text = "   “Enter and unwind. Here, even the smallest\r\n snack and simplest drink can brighten your day.”";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 62);
            label2.Name = "label2";
            label2.Size = new Size(199, 20);
            label2.TabIndex = 1;
            label2.Text = "“Taste joy, one sip at a time.”";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 156);
            label3.Name = "label3";
            label3.Size = new Size(337, 20);
            label3.TabIndex = 2;
            label3.Text = "Hello, Dear Customer, what would you like to do?";
            // 
            // button1
            // 
            button1.Location = new Point(153, 194);
            button1.Name = "button1";
            button1.Size = new Size(196, 39);
            button1.TabIndex = 3;
            button1.Text = "Make an Order";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(153, 258);
            button2.Name = "button2";
            button2.Size = new Size(196, 39);
            button2.TabIndex = 4;
            button2.Text = "Add Customer";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(153, 321);
            button3.Name = "button3";
            button3.Size = new Size(196, 39);
            button3.TabIndex = 5;
            button3.Text = "Show Purchase History";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(153, 385);
            button4.Name = "button4";
            button4.Size = new Size(196, 39);
            button4.TabIndex = 6;
            button4.Text = "Log Out";
            button4.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Options";
            Text = "Options";
          
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}