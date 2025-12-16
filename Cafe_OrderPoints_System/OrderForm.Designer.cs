namespace Cafe_OrderPoints_System
{
    partial class OrderForm
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
            cmbDrink = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cmbTemp = new ComboBox();
            label4 = new Label();
            cmbSnack = new ComboBox();
            btnOrder = new Button();
            btnLogOut = new Button();
            qtyDrinks = new NumericUpDown();
            qtySnacks = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)qtyDrinks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)qtySnacks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 0;
            label1.Text = "Please choose your item/s:";
            // 
            // cmbDrink
            // 
            cmbDrink.FormattingEnabled = true;
            cmbDrink.Location = new Point(69, 64);
            cmbDrink.Margin = new Padding(3, 2, 3, 2);
            cmbDrink.Name = "cmbDrink";
            cmbDrink.Size = new Size(211, 23);
            cmbDrink.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 46);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Drinks:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(310, 46);
            label3.Name = "label3";
            label3.Size = new Size(212, 15);
            label3.TabIndex = 3;
            label3.Text = "(choose the temperature of your drink)";
            // 
            // cmbTemp
            // 
            cmbTemp.FormattingEnabled = true;
            cmbTemp.Location = new Point(321, 64);
            cmbTemp.Margin = new Padding(3, 2, 3, 2);
            cmbTemp.Name = "cmbTemp";
            cmbTemp.Size = new Size(211, 23);
            cmbTemp.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 122);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 5;
            label4.Text = "Snacks:";
            // 
            // cmbSnack
            // 
            cmbSnack.FormattingEnabled = true;
            cmbSnack.Location = new Point(69, 140);
            cmbSnack.Margin = new Padding(3, 2, 3, 2);
            cmbSnack.Name = "cmbSnack";
            cmbSnack.Size = new Size(211, 23);
            cmbSnack.TabIndex = 6;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(445, 238);
            btnOrder.Margin = new Padding(3, 2, 3, 2);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(102, 34);
            btnOrder.TabIndex = 7;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(10, 238);
            btnLogOut.Margin = new Padding(3, 2, 3, 2);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(102, 34);
            btnLogOut.TabIndex = 8;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // qtyDrinks
            // 
            qtyDrinks.Location = new Point(69, 86);
            qtyDrinks.Margin = new Padding(3, 2, 3, 2);
            qtyDrinks.Name = "qtyDrinks";
            qtyDrinks.Size = new Size(131, 23);
            qtyDrinks.TabIndex = 9;
            // 
            // qtySnacks
            // 
            qtySnacks.Location = new Point(69, 165);
            qtySnacks.Margin = new Padding(3, 2, 3, 2);
            qtySnacks.Name = "qtySnacks";
            qtySnacks.Size = new Size(131, 23);
            qtySnacks.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 87);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 11;
            label5.Text = "qty:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 166);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 12;
            label6.Text = "qty:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(445, 200);
            btnBack.Margin = new Padding(3, 2, 3, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(102, 34);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.pexels_thelazyartist_1471120;
            ClientSize = new Size(560, 285);
            Controls.Add(btnBack);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(qtySnacks);
            Controls.Add(qtyDrinks);
            Controls.Add(btnLogOut);
            Controls.Add(btnOrder);
            Controls.Add(cmbSnack);
            Controls.Add(label4);
            Controls.Add(cmbTemp);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbDrink);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "OrderForm";
            Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)qtyDrinks).EndInit();
            ((System.ComponentModel.ISupportInitialize)qtySnacks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDrink;
        private Label label2;
        private Label label3;
        private ComboBox cmbTemp;
        private Label label4;
        private ComboBox cmbSnack;
        private Button btnOrder;
        private Button btnLogOut;
        private NumericUpDown qtyDrinks;
        private NumericUpDown qtySnacks;
        private Label label5;
        private Label label6;
        private Button btnBack;
    }
}