namespace BankSystem_School
{
    partial class Form8
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
            withdraw = new Button();
            panel2 = new Panel();
            label4 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(2, 0, 46);
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(381, 11);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 0;
            label1.Text = "Update Info";
            // 
            // withdraw
            // 
            withdraw.BackColor = Color.FromArgb(2, 0, 46);
            withdraw.Cursor = Cursors.Hand;
            withdraw.FlatAppearance.BorderSize = 0;
            withdraw.FlatStyle = FlatStyle.Flat;
            withdraw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            withdraw.ForeColor = Color.LightGray;
            withdraw.Location = new Point(47, 612);
            withdraw.Name = "withdraw";
            withdraw.Size = new Size(488, 83);
            withdraw.TabIndex = 27;
            withdraw.Text = "Submit";
            withdraw.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(2, 0, 46);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-134, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(852, 50);
            panel2.TabIndex = 24;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(146, -13);
            label4.Name = "label4";
            label4.Size = new Size(68, 49);
            label4.TabIndex = 40;
            label4.Text = "↼";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(69, 76);
            label2.Name = "label2";
            label2.Size = new Size(70, 31);
            label2.TabIndex = 32;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(69, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(441, 27);
            textBox2.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(69, 150);
            label6.Name = "label6";
            label6.Size = new Size(98, 31);
            label6.TabIndex = 34;
            label6.Text = "Phone #";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(69, 184);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(441, 27);
            textBox5.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(69, 335);
            label7.Name = "label7";
            label7.Size = new Size(153, 31);
            label7.TabIndex = 36;
            label7.Text = "Old Password";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(69, 369);
            textBox6.Name = "textBox6";
            textBox6.PasswordChar = '*';
            textBox6.Size = new Size(441, 27);
            textBox6.TabIndex = 37;
            textBox6.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(69, 442);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.Size = new Size(441, 27);
            textBox1.TabIndex = 39;
            textBox1.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(69, 408);
            label3.Name = "label3";
            label3.Size = new Size(162, 31);
            label3.TabIndex = 38;
            label3.Text = "New Password";
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 56);
            ClientSize = new Size(584, 761);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(withdraw);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form8";
            Text = "Form8";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button withdraw;
        private Panel panel2;
        private Label label2;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
    }
}