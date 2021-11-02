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
            //Unit unit1 = new Unit("Vasyan", 15);
            //unit1.AddItem(new Item("Palka", 2));
            //unit1.AddItem(new Item("Kamen", 3));
            //unit1.AddItem(new Item("Gulag", 9999999));
            //Unit.AddToDb(unit1);
            Unit.FindFromDatabase();



        }
    }
}

