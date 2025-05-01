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
            setCID(custId);
            InitializeComponent();
            
        }

        //submit data
        private void withdraw_MouseClick(object sender, MouseEventArgs e)
        {
            BankLogic bankLogic = new BankLogic();
            Console.WriteLine($"Pin debug: {textBox2.Text}");
            Account account = new Account
            {
                AccountID = bankLogic.GenerateAccId().ToString(),
                CustomerID = getCID(),
                AccountType = comboBox1.SelectedValue.ToString(),
                Balance = 0,
                PIN = textBox2.Text
            };
            
            if (bankLogic.BCreateAccount(account, comboBox1.Text, textBox2.Text, getCID()))
            {
                MessageBox.Show("Successfully Created Account!");
                Form6 f6 = new Form6(getCID());
                f6.Refresh();
                f6.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Account Not Created");
            }
        }

        private void Form7_Load(object sender, EventArgs e)
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
            
            comboBox1.DataSource = accountType;


        }


    }
}
