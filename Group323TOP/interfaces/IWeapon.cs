using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.interfaces
{
    internal interface IWeapon : IRepairible
    {
        int Damage { get; }
        void Attack();
    }
}
