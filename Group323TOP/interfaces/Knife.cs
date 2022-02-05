using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.interfaces
{
    internal class Knife : IWeapon
    {
        public int Damage => 3;

        public void Attack()
        {
            Console.WriteLine($"{GetType().Name} makes chik-chik {Damage}");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has been Repaired");
        }
    }
}
