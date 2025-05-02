using BankSystem_School.Model;

namespace BankSystem_School;

public partial class Form4 : Form
{
    Welcome welcome = new();
    const uint WM_NCLBUTTONDOWN = 0xA1;
    const uint HT_CAPTION = 0x2;

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern bool ReleaseCapture();
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

        if (bankLogic.BCreateCustomer(customer, fnameText, emailText, phoneText, lnameText, mnameText, passwordText))
        {
            MessageBox.Show("Customer created successfully");

            this.Close();
            // attach customer id to form 6 AKA ACCOUNT SELECTION because i can
            Form6 f6 = new Form6(bankLogic.getCustId());
            f6.Show();

        }
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void phone_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void label8_Click(object sender, EventArgs e)
    {
        welcome.Activate();
        welcome.Show();
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