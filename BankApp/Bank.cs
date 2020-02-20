using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BankApp
{
    static class Bank
    {
        private static List<Account> accounts = new List<Account>();
        //Camel casing e.g. lastAccountNumber for private is recommended
        /// <summary>
        /// Creates an account in the bank
        /// </summary>
        /// <param name="accountName">Name of your account</param>
        /// <param name="emailAddress">Email ID associated with the account</param>
        /// <param name="accountType">Type of Account</param>
        /// <param name="initialDeposit">Initial deposit</param>
        /// <returns>Newly created account</returns>
        public static Account CreateAccount(string accountName,
            string emailAddress,
            TypeofAccounts accountType =TypeofAccounts.Checking,
            decimal initialDeposit=0)
        {
            //Object initialization
            var account = new Account
            {
                AccountName = accountName,
                EmailAddress = emailAddress,
                AccountType = accountType
            };
            if (initialDeposit > 0)
            {
                account.Deposit(initialDeposit);
            }
            accounts.Add(account);
            return account;
        }

        public static void Deposit(int accountNumber, decimal amount) 
        {
            accounts.Where(a => a.AccountNumber = = accountNumber);
        }
    }
}
