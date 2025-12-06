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
            ((System.ComponentModel.ISupportInitialize)qtyDrinks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)qtySnacks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 0;
            label1.Text = "Please choose your item/s:";
            // 
            // cmbDrink
            // 
            cmbDrink.FormattingEnabled = true;
            cmbDrink.Location = new Point(79, 85);
            cmbDrink.Name = "cmbDrink";
            cmbDrink.Size = new Size(241, 28);
            cmbDrink.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 62);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Drinks:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 62);
            label3.Name = "label3";
            label3.Size = new Size(265, 20);
            label3.TabIndex = 3;
            label3.Text = "(choose the temperature of your drink)";
            // 
            // cmbTemp
            // 
            cmbTemp.FormattingEnabled = true;
            cmbTemp.Location = new Point(367, 85);
            cmbTemp.Name = "cmbTemp";
            cmbTemp.Size = new Size(241, 28);
            cmbTemp.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 163);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 5;
            label4.Text = "Snacks:";
            // 
            // cmbSnack
            // 
            cmbSnack.FormattingEnabled = true;
            cmbSnack.Location = new Point(79, 186);
            cmbSnack.Name = "cmbSnack";
            cmbSnack.Size = new Size(241, 28);
            cmbSnack.TabIndex = 6;
            // 
            // btnOrder
            // 
            btnOrder.Location = new Point(509, 318);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(116, 46);
            btnOrder.TabIndex = 7;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(12, 318);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(116, 46);
            btnLogOut.TabIndex = 8;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // qtyDrinks
            // 
            qtyDrinks.Location = new Point(79, 114);
            qtyDrinks.Name = "qtyDrinks";
            qtyDrinks.Size = new Size(150, 27);
            qtyDrinks.TabIndex = 9;
            // 
            // qtySnacks
            // 
            qtySnacks.Location = new Point(79, 220);
            qtySnacks.Name = "qtySnacks";
            qtySnacks.Size = new Size(150, 27);
            qtySnacks.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 116);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
            label5.TabIndex = 11;
            label5.Text = "qty:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 222);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 12;
            label6.Text = "qty:";
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 380);
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
    }
}