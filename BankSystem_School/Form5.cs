using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem_School
{
    public partial class Form5 : Form
    {
        const uint WM_NCLBUTTONDOWN = 0xA1;
        const uint HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        Welcome welcome = new();
        public Form5()
        {
            InitializeComponent();


        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            welcome.Activate();
            welcome.Show();
            this.Hide();
            
        }

        //fetch email pass and compare
        private void withdraw_MouseClick(object sender, MouseEventArgs e)
        {
            BankLogic bankLogic = new BankLogic();
            string email = textBox1.Text;
            string pass = textBox2.Text;
            if (bankLogic.ValidateSignIn(email, pass))
            {
                MessageBox.Show("Successfully signed in!");
                string custId = bankLogic.getCustId();
                
                Form6 f6 = new Form6(custId);
                welcome.Dispose();
                f6.Show();
                
                Close();
                welcome.Close();
                
            }
            else
            {
                MessageBox.Show("Incorrect Credentials.");
            }
        }



        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, (int)WM_NCLBUTTONDOWN, (int)HT_CAPTION, 0);
            }
        }
    }
}