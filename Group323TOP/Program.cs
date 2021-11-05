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
            MongoExamples.Person person = new MongoExamples.Person("Georgiy", 19, 321);
            MongoExamples.Person.UpdateFirst(person);





        }
    }
}

