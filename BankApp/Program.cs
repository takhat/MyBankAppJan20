using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("Welcome to my Bank!");
            while(true)
            { 
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Create an account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. View all accounts");
            Console.WriteLine("5. View all transactions");

            Console.Write("Select an option: ");
            var option = Console.ReadLine();
            switch(option)
            {
                case "0":
                    Console.WriteLine("Thank you for visiting the bank!");
                    return;
                case "1":
                    Console.Write("Account name: ");
                    var accountName = Console.ReadLine();

                    Console.Write("Email address: ");
                    var emailAddress = Console.ReadLine();

                    Console.WriteLine("Select an account type: ");

                    var accountTypes = Enum.GetNames(typeof(TypeofAccounts));
                    for (var i = 0; i < accountTypes.Length; i++)
                    {
                        Console.WriteLine($"{i}.{accountTypes[i]}");
                    }
                    //var accountType = (TypeofAccounts)Enum.Parse(typeof(TypeofAccounts), Console.ReadLine());
                    var accountType = Enum.Parse<TypeofAccounts>(Console.ReadLine());

                    Console.Write("Amount to deposit: ");
                    var amount = Convert.ToDecimal(Console.ReadLine());

                    var account = Bank.CreateAccount(accountName, emailAddress, accountType, amount);

                    Console.WriteLine($"AN: {account.AccountNumber}," +
                        $"AName: {account.AccountName}," +
                        $"Bal: {account.Balance:C}," +
                        $"CD: {account.CreatedDate}," +
                        $"EA: {account.EmailAddress}," +
                        $"AT: {account.AccountType}");
                    break;
                case "2":
                case "3":
                case "4":
                default:
                    Console.WriteLine("Invalid option! Try again!");
                    break;
            }
            }
        }
    }
}
