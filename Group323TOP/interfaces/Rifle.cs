using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.interfaces
{
    internal class Rifle : IWeapon, IReloadable, ICartridges
    {
        public int Damage => 100;
        

        public int Clip { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Value => 1;

        public void Attack()
        {
            Console.WriteLine($"{GetType().Name} makes puw-chick with {Damage}");
           
        }

        public void Cartrige()
        {
            Console.WriteLine($"{GetType().Name} has value {Value}");
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
