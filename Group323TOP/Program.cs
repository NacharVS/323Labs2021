using System;
using Group323TOP.interfaces;
using System.Xml;
using System.Collections.Generic;

namespace Group323TOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Gunslinger Andrey = new Gunslinger();
            Mechanic Vitalya = new Mechanic();
            Glock glock = new Glock();
            Knife knife = new Knife();
            Machinegun machinegun = new Machinegun();
            Shotgun shotgun = new Shotgun();
            Rifle rifle = new Rifle();
            var mleeWeapon = new Knife();
            Box box = new Box();

            
           
            Andrey.OpenFire(rifle);
            Andrey.Cartrigee(rifle);
            //Vitalya.Repair(glock);
            //Andrey.OpenFire(knife);
            // Vitalya.Repair(knife);

        }
    }
}
