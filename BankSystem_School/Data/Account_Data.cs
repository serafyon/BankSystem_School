using System.Configuration;
using BankSystem_School.Model;
using Microsoft.Data.SqlClient;

namespace BankSystem_School.Data;

public class Account_Data
{
    // original: C:\BankSystem_School\BankSystem_School\Database\DB_Bank.mdf
    // F:\devset\juu\BankSystem_School\BankSystem_School\Database\DB_bank.mdf
    private string _conn = ConfigurationManager.ConnectionStrings[@"F:\devset\juu\BankSystem_School\BankSystem_School\Database\DB_Bank.mdf"].ConnectionString;
    
    
    //account table accessor (read)
    public List<Account> GetAccounts()
    {
        List<Account> accounts = new List<Account>();
        
        using SqlConnection connection = new SqlConnection(_conn);
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
        using SqlConnection connection = new SqlConnection(_conn);
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
        using SqlConnection connection = new SqlConnection(_conn);
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
        using SqlConnection connection = new SqlConnection(_conn);
        {
            string query =
                "delete from Accounts where c_AccountID = @c_AccountID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@c_AccountID", account.AccountID);
            connection.Open();
            
            return command.ExecuteNonQuery() > 0;
        }
    }
    
    // AccountID fetcher
    /// <summary>
    /// Fetches Account ID from database using supplied customer ID. Returns a String.
    ///  </summary>
    /// <param name="customerID">Must be supplied by frontend</param>
    /// <returns>A string with account ID.</returns>
    public string FetchAccountID(string customerID)
    {
        // supplied by frontend, will use the current customer ID in runtime:
        string cID = customerID;
        // local supply
        string fetchAccountID = "";
        
        using SqlConnection connection = new SqlConnection(_conn);
        {
            // selective query, will only get c_AccountID
            string query = "SELECT c_AccountID FROM Accounts WHERE c_CustomerID = @cID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@cID", cID);
            connection.Open();
            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                fetchAccountID = (string)reader["c_AccountID"];
            }
            connection.Close();
            
        }
        return fetchAccountID;
    }
    
    /// <summary>
    /// Fetches Account details from database using supplied customer ID. Returns a List.
    ///  </summary>
    /// <param name="customerID">Must be supplied by frontend</param>
    /// <returns>An Account List with all details.</returns>
    public List<Account> FetchAccountDetail(string customerID)
    {
        // supplied by frontend, will use the current customer ID in runtime:
        string cID = customerID;
        // local supply
        List<Account> account = new List<Account>();
        
        using SqlConnection connection = new SqlConnection(_conn);
        {
            // selective query, will only get account of corresponding c_AccountID
            string query = "SELECT * FROM Accounts WHERE c_CustomerID = @cID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@cID", cID);
            connection.Open();
            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                account.Add(new Account
                {
                    AccountID = (string)reader["c_AccountID"],
                    CustomerID = (string)reader["c_CustomerID"],
                    AccountType = (string)reader["v_AccountType"],
                    Balance = Convert.ToDecimal(reader["d_Balance"])
                });
            }
            connection.Close();
        }
        return account;
    }
    
    //TODO
    public bool TransactionManager(Account account, string mode)
    {
        using SqlConnection connection = new SqlConnection(_conn);
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
}