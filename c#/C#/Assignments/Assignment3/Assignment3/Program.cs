using System;

namespace AccountsProgram
{
    class AccountBase
    {
        protected int accNo;
        protected string custName;
        protected string accType;
        protected double balance;

        public AccountBase(int accNo, string custName, string accType, double balance)
        {
            this.accNo = accNo;
            this.custName = custName;
            this.accType = accType;
            this.balance = balance;
        }
    }
    class Accounts : AccountBase
    {
        char transType;
        double amount;

        public Accounts(int accNo, string custName, string accType, double balance)
            : base(accNo, custName, accType, balance) { }

        public void Credit(double amt)
        {
            balance += amt;
        }

        public void Debit(double amt)
        {
            if (amt <= balance)
                balance -= amt;
            else
                Console.WriteLine("Insufficient Balance");
        }

        public void Transaction(char type, double amt)
        {
            transType = type;
            amount = amt;

            if (type == 'D' || type == 'd')
                Credit(amt);
            else if (type == 'W' || type == 'w')
                Debit(amt);
        }
        public void ShowData()
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine($"Acc No: {accNo}");
            Console.WriteLine($"Name: {custName}");
            Console.WriteLine($"Type: {accType}");
            Console.WriteLine($"Transaction: {transType}");
            Console.WriteLine($"Amount: {amount}");
            Console.WriteLine($"Balance: {balance}");
        }
    }
    class Program
    {
        static void Main()
        {
            Accounts acc = new Accounts(101, "Arun", "Savings", 5000);
            acc.Transaction('D', 2000);
            acc.Transaction('W', 1000);
            acc.ShowData();
        }
    }
}