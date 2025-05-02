namespace BankSystem_School
{
    partial class Form2
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
            pinBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            desiredBalance = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            withdraw = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            label8 = new System.Windows.Forms.Label();
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
            panel1.Controls.Add(pinBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(desiredBalance);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(withdraw);
            panel1.Location = new System.Drawing.Point(249, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(573, 601);
            panel1.TabIndex = 0;
            panel1.Paint += panel2_Paint;
            // 
            // pinBox
            // 
            pinBox.Location = new System.Drawing.Point(29, 420);
            pinBox.Name = "pinBox";
            pinBox.PasswordChar = '*';
            pinBox.Size = new System.Drawing.Size(444, 27);
            pinBox.TabIndex = 9;
            pinBox.Text = "0000";
            pinBox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 11.52F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label4.ForeColor = System.Drawing.Color.LightGray;
            label4.Location = new System.Drawing.Point(32, 353);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(157, 28);
            label4.TabIndex = 8;
            label4.Text = "Security Pincode";
            label4.Click += label4_Click;
            // 
            // desiredBalance
            // 
            desiredBalance.Location = new System.Drawing.Point(32, 130);
            desiredBalance.Name = "desiredBalance";
            desiredBalance.Size = new System.Drawing.Size(441, 27);
            desiredBalance.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label6.ForeColor = System.Drawing.Color.LightGray;
            label6.Location = new System.Drawing.Point(479, 130);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(29, 15);
            label6.TabIndex = 1;
            label6.Text = "USD";
            label6.Click += label6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 11.52F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label3.ForeColor = System.Drawing.Color.LightGray;
            label3.Location = new System.Drawing.Point(32, 71);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(149, 28);
            label3.TabIndex = 6;
            label3.Text = "Desired Balance";
            label3.Click += label3_Click;
            // 
            // withdraw
            // 
            withdraw.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
            withdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            withdraw.FlatAppearance.BorderSize = 0;
            withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            withdraw.Font = new System.Drawing.Font("Segoe UI", 7.6800003F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            withdraw.ForeColor = System.Drawing.Color.LightGray;
            withdraw.Location = new System.Drawing.Point(29, 479);
            withdraw.Name = "withdraw";
            withdraw.Size = new System.Drawing.Size(488, 83);
            withdraw.TabIndex = 0;
            withdraw.Text = "Withdraw";
            withdraw.UseVisualStyleBackColor = false;
            withdraw.Click += withdraw_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label1);
            panel2.Location = new System.Drawing.Point(-13, -12);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(852, 60);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // label8
            // 
            label8.Cursor = System.Windows.Forms.Cursors.Hand;
            label8.Font = new System.Drawing.Font("Segoe UI", 18.048002F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label8.ForeColor = System.Drawing.Color.LightGray;
            label8.Location = new System.Drawing.Point(25, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(68, 49);
            label8.TabIndex = 41;
            label8.Text = "↼";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.ForeColor = System.Drawing.Color.LightGray;
            label1.Location = new System.Drawing.Point(351, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Withdraw";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 11.52F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.ForeColor = System.Drawing.Color.LightGray;
            label2.Location = new System.Drawing.Point(15, 71);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Welcome";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new System.Drawing.Font("Segoe UI", 12.672001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            name.ForeColor = System.Drawing.Color.LightGray;
            name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            name.Location = new System.Drawing.Point(15, 112);
            name.Name = "name";
            name.Size = new System.Drawing.Size(135, 30);
            name.TabIndex = 2;
            name.Text = "Name Name";
            name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new System.Drawing.Font("Segoe UI", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            email.ForeColor = System.Drawing.Color.LightGray;
            email.Location = new System.Drawing.Point(20, 164);
            email.Name = "email";
            email.Size = new System.Drawing.Size(103, 15);
            email.TabIndex = 1;
            email.Text = "email@email.com";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label5.ForeColor = System.Drawing.Color.LightGray;
            label5.Location = new System.Drawing.Point(20, 280);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(0, 15);
            label5.TabIndex = 3;
            // 
            // balance
            // 
            balance.Font = new System.Drawing.Font("Segoe UI", 11.52F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
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
            label7.Font = new System.Drawing.Font("Segoe UI", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label7.ForeColor = System.Drawing.Color.LightGray;
            label7.Location = new System.Drawing.Point(20, 479);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(96, 15);
            label7.TabIndex = 5;
            label7.Text = "Account Balance";
            // 
            // Form2
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
            Load += Form2_Load;
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
        private Label label2;
        private Label name;
        private Label email;
        private Label label5;
        private Label balance;
        private Label label7;
        private System.Windows.Forms.Button withdraw;
        private Label label3;
        private TextBox pinBox;
        private Label label4;
        private TextBox desiredBalance;
        private Label label6;
        private Label label8;
    }
}