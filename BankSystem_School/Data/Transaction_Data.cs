using System.Configuration;
using BankSystem_School.Model;
using Microsoft.Data.SqlClient;

namespace BankSystem_School.Data;

public class Transaction_Data
{
    private string _conn = DatabaseConnector.ConnectorString;
    
    //transaction table accessor (read)
    public List<Transaction> GetTransactions()
    {
        List<Transaction> transactions = new List<Transaction>();

        using SqlConnection connection = new SqlConnection(_conn);
        {
            string query = "select * from Transactions";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                transactions.Add(new Transaction
                {
                    AccountID = (string)reader["c_AccountID"],
                    // TransactionID = (string)reader["c_TransactionID"],
                    TransactionDate = (DateTime)reader["dt_TransactionDate"],
                    TransactionType = (string)reader["v_TransactionType"],
                    AfterBalance = (decimal)reader["d_AfterBalance"],
                    Amount = (decimal)reader["d_Amount"],
                    PreviousBalance = (decimal)reader["d_PreviousBalance"],
                    Purpose = (string)reader["v_Purpose"],
                    

                });
            }
            connection.Close();
        }
        
        return transactions;
    }
    
    // transaction table mutator (create)
    public bool AddTransaction(Transaction transaction)
    {
        using SqlConnection connection = new SqlConnection(_conn);
        {
            string query = "insert into Transactions (c_AccountID, c_TransactionID, dt_TransactionDate, v_TransactionType, d_AfterBalance, d_Amount, d_PreviousBalance, v_Purpose) values (@c_AccountID, @c_TransactionID, @dt_TransactionDate, @v_TransactionType, @d_AfterBalance, @d_Amount, @d_PreviousBalance, @v_Purpose)";
            SqlCommand command = new SqlCommand(query, connection);
            
            // TODO: Fetch c_AccountID from current login session
            
            command.Parameters.AddWithValue("@c_AccountID", transaction.AccountID);
            command.Parameters.AddWithValue("@c_TransactionID", transaction.TransactionID);
            command.Parameters.AddWithValue("@dt_TransactionDate", transaction.TransactionDate);
            command.Parameters.AddWithValue("@v_TransactionType", transaction.TransactionType);
            command.Parameters.AddWithValue("@d_AfterBalance", transaction.AfterBalance);
            command.Parameters.AddWithValue("@d_Amount", transaction.Amount);
            command.Parameters.AddWithValue("@v_Purpose", transaction.Purpose);
            command.Parameters.AddWithValue("@d_PreviousBalance", transaction.PreviousBalance);
            connection.Open();
            
            return command.ExecuteNonQuery() > 0;
        }
    }
    
    // transaction table mutator (update)
    public bool UpdateTransaction(Transaction transaction)
    {
        using SqlConnection connection = new SqlConnection(_conn);
        {
            string query =
                "update Transactions set dt_TransactionDate = @dt_TransactionDate, v_TransactionType = @v_TransactionType, d_AfterBalance = @d_AfterBalance, d_Amount = @d_Amount where c_AccountID = @c_AccountID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@dt_TransactionDate", transaction.TransactionDate);
            command.Parameters.AddWithValue("@v_TransactionType", transaction.TransactionType);
            command.Parameters.AddWithValue("@d_AfterBalance", transaction.AfterBalance);
            command.Parameters.AddWithValue("@d_Amount", transaction.Amount);
            command.Parameters.AddWithValue("@d_Purpose", transaction.Purpose);
            connection.Open();
            
            return command.ExecuteNonQuery() > 0;
        }
    }
    
    // transaction table mutator (delete)
    public bool DeleteTransaction(Transaction transaction)
    {
        using SqlConnection connection = new SqlConnection(_conn);
        {
            string query = "delete from Transactions where c_AccountID = @c_AccountID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@c_AccountID", transaction.AccountID);
            connection.Open();
            
            return command.ExecuteNonQuery() > 0;
        }
    }

    //TODO: Transaction ID deleter. Just copy above but use conditional of only using the transaction id. Check FetchAccountID and other sources.
    
    //
    
    // Transaction logger -> same as account_data being brainfucky. if you can compactify it: sure!
    // check Account_Data.cs line 171 for more. -Sok
    public bool TransactionLogger(Transaction transaction, Account account, string mode)
    {
        if (!Account_Data.FetchAccountID(account.CustomerID).Equals(account.CustomerID))
        {
            Console.WriteLine(account.CustomerID + " is not the same as "+ Account_Data.FetchAccountID(account.CustomerID));
            Console.WriteLine("Terminating Transaction Logger!");
            return false;
        }
        
        using SqlConnection connection = new SqlConnection(_conn);
        {
            string query = "insert into Transactions (c_AccountID, dt_TransactionDate, v_TransactionType, d_AfterBalance, d_Amount, d_PreviousBalance, v_Purpose) values (@c_AccountID, @dt_TransactionDate, @v_TransactionType, @d_AfterBalance, @d_Amount, @d_PreviousBalance, @v_Purpose)";
            SqlCommand command = new SqlCommand(query, connection);
            
            // Fetch c_AccountID from current login session = DONE
            // TODO: NEED TO MAKE TRANSACTION ID AUTO-INCREMENT IN DATABASE!!!
            
            command.Parameters.AddWithValue("@c_AccountID", transaction.AccountID);
            // command.Parameters.AddWithValue("@c_TransactionID", transaction.TransactionID);
            command.Parameters.AddWithValue("@dt_TransactionDate", transaction.TransactionDate);
            command.Parameters.AddWithValue("@v_TransactionType", transaction.TransactionType);
            command.Parameters.AddWithValue("@d_AfterBalance", transaction.AfterBalance);
            command.Parameters.AddWithValue("@d_Amount", transaction.Amount);
            command.Parameters.AddWithValue("@v_Purpose", transaction.Purpose);
            command.Parameters.AddWithValue("@d_PreviousBalance", transaction.PreviousBalance);
            connection.Open();
            
            return command.ExecuteNonQuery() > 0;
        }
    }
}