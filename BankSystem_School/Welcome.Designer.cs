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
        panel1 = new System.Windows.Forms.Panel();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)122)), ((int)((byte)127)), ((int)((byte)132)));
        panel1.Location = new System.Drawing.Point(-8, 208);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(620, 511);
        panel1.TabIndex = 0;
        // 
        // Welcome
        // 
        AccessibleName = "Background";
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)49)), ((int)((byte)57)), ((int)((byte)76)));
        ClientSize = new System.Drawing.Size(604, 711);
        Controls.Add(panel1);
        MinimumSize = new System.Drawing.Size(620, 750);
        Text = "Welcome";
        Load += Welcome_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel panel1;

    #endregion
}