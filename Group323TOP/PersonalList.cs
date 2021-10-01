using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP
{
    class PersonalList
    {

        static List<PersonalData> person = new List<PersonalData>();
        public static void StartList()
        {
            person.Add(new PersonalData("Габдуллтити", "Марсесь", 15, 2288));
            person.Add(new PersonalData("Петраксим", "Скам", 24, 3222));
            person.Add(new PersonalData("Рыбочкин", "Пиво", 17, 1337));
            person.Add(new PersonalData("Уткин", "Артем", 14, 1488));
            person.Add(new PersonalData("Начаров", "Вадим", 32, 2754));
            foreach (var item in person)
            {
                Console.WriteLine($"{item.LastName} {item.Name} {item.Age} {item.AccountNumber}");
            }

        }
        public static void AddPerson()
        {
            List<PersonalData> person = new List<PersonalData>();
            Console.WriteLine("Введите фамилию чела: ");
            string lastname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите имя чела: ");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите возраст чела: ");
            int age = Convert.ToInt32(Console.ReadLine());
            int accountNumber = new Random().Next(1111, 9999);
            person.Add(new PersonalData(lastname, name, age, accountNumber));
            Console.WriteLine($"------------------------\nДобавлен клиент: {lastname} {name}\nЕго возраст: {age}\nЕго номер счета: {accountNumber}");
            Console.WriteLine();
        }

        public static void RemovePerson()
        {
            Console.Write("Введите номер удаляемого чела: ");
            int del = Convert.ToInt32(Console.ReadLine());
            person.RemoveAt(del - 1);
        }
        public static void StartMenu()
        {
            Console.WriteLine("Чтобы посмотреть список, жмякайте 1 \nЧтобы добавить челика в список, жмякайте 2 \nЧтобы удалить челика из списка, жмякайте 3");
            int tap = Convert.ToInt32(Console.ReadLine());
            switch (tap)
            {
                case 1:
                    StartList();
                    break;
                case 2:
                    AddPerson();
                    Console.WriteLine();
                    foreach (var item in person)
                    {
                        Console.WriteLine($"{item.LastName} {item.Name} {item.Age} {item.AccountNumber}");
                    }
                    break;
                case 3:
                    RemovePerson();
                    Console.WriteLine();
                    foreach (var item in person)
                    {
                        Console.WriteLine($"{item.LastName} {item.Name} {item.Age} {item.AccountNumber}");
                    }
                    break;

            }
        }

    }
}