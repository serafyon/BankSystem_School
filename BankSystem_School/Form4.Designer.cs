using System.ComponentModel;

namespace BankSystem_School;

partial class Form4
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        panel2 = new Panel();
        label8 = new Label();
        fname = new TextBox();
        label3 = new Label();
        withdraw = new Button();
        mname = new TextBox();
        label4 = new Label();
        label5 = new Label();
        lname = new TextBox();
        email = new TextBox();
        label2 = new Label();
        phone = new TextBox();
        label6 = new Label();
        pass = new TextBox();
        label7 = new Label();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = Color.FromArgb(2, 0, 46);
        label1.Font = new Font("Segoe UI", 9F);
        label1.ForeColor = Color.LightGray;
        label1.Location = new Point(381, 11);
        label1.Name = "label1";
        label1.Size = new Size(61, 20);
        label1.TabIndex = 0;
        label1.Text = "Sign Up";
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(2, 0, 46);
        panel2.Controls.Add(label8);
        panel2.Controls.Add(label1);
        panel2.Location = new Point(-134, -2);
        panel2.Name = "panel2";
        panel2.Size = new Size(852, 50);
        panel2.TabIndex = 1;
        panel2.Paint += panel2_Paint;
        panel2.MouseDown += panel2_MouseDown;
        // 
        // label8
        // 
        label8.Cursor = Cursors.Hand;
        label8.Font = new Font("Segoe UI", 20F);
        label8.ForeColor = Color.LightGray;
        label8.Location = new Point(134, 1);
        label8.Name = "label8";
        label8.Size = new Size(68, 35);
        label8.TabIndex = 41;
        label8.Text = "↼";
        label8.Click += label8_Click;
        // 
        // fname
        // 
        fname.Location = new Point(69, 122);
        fname.Name = "fname";
        fname.Size = new Size(441, 27);
        fname.TabIndex = 9;
        fname.TextChanged += textBox1_TextChanged;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 14F);
        label3.ForeColor = Color.LightGray;
        label3.Location = new Point(69, 89);
        label3.Name = "label3";
        label3.Size = new Size(129, 32);
        label3.TabIndex = 8;
        label3.Text = "First Name";
        // 
        // withdraw
        // 
        withdraw.BackColor = Color.FromArgb(2, 0, 46);
        withdraw.Cursor = Cursors.Hand;
        withdraw.FlatAppearance.BorderSize = 0;
        withdraw.FlatStyle = FlatStyle.Flat;
        withdraw.Font = new Font("Segoe UI", 14F);
        withdraw.ForeColor = Color.LightGray;
        withdraw.Location = new Point(47, 611);
        withdraw.Name = "withdraw";
        withdraw.Size = new Size(488, 83);
        withdraw.TabIndex = 12;
        withdraw.Text = "Sign Up";
        withdraw.UseVisualStyleBackColor = false;
        withdraw.MouseClick += withdraw_MouseClick;
        // 
        // mname
        // 
        mname.Location = new Point(69, 192);
        mname.Name = "mname";
        mname.Size = new Size(441, 27);
        mname.TabIndex = 14;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 14F);
        label4.ForeColor = Color.LightGray;
        label4.Location = new Point(69, 156);
        label4.Name = "label4";
        label4.Size = new Size(160, 32);
        label4.TabIndex = 15;
        label4.Text = "Middle Name";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 14F);
        label5.ForeColor = Color.LightGray;
        label5.Location = new Point(69, 224);
        label5.Name = "label5";
        label5.Size = new Size(126, 32);
        label5.TabIndex = 17;
        label5.Text = "Last Name";
        // 
        // lname
        // 
        lname.Location = new Point(69, 259);
        lname.Name = "lname";
        lname.Size = new Size(441, 27);
        lname.TabIndex = 16;
        // 
        // email
        // 
        email.Location = new Point(69, 363);
        email.Name = "email";
        email.Size = new Size(441, 27);
        email.TabIndex = 19;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 14F);
        label2.ForeColor = Color.LightGray;
        label2.Location = new Point(69, 327);
        label2.Name = "label2";
        label2.Size = new Size(71, 32);
        label2.TabIndex = 18;
        label2.Text = "Email";
        label2.Click += label2_Click;
        // 
        // phone
        // 
        phone.Location = new Point(69, 437);
        phone.MaxLength = 11;
        phone.Name = "phone";
        phone.Size = new Size(441, 27);
        phone.TabIndex = 21;
        phone.KeyPress += phone_KeyPress;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 14F);
        label6.ForeColor = Color.LightGray;
        label6.Location = new Point(69, 401);
        label6.Name = "label6";
        label6.Size = new Size(103, 32);
        label6.TabIndex = 20;
        label6.Text = "Phone #";
        label6.Click += label6_Click;
        // 
        // pass
        // 
        pass.Location = new Point(69, 539);
        pass.Name = "pass";
        pass.PasswordChar = '*';
        pass.Size = new Size(441, 27);
        pass.TabIndex = 23;
        pass.UseSystemPasswordChar = true;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 14F);
        label7.ForeColor = Color.LightGray;
        label7.Location = new Point(69, 504);
        label7.Name = "label7";
        label7.Size = new Size(111, 32);
        label7.TabIndex = 22;
        label7.Text = "Password";
        // 
        // Form4
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(10, 10, 56);
        ClientSize = new Size(584, 761);
        Controls.Add(pass);
        Controls.Add(label7);
        Controls.Add(phone);
        Controls.Add(label6);
        Controls.Add(email);
        Controls.Add(label2);
        Controls.Add(label5);
        Controls.Add(lname);
        Controls.Add(label4);
        Controls.Add(mname);
        Controls.Add(withdraw);
        Controls.Add(fname);
        Controls.Add(label3);
        Controls.Add(panel2);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Form4";
        Text = "Form4";
        Load += Form4_Load;
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Panel panel2;
    private TextBox fname;
    private Label label3;
    private System.Windows.Forms.Button withdraw;
    private TextBox mname;
    private Label label4;
    private Label label5;
    private TextBox lname;
    private TextBox email;
    private Label label2;
    private TextBox phone;
    private Label label6;
    private TextBox pass;
    private Label label7;
    private Label label8;
}