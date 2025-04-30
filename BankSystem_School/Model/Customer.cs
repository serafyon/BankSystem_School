namespace BankSystem_School.Model;

public class Customer
{
    // Deprecated, moved to Account
    
    //TODO: Split Name to First Name, Last Name, M.I.
    public required string CustomerID { get; set; }  // c_Customer_ID char 5
    public required string LName { get; set; }      // v_LName varchar 50
    public required string Name { get; set; }        // v_Name varchar 50
    public required string MName { get; set; }      // v_MName varchar 50
    public required string Email { get; set; }       // v_Email varchar 50
    public required string Phone { get; set; }       // v_Phone varchar 11
    public required string Password { get; set; }        //v_Password varchar 50

}