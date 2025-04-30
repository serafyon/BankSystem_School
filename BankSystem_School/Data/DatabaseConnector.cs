using System.Configuration;

namespace BankSystem_School.Data;

public class DatabaseConnector
{
    // original: C:\BankSystem_School\BankSystem_School\Database\DB_Bank.mdf
    // F:\devset\juu\BankSystem_School\BankSystem_School\Database\DB_bank.mdf
    public static string ConnectorString { get; } = ConfigurationManager
        .ConnectionStrings[@"F:\devset\juu\BankSystem_School\BankSystem_School\Database\DB_Bank.mdf"].ConnectionString;
}