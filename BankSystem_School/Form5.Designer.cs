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
            panel2 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            withdraw = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Location = new System.Drawing.Point(-135, -1);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(852, 50);
            panel2.TabIndex = 13;
            // 
            // label4
            // 
            label4.Cursor = System.Windows.Forms.Cursors.Hand;
            label4.Font = new System.Drawing.Font("Segoe UI", 22.560001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label4.ForeColor = System.Drawing.Color.LightGray;
            label4.Location = new System.Drawing.Point(147, -13);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(68, 49);
            label4.TabIndex = 41;
            label4.Text = "↼";
            label4.MouseClick += label4_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
            label1.Font = new System.Drawing.Font("Segoe UI", 8.64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.ForeColor = System.Drawing.Color.LightGray;
            label1.Location = new System.Drawing.Point(381, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            // 
            // withdraw
            // 
            withdraw.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
            withdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            withdraw.FlatAppearance.BorderSize = 0;
            withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            withdraw.Font = new System.Drawing.Font("Segoe UI", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            withdraw.ForeColor = System.Drawing.Color.LightGray;
            withdraw.Location = new System.Drawing.Point(46, 612);
            withdraw.Name = "withdraw";
            withdraw.Size = new System.Drawing.Size(488, 83);
            withdraw.TabIndex = 18;
            withdraw.Text = "Sign In";
            withdraw.UseVisualStyleBackColor = false;
            withdraw.MouseClick += withdraw_MouseClick;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(68, 397);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new System.Drawing.Size(441, 27);
            textBox2.TabIndex = 17;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14.400001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.ForeColor = System.Drawing.Color.LightGray;
            label2.Location = new System.Drawing.Point(68, 338);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(120, 35);
            label2.TabIndex = 16;
            label2.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(68, 239);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(441, 27);
            textBox1.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 14.400001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label3.ForeColor = System.Drawing.Color.LightGray;
            label3.Location = new System.Drawing.Point(68, 180);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 35);
            label3.TabIndex = 14;
            label3.Text = "Email";
            // 
            // Form5
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)10)), ((int)((byte)56)));
            ClientSize = new System.Drawing.Size(584, 761);
            Controls.Add(panel2);
            Controls.Add(withdraw);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Text = "Form5";
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
        private TextBox textBox1;
        private Label label3;
        private System.Windows.Forms.Label label4;
    }
}