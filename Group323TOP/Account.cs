using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP
{
    class Account
    {
        private double _balanceDollars;
        private double _balanceRubbles;

        public Account(double dollars, double rubles)
        {
            _balanceDollars = dollars;
            _balanceRubbles = rubles;
        }
        public double Balance
        {
            get => _balanceDollars;
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Balance to low");
                    return;
                }
                else
                    _balanceDollars = value;
            }
        }
    }
}
