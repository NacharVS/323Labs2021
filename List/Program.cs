using System;
using System.Collections.Generic;

namespace GAME
{
    class Program
    {
        class Unit
        {
            public string type;
            public int maxHP;
            public int hp;
            public double damage;
            public int cash;
            public object inventory;

            public void GetInfo()
            {
                Console.Write($"Тип.....{type}" + "\t" +
                    $"Максимальное здоровье.....{maxHP}" + "\t" +
                    $"Здоровье.....{hp}" + "\t" +
                    $"Урон.....{damage}" + "\t" +
                    $"Деньги.....{cash}" + "\t" +
                    $"Инвентарь.....{inventory}");
            }
        }
        static object GetInventoryArc1()
        {
            List<string> GetInventoryArc = new List<string>()
            {
                {"Лук; 60 стрел; Зелье здоровья; Зелье урона" /*и тд*/}
            };
            return GetInventoryArc;
        }

        static object GetInventoryKin1()
        {
            List<string> GetInventoryKin = new List<string>()
            {
                {"Меч; 5х Зелье урона; 5х Зелье здоровья" /*и тд*/}
            };
            return GetInventoryKin;
        }

        static object GetInventorySwo1()
        {
            List<string> GetInventorySwo = new List<string>()
            {
                {"Кольчуга; Поножи; Шлем; Зелье урона; Зелье здоровья" /*и тд*/}
            };
            return GetInventorySwo;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Выберите персонажа");
            Console.WriteLine("Нажмите: i - Лучник;  x - Король;  y - Мечник");

            Unit archer = new Unit { type = "Лучник", maxHP = 200, hp = 200, damage = 20.5, cash = 2500, inventory = GetInventoryArc1() };
            Unit king = new Unit { type = "Король", maxHP = 20000, hp = 5000, damage = 500, cash = 99999999, inventory = GetInventoryKin1() };
            Unit swordsman = new Unit { type = "Мечник", maxHP = 500, hp = 500, damage = 35, cash = 0, inventory = GetInventorySwo1() };

            string selection = Console.ReadLine();
            switch (selection)
            {
                case "i":
                    archer.GetInfo();
                    break;
                case "x":
                    king.GetInfo();
                    break;
                case "y":
                    swordsman.GetInfo();
                    break;
            }

            Console.ReadLine();
        }
    }
}

