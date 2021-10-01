using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Талибы
{
    interface IMeleeTalib
    {
        int Health { get; set; }

        string FullName { get; set; }

        int Damage { get; set; }

        public void Babah(Soldier soldier, MeleeTalib meleeTalib);

        public void Defence();
    }
}
