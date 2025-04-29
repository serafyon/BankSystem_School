using System.Configuration;
using BankSystem_School.Model;
using Microsoft.Data.SqlClient;

namespace BankSystem_School.Data;

public class Account_Data
{
    private string conn = ConfigurationManager.ConnectionStrings[@"C:\BankSystem_School\BankSystem_School\Database\DB_Bank.mdf"].ConnectionString;
    
    
    //account table accessor (read)
    public List<Account> GetAccounts()
    {
        List<Account> accounts = new List<Account>();
        
        using SqlConnection connection = new SqlConnection(conn);
        {
            string query = "select * from Accounts";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                accounts.Add(new Account
                {
                    AccountID = (string)reader["c_AccountID"],
                    CustomerID = (string)reader["c_CustomerID"],
                    AccountType = (string)reader["v_AccountType"],
                    Balance = Convert.ToDecimal(reader["d_Balance"])
                });
            }
            connection.Close();
            
        }
        return accounts;
    }
    
    // account table mutator (create)
    public bool AddAccount(Account account)
    {
        using SqlConnection connection = new SqlConnection(conn);
        {
            
            // TODO: Fetch c_CustomerID from current login session
            
            // fkquery validation
            //string fkquery = "select c_CustomerID from Customer where c_CustomerID=@c_CustomerID"; 
            string query =
                "insert into Accounts (c_AccountID, c_CustomerID, v_AccountType, d_Balance) values (@c_AccountID, @c_CustomerID, @v_AccountType, @d_Balance)";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            //SqlCommand command2 = new SqlCommand(fkquery, connection);
            //command2.Parameters.AddWithValue("@c_CustomerID", account.CustomerID);
            command.Parameters.AddWithValue("@c_CustomerID", account.CustomerID); //Need session c_CustomerID (CHECK TODO)
            command.Parameters.AddWithValue("@c_AccountID", account.AccountID);
            command.Parameters.AddWithValue("@v_AccountType", account.AccountType);
            command.Parameters.AddWithValue("@d_Balance", account.Balance);


            return command.ExecuteNonQuery() > 0;
        }
    }
    
    // account table mutator (update)
    public bool UpdateAccount(Account account)
    {
        using SqlConnection connection = new SqlConnection(conn);
        {
            string query =
                "update Accounts set v_AccountType = @c_AccountType, d_Balance = @d_Balance where c_AccountID = @c_AccountID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@c_AccountID", account.AccountID);
            command.Parameters.AddWithValue("@d_Balance", account.Balance);
            command.Parameters.AddWithValue("@c_AccountType", account.AccountType);
            connection.Open();
            
            return command.ExecuteNonQuery() > 0;
        }
    }
    
    // account table mutator (delete)
    public bool DeleteAccount(Account account)
    {
        using SqlConnection connection = new SqlConnection(conn);
        {
            string query =
                "delete from Accounts where c_AccountID = @c_AccountID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@c_AccountID", account.AccountID);
            connection.Open();
            
            return command.ExecuteNonQuery() > 0;
        }
    }
}