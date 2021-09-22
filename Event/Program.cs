using System;

namespace Bank_Account
{
    class Program
    {
        class Account
        {
            delegate void AccountHandler(string message);
            event AccountHandler Notify;

            public Account(int sum) // сумма на счете
            {
                Sum = sum;
                Console.WriteLine($"На счету: {sum}");
            }

            public int Sum { get; private set; } // добавление средств на счет

            public void Put(int sum) // списание средств со счета
            {
                Sum += sum;
                Notify?.Invoke($"На счет поступило: {sum}");
            }

            public void Take(int sum)
            {
                if (Sum >= sum)
                {
                    Sum -= sum;
                    Notify?.Invoke($"Со счета снято: {sum}");
                }
                else
                {
                    Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {sum}");
                }
            }
        }

        static void Main(string[] args)
        {
            Account acc = new Account(100);
            acc.Put(20);
            Console.WriteLine($"Сумма на счету: {acc.Sum}");
            acc.Take(70);
            Console.WriteLine($"Сумма на счету: {acc.Sum}");
            acc.Take(180);
            Console.WriteLine($"Сумма на счету: {acc.Sum}");
        }
    }
}
