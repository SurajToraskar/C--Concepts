using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_Threads
{
     class BankAccount
    {
        private Object acctLock = new object();
        double Balance { get; set; }
        string Name { get; set; }

        public BankAccount(double balance)
        {
            this.Balance= balance;
        }

        public double Withdraw(double amt)
        {
            if ((Balance - amt) < 0)
            {
                Console.WriteLine($"Sorry ${this.Balance} in Account");
                return Balance;
            }
            lock(acctLock)
            {
                if (Balance >= amt)
                {
                    Console.WriteLine($"Removed {amt} and {Balance-amt} left in account");
                    Balance-= amt;
                }
                return Balance;
            }
        }

        public void IssueWithdraw()
        {
            Withdraw(1);
        }

        public void BankBalance()
        {
            Console.WriteLine($"Bank Balance: {this.Balance}");
        }

    }
}
