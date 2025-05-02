namespace BankSystem_School
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            pinBox = new TextBox();
            label4 = new Label();
            desiredBalance = new TextBox();
            label6 = new Label();
            label3 = new Label();
            deposit = new Button();
            panel2 = new Panel();
            label8 = new Label();
            label1 = new Label();
            dollarsign = new Label();
            label7 = new Label();
            balance = new Label();
            label5 = new Label();
            email = new Label();
            name = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 10, 56);
            panel1.Controls.Add(pinBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(desiredBalance);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(deposit);
            panel1.Location = new Point(249, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 601);
            panel1.TabIndex = 0;
            // 
            // pinBox
            // 
            pinBox.Location = new Point(32, 421);
            pinBox.Name = "pinBox";
            pinBox.PasswordChar = '*';
            pinBox.Size = new Size(444, 27);
            pinBox.TabIndex = 9;
            pinBox.Text = "0000";
            pinBox.UseSystemPasswordChar = true;
            pinBox.TextChanged += textBox2_TextChanged;
            pinBox.KeyPress += pinBox_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(29, 365);
            label4.Name = "label4";
            label4.Size = new Size(191, 32);
            label4.TabIndex = 8;
            label4.Text = "Security Pincode";
            // 
            // desiredBalance
            // 
            desiredBalance.Location = new Point(32, 130);
            desiredBalance.Name = "desiredBalance";
            desiredBalance.Size = new Size(441, 27);
            desiredBalance.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(479, 130);
            label6.Name = "label6";
            label6.Size = new Size(51, 28);
            label6.TabIndex = 1;
            label6.Text = "USD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(29, 74);
            label3.Name = "label3";
            label3.Size = new Size(184, 32);
            label3.TabIndex = 6;
            label3.Text = "Desired Balance";
            // 
            // deposit
            // 
            deposit.BackColor = Color.FromArgb(2, 0, 46);
            deposit.Cursor = Cursors.Hand;
            deposit.FlatAppearance.BorderSize = 0;
            deposit.FlatStyle = FlatStyle.Flat;
            deposit.Font = new Font("Segoe UI", 14F);
            deposit.ForeColor = Color.LightGray;
            deposit.Location = new Point(29, 479);
            deposit.Name = "deposit";
            deposit.Size = new Size(488, 83);
            deposit.TabIndex = 0;
            deposit.Text = "Deposit";
            deposit.UseVisualStyleBackColor = false;
            deposit.Click += deposit_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-13, -12);
            panel2.Name = "panel2";
            panel2.Size = new Size(852, 60);
            panel2.TabIndex = 0;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // label8
            // 
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 20F);
            label8.ForeColor = Color.LightGray;
            label8.Location = new Point(15, 11);
            label8.Name = "label8";
            label8.Size = new Size(68, 38);
            label8.TabIndex = 41;
            label8.Text = "↼";
            label8.Click += label8_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(382, 21);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Deposit";
            // 
            // dollarsign
            // 
            dollarsign.Font = new Font("Segoe UI", 15F);
            dollarsign.ForeColor = Color.LightGray;
            dollarsign.ImageAlign = ContentAlignment.MiddleLeft;
            dollarsign.Location = new Point(17, 499);
            dollarsign.Name = "dollarsign";
            dollarsign.Size = new Size(25, 41);
            dollarsign.TabIndex = 13;
            dollarsign.Text = "$";
            dollarsign.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(17, 479);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.TabIndex = 12;
            label7.Text = "Account Balance";
            // 
            // balance
            // 
            balance.Font = new Font("Segoe UI", 15F);
            balance.BackColor = System.Drawing.Color.Transparent;
            balance.ForeColor = Color.LightGray;
            balance.ImageAlign = ContentAlignment.MiddleLeft;
            balance.Location = new Point(42, 499);
            balance.Name = "balance";
            balance.Size = new Size(198, 41);
            balance.TabIndex = 11;
            balance.Text = "BALANCE";
            balance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;    
            label5.Font = new Font("Segoe UI", 8.64F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(17, 280);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 10;
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = System.Drawing.Color.Transparent;
            email.Font = new Font("Segoe UI", 9F);
            email.ForeColor = Color.LightGray;
            email.Location = new Point(17, 164);
            email.Name = "email";
            email.Size = new Size(129, 20);
            email.TabIndex = 7;
            email.Text = "email@email.com";
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = System.Drawing.Color.Transparent;
            name.Font = new Font("Segoe UI", 16F);
            name.ForeColor = Color.LightGray;
            name.ImageAlign = ContentAlignment.MiddleLeft;
            name.Location = new Point(12, 112);
            name.Name = "name";
            name.Size = new Size(166, 37);
            name.TabIndex = 9;
            name.Text = "Name Name";
            name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(118, 35);
            label2.TabIndex = 8;
            label2.Text = "Welcome";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 0, 46);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 600);
            Controls.Add(dollarsign);
            Controls.Add(label7);
            Controls.Add(balance);
            Controls.Add(label5);
            Controls.Add(email);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form1";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private System.Windows.Forms.Button deposit;
        private Label label3;
        private TextBox pinBox;
        private Label label4;
        private TextBox desiredBalance;
        private Label label6;
        private Label label8;
        private Label dollarsign;
        private Label label7;
        private Label balance;
        private Label label5;
        private Label email;
        private Label name;
        private Label label2;
    }
}