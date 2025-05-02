namespace BankSystem_School
{
    partial class Form7
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
            panel2 = new Panel();
            label4 = new Label();
            label1 = new Label();
            withdraw = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(2, 0, 46);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-134, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(852, 50);
            panel2.TabIndex = 19;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 20F);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(134, -1);
            label4.Name = "label4";
            label4.Size = new Size(68, 49);
            label4.TabIndex = 41;
            label4.Text = "↼";
            label4.Click += label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(2, 0, 46);
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(361, 10);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Create Account";
            label1.Click += label1_Click;
            // 
            // withdraw
            // 
            withdraw.BackColor = Color.FromArgb(2, 0, 46);
            withdraw.Cursor = Cursors.Hand;
            withdraw.FlatAppearance.BorderSize = 0;
            withdraw.FlatStyle = FlatStyle.Flat;
            withdraw.Font = new Font("Segoe UI", 14F);
            withdraw.ForeColor = Color.LightGray;
            withdraw.Location = new Point(47, 612);
            withdraw.Name = "withdraw";
            withdraw.Size = new Size(488, 83);
            withdraw.TabIndex = 24;
            withdraw.Text = "Submit";
            withdraw.UseVisualStyleBackColor = false;
            withdraw.MouseClick += withdraw_MouseClick;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(69, 397);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(441, 27);
            textBox2.TabIndex = 23;
            textBox2.UseSystemPasswordChar = true;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(69, 338);
            label2.Name = "label2";
            label2.Size = new Size(51, 32);
            label2.TabIndex = 22;
            label2.Text = "PIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(69, 180);
            label3.Name = "label3";
            label3.Size = new Size(159, 32);
            label3.TabIndex = 20;
            label3.Text = "Account Type";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Business", "Savings", "Student" });
            comboBox1.Location = new Point(69, 235);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(441, 28);
            comboBox1.TabIndex = 25;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 56);
            ClientSize = new Size(584, 761);
            Controls.Add(comboBox1);
            Controls.Add(panel2);
            Controls.Add(withdraw);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private System.Windows.Forms.Button withdraw;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
    }
}