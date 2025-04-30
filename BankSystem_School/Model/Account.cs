namespace BankSystem_School.Model;

public class Account
{
    public required string AccountID { get; set; }       //c_AccountID char 10
    public required string CustomerID { get; set; }      //c_CustomerID char 5 Foreign
    public required string AccountType { get; set; }     //v_AccountType varchar 20
    public required decimal Balance { get; set; }        //d_Balance decimal 18,2
    public required string PIN { get; set; }        //v_Password varchar 50

}