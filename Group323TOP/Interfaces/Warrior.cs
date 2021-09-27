using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.Interfaces
{
    class Warrior : IUnit, IDamage
    {
        private int _health;
        private string _unitType;

        public Warrior(int health, string unitType)
        {
            Health = health;
            _unitType = unitType;
        }

        public int Health { get => _health; set => _health = value; }
        

        public void InflictDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{_unitType} has inflicted {damage} health - {_health}");
        }

        public void Message()
        {
            Console.WriteLine($"{_unitType} health -  {_health}");
        }
    }
}
