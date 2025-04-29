using System.Configuration;
using BankSystem_School.Model;
using Microsoft.Data.SqlClient;

namespace BankSystem_School.Data;

public class Customer_Data
{
    private string conn = ConfigurationManager.ConnectionStrings[@"C:\BankSystem_School\BankSystem_School\Database\DB_Bank.mdf"].ConnectionString;
    
    // customer table accessor (read)
    public List<Customer> GetCustomers()
    {
        List<Customer> customers = new List<Customer>();

        using (SqlConnection connection = new SqlConnection(conn))
        {
            
            string query = "SELECT * FROM Customers";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                customers.Add(new Customer
                {
                    CustomerID = (string)reader["c_CustomerID"],
                    Name = (string)reader["v_Name"],
                    Email = (string)reader["v_Email"],
                    Phone = (string)reader["v_Phone"],
                    Password = (string)reader["v_Password"],
                });
            }
            connection.Close();
        }
        return customers;
    }
    
    // customer table mutator (create)
    public bool AddCustomer(Customer customer)
    {
        using (SqlConnection connection = new SqlConnection(conn))
        {

            string query =
                "insert into Customers (c_CustomerID, v_Name, v_Email, v_Phone, v_Password) VALUES (@c_CustomerID, @v_Name, @v_Email, @v_Phone, @v_Password)";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            
            command.Parameters.AddWithValue("@c_CustomerID", customer.CustomerID);
            command.Parameters.AddWithValue("@v_Name", customer.Name);
            command.Parameters.AddWithValue("@v_Email", customer.Email);
            command.Parameters.AddWithValue("@v_Phone", customer.Phone);
            command.Parameters.AddWithValue("@v_Password", customer.Password);

            
            
            return command.ExecuteNonQuery() > 0;
            
        }
    }
    
    // customer table mutator (update)
    public bool UpdateCustomer(Customer customer)
    {
        using (SqlConnection connection = new SqlConnection(conn))
        {
            string query =
                "update Customers set v_Name = @name, v_Email = @email, v_Phone = @phone, v_Password = @password where c_CustomerID = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", customer.CustomerID);
            command.Parameters.AddWithValue("@name", customer.Name);
            command.Parameters.AddWithValue("@email", customer.Email);
            command.Parameters.AddWithValue("@phone", customer.Phone);
            command.Parameters.AddWithValue("@password", customer.Password);
            connection.Open();
            
            return command.ExecuteNonQuery() > 0;
        }
    }
    
    // customer table mutator (delete)
    public bool DeleteCustomer(Customer customer)
    {
        using (SqlConnection connection = new SqlConnection(conn))
        {
            string query =
                "delete from Customers where c_CustomerID = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", customer.CustomerID);
            connection.Open();
            
            return command.ExecuteNonQuery() > 0;
        }
    }
    
    // delete all (don't unless necessary)
    public bool DeleteAllCustomers(Customer customer)
    {
        using (SqlConnection connection = new SqlConnection(conn))
        {
            string query =
                "delete from Customers";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            
            return command.ExecuteNonQuery() > 0;
        }
    }
    
}