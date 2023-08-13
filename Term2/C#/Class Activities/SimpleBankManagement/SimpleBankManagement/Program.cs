using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankManagement
{
    class BankAccount
    {
        private string Name;
        private int AccountNumber;
        private double Balance;

        public BankAccount(string name, int accountNumber, double balance)
        {
            Name = name;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public bool Withdraw(double amount)
        {
            if(Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
        public void Transfer(BankAccount recipient, double amount)
        {
            if(Withdraw(amount))
            {
                recipient.Deposit(amount);
            }
        }
        public void ShowAccountInformation()
        {
            Console.WriteLine($"Name: {Name}, Account Number: {AccountNumber}, Balance: {Balance}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount david = new BankAccount("David", 1, 100.00);
            BankAccount susan = new BankAccount("Susan", 2, 10000.00);

            david.ShowAccountInformation();
            Console.WriteLine();

            david.Deposit(100);
            david.ShowAccountInformation();
            Console.WriteLine();

            david.Withdraw(500);
            david.ShowAccountInformation();
            Console.WriteLine();

            susan.ShowAccountInformation();
            susan.Transfer(david, 1000);
            Console.WriteLine();

            Console.WriteLine("After Transfer: ");
            david.ShowAccountInformation();
            susan.ShowAccountInformation();
            Console.WriteLine();
        }
    }
}
