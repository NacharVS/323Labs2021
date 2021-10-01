using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP
{
    class spermbank
    {
        private double _dollaraccount;
        private double _rublaccount;
        public int Age;
        public string Name;
        private static int Id;
        public spermbank()
        {
            Console.WriteLine("Введите имя");
            this.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите возраст");
            this.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите счет в долларах");
            this._dollaraccount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите счет в рублях");
            this._rublaccount = Convert.ToDouble(Console.ReadLine());
            Id = 0;
            Id++;
            Console.WriteLine($"Name: {Name}, Age: {Age}, Dollar: {_dollaraccount}, Rub: {_rublaccount}, Id: {Id}");
        }
        //public static int counter;
        //private int _counter2;
        //public int Xuy { get; set; }
        //public spermbank(int counter)
        //{
        //    Counter = counter;
        //}
        //public int Counter
        //{
        //    get
        //    {
        //        return _counter2;
        //    }
        //    set
        //    {
        //        if (value < 2)
        //        {
        //            Console.WriteLine("Penis");

        //        }
        //        else
        //        {
        //            _counter2 = value;
        //        }
        //    }
        //}
        //public void CounterIncrement()
        //{
        //    Console.WriteLine(Counter++);
        //}
        //public static void Aboba()
        //{
        //    Console.WriteLine("Pepega");
        //}
        //public static void Aboba(string text)
        //{
        //    Console.WriteLine($"Xuy {text}");
        //}jj
    }
}
