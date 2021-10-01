using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP
{
    interface IMeleeTalib
    {
        int Health { get; set; }

        string FullName { get; set; }

        int Damage { get; }

        public void Babah(Soldier soldier, MeleeTalib meleeTalib);

        public void Defence();
    }
}
