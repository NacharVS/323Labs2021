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
            IUnit newUnit = new Warrior(1000, "Semen");
            IDamage inflictDamage = new Warrior(1000, "Pa123eleymon");
            newUnit.Message();
            inflictDamage.InflictDamage(200);
            
            
        }
    }
}

