using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

namespace Group323TOP
{
    class Student
    {
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }    
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            for (int i = 0; i < 100; i++)
            {
                students.Add(new Student("Ivan", new Random().Next(20,30)));
            }
            List <Student> finding = new List<Student>();
            finding = students.FindAll(x => x.Age == 25);

            foreach (var item in finding)
            {
                Console.WriteLine($" {item.Name} ");
            }




        }
    }
}

