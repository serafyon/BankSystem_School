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
            panel1 = new Panel();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            label3 = new Label();
            withdraw = new Button();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            name = new Label();
            email = new Label();
            label5 = new Label();
            balance = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(10, 10, 56);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(withdraw);
            panel1.Location = new Point(249, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(573, 601);
            panel1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(29, 420);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(444, 27);
            textBox2.TabIndex = 9;
            textBox2.Text = "0000";
            textBox2.UseSystemPasswordChar = true;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(32, 353);
            label4.Name = "label4";
            label4.Size = new Size(238, 41);
            label4.TabIndex = 8;
            label4.Text = "Security Pincode";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(32, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(441, 27);
            textBox1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(479, 130);
            label6.Name = "label6";
            label6.Size = new Size(47, 25);
            label6.TabIndex = 1;
            label6.Text = "USD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(32, 71);
            label3.Name = "label3";
            label3.Size = new Size(228, 41);
            label3.TabIndex = 6;
            label3.Text = "Desired Balance";
            // 
            // withdraw
            // 
            withdraw.BackColor = Color.FromArgb(2, 0, 46);
            withdraw.Cursor = Cursors.Hand;
            withdraw.FlatAppearance.BorderSize = 0;
            withdraw.FlatStyle = FlatStyle.Flat;
            withdraw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            withdraw.ForeColor = Color.LightGray;
            withdraw.Location = new Point(29, 479);
            withdraw.Name = "withdraw";
            withdraw.Size = new Size(488, 83);
            withdraw.TabIndex = 0;
            withdraw.Text = "Deposit";
            withdraw.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-13, -12);
            panel2.Name = "panel2";
            panel2.Size = new Size(852, 60);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(351, 21);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 0;
            label1.Text = "Deposit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(15, 71);
            label2.Name = "label2";
            label2.Size = new Size(142, 41);
            label2.TabIndex = 1;
            label2.Text = "Welcome";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.ForeColor = Color.LightGray;
            name.ImageAlign = ContentAlignment.MiddleLeft;
            name.Location = new Point(15, 112);
            name.Name = "name";
            name.Size = new Size(207, 46);
            name.TabIndex = 2;
            name.Text = "Name Name";
            name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email.ForeColor = Color.LightGray;
            email.Location = new Point(20, 164);
            email.Name = "email";
            email.Size = new Size(152, 25);
            email.TabIndex = 1;
            email.Text = "email@email.com";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(20, 280);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 3;
            // 
            // balance
            // 
            balance.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            balance.ForeColor = Color.LightGray;
            balance.ImageAlign = ContentAlignment.MiddleLeft;
            balance.Location = new Point(15, 504);
            balance.Name = "balance";
            balance.Size = new Size(231, 41);
            balance.TabIndex = 4;
            balance.Text = "$99999999999";
            balance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(20, 479);
            label7.Name = "label7";
            label7.Size = new Size(141, 25);
            label7.TabIndex = 5;
            label7.Text = "Account Balance";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 0, 46);
            ClientSize = new Size(800, 600);
            Controls.Add(label7);
            Controls.Add(balance);
            Controls.Add(label5);
            Controls.Add(email);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form1";
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
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label6;
    }
}