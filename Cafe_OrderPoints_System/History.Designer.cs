namespace Cafe_OrderPoints_System
{
    partial class History
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
            lstHistory = new ListBox();
            btnBack = new Button();
            lblTitle = new Label();
            btnLoadHistory = new Button();
            SuspendLayout();
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.ItemHeight = 15;
            lstHistory.Location = new Point(5, 9);
            lstHistory.Margin = new Padding(3, 2, 3, 2);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(841, 214);
            lstHistory.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(758, 226);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(88, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(22, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 15);
            lblTitle.TabIndex = 2;
            // 
            // btnLoadHistory
            // 
            btnLoadHistory.Location = new Point(664, 226);
            btnLoadHistory.Margin = new Padding(3, 2, 3, 2);
            btnLoadHistory.Name = "btnLoadHistory";
            btnLoadHistory.Size = new Size(88, 29);
            btnLoadHistory.TabIndex = 3;
            btnLoadHistory.Text = "Load";
            btnLoadHistory.UseVisualStyleBackColor = true;
            btnLoadHistory.Click += btnLoad_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pexels_thelazyartist_1471120;
            ClientSize = new Size(857, 264);
            Controls.Add(btnLoadHistory);
            Controls.Add(lblTitle);
            Controls.Add(btnBack);
            Controls.Add(lstHistory);
            Margin = new Padding(3, 2, 3, 2);
            Name = "History";
            Text = "History";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstHistory;
        private Button btnBack;
        private Label lblTitle;
        private Button btnLoadHistory;
    }
}