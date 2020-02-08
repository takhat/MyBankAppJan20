using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace BankApp
{
    /// <summary>
    /// This represents Bank account where you can withdraw or deposit money into the account
    /// </summary>
    enum TypeofAccounts
    {  
        Checking,
        Savings,
        CD,
        Loan
    }
    class Account
    {
        private static int lastAccountNumber = 0; 
        #region Properties
        /// <summary>
        /// Unique Account Number
        /// </summary>
        public int AccountNumber { get; private set; }
        /// <summary>
        /// Select an Account Type
        /// </summary>
        public TypeofAccounts AccountType { get; set; }
        /// Personalized Account Name 
        public string AccountName { get; set; }
        /// <summary>
        /// Current Balance
        /// </summary>
        public decimal Balance { get; private set; }
        /// <summary>
        /// Email Address
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Date Account was opened
        /// </summary>
        public DateTime CreatedDate { get; set; }
        #endregion
        #region Constructor
        public Account()
        { 
            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.UtcNow;
        }
        #endregion
        #region Methods
        /// <summary>
        /// Deposit money into the account
        /// </summary>
        /// <param name="amount">Amount to deposit</param>
        public void Deposit(decimal amount) 
        {
            Balance += amount;
        }
        public decimal Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }
        #endregion
    }
}

