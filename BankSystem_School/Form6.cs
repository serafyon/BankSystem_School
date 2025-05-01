using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystem_School.Data;
using BankSystem_School.Model;
using Microsoft.VisualBasic;

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


        private string PIN;
        private void Form6_Load(object sender, EventArgs e)
        {
            Console.WriteLine($"this is a cid thingy {getCID()}");//debug line
            BankLogic bankLogic = new BankLogic();
            List<Account> accounts = bankLogic.GetAccounts(getCID());
            
            List<string> temp = new List<string>();
            foreach (var account in accounts)
            {
                temp.Add($"{account.AccountID} - {account.AccountType} ");
                Console.WriteLine(temp[0]);
            }
            
            
            comboBox1.DataSource = accounts.Select(a => new
            {
                Display = $"{a.AccountID} - {a.AccountType}",
                Value = a.AccountID
            }).ToList();
            comboBox1.DisplayMember = "Display";
            comboBox1.ValueMember = "Value";
            comboBox1.BindingContext = this.BindingContext;
            
            
            

        }

        private void withdraw_MouseHover(object sender, EventArgs e)
        {
            Console.WriteLine(comboBox1.ValueMember);
            Console.WriteLine(comboBox1.SelectedValue.ToString());
            
        }

        
        private void withdraw_MouseClick(object sender, EventArgs e)
        {

            Account_Data acdata = new Account_Data();
            string accId = comboBox1.SelectedValue.ToString(); // passes 
            string prompt = Interaction.InputBox("Enter your 4-digit PIN", "Security", "", -1, -1);
            if (prompt == acdata.GetPinByAccID(comboBox1.SelectedValue.ToString())) //fetch PIN from idk
            {
                MessageBox.Show("Ok gtfo idk");
            }
            else
            {
                MessageBox.Show("ermm wrong input");
            }
            
            Form1 f1 = new Form1(accId, getCID()); // we got acc id here just needs to re fetch customer id
            this.Close();
            f1.Show();
        }
    }
}
