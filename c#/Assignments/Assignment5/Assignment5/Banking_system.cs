using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment5
{
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }
    class Account
    {
        int accNo;
        string name;
        double balance;
        public Account(int accNo, string name, double balance)
        {
            this.accNo = accNo;
            this.name = name;
            this.balance = balance;
        }
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine("Deposited: " + amount);
        }
        public void Withdraw(double amount)
        {
            if (amount > balance)
                throw new InsufficientBalanceException("Insufficient Balance!");
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        public void ShowBalance()
        {
            Console.WriteLine("Current Balance: " + balance);
        }
    }
    internal class Banking_system
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter Account Number: ");
                int accNo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Customer Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Initial Balance: ");
                double balance = Convert.ToDouble(Console.ReadLine());
                Account acc = new Account(accNo, name, balance);
                Console.Write("Enter Deposit Amount: ");
                double deposit = Convert.ToDouble(Console.ReadLine());
                acc.Deposit(deposit);
                acc.ShowBalance();
                Console.Write("Enter Withdraw Amount: ");
                double withdraw = Convert.ToDouble(Console.ReadLine());
                acc.Withdraw(withdraw);
                acc.ShowBalance();
            }
            catch (InsufficientBalanceException e)
            {
                Console.WriteLine("Custom Exception: " + e.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter correct values.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.ReadLine();
        }
    }
}