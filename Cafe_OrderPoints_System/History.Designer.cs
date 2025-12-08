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
            lstHistory.Location = new Point(6, 12);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(961, 284);
            lstHistory.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(866, 302);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(101, 39);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(25, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 20);
            lblTitle.TabIndex = 2;
            // 
            // btnLoadHistory
            // 
            btnLoadHistory.Location = new Point(759, 302);
            btnLoadHistory.Name = "btnLoadHistory";
            btnLoadHistory.Size = new Size(101, 39);
            btnLoadHistory.TabIndex = 3;
            btnLoadHistory.Text = "Load";
            btnLoadHistory.UseVisualStyleBackColor = true;
            btnLoadHistory.Click += btnLoad_Click;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 352);
            Controls.Add(btnLoadHistory);
            Controls.Add(lblTitle);
            Controls.Add(btnBack);
            Controls.Add(lstHistory);
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