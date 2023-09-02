using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedExceptionAccountsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Accounts account1 = new Accounts(101, "Joshit", "Hdfc", 6000);
            Console.WriteLine(account1.Deposit(4000));
            Console.WriteLine("UPDATED BALANCE IS "+ account1.Balance);
            try
            {
                Console.WriteLine(account1.Withdraw(9600));
            } catch(InsufficientBalanceException ibe)
            {
                Console.WriteLine(ibe.Message);
            }
            Console.WriteLine("updated Balance is " + account1.Balance);
        }
    }
}
