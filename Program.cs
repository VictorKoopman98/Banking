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
                Console.WriteLine($"Transaction: {t.DateOfTrans} - {t.Amount} - {t.TransactionType} - {t.Notes ?? "No description"}");
            }
            SavingsAccount saving = new SavingsAccount("123-4567891-03", 0.01M);
            saving.Deposit(200M);
            saving.Withdraw(100M);
            saving.AddInterest();
            Console.WriteLine($"Balance savingsaccount: {saving.Balance}");
            BankAccount savingsAccount = new SavingsAccount("132-4567890-02", 0.05M);
            Console.WriteLine($"SavingsAccount : {savingsAccount}");
            savingsAccount.Deposit(200M);
            savingsAccount.Withdraw(100M);
            Console.WriteLine($"Balance savingsaccount: {savingsAccount.Balance}");
            Console.ReadKey();
        }
    }
}
