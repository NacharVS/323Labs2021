using System;
using System.Collections.Generic;
using System.Text;

namespace Bank1
{
    class Operations
    {
        public static void ShowInfo(Person person)
        {
            Console.WriteLine($"{person.name} has {person.balance.dollars}$ \n");
        }

        public static void Deposit(Person person, double sum)
        {
            if (sum != 0 && sum > 0)
            {
                person.balance.dollars += sum;
                Console.WriteLine("Operation succeed");
                Console.WriteLine($"{sum}$ was credited to {person.name}");

            }
            else
                Console.WriteLine("You can`t credit invalid sum of money");
        }

        public static void Withdraw(Person person, double sum)
        {
            if (person.balance.dollars < sum)
            {
                Console.WriteLine("Not enough money to withdraw");
            }
            else
            {
                person.balance.dollars -= sum;
                Console.WriteLine("Operation succeed");
                Console.WriteLine($"{person.name} withdrew {sum}$ from the account");
            }
        }

        public static void Transaction(Person personSeller, Person personGetter, double sum)
        {

            if (personSeller.balance.dollars > sum && sum > 0)
            {
                personSeller.balance.dollars -= sum;
                personGetter.balance.dollars += sum;
                Console.WriteLine("Operation succeed");
                Console.WriteLine($"{personSeller.name} transferred {personGetter.name} {sum}$");
            }
            else if (sum < 0)
                Console.WriteLine("The transfer amount can not be less than zero");
            else if (personSeller.balance.dollars < sum)
                Console.WriteLine("Not enough money to transact");
        }
        public static void Contribution(Person person, int monthCount)
        {
            if (person.balance.dollars > 0)
            {
                Console.WriteLine("Operation succeed");
                person.balance.dollars = person.balance.dollars + (person.balance.dollars * Balance.rate / 12 * monthCount);
            }
            else
                Console.WriteLine("You can`t deposit if you have 0$ or less");
        }


    }
}
