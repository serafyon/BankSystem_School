using BankSystem_School.Data;
using BankSystem_School.Model;

namespace BankSystem_School;

static class Program
{
    static void TestCustomer(string cid, string name, string email, string phone, string password)
    {
        Customer_Data data = new Customer_Data();

        Customer c = new Customer
        {
            CustomerID = cid,
            Name = name,
            Email = email,
            Phone = phone,
            Password = password,
        };

        if (data.AddCustomer(c))
        {
            Console.WriteLine("Customer created :DDDDDDDD");
        }
        else
        {
            Console.WriteLine("your code fucking sucks stop using tab");
        }
        
        // read
        var customers = data.GetCustomers();
        foreach (var customer in customers)
        {
            Console.WriteLine($"{customer.CustomerID}, {customer.Name}, {customer.Email}, {customer.Phone}");
        }
        
        /*
         * Console.WriteLine("Deleting the fucking things");
        data.DeleteAllCustomers(c);
         */

        Console.Read();
    }


    static void TestAccount()
    {
        Account_Data data = new Account_Data();

        Account a = new Account
        {
            AccountID = "1000000000",
            CustomerID = "10000", //don't forget to attach customer to account
            AccountType = "Savings",
            Balance = (decimal)130224.50
        };

        if (data.AddAccount(a))
        {
            Console.WriteLine("Account added :33333");
        }
        else
        {
            Console.WriteLine("Fuck your code bro");
        }
        
        //read
        var accounts = data.GetAccounts();
        foreach (var acc in accounts)
        {
            Console.WriteLine($"{acc.CustomerID}, {acc.AccountID}, {acc.Balance}");
        }

        Console.Read();
    }

    static void TestTransaction()
    {
        Transaction_Data data = new Transaction_Data();

        Transaction t = new Transaction
        {
            TransactionID = "1000000000",
            AccountID = "1000000000",
            TransactionType = "Withdrawal",
            Amount = (decimal)130224.50,
            PreviousBalance = (decimal)130224.50,
            AfterBalance = (decimal)0,
            Purpose = "Im rich bitch",
            TransactionDate = DateTime.Now
        };

        if (data.AddTransaction(t))
        {
            Console.WriteLine("Transaction created :DDDDDDDD");
        }
        else
        {
            Console.WriteLine("Your code bro");
        }
        
        //read
        var transactions = data.GetTransactions();
        foreach (var trans in transactions)
        {
            Console.WriteLine($"{trans.TransactionID}, {trans.AccountID}, {trans.TransactionType}, {trans.Amount}");
        }
        
        Console.Read();
    }
    
    static void Main()
    {
        
        //Three Data Access tests complete
        //TODO: Make Business Layer for Deposit and Withdrawal
        /*TODO:
         * Create Account
         * Remove Customer
         * Deposit
         * Withdrawal
         * View Acc Balance
         * View Transaction History
         *
         * Actual functions for:
         * CRUD customers & accounts
         * 
         */

    }
}