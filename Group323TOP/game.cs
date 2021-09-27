using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP
{
    class game 
    {   public delegate void Damage();
       
        class Tips
        {

            public delegate void ValueChangedDelegateHealth(string messagehealth);
            public delegate void ValueChangedDelegateDamage(string messagedamage);


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

            public int Health
            {
                get => _health;

                set
                {
                    _health = value;
                    if (_health < 1)
                    {
                        HealthChangedEvent?.Invoke($" Персонаж    {_name}   погиб и имеет  {_health} здоровья ");
                    }
                    else
                    {
                        HealthChangedEvent?.Invoke($" Здоовье персонажа   {_name} =  {_health} ");
                    }
                }
            }
            public int Damagee
            {
                get => _damage;

                set
                {
                    _damage = value;
                    
                    if (_damage < 50)
                    {
                        _damage = _damage + 10;
                        DamageChangedEvent?.Invoke($" Суммарный урон равен {_name} =   {_damage}");
                    }
                    else
                    {
                        _damage = _damage + 5;
                        DamageChangedEvent?.Invoke($" Суммарный урон равен  {_name}  = {_damage}");
                    }
                }
            }

            public void SumDamge() 
            {
                        if (_damage < 50)
                        {
                            _damage = _damage - 10;
                            Console.WriteLine($"Суммарный урон равен {_damage}");
                        }
                        else 
                        {
                            _damage  = _damage - 5;
                            Console.WriteLine($"Суммарный урон равен {_damage}");
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


            public static void Shoot() 
            {
                Console.WriteLine("--------------------------------------Проверка завершена---------------------------------------------------");
            }

            public static void InflictDamage(Tips char1, int damage)
            {
                
                char1.Health -= damage;
                
            }
            public static void BoosterDamage(Tips char2, int damagee)
            {

                char2.Damagee += damagee;

            }

            public static event ValueChangedDelegateHealth HealthChangedEvent;
            public static event ValueChangedDelegateDamage DamageChangedEvent;

        }
        

        public class Start
        {
            static void DisplayMessage(string mes)
            {
               
                    Console.WriteLine(mes);
                
            }

            public static void StartPersonajii()
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
                Damage dam1 = Tips.Shoot;
                Console.WriteLine();
                Tips.HealthChangedEvent += DisplayMessage;
                Tips.DamageChangedEvent += DisplayMessage;
                Tips.InflictDamage(medic_mirniy, 10);
                Console.WriteLine();
                Tips.BoosterDamage(medic_mirniy, 50);
                Console.WriteLine();
                Tips.InflictDamage(letchik_vrag,100);
                Console.WriteLine();
                Tips.BoosterDamage(podrivnik_vrag , 70);
                dam1();


            }
        }
    }
}
