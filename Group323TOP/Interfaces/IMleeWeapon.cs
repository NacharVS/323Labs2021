using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.Interfaces
{
    interface IMleeWeapon : IRepairible
    {
        int MleeDamage { get;}

        void MleeAttack();
    }
}
