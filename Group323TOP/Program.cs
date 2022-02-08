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
            Glock weapon1 = new Glock();
            var mleeWeapon = new Knife();
            Shotgun weapon2 = new Shotgun();
            Machinegun weapon3 = new Machinegun();
            Knife mleeWEapon = new Knife();
            Bekmansurov.ThrowMlee(mleeWEapon);
            //Bekmansurov.Reload(mleeWeapon);
            Galyaviev.Repair(weapon2);
            





        }
    }
}

