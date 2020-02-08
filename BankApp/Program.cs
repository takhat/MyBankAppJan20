using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = Bank.CreateAccount("My Savings", 
                "test@test.com", 
                accountType: TypeofAccounts.Savings, 
                100);
            Console.WriteLine($"AN: {myAccount.AccountNumber}, Balance: {myAccount.Balance}, CD: {myAccount.CreatedDate}, Email ID: {myAccount.EmailAddress}");

            
        }
    }
}
