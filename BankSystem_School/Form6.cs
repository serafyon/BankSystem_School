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
    public partial class Form6: Form
    {

        
        private string cid;

        private void setCID(string cid)
        {
            this.cid = cid;
            Console.WriteLine($"SetCID flag {this.cid}");
        }

        private string getCID()
        {
            Console.WriteLine($"GetCID flag {this.cid}");
            return cid;
            
        }
        
        public Form6(string custId)
        {
            
            setCID(custId);
            Console.WriteLine($"this is a cid thingy {custId}");//debug line
            BankLogic bankLogic = new BankLogic();
            List<Account> accounts = bankLogic.GetAccounts(custId);
            List<string> temp = new List<string>();
            foreach (var account in accounts)
            {
                temp.Add($"{account.AccountID} - {account.AccountType} ");
                Console.WriteLine(temp[0]);
            }

            comboBox1.DataSource = temp; //TODO: FIX
            
            comboBox1.DisplayMember = "AccountType";
            comboBox1.ValueMember = "AccountID";
            
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                // if shit hits the fan, this is the reason
                Account sel = (Account)comboBox1.SelectedItem;
                
                string accountId = sel.AccountID;
                string accountType = sel.AccountType;
                
                Console.WriteLine($@"Debug stuff {accountId} {accountType}");
            }
        }

        // new acc
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Form7 f7 = new Form7(getCID());
            f7.Show();
            Hide();
        }

        // select existing
        // make sure to set up a PIN security check thingamajig or else ill blow up lol
        private void withdraw_MouseClick(object sender, MouseEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
