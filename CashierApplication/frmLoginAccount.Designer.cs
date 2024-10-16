namespace CashierApplication
{
    partial class frmLoginAccount
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
            TextUser = new TextBox();
            TextPass = new TextBox();
            button1 = new Button();
            label3 = new Label();
            lblWelcome = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(98, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 94);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // TextUser
            // 
            TextUser.Location = new Point(22, 52);
            TextUser.Name = "TextUser";
            TextUser.Size = new Size(225, 23);
            TextUser.TabIndex = 2;
            // 
            // TextPass
            // 
            TextPass.Location = new Point(22, 122);
            TextPass.Name = "TextPass";
            TextPass.Size = new Size(225, 23);
            TextPass.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(50, 168);
            button1.Name = "button1";
            button1.Size = new Size(168, 36);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(8, 8);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(57, 15);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "Welcome";
            // 
            // frmLoginAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Firebrick;
            ClientSize = new Size(259, 230);
            Controls.Add(lblWelcome);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(TextPass);
            Controls.Add(TextUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLoginAccount";
            Text = "User Login";
            Load += frmLoginAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TextUser;
        private TextBox TextPass;
        private Button button1;
        private Label label3;
        private Label lblWelcome;
    }
}