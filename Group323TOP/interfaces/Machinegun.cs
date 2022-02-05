using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.interfaces
{
    internal class Machinegun : IReloadable, IWeapon
    {
        public int Clip { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Damage => 50;

       
        public void Attack()
        {
            Console.WriteLine($"{GetType().Name} makes bum-bum-bum with {Damage}");
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
