using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedExceptionAccountsApp
{
    internal class Accounts
    {
        public int AccountNo { get; set; }

        public string AccountName { get; set; } 

        public string BankName { get; set; }

        public double Balance { get; set; }

        const double MinimumBalance = 500;

        public Accounts(int accountNo, string accountName, string bankName, double balance)
        {
            AccountNo = accountNo;
            AccountName = accountName;
            BankName = bankName;
            Balance = balance;
        }

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Amount Deposited Successfully";
        }

        public string Withdraw(double amount)
        {
            if (Balance >= MinimumBalance) 
            {
                Balance -= MinimumBalance;
                return "withdrawl sucessfull";
            }

            throw new InsufficientBalanceException("Minimum balance of 500 rs is to be maintailed " +
                "\n WITHDRAWEL DENIED !!");
        }
    }
}
