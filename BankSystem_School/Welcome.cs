namespace BankSystem_School;



public partial class Welcome : Form
{
    
    const uint WM_NCLBUTTONDOWN = 0xA1;
    const uint HT_CAPTION = 0x2;

    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    public static extern bool ReleaseCapture();

    public Welcome()
    {
        InitializeComponent();
    }

    private void Welcome_Load(object sender, EventArgs e)
    {
        // nothing
    }

    private void withdraw_MouseClick(object sender, MouseEventArgs e)
    {
        Form5 form5 = new Form5();
        form5.Show();
        Hide();
    }

    private void button1_MouseClick(object sender, MouseEventArgs e)
    {
        Form4 form4 = new Form4();
        form4.Show();
        Hide();
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