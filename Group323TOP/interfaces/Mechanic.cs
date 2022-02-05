using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.interfaces
{
    internal class Mechanic
    {
        public void Repair(IRepairible repairible)
        {
            repairible.Repair();
        }
    }
}
