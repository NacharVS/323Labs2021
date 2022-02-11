using Group323TOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Group323TOP
{    
    class Program
    {
        static void Main(string[] args)
        {
            Gunslinger Bekmansurov = new Gunslinger();
            Mechanic Galyaviev = new Mechanic();
            Glock weapon1 = new Glock(3, 20, 20);
            weapon1.Attack();
            weapon1.Attack();
            weapon1.Attack();
            weapon1.Attack();







        }
    }
}

