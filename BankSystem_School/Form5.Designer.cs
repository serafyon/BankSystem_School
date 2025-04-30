namespace BankSystem_School
{
    partial class Form5
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
            label1 = new Label();
            withdraw = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(2, 0, 46);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-135, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(852, 50);
            panel2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(2, 0, 46);
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(381, 11);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            // 
            // withdraw
            // 
            withdraw.BackColor = Color.FromArgb(2, 0, 46);
            withdraw.Cursor = Cursors.Hand;
            withdraw.FlatAppearance.BorderSize = 0;
            withdraw.FlatStyle = FlatStyle.Flat;
            withdraw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            withdraw.ForeColor = Color.LightGray;
            withdraw.Location = new Point(46, 612);
            withdraw.Name = "withdraw";
            withdraw.Size = new Size(488, 83);
            withdraw.TabIndex = 18;
            withdraw.Text = "Sign In";
            withdraw.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(68, 397);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(441, 27);
            textBox2.TabIndex = 17;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(68, 338);
            label2.Name = "label2";
            label2.Size = new Size(143, 41);
            label2.TabIndex = 16;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 239);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(441, 27);
            textBox1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(68, 180);
            label3.Name = "label3";
            label3.Size = new Size(88, 41);
            label3.TabIndex = 14;
            label3.Text = "Email";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 56);
            ClientSize = new Size(584, 761);
            Controls.Add(panel2);
            Controls.Add(withdraw);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form5";
            Text = "Form5";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label1;
        private Button withdraw;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
    }
}