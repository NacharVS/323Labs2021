using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP
{
    class Balance
    {
        private double _dollars;
        public static double rate = 0.057;

        public double dollars
        {
            get => _dollars;
            set
            {
                if (_dollars < 0)
                {
                    Console.WriteLine("No money");
                }
                else
                    _dollars = value;
            }
        }

        public Balance(double dollars)
        {
            _dollars = dollars;
        }
    }
}
