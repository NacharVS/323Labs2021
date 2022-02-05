using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.interfaces
{
    internal class Rifle : IWeapon, IReloadable
    {
        public int Damage => 100;

        public int Clip { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Attack()
        {
            Console.WriteLine($"{GetType().Name} makes puw-chick with {Damage}");
        }

        public void Reload()
        {
            Console.WriteLine($"{GetType().Name} has been Reloaded");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has been Repaired");
        }
    }
}
