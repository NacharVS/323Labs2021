using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.Interfaces
{
    class Box
    {
      public IWeapon[] box = new IWeapon[3] { new Glock(), new Machinegun(), new Shotgun()};
    }
}
