using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.Interfaces
{
    class Knife : IWeapon
    {
        public int Damage => 90;

        public void Attack()
        {
            Console.WriteLine($"{GetType().Name} makes chik-chikchirick with {Damage}");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has been repaired");
        }
    }
}
