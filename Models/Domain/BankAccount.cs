using System;
namespace Banking.Models.Domain
{
    public class BankAccount
    {
        #region Fields
        private string _accountNumber;
        private decimal _balance;
        #endregion

        #region Properties
        public decimal Balance { get; private set; }
        public string AccountNumber { get; }
        #endregion

        #region Constructors
        public BankAccount(string account)
        {
            AccountNumber = account;
            Balance = Decimal.Zero;
        }
        #endregion

        #region Methods
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        #endregion
    }
}
