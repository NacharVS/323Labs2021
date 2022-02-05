using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.interfaces
{
    internal interface IReloadable
    {
        public int Clip { get; set; }
        void Reload();
    }
}
