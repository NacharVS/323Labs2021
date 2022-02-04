using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.Interfaces
{
    class Mechanic
    {
        public void Repair(IRepairible item)
        {
            item.Repair();
        }
    }
}
