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
        label1 = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        label8 = new System.Windows.Forms.Label();
        fname = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        withdraw = new System.Windows.Forms.Button();
        mname = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        lname = new System.Windows.Forms.TextBox();
        email = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        phone = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        pass = new System.Windows.Forms.TextBox();
        label7 = new System.Windows.Forms.Label();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
        label1.Font = new System.Drawing.Font("Segoe UI", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.LightGray;
        label1.Location = new System.Drawing.Point(381, 11);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(48, 15);
        label1.TabIndex = 0;
        label1.Text = "Sign Up";
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
        panel2.Controls.Add(label8);
        panel2.Controls.Add(label1);
        panel2.Location = new System.Drawing.Point(-134, -2);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(852, 50);
        panel2.TabIndex = 1;
        panel2.Paint += panel2_Paint;
        // 
        // label8
        // 
        label8.Cursor = System.Windows.Forms.Cursors.Hand;
        label8.Font = new System.Drawing.Font("Segoe UI", 18.048002F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label8.ForeColor = System.Drawing.Color.LightGray;
        label8.Location = new System.Drawing.Point(146, -13);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(68, 49);
        label8.TabIndex = 41;
        label8.Text = "↼";
        // 
        // fname
        // 
        fname.Location = new System.Drawing.Point(69, 122);
        fname.Name = "fname";
        fname.Size = new System.Drawing.Size(441, 27);
        fname.TabIndex = 9;
        fname.TextChanged += textBox1_TextChanged;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new System.Drawing.Font("Segoe UI", 8.832F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.ForeColor = System.Drawing.Color.LightGray;
        label3.Location = new System.Drawing.Point(69, 88);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(80, 20);
        label3.TabIndex = 8;
        label3.Text = "First Name";
        // 
        // withdraw
        // 
        withdraw.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
        withdraw.Cursor = System.Windows.Forms.Cursors.Hand;
        withdraw.FlatAppearance.BorderSize = 0;
        withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        withdraw.Font = new System.Drawing.Font("Segoe UI", 7.6800003F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        withdraw.ForeColor = System.Drawing.Color.LightGray;
        withdraw.Location = new System.Drawing.Point(47, 611);
        withdraw.Name = "withdraw";
        withdraw.Size = new System.Drawing.Size(488, 83);
        withdraw.TabIndex = 12;
        withdraw.Text = "Sign Up";
        withdraw.UseVisualStyleBackColor = false;
        withdraw.MouseClick += withdraw_MouseClick;
        // 
        // mname
        // 
        mname.Location = new System.Drawing.Point(69, 188);
        mname.Name = "mname";
        mname.Size = new System.Drawing.Size(441, 27);
        mname.TabIndex = 14;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new System.Drawing.Font("Segoe UI", 8.832F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.ForeColor = System.Drawing.Color.LightGray;
        label4.Location = new System.Drawing.Point(69, 152);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 20);
        label4.TabIndex = 15;
        label4.Text = "Middle Name";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new System.Drawing.Font("Segoe UI", 8.832F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.ForeColor = System.Drawing.Color.LightGray;
        label5.Location = new System.Drawing.Point(69, 216);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(79, 20);
        label5.TabIndex = 17;
        label5.Text = "Last Name";
        // 
        // lname
        // 
        lname.Location = new System.Drawing.Point(69, 252);
        lname.Name = "lname";
        lname.Size = new System.Drawing.Size(441, 27);
        lname.TabIndex = 16;
        // 
        // email
        // 
        email.Location = new System.Drawing.Point(69, 340);
        email.Name = "email";
        email.Size = new System.Drawing.Size(441, 27);
        email.TabIndex = 19;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new System.Drawing.Font("Segoe UI", 8.832F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.LightGray;
        label2.Location = new System.Drawing.Point(69, 306);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(46, 20);
        label2.TabIndex = 18;
        label2.Text = "Email";
        // 
        // phone
        // 
        phone.Location = new System.Drawing.Point(69, 414);
        phone.Name = "phone";
        phone.Size = new System.Drawing.Size(441, 27);
        phone.TabIndex = 21;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new System.Drawing.Font("Segoe UI", 8.832F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.ForeColor = System.Drawing.Color.LightGray;
        label6.Location = new System.Drawing.Point(69, 380);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(63, 20);
        label6.TabIndex = 20;
        label6.Text = "Phone #";
        label6.Click += label6_Click;
        // 
        // pass
        // 
        pass.Location = new System.Drawing.Point(69, 539);
        pass.Name = "pass";
        pass.PasswordChar = '*';
        pass.Size = new System.Drawing.Size(441, 27);
        pass.TabIndex = 23;
        pass.UseSystemPasswordChar = true;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new System.Drawing.Font("Segoe UI", 8.832F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.ForeColor = System.Drawing.Color.LightGray;
        label7.Location = new System.Drawing.Point(69, 505);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(70, 20);
        label7.TabIndex = 22;
        label7.Text = "Password";
        // 
        // Form4
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)10)), ((int)((byte)56)));
        ClientSize = new System.Drawing.Size(584, 761);
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
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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