using System;
using System.Collections.Generic;
using Талибы;

namespace Bank1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Balance balance1 = new Balance(2000);
            //Balance balance2 = new Balance(1337);
            //Balance balance3 = new Balance(228);
            //Balance balance4 = new Balance(1488);
            //Balance balance5 = new Balance(322);
            //DataBase db = new DataBase();
            //db.users.Add(new Person("1", "Иванов Иван Иванович", "629215034", balance1));
            //db.users.Add(new Person("2", "Жаров Андрей Артемьевич", "667391251", balance2));
            //db.users.Add(new Person("3", "Воронцов Тимофей Алексеевич", "833211459", balance3));
            //db.users.Add(new Person("4", "Скворцова Александра Александровна", "173097427", balance4));
            //db.users.Add(new Person("5", "Калашникова Яна Руслановна", "801346616", balance5));

            //Operations.Deposit(db.users[0], 100);
            //Operations.Withdraw(db.users[0], 100);
            //Operations.Transaction(db.users[0], db.users[1], 100);
            //Operations.ShowInfo(db.users[0]);
            //Operations.ShowInfo(db.users[1]);
            //db.StartMenu();

            GrenadierTalib Akhmed = new GrenadierTalib(100, "Akhmed", 20);
            Soldier Artem = new Soldier(100, "Артем", 40);
            Akhmed.Shoot(Artem, Akhmed);
            Console.WriteLine(Artem.Health);

            // дада тут
        }
    }
}
