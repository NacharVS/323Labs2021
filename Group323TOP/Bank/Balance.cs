using System;
using System.Collections.Generic;
using System.Text;

namespace Bank1
{
    class Balance
    {
        private double _dollars;
        public static double rate = 0.057;

        public double dollars// свойство. делается для того, чтобы работать в других классах  с и3олированными обектами
        {
            get => _dollars;
            set
            {
                if (_dollars < 0)
                {
                    Console.WriteLine("Not enough money");
                }
                else
                    _dollars = value;
            }
        }

        public Balance(double dollars)//конструктор. с помощью него заполняется экземпляр в Main
        {
            _dollars = dollars;
        }
    }
}