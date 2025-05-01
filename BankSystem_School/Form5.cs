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
    public partial class Form5: Form
    {

        public Form5()
        {
            InitializeComponent();

            
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            Welcome welcome = new Welcome();
            this.Close();
            welcome.Show();
        }
            
        //fetch email pass and compare
        private void withdraw_MouseClick(object sender, MouseEventArgs e)
        {
            BankLogic bankLogic = new BankLogic();
            string email = textBox1.Text;
            string pass = textBox2.Text;
            if (bankLogic.ValidateSignIn(email, pass))
            {
                MessageBox.Show("You fucking did it");
                
                Console.WriteLine($"Testing {bankLogic.getCustId()}");
                string custId = bankLogic.getCustId();
                // attach customer id to form 6 AKA ACCOUNT SELECTION because i can
                Form6 f6 = new Form6(custId);
                
                f6.Show();
                Close();
            }
            else
            {
                MessageBox.Show("DIE!!!!");
            }
        }


    }
}