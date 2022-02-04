﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.Interfaces
{
    class Machinegun : IWeapon, IReloadable
    {
        public int Damage => 20;

        public int Clip { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Attack()
        {
            Console.WriteLine($"{GetType().Name} makes piu-pau with {Damage}");
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
