using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP
{
    class Operations
    {
        public double Deposit;

        public static void Transaction(Account accountSeller, Account accountGetter, double summ)
        {
            accountSeller.Balance -= summ;
            accountGetter.Balance += summ;
            Console.WriteLine("Transaction completed");
            Console.WriteLine($"balance sell - {accountSeller.Balance}");
        }
        public static int Withdraw(Account account, double summ)
        {
            if (account.Balance < summ)
                Console.WriteLine("Operation denied");
            else
                account.Balance -= summ;
            return (int)summ;
        }


    }
}
