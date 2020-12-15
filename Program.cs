using Banking.Models.Domain;
using System;
using System.Collections.Generic;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount("123-123123-12");
            Console.WriteLine($"AccountNumber: {myAccount.AccountNumber}");
            Console.WriteLine($"Balance: {myAccount.Balance}");
            myAccount.Deposit(200M, "My first deposit");
            Console.WriteLine($"Balance after deposit of 200 euros: {myAccount.Balance}");
            myAccount.Withdraw(100M);
            Console.WriteLine($"Balance after withdrawal of 100 euros: {myAccount.Balance}");
            Console.WriteLine($"Number of transactions: {myAccount.NumberOfTransactions}");
            IEnumerable<Transaction> transactions = myAccount.GetTransactions(null, null);
            foreach (Transaction t in transactions)
            {
                Console.WriteLine($"Transaction: {t.DateOfTrans} - {t.Amount} - {t.TransactionType} - {t.Notes ?? "/"}");
            }
        }
    }
}
