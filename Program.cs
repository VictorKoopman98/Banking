using Banking.Models.Domain;
using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount("123-123123-12");
            Console.WriteLine(myAccount.Balance.ToString());
            Console.WriteLine($"AccountNumber: {myAccount.AccountNumber}");
            Console.WriteLine($"Balance: {myAccount.Balance}");
            myAccount.Deposit(200M);
            Console.WriteLine($"Balance after deposit of 200 euros: {myAccount.Balance}");
            myAccount.Withdraw(100M);
            Console.WriteLine($"Balance after withdrawal of 100 euros: {myAccount.Balance}");
            Console.WriteLine(Console.ReadKey());
        }
    }
}
