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

namespace BankSystem_School
{
    public partial class Form8 : Form
    {
        private string customerID;
        private string accID;
        public Form8(string customerId, string accId)
        {
            customerID = customerId;
            accID = accId;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string t_email = email.Text;
            string t_phone = phone.Text;
            string t_old = oldpass.Text;
            string t_new = newpass.Text;
            
            Customer_Data cdata = new Customer_Data();
            Customer customer = new Customer
            {
                CustomerID = customerID,
                LName = "",
                Name = "",
                MName = "",
                Email = t_email,
                Phone = t_phone,
                Password = t_new,
            };
            if (!t_old.Equals(t_new))
            {
                cdata.SetCustomerInfo(customerID, customer);
                MessageBox.Show("Success, please sign in again!");
                Welcome w = new Welcome();
                w.Refresh();
                w.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("21 \n you stupid", "Whas 9 plus ten???"); // cannot be the same password
            }
            
        }
        int count = 0;
        private void delete_Click(object sender, EventArgs e)
        {
           
            if (count == 0)
            {
                delete.Text = "ARE YOU SURE?"; //https://tenor.com/eQQ2wj7R9Dz.gif
                count++;
                Console.WriteLine(count);
            }
            else if (count == 1)
            {
                delete.Text = "ARE YOU VERY SURE?"; 
                count++;
                Console.WriteLine(count);
            }
            else if (count == 2)
            {
                Customer_Data cdata = new Customer_Data();
                Account_Data acdata = new Account_Data();
                acdata.DeleteAllAccountsByCustomerID(customerID);
                cdata.DeleteCustomer(customerID);
                
                MessageBox.Show("Deleted, thank you for using our services.");
                Welcome w = new Welcome();
                w.Refresh();
                w.Show();
                this.Close();
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
