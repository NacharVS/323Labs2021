using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP
{
    interface IRangeTalib
    {
        int Health { get; set; }

        string FullName { get; set; }

        int Damage { get; set; }



        public void Defence();
    }
}
