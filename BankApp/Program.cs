using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new Account();
            myAccount.Deposit(1000);
            Console.WriteLine($"AN: {myAccount.AccountNumber}, Balance: {myAccount.Balance}, CD: {myAccount.CreatedDate}");
        }
    }
}
