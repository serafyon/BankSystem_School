namespace BankSystem_School.Model;

public class Authenticator
{
    public required string CustomerID { get; set; }  // c_Customer_ID char 5
    public string Name { get; set; }
    public string MName { get; set; }
    public string LName { get; set; }
    public required string Password { get; set; }  
    public required string Email { get; set; }
    public required string PIN { get; set; }
    
}