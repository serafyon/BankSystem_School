using System.Configuration;
using BankSystem_School.Data;
using BankSystem_School.Model;
using Microsoft.Data.SqlClient;

namespace BankSystem_School;

public class BankLogic
{
    Customer_Data cdata = new Customer_Data();
    Account_Data acdata = new Account_Data();
    Transaction_Data trdata = new Transaction_Data();
    
    private string conn = ConfigurationManager
        .ConnectionStrings[@"C:\BankSystem_School\BankSystem_School\Database\DB_Bank.mdf"].ConnectionString;

    //init data layer var
    private Customer_Data _customerData = new Customer_Data();
    private Account_Data _accountData = new Account_Data();
    private Transaction_Data _transactionData = new Transaction_Data();

    /*TODO:
     * Generate Transaction ID
     * Generate Customer ID
     * Generate Account ID
     * CreateCustomer /
     * UpdateCustomer /
     * CreateAccount /
     * Deposit /
     * Withdraw
     * GetAccountBalance
     * GetTransactionHistory
     */

    
    //********************FETCH LOGIN DATA************************
    
    public string GetCustomerID()
    {
        //TODO: fetch ID from login session
        return "nothing yet";
    }
    
    public string GetAccID(string customerID) //attach parameter from forms login page WHEN I MAKE IT OK JESUS CHRIST
    //customerID received from matching the login credentials to an existing customerID foreign key (from accounts)
    //
    {
        string query = "select a.c_AccountID, a.d_Balance, a.c_CustomerID " +
                       "from Accounts a " +
                       "where a.c_CustomerID = @customerID"; // does this even work?? what was i trying to achieve??

        using (SqlConnection con = new SqlConnection(conn))
        {
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@customerID", customerID);
            
            con.Open();
            
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                var account = new Account
                {
                    AccountID = reader["c_AccountID"].ToString(),
                    CustomerID = reader["c_CustomerID"].ToString(),
                    AccountType = null,
                    Balance = (decimal)reader["d_Balance"],
                    PIN = reader["d_PIN"].ToString(),
                };
                return account.AccountID;
                //this returns the account id for now
            }
            else
            {
                throw new Exception("Account not found");
            }
        }
    }
    
    
    //***********************ID GENERATION************************
    //fetches last trans id and generates a new unique one
    public long GenerateTransId()
    {
        long lastId;

        string query = "select bi_LastID from TransactionID_Tracker where i_ID = 1";

        using (SqlConnection conn = new SqlConnection(this.conn))
        {
            conn.Open();

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                lastId = (long)cmd.ExecuteScalar(); //fetch
            }
        }
        
        long newId = lastId + 1;
        
        string updateQuery = "update TransactionID_Tracker set bi_LastID = @newId where i_ID = @id";

        using (SqlConnection conn = new SqlConnection(this.conn))
        {
            conn.Open();

            using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
            {  
                cmd.Parameters.AddWithValue("@newId", newId);
                cmd.ExecuteNonQuery();
            }
        }
        
        return newId;
    }

    public long GenerateCustId()
    {
        long lastId;
        
        string query = "select bi_LastID from CustomerID_Tracker where i_ID = 1";

        using (SqlConnection conn = new SqlConnection(this.conn))
        {
            conn.Open();

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                lastId = (long)cmd.ExecuteScalar(); //fetch
            }
        }
        long newId = lastId + 1;
        
        string updateQuery = "update CustomerID_Tracker set bi_LastID = @newId where i_ID = @id";

        using (SqlConnection conn = new SqlConnection(this.conn))
        {
            conn.Open();

            using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
            {
                cmd.Parameters.AddWithValue("@newId", newId);
                cmd.ExecuteNonQuery();
            }
        }
        return newId;
    }

    public long GenerateAccId()
    {
        long lastId;
        
        string query = "select bi_LastID from AccountID_Tracker where i_ID = 1";

        using (SqlConnection conn = new SqlConnection(this.conn))
        {  
            conn.Open();

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                lastId = (long)cmd.ExecuteScalar(); // fetch
            }
        }
        long newId = lastId + 1;
        
        string updateQuery = "update AccountID_Tracker set bi_LastID = @newId where i_ID = @id";

        using (SqlConnection conn = new SqlConnection(this.conn))
        {
            conn.Open();

            using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
            {
                cmd.Parameters.AddWithValue("@newId", newId);
                cmd.ExecuteNonQuery();
            }
        }
        return newId;
    }
    
    //***********************ID GENERATION************************
    
    //***********************ID CHECKING**************************
    //checks if customer has existing id
    public bool IsCustomerExist(string cId)
    {
        using (SqlConnection conn = new SqlConnection(this.conn))
        {
            conn.Open();
            string query =
                "select count(*) from Customers where c_CustomerID = @customerId ";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@customerId", cId);

                int count = (int)cmd.ExecuteScalar();

                //1 exists, 0 does not exist
                return count > 0;
            }
        }

    }

    //checks if email already in use
    public bool IsEmailExist(string email)
    {
        using (SqlConnection conn = new SqlConnection(this.conn))
        {
            conn.Open();
            string query =
                "select count(*) from Customers where v_Email = @email";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@email", email);

                int count = (int)cmd.ExecuteScalar();

                //1 exists, 0 does not exist
                return count > 0;
            }
        }

    }

    public bool IsAccountExist(string accountNumber)
    {
        using (SqlConnection conn = new SqlConnection(this.conn))
        {
            conn.Open();
            string query =
                "select count(*) from Accounts where c_AccountID = @accountNumber";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@accountNumber", accountNumber);
                
                int count = (int)cmd.ExecuteScalar();
                
                //same
                return count > 0;
            }
        }
    }
    
    //***********************ID CHECKING**************************

    //***********************CREATION*****************************
    
    //check customer and email 
    public bool BCreateCustomer(Customer customer, string name, string email, string phone)
    {
        //check first
        if (IsCustomerExist(customer.CustomerID))
        {
            // call popup id exists
            throw new Exception("Customer already exists");
        }

        if (IsEmailExist(customer.Email))
        {
            throw new Exception("Email already in use");
        }

        if (string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("All fields are required");
        }
        
        //generates id mrrp meow meow mrrp
        long custId = GenerateCustId();

        var newCustomer = new Customer
        {
            CustomerID = custId.ToString(),
            Name = name,
            Email = email,
            Phone = phone,
            LName = null,
            MName = null,
            Password = null
        };

        //call now :333
        try
        {
            bool isAdded = cdata.AddCustomer(newCustomer);

            if (isAdded)
            {
                return true;
            }
            else
            {
                throw new Exception("Failed to add");
            }

        }
        catch (Exception ex)
        {
            throw new Exception("Something fucked up and idk what it is :3333");
        }
        
    }
    
    //check customer, acc duplicate, and negative balance input
    public bool BCreateAccount(Account account, string acctype, decimal balance, string password, string pin)
    {
        //checks
        if (!IsCustomerExist(account.CustomerID))
        {
            throw new Exception("Failed to create account. Customer does not exist");
        }

        if (IsAccountExist(account.AccountID))
        {
            throw new Exception("Account already exists");
        }

        if (account.Balance < 0)
        {
            throw new Exception("Cannot have negative balance.");
        }
        
        //generates id
        long accId = GenerateAccId();

        var newAccount = new Account
        {
            AccountID = accId.ToString(),
            CustomerID = null, //needs to refer to current login ID
            AccountType = acctype,
            Balance = balance,
            PIN = pin
        };
        
        // calls
        try
        {
            bool isAdded = acdata.AddAccount(newAccount);

            if (isAdded)
            {
                return true;
            }
            else
            {
                throw new Exception("Failed to add");
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Failed to create account");
        }
        

    }

    
    //***********************CREATION*****************************

    //check customer
    public bool BUpdateCustomer(Customer customer)
    {
        if (!IsCustomerExist(customer.CustomerID))
        {
            throw new Exception("Customer does not exist");
        }

        return cdata.UpdateCustomer(customer);
    }
    // not finished lolll
    


    public bool MoneyDeposit(Account account, string accountId, decimal amount, string purpose, string transtype)
    {
        var acc = IsAccountExist(accountId);
        if (acc == null)
        {
            throw new Exception("Account does not exist");
        }
        long transId = GenerateTransId();
        decimal afterBalance = account.Balance + amount;

        var trans = new Transaction
        {
            TransactionID = transId.ToString(),
            AccountID = GetAccID(GetCustomerID()), //fetch current account
            TransactionType = transtype,
            Amount = amount,
            PreviousBalance = 0, //fetch previous account's balance (checkBalance)
            AfterBalance = afterBalance,
            Purpose = purpose,
            TransactionDate = DateTime.Now
        };

        try
        {
            bool isAdded = trdata.AddTransaction(trans);

            if (isAdded)
            {
                return true;
            }
            else
            {
                throw new Exception("Failed to add");
            }
        }
        catch (Exception ex)
        {
            throw new Exception("Failed to add");
        }
    }
}