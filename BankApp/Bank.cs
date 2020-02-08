using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    static class Bank
    {
        //Camel casing e.g. lastAccountNumber for private is recommended
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accountName">Name of the account</param>
        /// <param name="emailAddress">Email ID associated with the account</param>
        /// <param name="accountType">Type of Account</param>
        /// <param name="initialDeposit">Initial deposit</param>
        /// <returns>Creates a new account in the bank</returns>
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
            return account;
        }


    }
}
