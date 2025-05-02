using System.ComponentModel;

namespace BankSystem_School;

partial class Welcome
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
        ComponentResourceManager resources = new ComponentResourceManager(typeof(Welcome));
        label1 = new Label();
        button1 = new Button();
        withdraw = new Button();
        panel2 = new Panel();
        panel1 = new Panel();
        label3 = new Label();
        label2 = new Label();
        panel2.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = Color.FromArgb(2, 0, 46);
        label1.Font = new Font("Segoe UI", 9F);
        label1.ForeColor = Color.LightGray;
        label1.Location = new Point(376, 12);
        label1.Name = "label1";
        label1.Size = new Size(71, 20);
        label1.TabIndex = 0;
        label1.Text = "Welcome";
        // 
        // button1
        // 
        button1.BackColor = Color.FromArgb(2, 0, 46);
        button1.Cursor = Cursors.Hand;
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Segoe UI", 14F);
        button1.ForeColor = Color.LightGray;
        button1.Location = new Point(504, 165);
        button1.Name = "button1";
        button1.Size = new Size(235, 55);
        button1.TabIndex = 27;
        button1.Text = "Sign Up";
        button1.UseVisualStyleBackColor = false;
        button1.MouseClick += button1_MouseClick;
        // 
        // withdraw
        // 
        withdraw.BackColor = Color.FromArgb(2, 0, 46);
        withdraw.Cursor = Cursors.Hand;
        withdraw.FlatAppearance.BorderSize = 0;
        withdraw.FlatStyle = FlatStyle.Flat;
        withdraw.Font = new Font("Segoe UI", 14F);
        withdraw.ForeColor = Color.LightGray;
        withdraw.Location = new Point(504, 74);
        withdraw.Name = "withdraw";
        withdraw.Size = new Size(235, 55);
        withdraw.TabIndex = 26;
        withdraw.Text = "Sign In";
        withdraw.UseVisualStyleBackColor = false;
        withdraw.MouseClick += withdraw_MouseClick;
        // 
        // panel2
        // 
        panel2.BackColor = Color.FromArgb(2, 0, 46);
        panel2.Controls.Add(label1);
        panel2.Location = new Point(-26, -3);
        panel2.Name = "panel2";
        panel2.Size = new Size(852, 50);
        panel2.TabIndex = 22;
        panel2.MouseDown += panel2_MouseDown;
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(2, 0, 46);
        panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
        panel1.BackgroundImageLayout = ImageLayout.Center;
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Location = new Point(-1, 46);
        panel1.Name = "panel1";
        panel1.Size = new Size(436, 217);
        panel1.TabIndex = 28;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.BackColor = Color.Transparent;
        label3.Font = new Font("Segoe UI", 14F);
        label3.ForeColor = Color.LightGray;
        label3.Location = new Point(18, 80);
        label3.Name = "label3";
        label3.Size = new Size(299, 32);
        label3.TabIndex = 2;
        label3.Text = "Balance, Beyond Numbers.";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.BackColor = Color.Transparent;
        label2.Font = new Font("Segoe UI", 25F);
        label2.ForeColor = Color.LightGray;
        label2.Location = new Point(13, 19);
        label2.Name = "label2";
        label2.Size = new Size(198, 57);
        label2.TabIndex = 1;
        label2.Text = "Silly Bank";
        // 
        // Welcome
        // 
        AccessibleName = "Background";
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(10, 10, 56);
        ClientSize = new Size(800, 259);
        Controls.Add(panel1);
        Controls.Add(button1);
        Controls.Add(withdraw);
        Controls.Add(panel2);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Welcome";
        Text = "Welcome";
        Load += Welcome_Load;
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button withdraw;
    private Panel panel2;
    private Panel panel1;
    private Label label3;
    private Label label2;
}