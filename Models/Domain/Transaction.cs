using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models.Domain
{
    public class Transaction
    {
        #region Properties
        public decimal Amount { get; }
        public DateTime DateOfTrans { get; }
        public TransactionType TransactionType { get; }
        public string Notes { get; }
        #endregion

        #region Constructors
        public Transaction(decimal amount, TransactionType transactionType)
        {
            Amount = amount;
            TransactionType = transactionType;
            DateOfTrans = DateTime.Now;
        }
        public Transaction(decimal amount, TransactionType transactionType, string notes) : this(amount, transactionType)
        {
            Notes = notes;
        }
        #endregion

        #region Methods
        public bool IsDeposit { get { return TransactionType == TransactionType.Deposit; } }
        public bool IsWithdraw { get { return TransactionType == TransactionType.Withdraw; } }
        #endregion
    }
}
