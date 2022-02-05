using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.interfaces
{
    internal class Box
    {
        public IWeapon[] box = new IWeapon[3] { new Glock(), new Machinegun(), new Shotgun() };
    }
}
