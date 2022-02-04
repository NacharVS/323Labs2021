using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.Interfaces
{
    class Glock : IWeapon, IReloadable
    {
        public int Damage => 8;

        public int Clip { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int a;
        public void Attack()
        {
            Console.WriteLine($"{GetType().Name} makes tr-tr-tr with {Damage}");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has been repaired");
        }

        public void Reload()
        {
            Console.WriteLine($"{GetType().Name} reloaded");
        }
    }
}
