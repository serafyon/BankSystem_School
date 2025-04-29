namespace BankSystem_School.Model;

public class Transaction
{
    public required string TransactionID { get; set; }       //c_TransactionID char 10
    public required string AccountID { get; set; }           //c_AccountID char 10 Foreign
    public required string TransactionType { get; set; }     //v_TransactionType varchar 20
    public required decimal Amount { get; set; }             //d_Amount decimal 18,2
    public required decimal PreviousBalance { get; set; }    //d_PreviousBalance decimal 18,2
    public decimal? AfterBalance { get; set; }       //d_AfterBalance decimal 18,2
    public string? Purpose { get; set; }             //v_Purpose varchar 100
    public required DateTime TransactionDate { get; set; }   //dt_TransactionDate datetime
    
}