using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP
{
    class DataBase
    {
        public List<Person> users = new List<Person>();

        public void StartMenu()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to the Bank");
                Console.WriteLine("1-полный список пользователей\n2 - удалить пользователя\n3-добавить пользователя\n4-выход\n");
                Console.Write("Enter number: ");
                int button = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (button)
                {
                    case 1:
                        foreach (var item in users)
                        {
                            Console.WriteLine($"{item.id}--{item.name}--{item.balance.dollars}$");

                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Removing user \n");
                        Removing();
                        break;
                    case 3:
                        Console.WriteLine("Adding new user \n");
                        AddingUser();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
        public void Removing()
        {
            Console.WriteLine("Enter an id of user you want to delete: ");
            string index = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < users.Count; i++)
            {
                if (index == users[i].id)
                {
                    users.Remove(users[i]);
                }
            }
        }

        public void AddingUser()
        {
            Console.Write("Enter ID of new user:");
            string id = new string(Convert.ToString(Console.ReadLine()));
            Console.Write("Enter name of new user:");
            string name = new string(Convert.ToString(Console.ReadLine()));
            Console.Write("Enter passport of new user:");
            string passport = new string(Convert.ToString(Console.ReadLine()));
            Console.Write("Enter money of new user:");
            Balance balance = new Balance(Convert.ToDouble(Console.ReadLine()));
            Person newPerson = new Person(id, name, passport, balance);
            users.Add(newPerson);
        }
    }
}
