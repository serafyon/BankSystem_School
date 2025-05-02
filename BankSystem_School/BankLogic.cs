using System.Configuration;
using BankSystem_School.Data;
using BankSystem_School.Model;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;

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
    private long custId;
    private long accId;

    public string getCustId()
    {
        Console.WriteLine($"Getting Cust ID {custId.ToString()}");
        return this.custId.ToString();
    }

    public string getAccId()
    {
        return this.accId.ToString();
    }

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


    public bool ValidateSignIn(string email, string password)
    {
        using (SqlConnection con = new SqlConnection(conn))
        {
            string query = "select count(*) from Customers where v_Email = @Email and v_Password = @Password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            
            con.Open();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            if (count > 0)
            {
                string fetchquery = "select c_CustomerID from Customers where v_Email = @Email and v_Password = @Password";
                SqlCommand cmd1 = new SqlCommand(fetchquery, con);
                cmd1.Parameters.AddWithValue("@Email", email);
                cmd1.Parameters.AddWithValue("@Password", password);
                con.Open();
                SqlDataReader reader = cmd1.ExecuteReader(); 
                while (reader.Read())
                {
                    custId = Convert.ToInt64(reader["c_CustomerID"]);
                }
                con.Close();
                return true;
                
            }
            
        }

        return false;

    }

    public List<Account> GetAccounts(string custId)
    {
        Console.WriteLine(custId); // IT WASNT PICKING UP THE FUCKING CUSTOMER_ID
        List<Account> accounts = new List<Account>();

        using (SqlConnection con = new SqlConnection(conn))
        {
            string query = "select c_AccountID, v_AccountType, c_CustomerID, v_PIN from Accounts where c_CustomerID = @c_CustomerID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@c_CustomerID", custId);
            
            con.Open();
            
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                accounts.Add(new Account
                {
                    AccountID = reader["c_AccountID"].ToString(),
                    CustomerID = reader["c_CustomerID"].ToString(),
                    AccountType = reader["v_AccountType"].ToString(),
                    Balance = 0,
                    PIN = reader["v_PIN"].ToString()
                });
                Console.WriteLine($@"LOG: {reader["c_CustomerID"].ToString()}");
            }
            
        }
        Console.WriteLine(accounts.Count); // check list index #s
        if (accounts.Count > 0)
        {
            foreach (Account account in accounts)
            {
                Console.WriteLine($"Account ID: {account.AccountID} | Account Type: {account.AccountType}");
            }
            Console.WriteLine("Account List Found?");
            return accounts ?? new List<Account>();
        }

        return accounts ?? new List<Account>();
    }
     

    
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
                cmd.Parameters.AddWithValue("@id", 1);
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
                cmd.Parameters.AddWithValue("@id", 1);
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
                cmd.Parameters.AddWithValue("@id", 1);
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
    public bool BCreateCustomer(Customer customer, string fname, string email, string phone, string lname, string mname, string password)
    {
        //check first
        if (IsCustomerExist(customer.CustomerID))
        {
            // call popup id exists
            MessageBox.Show("Customer already exists.");
        }

        else if (IsEmailExist(customer.Email))
        {
            MessageBox.Show("Email already in use.");
        }

        else if (string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname) || string.IsNullOrEmpty(mname) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please fill all fields.");
        }

        else
        {
            //generates id mrrp meow meow mrrp
            custId = GenerateCustId();

            var newCustomer = new Customer
            {
                CustomerID = custId.ToString(),
                Name = fname,
                Email = email,
                Phone = phone,
                LName = lname,
                MName = mname,
                Password = password
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
                throw new Exception(ex.Message);
            }
        
        }

        return false;
    }
    
    //check customer, acc duplicate, and negative balance input
    public bool BCreateAccount(Account account, string acctype, string pin, string customerID)
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
        accId = GenerateAccId();

        var newAccount = new Account
        {
            AccountID = accId.ToString(),
            CustomerID = customerID,
            AccountType = acctype,
            Balance = 0,
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

    public bool UpdateBalance(string accId, decimal newBalance)
    {
        using (SqlConnection conn = new SqlConnection(this.conn))
        {
            string query = "UPDATE Accounts SET d_Balance = @newBalance WHERE c_AccountID = @accId";
            SqlCommand cmd = new SqlCommand(query, conn);
            
            cmd.Parameters.AddWithValue("@accId", accId);
            cmd.Parameters.AddWithValue("@newBalance", newBalance);
            
            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            
            return rowsAffected > 0;
        }
    }

    public bool MoneyWithdraw(Account account, string accountId, decimal amount, string purpose)
    {
        if (account.Balance >= amount)
        {
            decimal prevBalance = account.Balance;
            decimal newBalance = prevBalance - amount;
            
            bool withdrew = UpdateBalance(accountId, newBalance);

            Transaction t_withdraw = new Transaction
            {
                TransactionID = GenerateTransId().ToString(),
                AccountID = accountId,
                TransactionType = "Withdraw",
                Amount = amount,
                PreviousBalance = prevBalance,
                AfterBalance = newBalance,
                Purpose = purpose,
                TransactionDate = DateTime.Now
            };
            
            trdata.AddTransaction(t_withdraw);
            
            return withdrew;
        }
        else
        {
            MessageBox.Show("Insufficient balance!");
            return false;
        }
    }
    public bool MoneyDeposit(Account account, string accountId, decimal amount, string purpose)
    {
        decimal prevBalance = account.Balance;
        decimal newBalance = prevBalance + amount;
        
        bool deposited = UpdateBalance(accountId, newBalance);

        Transaction t_deposit = new Transaction
        {
            TransactionID = GenerateTransId().ToString(),
            AccountID = accountId,
            TransactionType = "Deposit",
            Amount = amount,
            PreviousBalance = prevBalance,
            AfterBalance = newBalance,
            Purpose = purpose,
            TransactionDate = DateTime.Now
        };
        
        
        trdata.AddTransaction(t_deposit);
        
        return deposited;
    }
}

