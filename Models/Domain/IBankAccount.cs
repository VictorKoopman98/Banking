using System;
using System.Collections.Generic;

namespace Banking.Models.Domain
{
    public interface IBankAccount
    {
        string AccountNumber { get; }
        decimal Balance { get; }
        int NumberOfTransactions { get; }

        void Deposit(decimal amount, string notes = null);
        IEnumerable<Transaction> GetTransactions(DateTime? from, DateTime? till);
        void Withdraw(decimal amount, string notes = null);
    }
}