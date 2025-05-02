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
            submit = new Button();
            panel2 = new Panel();
            backbutton = new Label();
            label2 = new Label();
            email = new TextBox();
            label6 = new Label();
            phone = new TextBox();
            label7 = new Label();
            oldpass = new TextBox();
            newpass = new TextBox();
            label3 = new Label();
            delete = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(2, 0, 46);
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(381, 11);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 0;
            label1.Text = "Update Info";
            // 
            // submit
            // 
            submit.BackColor = Color.FromArgb(2, 0, 46);
            submit.Cursor = Cursors.Hand;
            submit.FlatAppearance.BorderSize = 0;
            submit.FlatStyle = FlatStyle.Flat;
            submit.Font = new Font("Segoe UI", 14F);
            submit.ForeColor = Color.LightGray;
            submit.Location = new Point(48, 519);
            submit.Name = "submit";
            submit.Size = new Size(488, 83);
            submit.TabIndex = 27;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(2, 0, 46);
            panel2.Controls.Add(backbutton);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-134, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(852, 50);
            panel2.TabIndex = 24;
            panel2.Paint += panel2_Paint;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // backbutton
            // 
            backbutton.Cursor = Cursors.Hand;
            backbutton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            backbutton.ForeColor = Color.LightGray;
            backbutton.Location = new Point(137, -4);
            backbutton.Name = "backbutton";
            backbutton.Size = new Size(68, 49);
            backbutton.TabIndex = 40;
            backbutton.Text = "↼";
            backbutton.Click += label4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(63, 71);
            label2.Name = "label2";
            label2.Size = new Size(71, 32);
            label2.TabIndex = 32;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // email
            // 
            email.Location = new Point(69, 110);
            email.Name = "email";
            email.Size = new Size(441, 27);
            email.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(63, 145);
            label6.Name = "label6";
            label6.Size = new Size(103, 32);
            label6.TabIndex = 34;
            label6.Text = "Phone #";
            // 
            // phone
            // 
            phone.Location = new Point(69, 184);
            phone.Name = "phone";
            phone.Size = new Size(441, 27);
            phone.TabIndex = 35;
            phone.KeyPress += phone_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.ForeColor = Color.LightGray;
            label7.Location = new Point(63, 332);
            label7.Name = "label7";
            label7.Size = new Size(156, 32);
            label7.TabIndex = 36;
            label7.Text = "Old Password";
            // 
            // oldpass
            // 
            oldpass.Location = new Point(69, 369);
            oldpass.Name = "oldpass";
            oldpass.PasswordChar = '*';
            oldpass.Size = new Size(441, 27);
            oldpass.TabIndex = 37;
            oldpass.UseSystemPasswordChar = true;
            // 
            // newpass
            // 
            newpass.Location = new Point(69, 442);
            newpass.Name = "newpass";
            newpass.PasswordChar = '*';
            newpass.Size = new Size(441, 27);
            newpass.TabIndex = 39;
            newpass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(63, 405);
            label3.Name = "label3";
            label3.Size = new Size(166, 32);
            label3.TabIndex = 38;
            label3.Text = "New Password";
            // 
            // delete
            // 
            delete.BackColor = Color.FromArgb(2, 0, 46);
            delete.Cursor = Cursors.Hand;
            delete.FlatAppearance.BorderSize = 0;
            delete.FlatStyle = FlatStyle.Flat;
            delete.Font = new Font("Segoe UI", 14F);
            delete.ForeColor = Color.Brown;
            delete.Location = new Point(48, 626);
            delete.Name = "delete";
            delete.Size = new Size(488, 83);
            delete.TabIndex = 27;
            delete.Text = "Delete Account";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 56);
            ClientSize = new Size(584, 761);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form8";
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
        private Label backbutton;
    }
}