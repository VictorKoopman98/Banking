using System;
namespace Banking.Models.Domain
{
    public class SavingsAccount : BankAccount
    {
        #region Fields
        protected const decimal _WithdrawCost = 0.25M;
        #endregion

        #region Properties
        public decimal InterestRate { get; }
        #endregion

        #region Constructors
        public SavingsAccount(string account, decimal interestRate) : base(account)
        {
            InterestRate = interestRate;
        }
        #endregion

        #region Methods
        public void AddInterest()
        {
            Deposit(Balance * InterestRate);
        }
        public override void Withdraw(decimal amount, string notes = null)
        {
            if (notes != null)
                base.Withdraw(amount, notes);
            else
                base.Withdraw(amount);
            base.Withdraw(_WithdrawCost);
        }
        #endregion
    }
}
