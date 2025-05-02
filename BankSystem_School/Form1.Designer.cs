namespace BankSystem_School
{
    partial class Form1
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
            panel1 = new Panel();
            logout = new Button();
            update = new Button();
            deposit = new Button();
            withdraw = new Button();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            name = new Label();
            email = new Label();
            label5 = new Label();
            balance = new Label();
            label7 = new Label();
            dollarsign = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 10, 56);
            panel1.Controls.Add(logout);
            panel1.Controls.Add(update);
            panel1.Controls.Add(deposit);
            panel1.Controls.Add(withdraw);
            panel1.Location = new Point(249, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 601);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // logout
            // 
            logout.BackColor = Color.FromArgb(2, 0, 46);
            logout.Cursor = Cursors.Hand;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Font = new Font("Segoe UI", 14F);
            logout.ForeColor = Color.LightGray;
            logout.Location = new Point(300, 338);
            logout.Name = "logout";
            logout.Size = new Size(228, 213);
            logout.TabIndex = 2;
            logout.Text = "Log Out";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(2, 0, 46);
            update.Cursor = Cursors.Hand;
            update.FlatAppearance.BorderSize = 0;
            update.FlatStyle = FlatStyle.Flat;
            update.Font = new Font("Segoe UI", 14F);
            update.ForeColor = Color.LightGray;
            update.Location = new Point(33, 338);
            update.Name = "update";
            update.Size = new Size(228, 213);
            update.TabIndex = 1;
            update.Text = "Update Info";
            update.UseVisualStyleBackColor = false;
            update.MouseClick += update_MouseClick;
            // 
            // deposit
            // 
            deposit.BackColor = Color.FromArgb(2, 0, 46);
            deposit.Cursor = Cursors.Hand;
            deposit.FlatAppearance.BorderSize = 0;
            deposit.FlatStyle = FlatStyle.Flat;
            deposit.Font = new Font("Segoe UI", 14F);
            deposit.ForeColor = Color.LightGray;
            deposit.Location = new Point(300, 79);
            deposit.Name = "deposit";
            deposit.Size = new Size(228, 213);
            deposit.TabIndex = 0;
            deposit.Text = "Deposit";
            deposit.UseVisualStyleBackColor = false;
            deposit.Click += deposit_Click;
            // 
            // withdraw
            // 
            withdraw.BackColor = Color.FromArgb(2, 0, 46);
            withdraw.Cursor = Cursors.Hand;
            withdraw.FlatAppearance.BorderSize = 0;
            withdraw.FlatStyle = FlatStyle.Flat;
            withdraw.Font = new Font("Segoe UI", 14F);
            withdraw.ForeColor = Color.LightGray;
            withdraw.Location = new Point(33, 81);
            withdraw.Name = "withdraw";
            withdraw.Size = new Size(228, 213);
            withdraw.TabIndex = 0;
            withdraw.Text = "Withdraw";
            withdraw.UseVisualStyleBackColor = false;
            withdraw.Click += withdraw_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-13, -12);
            panel2.Name = "panel2";
            panel2.Size = new Size(852, 60);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(351, 21);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(15, 71);
            label2.Name = "label2";
            label2.Size = new Size(118, 35);
            label2.TabIndex = 1;
            label2.Text = "Welcome";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 16F);
            name.ForeColor = Color.LightGray;
            name.ImageAlign = ContentAlignment.MiddleLeft;
            name.Location = new Point(15, 112);
            name.Name = "name";
            name.Size = new Size(166, 37);
            name.TabIndex = 2;
            name.Text = "Name Name";
            name.TextAlign = ContentAlignment.MiddleLeft;
            name.Click += label3_Click;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 9F);
            email.ForeColor = Color.LightGray;
            email.Location = new Point(20, 164);
            email.Name = "email";
            email.Size = new Size(129, 20);
            email.TabIndex = 1;
            email.Text = "email@email.com";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.64F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(20, 280);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 3;
            label5.Click += label5_Click;
            // 
            // balance
            // 
            balance.Font = new Font("Segoe UI", 15F);
            balance.ForeColor = Color.LightGray;
            balance.ImageAlign = ContentAlignment.MiddleLeft;
            balance.Location = new Point(45, 499);
            balance.Name = "balance";
            balance.Size = new Size(198, 41);
            balance.TabIndex = 4;
            balance.Text = "BALANCE";
            balance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(20, 479);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 5;
            label7.Text = "Account Balance";
            // 
            // dollarsign
            // 
            dollarsign.Font = new Font("Segoe UI", 15F);
            dollarsign.ForeColor = Color.LightGray;
            dollarsign.ImageAlign = ContentAlignment.MiddleLeft;
            dollarsign.Location = new Point(20, 499);
            dollarsign.Name = "dollarsign";
            dollarsign.Size = new Size(25, 41);
            dollarsign.TabIndex = 6;
            dollarsign.Text = "$";
            dollarsign.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 0, 46);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label name;
        private Label email;
        private Label label5;
        private Label balance;
        private Label label7;
        private Button withdraw;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button deposit;
        private Button logout;
        private Label dollarsign;
    }
}