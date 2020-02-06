using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    /// <summary>
    /// This represents Bank account where you can withdraw or deposit money into the account
    /// </summary>
    class Account
    {
        #region Properties
        /// <summary>
        /// Unique Account Number
        /// </summary>
        public int AccountNumber { get; set; }
        /// <summary>
        /// Select an Account Type
        /// </summary>
        public string AccountType { get; set; }
        /// Personalized Account Name 
        public string AccountName { get; set; }
        /// <summary>
        /// Current Balance
        /// </summary>
        public decimal Balance { get; set; }
        /// <summary>
        /// Email Address
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Date Account was opened
        /// </summary>
        public DateTime CreatedDate { get; set; }
        #endregion
    }
}
