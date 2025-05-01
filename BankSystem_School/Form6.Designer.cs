namespace BankSystem_School
{
    partial class Form6
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
            panel2 = new System.Windows.Forms.Panel();
            name = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            withdraw = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
            label1.Font = new System.Drawing.Font("Segoe UI", 6.912F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label1.ForeColor = System.Drawing.Color.LightGray;
            label1.Location = new System.Drawing.Point(348, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Account Selection";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
            panel2.Controls.Add(label1);
            panel2.Location = new System.Drawing.Point(-26, -2);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(852, 50);
            panel2.TabIndex = 14;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new System.Drawing.Font("Segoe UI", 12.672001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            name.ForeColor = System.Drawing.Color.LightGray;
            name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            name.Location = new System.Drawing.Point(12, 70);
            name.Name = "name";
            name.Size = new System.Drawing.Size(169, 30);
            name.TabIndex = 15;
            name.Text = "Existing Account";
            name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "---Choose an Account---" });
            comboBox1.Location = new System.Drawing.Point(24, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(235, 28);
            comboBox1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12.672001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label2.ForeColor = System.Drawing.Color.LightGray;
            label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label2.Location = new System.Drawing.Point(530, 70);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(141, 30);
            label2.TabIndex = 17;
            label2.Text = "New Account";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // withdraw
            // 
            withdraw.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
            withdraw.Cursor = System.Windows.Forms.Cursors.Hand;
            withdraw.FlatAppearance.BorderSize = 0;
            withdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            withdraw.Font = new System.Drawing.Font("Segoe UI", 7.6800003F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            withdraw.ForeColor = System.Drawing.Color.LightGray;
            withdraw.Location = new System.Drawing.Point(24, 178);
            withdraw.Name = "withdraw";
            withdraw.Size = new System.Drawing.Size(235, 55);
            withdraw.TabIndex = 19;
            withdraw.Text = "Select";
            withdraw.UseVisualStyleBackColor = false;
            withdraw.Click += withdraw_MouseClick;
            withdraw.MouseHover += withdraw_MouseHover;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)2)), ((int)((byte)0)), ((int)((byte)46)));
            button1.Cursor = System.Windows.Forms.Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Segoe UI", 7.6800003F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            button1.ForeColor = System.Drawing.Color.LightGray;
            button1.Location = new System.Drawing.Point(530, 178);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(235, 55);
            button1.TabIndex = 20;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)10)), ((int)((byte)56)));
            label3.Font = new System.Drawing.Font("Segoe UI", 8.832F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            label3.ForeColor = System.Drawing.Color.LightGray;
            label3.Location = new System.Drawing.Point(377, 85);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(23, 20);
            label3.TabIndex = 1;
            label3.Text = "or";
            // 
            // Form6
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(((int)((byte)10)), ((int)((byte)10)), ((int)((byte)56)));
            ClientSize = new System.Drawing.Size(800, 259);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(withdraw);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(name);
            Controls.Add(panel2);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Text = "Form6";
            Load += Form6_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Label name;
        private ComboBox comboBox1;
        private Label label2;
        private System.Windows.Forms.Button withdraw;
        private Button button1;
        private Label label3;
    }
}