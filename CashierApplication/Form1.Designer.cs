namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblItemName = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblDiscount = new Label();
            lblTotalAmount = new Label();
            lblAmountPaid = new Label();
            lblChange = new Label();
            TextItemName = new TextBox();
            TextPrice = new TextBox();
            TextQuantity = new TextBox();
            TextDiscount = new TextBox();
            TextAmountPaid = new TextBox();
            btnCompute = new Button();
            btnSubmit = new Button();
            SuspendLayout();
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemName.Location = new Point(12, 9);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(114, 25);
            lblItemName.TabIndex = 0;
            lblItemName.Text = "Item Name:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(12, 70);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(59, 25);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(388, 70);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(92, 25);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity:";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(388, 9);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(121, 25);
            lblDiscount.TabIndex = 3;
            lblDiscount.Text = "Discount(%):";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalAmount.Location = new Point(76, 219);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(133, 25);
            lblTotalAmount.TabIndex = 4;
            lblTotalAmount.Text = "Total Amount:";
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.AutoSize = true;
            lblAmountPaid.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmountPaid.Location = new Point(36, 269);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(173, 25);
            lblAmountPaid.TabIndex = 5;
            lblAmountPaid.Text = "Payment Received:";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChange.Location = new Point(127, 312);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(82, 25);
            lblChange.TabIndex = 6;
            lblChange.Text = "Change:";
            // 
            // TextItemName
            // 
            TextItemName.Location = new Point(12, 37);
            TextItemName.Name = "TextItemName";
            TextItemName.Size = new Size(331, 23);
            TextItemName.TabIndex = 7;
            // 
            // TextPrice
            // 
            TextPrice.Location = new Point(12, 98);
            TextPrice.Name = "TextPrice";
            TextPrice.Size = new Size(331, 23);
            TextPrice.TabIndex = 8;
            // 
            // TextQuantity
            // 
            TextQuantity.Location = new Point(388, 98);
            TextQuantity.Name = "TextQuantity";
            TextQuantity.Size = new Size(111, 23);
            TextQuantity.TabIndex = 9;
            // 
            // TextDiscount
            // 
            TextDiscount.Location = new Point(388, 37);
            TextDiscount.Name = "TextDiscount";
            TextDiscount.Size = new Size(111, 23);
            TextDiscount.TabIndex = 10;
            // 
            // TextAmountPaid
            // 
            TextAmountPaid.Location = new Point(211, 269);
            TextAmountPaid.Name = "TextAmountPaid";
            TextAmountPaid.Size = new Size(100, 23);
            TextAmountPaid.TabIndex = 12;
            // 
            // btnCompute
            // 
            btnCompute.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCompute.Location = new Point(243, 149);
            btnCompute.Name = "btnCompute";
            btnCompute.Size = new Size(117, 28);
            btnCompute.TabIndex = 14;
            btnCompute.Text = "Compute";
            btnCompute.UseVisualStyleBackColor = true;
            btnCompute.Click += btnCompute_Click_1;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(353, 266);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(117, 28);
            btnSubmit.TabIndex = 15;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // frmPurchaseDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(615, 400);
            Controls.Add(btnSubmit);
            Controls.Add(btnCompute);
            Controls.Add(TextAmountPaid);
            Controls.Add(TextDiscount);
            Controls.Add(TextQuantity);
            Controls.Add(TextPrice);
            Controls.Add(TextItemName);
            Controls.Add(lblChange);
            Controls.Add(lblAmountPaid);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblDiscount);
            Controls.Add(lblQuantity);
            Controls.Add(lblPrice);
            Controls.Add(lblItemName);
            Name = "frmPurchaseDiscountedItem";
            Text = "Purchase Discounted item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemName;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblDiscount;
        private Label lblTotalAmount;
        private Label lblAmountPaid;
        private Label lblChange;
        private TextBox TextItemName;
        private TextBox TextPrice;
        private TextBox TextQuantity;
        private TextBox TextDiscount;
        private TextBox TextAmountPaid;
        private Button btnCompute;
        private Button btnSubmit;
    }
}
