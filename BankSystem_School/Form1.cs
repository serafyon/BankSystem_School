using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging.Effects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystem_School.Data;
using MaterialSkin;
using MaterialSkin;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic;

namespace BankSystem_School
{
    public partial class Form1 : Form
    {

        const uint WM_NCLBUTTONDOWN = 0xA1;
        const uint HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void GetDetails()
        {
            Account_Data acdata = new Account_Data();
            //accID = acdata.
        }

        private string accId;
        private string cId;
        public Form1(string accId, string cId)
        {
            this.accId = accId;
            this.cId = cId;
            // name, email, balance
            //name.Text = $@"{fname} {lname}";
            //this.email.Text = email;
            
            
            
            InitializeComponent();
            // balance.Text = ;
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
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

            if (temp1[0].IsNullOrEmpty())
            {
                balance.Text = 0.ToString();
            }
            else
            {
                balance.Text = temp1[0];
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, (int)WM_NCLBUTTONDOWN, (int)HT_CAPTION, 0);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully logged out.");
            Welcome welcome = new Welcome();
            welcome.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // update acc info
        private void update_MouseClick(object sender, MouseEventArgs e)
        {
            Form8 updateForm = new Form8(cId, accId);
            updateForm.Show();
            this.Hide();
            // remember to refresh to update data after updating
        }

        private void deposit_Click(object sender, EventArgs e)
        {
            Form3 depositForm = new Form3(cId, accId);
            depositForm.Show();
            this.Hide();
        }
        
        private void withdraw_Click(object sender, EventArgs e)
        {
            Form2 withdrawForm = new Form2(cId, accId);
            withdrawForm.Show();
            this.Hide();
        }
    }
}
