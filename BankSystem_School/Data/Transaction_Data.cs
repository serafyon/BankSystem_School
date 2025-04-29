using System.Configuration;
using BankSystem_School.Model;
using Microsoft.Data.SqlClient;

namespace BankSystem_School.Data;

public class Transaction_Data
{
    private string conn = ConfigurationManager.ConnectionStrings["C:\\BankSystem_School\\BankSystem_School\\Database\\DB_Bank.mdf"].ConnectionString;
    
    //transaction table accessor (read)
    public List<Transaction> GetTransactions()
    {
        List<Transaction> transactions = new List<Transaction>();

        using SqlConnection connection = new SqlConnection(conn);
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
                    TransactionID = (string)reader["c_TransactionID"],
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
        using SqlConnection connection = new SqlConnection(conn);
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
        using SqlConnection connection = new SqlConnection(conn);
        {
            string query =
                "update Transaction set dt_TransactionDate = @dt_TransactionDate, v_TransactionType = @v_TransactionType, d_AfterBalance = @d_AfterBalance, v_Amount = @v_Amount where c_AccountID = @c_AccountID";
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
        using SqlConnection connection = new SqlConnection(conn);
        {
            string query = "delete from Transactions where c_AccountID = @c_AccountID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@c_AccountID", transaction.AccountID);
            connection.Open();
            
            return command.ExecuteNonQuery() > 0;
        }
    }
}