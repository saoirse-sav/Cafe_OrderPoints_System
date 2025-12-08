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
            SuspendLayout();
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.Location = new Point(6, 34);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(520, 284);
            lstHistory.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(421, 324);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(101, 39);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += History_Load;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(25, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(0, 20);
            lblTitle.TabIndex = 2;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 375);
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
    }
}