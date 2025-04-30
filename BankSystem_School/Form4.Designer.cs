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
        textBox1 = new TextBox();
        label3 = new Label();
        withdraw = new Button();
        textBox3 = new TextBox();
        label4 = new Label();
        label5 = new Label();
        textBox4 = new TextBox();
        textBox2 = new TextBox();
        label2 = new Label();
        textBox5 = new TextBox();
        label6 = new Label();
        textBox6 = new TextBox();
        label7 = new Label();
        label8 = new Label();
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
        label1.Size = new Size(75, 25);
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
        // 
        // textBox1
        // 
        textBox1.Location = new Point(69, 122);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(441, 27);
        textBox1.TabIndex = 9;
        textBox1.TextChanged += textBox1_TextChanged;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label3.ForeColor = Color.LightGray;
        label3.Location = new Point(69, 88);
        label3.Name = "label3";
        label3.Size = new Size(124, 31);
        label3.TabIndex = 8;
        label3.Text = "First Name";
        // 
        // withdraw
        // 
        withdraw.BackColor = Color.FromArgb(2, 0, 46);
        withdraw.Cursor = Cursors.Hand;
        withdraw.FlatAppearance.BorderSize = 0;
        withdraw.FlatStyle = FlatStyle.Flat;
        withdraw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        withdraw.ForeColor = Color.LightGray;
        withdraw.Location = new Point(47, 611);
        withdraw.Name = "withdraw";
        withdraw.Size = new Size(488, 83);
        withdraw.TabIndex = 12;
        withdraw.Text = "Sign Up";
        withdraw.UseVisualStyleBackColor = false;
        // 
        // textBox3
        // 
        textBox3.Location = new Point(69, 188);
        textBox3.Name = "textBox3";
        textBox3.Size = new Size(441, 27);
        textBox3.TabIndex = 14;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label4.ForeColor = Color.LightGray;
        label4.Location = new Point(69, 152);
        label4.Name = "label4";
        label4.Size = new Size(154, 31);
        label4.TabIndex = 15;
        label4.Text = "Middle Name";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label5.ForeColor = Color.LightGray;
        label5.Location = new Point(69, 216);
        label5.Name = "label5";
        label5.Size = new Size(122, 31);
        label5.TabIndex = 17;
        label5.Text = "Last Name";
        // 
        // textBox4
        // 
        textBox4.Location = new Point(69, 252);
        textBox4.Name = "textBox4";
        textBox4.Size = new Size(441, 27);
        textBox4.TabIndex = 16;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(69, 340);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(441, 27);
        textBox2.TabIndex = 19;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label2.ForeColor = Color.LightGray;
        label2.Location = new Point(69, 306);
        label2.Name = "label2";
        label2.Size = new Size(70, 31);
        label2.TabIndex = 18;
        label2.Text = "Email";
        // 
        // textBox5
        // 
        textBox5.Location = new Point(69, 414);
        textBox5.Name = "textBox5";
        textBox5.Size = new Size(441, 27);
        textBox5.TabIndex = 21;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label6.ForeColor = Color.LightGray;
        label6.Location = new Point(69, 380);
        label6.Name = "label6";
        label6.Size = new Size(98, 31);
        label6.TabIndex = 20;
        label6.Text = "Phone #";
        label6.Click += label6_Click;
        // 
        // textBox6
        // 
        textBox6.Location = new Point(69, 539);
        textBox6.Name = "textBox6";
        textBox6.PasswordChar = '*';
        textBox6.Size = new Size(441, 27);
        textBox6.TabIndex = 23;
        textBox6.UseSystemPasswordChar = true;
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label7.ForeColor = Color.LightGray;
        label7.Location = new Point(69, 505);
        label7.Name = "label7";
        label7.Size = new Size(110, 31);
        label7.TabIndex = 22;
        label7.Text = "Password";
        // 
        // label8
        // 
        label8.Cursor = Cursors.Hand;
        label8.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label8.ForeColor = Color.LightGray;
        label8.Location = new Point(146, -13);
        label8.Name = "label8";
        label8.Size = new Size(68, 49);
        label8.TabIndex = 41;
        label8.Text = "↼";
        // 
        // Form4
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(10, 10, 56);
        ClientSize = new Size(584, 761);
        Controls.Add(textBox6);
        Controls.Add(label7);
        Controls.Add(textBox5);
        Controls.Add(label6);
        Controls.Add(textBox2);
        Controls.Add(label2);
        Controls.Add(label5);
        Controls.Add(textBox4);
        Controls.Add(label4);
        Controls.Add(textBox3);
        Controls.Add(withdraw);
        Controls.Add(textBox1);
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
    private TextBox textBox1;
    private Label label3;
    private Button withdraw;
    private TextBox textBox3;
    private Label label4;
    private Label label5;
    private TextBox textBox4;
    private TextBox textBox2;
    private Label label2;
    private TextBox textBox5;
    private Label label6;
    private TextBox textBox6;
    private Label label7;
    private Label label8;
}