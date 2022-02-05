using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.interfaces
{
    internal class Shotgun
    {
        public int Damage => 50;
        public int Clip { get => throw new NotFiniteNumberException(); set=> throw new NotFiniteNumberException(); }
    }
}
