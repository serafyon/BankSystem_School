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
            panel1 = new System.Windows.Forms.Panel();
            logout = new System.Windows.Forms.Button();
            update = new System.Windows.Forms.Button();
            deposit = new System.Windows.Forms.Button();
            withdraw = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            name = new System.Windows.Forms.Label();
            email = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            balance = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)10)), ((int)((byte)56)));
            panel1.Controls.Add(logout);
            panel1.Controls.Add(update);
            panel1.Controls.Add(deposit);
            panel1.Controls.Add(withdraw);
            panel1.Location = new System.Drawing.Point(249, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(573, 601);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // logout
            // 
            logout.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
            logout.Cursor = System.Windows.Forms.Cursors.Hand;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            logout.Font = new System.Drawing.Font("Segoe UI", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            logout.ForeColor = System.Drawing.Color.LightGray;
            logout.Location = new System.Drawing.Point(300, 338);
            logout.Name = "logout";
            logout.Size = new System.Drawing.Size(228, 213);
            logout.TabIndex = 2;
            logout.Text = "Log Out";
            logout.UseVisualStyleBackColor = false;
            logout.Click += logout_Click;
            // 
            // update
            // 
            update.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
            update.Cursor = System.Windows.Forms.Cursors.Hand;
            update.FlatAppearance.BorderSize = 0;
            update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            update.Font = new System.Drawing.Font("Segoe UI", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            update.ForeColor = System.Drawing.Color.LightGray;
            update.Location = new System.Drawing.Point(33, 338);
            update.Name = "update";
            update.Size = new System.Drawing.Size(228, 213);
            update.TabIndex = 1;
            update.Text = "Update Info";
            update.UseVisualStyleBackColor = false;
            update.MouseClick += update_MouseClick;
            // 
            // deposit
            // 
            deposit.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
            deposit.Cursor = System.Windows.Forms.Cursors.Hand;
            deposit.FlatAppearance.BorderSize = 0;
            deposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            deposit.Font = new System.Drawing.Font("Segoe UI", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            deposit.ForeColor = System.Drawing.Color.LightGray;
            deposit.Location = new System.Drawing.Point(300, 79);
            deposit.Name = "deposit";
            deposit.Size = new System.Drawing.Size(228, 213);
            deposit.TabIndex = 0;
            deposit.Text = "Deposit";
            deposit.UseVisualStyleBackColor = false;
            deposit.Click += deposit_Click;
            // 
            // withdraw
            // 
            withdraw.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
            withdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            withdraw.FlatAppearance.BorderSize = 0;
            withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            withdraw.Font = new System.Drawing.Font("Segoe UI", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            withdraw.ForeColor = System.Drawing.Color.LightGray;
            withdraw.Location = new System.Drawing.Point(33, 81);
            withdraw.Name = "withdraw";
            withdraw.Size = new System.Drawing.Size(228, 213);
            withdraw.TabIndex = 0;
            withdraw.Text = "Withdraw";
            withdraw.UseVisualStyleBackColor = false;
            withdraw.Click += withdraw_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new System.Drawing.Point(-13, -12);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(852, 60);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 8.64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.ForeColor = System.Drawing.Color.LightGray;
            label1.Location = new System.Drawing.Point(351, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14.400001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.ForeColor = System.Drawing.Color.LightGray;
            label2.Location = new System.Drawing.Point(15, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(118, 35);
            label2.TabIndex = 1;
            label2.Text = "Welcome";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new System.Drawing.Font("Segoe UI", 15.840001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            name.ForeColor = System.Drawing.Color.LightGray;
            name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            name.Location = new System.Drawing.Point(15, 112);
            name.Name = "name";
            name.Size = new System.Drawing.Size(166, 37);
            name.TabIndex = 2;
            name.Text = "Name Name";
            name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            name.Click += label3_Click;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new System.Drawing.Font("Segoe UI", 8.64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            email.ForeColor = System.Drawing.Color.LightGray;
            email.Location = new System.Drawing.Point(20, 164);
            email.Name = "email";
            email.Size = new System.Drawing.Size(129, 20);
            email.TabIndex = 1;
            email.Text = "email@email.com";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 8.64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label5.ForeColor = System.Drawing.Color.LightGray;
            label5.Location = new System.Drawing.Point(20, 280);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(0, 20);
            label5.TabIndex = 3;
            label5.Click += label5_Click;
            // 
            // balance
            // 
            balance.Font = new System.Drawing.Font("Segoe UI", 14.400001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            balance.ForeColor = System.Drawing.Color.LightGray;
            balance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            balance.Location = new System.Drawing.Point(15, 504);
            balance.Name = "balance";
            balance.Size = new System.Drawing.Size(231, 41);
            balance.TabIndex = 4;
            balance.Text = "$99999999999";
            balance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 8.64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label7.ForeColor = System.Drawing.Color.LightGray;
            label7.Location = new System.Drawing.Point(20, 479);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(119, 20);
            label7.TabIndex = 5;
            label7.Text = "Account Balance";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
            ClientSize = new System.Drawing.Size(800, 600);
            Controls.Add(label7);
            Controls.Add(balance);
            Controls.Add(label5);
            Controls.Add(email);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}