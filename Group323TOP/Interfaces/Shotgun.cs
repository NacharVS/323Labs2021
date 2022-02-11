using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.Interfaces
{
    class Shotgun : IWeapon, IReloadable
    {
        public int Damage => 50;

        public int Clip { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int IWeapon.Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Attack()
        {
            Console.WriteLine($"{GetType().Name} makes BAH! with {Damage}");
        }

        public void Reload()
        {
            Console.WriteLine($"{GetType().Name} reloaded");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has been repaired");
        }
    }
}
