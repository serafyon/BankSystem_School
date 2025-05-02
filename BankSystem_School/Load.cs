namespace BankSystem_School;

public partial class Load : Form
{
    public Load()
    {
        InitializeComponent();
    }

    private void Load_Load(object sender, EventArgs e)
    {
        
    }

    private void Load_Shown(object sender, EventArgs e)
    {
        Welcome welcome = new();
        welcome.Show();
        this.Hide();
    }
}