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
        label1 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        withdraw = new System.Windows.Forms.Button();
        panel2 = new System.Windows.Forms.Panel();
        panel1 = new System.Windows.Forms.Panel();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
        label1.Font = new System.Drawing.Font("Segoe UI", 8.64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.LightGray;
        label1.Location = new System.Drawing.Point(376, 12);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(71, 20);
        label1.TabIndex = 0;
        label1.Text = "Welcome";
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
        button1.Cursor = System.Windows.Forms.Cursors.Hand;
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button1.Font = new System.Drawing.Font("Segoe UI", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button1.ForeColor = System.Drawing.Color.LightGray;
        button1.Location = new System.Drawing.Point(504, 165);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(235, 55);
        button1.TabIndex = 27;
        button1.Text = "Sign Up";
        button1.UseVisualStyleBackColor = false;
        button1.MouseClick += button1_MouseClick;
        // 
        // withdraw
        // 
        withdraw.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
        withdraw.Cursor = System.Windows.Forms.Cursors.Hand;
        withdraw.FlatAppearance.BorderSize = 0;
        withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        withdraw.Font = new System.Drawing.Font("Segoe UI", 9.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        withdraw.ForeColor = System.Drawing.Color.LightGray;
        withdraw.Location = new System.Drawing.Point(504, 74);
        withdraw.Name = "withdraw";
        withdraw.Size = new System.Drawing.Size(235, 55);
        withdraw.TabIndex = 26;
        withdraw.Text = "Sign In";
        withdraw.UseVisualStyleBackColor = false;
        withdraw.MouseClick += withdraw_MouseClick;
        // 
        // panel2
        // 
        panel2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
        panel2.Controls.Add(label1);
        panel2.Location = new System.Drawing.Point(-26, -3);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(852, 50);
        panel2.TabIndex = 22;
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
        panel1.Location = new System.Drawing.Point(-1, 46);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(436, 217);
        panel1.TabIndex = 28;
        // 
        // Welcome
        // 
        AccessibleName = "Background";
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)10)), ((int)((byte)56)));
        ClientSize = new System.Drawing.Size(800, 259);
        Controls.Add(panel1);
        Controls.Add(button1);
        Controls.Add(withdraw);
        Controls.Add(panel2);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        Text = "Welcome";
        Load += Welcome_Load;
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button withdraw;
    private Panel panel2;
    private Panel panel1;
}