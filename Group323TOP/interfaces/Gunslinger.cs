using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.interfaces
{
    internal class Gunslinger
    {
        public void OpenFire(IWeapon weapon)
        {
            weapon.Attack();
        }
        public void Reload(IReloadable reloadable)
        {
            reloadable.Reload();
        }
    }
}
