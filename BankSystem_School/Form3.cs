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
using Microsoft.IdentityModel.Tokens;

namespace BankSystem_School
{

    public partial class Form3 : Form
    {
        const uint WM_NCLBUTTONDOWN = 0xA1;
        const uint HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();


        private string accId;
        private string cId;
        private string _balance;
        public Form3(string cId, string accId)
        {
            this.accId = accId;
            this.cId = cId;
            InitializeComponent();
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void deposit_Click(object sender, EventArgs e)
        {
            BankLogic bankLogic = new BankLogic();
            Account_Data acdata = new Account_Data();
            Account account = new Account
            {
                AccountID = accId,
                CustomerID = cId,
                AccountType = "",
                Balance = Convert.ToDecimal(_balance),
                PIN = pinBox.Text
            };
            if (pinBox.Text == acdata.FetchAccountDetailSingle(cId, accId)[0].PIN)
            {
                if (bankLogic.MoneyDeposit(account, accId, Convert.ToDecimal(desiredBalance.Text), "deposit default"))
                {
                    Refresh();
                    MessageBox.Show("Success!");
                    Form1 f1 = new Form1(accId, cId);
                    f1.Refresh();
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to Deposit.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect PIN.");
            }


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Customer_Data cdata = new Customer_Data();

            List<string> temp = new List<string>();
            foreach (var data in cdata.GetCustomerInfo(cId))
            {
                Console.WriteLine(data.Name);
                Console.WriteLine(data.Email);
                temp.Add(data.Name);
                temp.Add(data.Email);
            }

            name.Text = temp[0];
            email.Text = temp[1];

            Account_Data acdata = new Account_Data();

            List<string> temp1 = new List<string>();
            foreach (var data in acdata.FetchAccountDetailSingle(cId, accId))
            {
                temp1.Add(data.Balance.ToString());
                temp1.Add(data.AccountID);
                temp1.Add(data.AccountType);
                temp1.Add(data.PIN);
            }
            _balance = temp1[0];


            if (temp1[0].IsNullOrEmpty())
            {
                balance.Text = 0.ToString();
            }
            else
            {
                balance.Text = temp1[0];
            }
        }


        private void pinBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(accId, cId);
            form1.Show();
            this.Close();
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
