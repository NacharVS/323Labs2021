using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.interfaces
{
    internal class Glock : IWeapon, IReloadable
    {
        public int Damage => 8;

        public int Clip { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Attack()
        {
            Console.WriteLine($"{GetType().Name} makes tr-tr-tr with {Damage}");
        }

        public void Reload()
        {
            Console.WriteLine($"{GetType().Name} has been reloaded");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has been repaired");
        }
    }
}
