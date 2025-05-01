using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystem_School.Model;

namespace BankSystem_School
{
    public partial class Form7: Form
    {
        private string cid;

        private void setCID(string cid)
        {
            this.cid = cid;
        }

        private string getCID()
        {
            return cid;
        }
        public Form7(string custId)
        {
            List <string> accountType = new List<string>
            {
                "Savings",
                "Checking",
                "Business",
                "Student",
                "Investment",
                "Retirement"
            };
            setCID(custId);
            comboBox1.DataSource = accountType;
            
            
            InitializeComponent();
        }

        //submit data
        private void withdraw_MouseClick(object sender, MouseEventArgs e)
        {
            BankLogic bankLogic = new BankLogic();
            Account account = new Account
            {
                AccountID = null,
                CustomerID = null,
                AccountType = null,
                Balance = 0,
                PIN = null
            };
            if (bankLogic.BCreateAccount(account, comboBox1.Text, textBox2.Text, getCID()))
            {
                MessageBox.Show("Account Created :3");
            }
            else
            {
                MessageBox.Show("Account Not Created");
            }
        }
    }
}
