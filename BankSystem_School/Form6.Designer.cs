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
            label1 = new Label();
            panel2 = new Panel();
            name = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            withdraw = new Button();
            button1 = new Button();
            label3 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(2, 0, 46);
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(348, 11);
            label1.Name = "label1";
            label1.Size = new Size(153, 25);
            label1.TabIndex = 0;
            label1.Text = "Account Selection";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(2, 0, 46);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-26, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(852, 50);
            panel2.TabIndex = 14;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name.ForeColor = Color.LightGray;
            name.ImageAlign = ContentAlignment.MiddleLeft;
            name.Location = new Point(12, 70);
            name.Name = "name";
            name.Size = new Size(267, 46);
            name.TabIndex = 15;
            name.Text = "Existing Account";
            name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.WhiteSmoke;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "---Choose an Account---" });
            comboBox1.Location = new Point(24, 134);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(235, 28);
            comboBox1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(530, 70);
            label2.Name = "label2";
            label2.Size = new Size(221, 46);
            label2.TabIndex = 17;
            label2.Text = "New Account";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // withdraw
            // 
            withdraw.BackColor = Color.FromArgb(2, 0, 46);
            withdraw.Cursor = Cursors.Hand;
            withdraw.FlatAppearance.BorderSize = 0;
            withdraw.FlatStyle = FlatStyle.Flat;
            withdraw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            withdraw.ForeColor = Color.LightGray;
            withdraw.Location = new Point(24, 178);
            withdraw.Name = "withdraw";
            withdraw.Size = new Size(235, 55);
            withdraw.TabIndex = 19;
            withdraw.Text = "Select";
            withdraw.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(2, 0, 46);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.LightGray;
            button1.Location = new Point(530, 178);
            button1.Name = "button1";
            button1.Size = new Size(235, 55);
            button1.TabIndex = 20;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(10, 10, 56);
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(377, 85);
            label3.Name = "label3";
            label3.Size = new Size(35, 31);
            label3.TabIndex = 1;
            label3.Text = "or";
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 56);
            ClientSize = new Size(800, 259);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(withdraw);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(name);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form6";
            Text = "Form6";
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
        private Button withdraw;
        private Button button1;
        private Label label3;
    }
}