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
            label1 = new System.Windows.Forms.Label();
            submit = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            email = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            phone = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            oldpass = new System.Windows.Forms.TextBox();
            newpass = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            delete = new System.Windows.Forms.Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.ForeColor = System.Drawing.Color.LightGray;
            label1.Location = new System.Drawing.Point(381, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(58, 12);
            label1.TabIndex = 0;
            label1.Text = "Update Info";
            // 
            // submit
            // 
            submit.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
            submit.Cursor = System.Windows.Forms.Cursors.Hand;
            submit.FlatAppearance.BorderSize = 0;
            submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            submit.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            submit.ForeColor = System.Drawing.Color.LightGray;
            submit.Location = new System.Drawing.Point(48, 519);
            submit.Name = "submit";
            submit.Size = new System.Drawing.Size(488, 83);
            submit.TabIndex = 27;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label1);
            panel2.Location = new System.Drawing.Point(-134, -1);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(852, 50);
            panel2.TabIndex = 24;
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.Cursor = System.Windows.Forms.Cursors.Hand;
            label4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label4.ForeColor = System.Drawing.Color.LightGray;
            label4.Location = new System.Drawing.Point(146, -13);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(68, 49);
            label4.TabIndex = 40;
            label4.Text = "↼";
            label4.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.ForeColor = System.Drawing.Color.LightGray;
            label2.Location = new System.Drawing.Point(69, 76);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 15);
            label2.TabIndex = 32;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // email
            // 
            email.Location = new System.Drawing.Point(69, 110);
            email.Name = "email";
            email.Size = new System.Drawing.Size(441, 27);
            email.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label6.ForeColor = System.Drawing.Color.LightGray;
            label6.Location = new System.Drawing.Point(69, 150);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(51, 15);
            label6.TabIndex = 34;
            label6.Text = "Phone #";
            // 
            // phone
            // 
            phone.Location = new System.Drawing.Point(69, 184);
            phone.Name = "phone";
            phone.Size = new System.Drawing.Size(441, 27);
            phone.TabIndex = 35;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label7.ForeColor = System.Drawing.Color.LightGray;
            label7.Location = new System.Drawing.Point(69, 335);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(79, 15);
            label7.TabIndex = 36;
            label7.Text = "Old Password";
            // 
            // oldpass
            // 
            oldpass.Location = new System.Drawing.Point(69, 369);
            oldpass.Name = "oldpass";
            oldpass.PasswordChar = '*';
            oldpass.Size = new System.Drawing.Size(441, 27);
            oldpass.TabIndex = 37;
            oldpass.UseSystemPasswordChar = true;
            // 
            // newpass
            // 
            newpass.Location = new System.Drawing.Point(69, 442);
            newpass.Name = "newpass";
            newpass.PasswordChar = '*';
            newpass.Size = new System.Drawing.Size(441, 27);
            newpass.TabIndex = 39;
            newpass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label3.ForeColor = System.Drawing.Color.LightGray;
            label3.Location = new System.Drawing.Point(69, 408);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 15);
            label3.TabIndex = 38;
            label3.Text = "New Password";
            // 
            // delete
            // 
            delete.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
            delete.Cursor = System.Windows.Forms.Cursors.Hand;
            delete.FlatAppearance.BorderSize = 0;
            delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            delete.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            delete.ForeColor = System.Drawing.Color.Brown;
            delete.Location = new System.Drawing.Point(48, 626);
            delete.Name = "delete";
            delete.Size = new System.Drawing.Size(488, 83);
            delete.TabIndex = 27;
            delete.Text = "Delete Customer";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)10)), ((int)((byte)56)));
            ClientSize = new System.Drawing.Size(584, 761);
            Controls.Add(newpass);
            Controls.Add(label3);
            Controls.Add(oldpass);
            Controls.Add(label7);
            Controls.Add(phone);
            Controls.Add(label6);
            Controls.Add(email);
            Controls.Add(label2);
            Controls.Add(delete);
            Controls.Add(submit);
            Controls.Add(panel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Text = "Form8";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button delete;

        #endregion

        private Label label1;
        private System.Windows.Forms.Button submit;
        private Panel panel2;
        private Label label2;
        private TextBox email;
        private Label label6;
        private TextBox phone;
        private Label label7;
        private TextBox oldpass;
        private TextBox newpass;
        private Label label3;
        private Label label4;
    }
}