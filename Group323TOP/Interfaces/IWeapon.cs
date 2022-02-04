using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.Interfaces
{
    interface IWeapon : IRepairible
    {
        int Damage { get; }
        void Attack();
    }
}
