using BankSystem_School.Model;

namespace BankSystem_School;

public partial class Form4 : Form
{
    public Form4()
    {
        InitializeComponent();
    }

    private void Form4_Load(object sender, EventArgs e)
    {
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    //this is where i put the things for um
    //i think this is for adding a new customer, cross-reference banklogic for any shit for this
    private void withdraw_MouseClick(object sender, MouseEventArgs e)
    {
        string fnameText = this.fname.Text;
        string mnameText = this.mname.Text;
        string lnameText = this.lname.Text;
        string emailText = this.email.Text;
        string phoneText = this.phone.Text;
        string passwordText = pass.Text;
        
        BankLogic bankLogic = new BankLogic();
        Customer customer = new Customer
        {
            CustomerID = "",
            LName = lnameText,
            Name = fnameText,
            MName = mnameText,
            Email = emailText,
            Phone = phoneText,
            Password = passwordText
        };

        if (bankLogic.BCreateCustomer(customer, fnameText, mnameText, lnameText, emailText, phoneText, passwordText))
        {
            MessageBox.Show("Customer created successfully");
           
            this.Close();
            // attach customer id to form 6 AKA ACCOUNT SELECTION because i can
            Form6 f6 = new Form6(bankLogic.getCustId());
            f6.Show();
        }
    }

}