using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception
{
    public class BankAccount
    {
        //string accountNumber;
        double balance = 6000;
        public BankAccount(double initialBalance)
        {
            this.balance = initialBalance;
        }
        public double Deposite(double amount)
        {
            balance = balance + amount;
            Console.WriteLine($"The current balance is {balance}");
            return balance;
        }
        public double Withdraw(double amount)
        {
            try
            {
                if (amount > balance)
                {
                    throw new NegativeBalanceException("Withdraw causes negative balance");
                }

                balance = balance - amount;
                Console.WriteLine($"The current balance is {balance}");

            }
            catch(NegativeBalanceException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return balance;
        }

    }
}
