using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.Interfaces
{
    class Gunslinger
    {
        public void OpenFire(IWeapon weapon)
        {
            weapon.Attack();
        }

        public void Reload(IReloadable weapon)
        {
            weapon.Reload();
        }

        public void MleeAttack(IMleeWeapon weapon)
        {
            weapon.MleeAttack();
        }

        public void ThrowMlee(IThrowable weapon)
        {
            weapon.Throw();
        }
    }
}
