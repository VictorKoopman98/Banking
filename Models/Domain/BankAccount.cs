﻿using System;
using System.Collections.Generic;

namespace Banking.Models.Domain
{
    public class BankAccount : IBankAccount
    {
        #region Fields
        private string _accountNumber;
        private decimal _balance;
        private readonly IList<Transaction> _transactions = new List<Transaction>();
        #endregion

        #region Properties
        public decimal Balance { get; private set; }
        public string AccountNumber { get; }
        public int NumberOfTransactions { get { return _transactions.Count; } }
        #endregion

        #region Constructors
        public BankAccount(string account)
        {
            AccountNumber = account;
            Balance = Decimal.Zero;
        }
        #endregion

        #region Methods
        public virtual void Withdraw(decimal amount, string notes = null)
        {
            if (notes == null)
                _transactions.Add(new Transaction(amount, TransactionType.Withdraw));
            else
                _transactions.Add(new Transaction(amount, TransactionType.Withdraw, notes));
            Balance -= amount;
        }
        public void Deposit(decimal amount, string notes = null)
        {
            if (notes == null)
                _transactions.Add(new Transaction(amount, TransactionType.Deposit));
            else
                _transactions.Add(new Transaction(amount, TransactionType.Deposit, notes));
            Balance += amount;
        }
        public IEnumerable<Transaction> GetTransactions(DateTime? from, DateTime? till)
        {
            if (from == null && till == null) return _transactions;
            if (from is null) from = DateTime.MinValue;
            if (!till.HasValue) till = DateTime.MaxValue;

            IList<Transaction> transList = new List<Transaction>();
            foreach (Transaction transaction in _transactions)
            {
                if (transaction.DateOfTrans >= from && transaction.DateOfTrans <= till)
                    transList.Add(transaction);
            }
            return transList;
        }
        public override string ToString()
        {
            return $"{AccountNumber} - {Balance}";
        }
        public override bool Equals(object obj)
        {
            if (!(obj is BankAccount account)) return false;
            return AccountNumber == account.AccountNumber;
        }
        public override int GetHashCode()
        {
            return AccountNumber?.GetHashCode() ?? 0;
        }
        #endregion
    }
}
