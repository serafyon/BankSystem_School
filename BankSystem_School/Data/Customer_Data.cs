using System.Configuration;
using BankSystem_School.Model;
using Microsoft.Data.SqlClient;

namespace BankSystem_School.Data;

public class Customer_Data
{
    // original: C:\BankSystem_School\BankSystem_School\Database\DB_Bank.mdf
    // F:\devset\juu\BankSystem_School\BankSystem_School\Database\DB_bank.mdf
    private string _conn = DatabaseConnector.ConnectorString;
    
    // customer table accessor (read)
    public List<Customer> GetCustomers()
    {
        List<Customer> customers = new List<Customer>();

        using (SqlConnection connection = new SqlConnection(_conn))
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
                    LName = (string)reader["LName"],
                    Name = (string)reader["v_Name"],
                    MName = (string)reader["MName"],
                    Email = (string)reader["v_Email"],
                    Phone = (string)reader["v_Phone"],
                    Password = (string)reader["v_Password"]
                });
            }
            connection.Close();
        }
        return customers;
    }
    
    // customer table mutator (create)
    public bool AddCustomer(Customer customer)
    {
        using (SqlConnection connection = new SqlConnection(_conn))
        {
            string query =
                "insert into Customers (c_CustomerID,v_LName, v_Name, v_MName, v_Email, v_Phone, v_Password) VALUES (@c_CustomerID, @v_LName, @v_Name, @v_MName, @v_Email, @v_Phone, @v_Password)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@c_CustomerID", customer.CustomerID);
            command.Parameters.AddWithValue("@v_LName", customer.LName);
            command.Parameters.AddWithValue("@v_Name", customer.Name);
            command.Parameters.AddWithValue("@v_MName", customer.MName);
            command.Parameters.AddWithValue("@v_Email", customer.Email);
            command.Parameters.AddWithValue("@v_Phone", customer.Phone);
            command.Parameters.AddWithValue("@v_Password", customer.Password);
            connection.Open();
            
            

            
            
            return command.ExecuteNonQuery() > 0;
            
        }
    }
    
    // customer table mutator (update)
    public bool UpdateCustomer(Customer customer)
    {
        using (SqlConnection connection = new SqlConnection(_conn))
        {
            string query =
                "update Customers set v_Name = @name, v_Email = @email, v_Phone = @phone, v_Password = @password where c_CustomerID = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", customer.CustomerID);
            command.Parameters.AddWithValue("@lname", customer.LName);
            command.Parameters.AddWithValue("@name", customer.Name);
            command.Parameters.AddWithValue("@mname", customer.MName);
            command.Parameters.AddWithValue("@email", customer.Email);
            command.Parameters.AddWithValue("@phone", customer.Phone);
            command.Parameters.AddWithValue("@password", customer.Password);
            connection.Open();
            
            return command.ExecuteNonQuery() > 0;
        }
    }
    
    // customer table mutator (delete)
    public bool DeleteCustomer(string customerID)
    {
        using (SqlConnection connection = new SqlConnection(_conn))
        {
            string query =
                "delete from Customers where c_CustomerID = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", customerID);
            connection.Open();
            
            return command.ExecuteNonQuery() > 0;
        }
    }
    
    // delete all (don't unless necessary)
    public bool DeleteAllCustomers(Customer customer)
    {
        using (SqlConnection connection = new SqlConnection(_conn))
        {
            string query =
                "delete * from Customers";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            
            return command.ExecuteNonQuery() > 0;
        }
    }
    
    //Verification/Authenticator; returns an Enum to be used anywhere.
    /// <summary>
    /// Calls Customer_Data to fetch things to a List Authenticator and returns it as a list. Very modifiable at Customer_Data.cs.
    /// Full mode has CustomerID, Name, LName, MName, Email, Password.
    /// Pass mode only returns the list with CustomerID, Email and Password.
    /// </summary>
    /// <param name="customerID">Required to be passed by frontend. Should be a STRING.</param>
    /// <param name="password">Required to be passed by frontend. Should be a STRING.</param>
    /// <param name="mode">Only accepts between "full" and "pass". Full = Everything, Pass = Only Email, password and Customer ID.</param>
    /// <returns>authenticateData</returns>
    public List<Authenticator> GetAuth(string customerID, string password, string mode)
    {
        List<Authenticator> authenticateData = new List<Authenticator>();
        // check Authenticator.cs
        using (SqlConnection connection = new SqlConnection(_conn))
        {
            switch (mode)
            {
                case "full":
                    // query, gets only ID, password and email from supplied id
                    string query =
                        "SELECT * FROM Customers WHERE c_CustomerID = @id AND v_Password = @password";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", customerID);
                    command.Parameters.AddWithValue("@password", password);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        authenticateData.Add(new Authenticator()
                        {
                            CustomerID = (string)reader["c_CustomerID"],
                            Name = (string)reader["v_Name"],
                            LName = (string)reader["v_LName"],
                            MName = (string)reader["v_LName"],
                            Email = (string)reader["v_Email"],
                            // Phone = (string)reader["v_Phone"],
                            Password = (string)reader["v_Password"],
                            PIN = (string)reader["v_PIN"]
                        });
                    }
                    connection.Close();
                    break;
                case "pass":
                    // query, gets only ID, password and email from supplied id
                    string query2 =
                        "SELECT c_CustomerID, v_Password, v_Email FROM Customers WHERE c_CustomerID = @id AND v_Password = @password";
                    SqlCommand command2 = new SqlCommand(query2, connection);
                    command2.Parameters.AddWithValue("@id", customerID);
                    command2.Parameters.AddWithValue("@password", password);
                    connection.Open();

                    SqlDataReader reader2 = command2.ExecuteReader();
                    while (reader2.Read())
                    {
                        authenticateData.Add(new Authenticator()
                        {
                            CustomerID = (string)reader2["c_CustomerID"],
                            Email = (string)reader2["v_Email"],
                            // Phone = (string)reader["v_Phone"],
                            Password = (string)reader2["v_Password"],
                            PIN = (string)reader2["v_PIN"],
                        });
                    }
                    connection.Close();
                    break;
            }
        }
        return authenticateData;
    }
    /// <summary>
    /// Calls upon the information of the customer provided it gets the customer ID. Returns a list.
    /// Data:   CustomerID, LName, Name, MName, Email, Phone, Password, PIN
    /// </summary>
    /// <param name="customerID">Should be fetched from backend.</param>
    /// <returns>A list containing everything from the usual fetch, but depends on the ID.</returns>
    public List<Customer> GetCustomerInfo(string customerID)
    {
        List<Customer> customers = new List<Customer>();
        using (SqlConnection connection = new SqlConnection(_conn))
        {
            string query = "SELECT * FROM Customers WHERE c_CustomerID = @customerID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerID", customerID);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                customers.Add(new Customer
                {
                    CustomerID = (string)reader["c_CustomerID"],
                    LName = (string)reader["v_LName"],
                    Name = (string)reader["v_Name"],
                    MName = (string)reader["v_MName"],
                    Email = (string)reader["v_Email"],
                    Phone = (string)reader["v_Phone"],
                    Password = (string)reader["v_Password"]
                });
            }
            connection.Close();
        }
        return customers;
    }
    
        /// <summary>
    /// Calls upon the information of the customer provided it gets the customer ID and modifies the database
    /// Data required: Customer ID, Email, Phone, Password
    /// </summary>
    /// <param name="customerID">Should be fetched from frontend.</param>
    /// <param name="newcustomerData">Should be fetched from frontend. Need to require everything</param>
    /// <returns>A list containing everything from the usual fetch, but depends on the ID.</returns>
    public bool SetCustomerInfo(string customerID, Customer newcustomerData)
    {
        List<Customer> customers = new List<Customer>();
        using (SqlConnection connection = new SqlConnection(_conn))
        {
            // SqlCommand command = new SqlCommand(query, connection);
            // command.Parameters.AddWithValue("@id", customer.CustomerID);
            // command.Parameters.AddWithValue("@lname", customer.LName);
            // command.Parameters.AddWithValue("@name", customer.Name);
            // command.Parameters.AddWithValue("@mname", customer.MName);
            // command.Parameters.AddWithValue("@email", customer.Email);
            // command.Parameters.AddWithValue("@phone", customer.Phone);
            // command.Parameters.AddWithValue("@password", customer.Password);
            // connection.Open();
            //
            // return command.ExecuteNonQuery() > 0;
            // "update Customers set v_Name = @name, v_Email = @email, v_Phone = @phone, v_Password = @password where c_CustomerID = @id"
            string query = "UPDATE Customers SET v_Email = @v_Email, v_Phone = @v_Phone, v_Password = @v_Password WHERE c_CustomerID = @customerID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerID", customerID);
            command.Parameters.AddWithValue("@v_Email", newcustomerData.Email);
            command.Parameters.AddWithValue("@v_Phone", newcustomerData.Phone);
            command.Parameters.AddWithValue("@v_Password", newcustomerData.Password);
            connection.Open();
            return command.ExecuteNonQuery() > 0;
        }
    }

}

