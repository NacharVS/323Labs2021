using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP
{
    class game
    {
        class Tips
        {
            private int _health;
            private int _damage;
            private bool _evil;
            private bool _walking;
            private string _name;


            public Tips(string name, int helth, int damage, bool evil, bool walking)
            {
                _name = name;
                _health = helth;
                _damage = damage;
                _evil = evil;
                _walking = walking;


                if (evil == true)
                {
                    Console.WriteLine('\t' + "Внимание! \n  \t Враг!" + '\n' + '\t' + "цель :" + $"{name}");

                }


            }
            public void Print()
            {
                if (_evil == false)
                {


                    if (_walking == true)
                    {
                        Console.WriteLine();
                        Console.WriteLine(Convert.ToString("\t  Наземная цель."));

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(Convert.ToString("\t Не наземная цель."));

                    }
                    Console.WriteLine('\t' + $"{_name} \t Здоровье : { _health} \t Урон : {_damage}");
                }
                else
                {
                    if (_walking == true)
                    {
                        Console.WriteLine();
                        Console.WriteLine(Convert.ToString("\t Наземная цель."));

                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine(Convert.ToString("\t Не наземная цель."));

                    }
                    Console.WriteLine('\t' + $"{_name} \t Здоровье : { _health} \t Урон : {_damage}");
                }


            }




        }

        class Start
        {

            static void StartPersonajii()
            {

                Tips medic_mirniy = new Tips("Медик", 100, 20, evil: false, walking: true);
                Console.WriteLine();
                Tips voin_mirniy = new Tips("Лучник", 10, 30, evil: false, walking: true);
                Console.WriteLine();
                Tips mechnik_vrag = new Tips("Мечник", 90, 32, evil: true, walking: true);
                Console.WriteLine();
                Tips podrivnik_vrag = new Tips("Подрывник", 100, 100, evil: true, walking: true);
                Console.WriteLine();
                Tips letchik_vrag = new Tips("Летчик", 100, 60, evil: true, walking: false);
                Console.WriteLine();
                medic_mirniy.Print();
                voin_mirniy.Print();
                mechnik_vrag.Print();
                podrivnik_vrag.Print();
                letchik_vrag.Print();

            }
        }
    }
}
