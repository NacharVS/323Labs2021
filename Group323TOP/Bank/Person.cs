using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.Bank
{
    class Person
    {
        private string _name;
        private string _passport;
        private string _id;
        Balance _balance;
        public string name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }
        public string passport
        {
            get => _passport;
            set
            {
                _passport = value;
            }
        }
        public string id
        {
            get => _id;
            set
            {
                _id = value;
            }
        }
        public Balance balance
        {
            get => _balance;
            set
            {
                _balance = value;
            }
        }

        public Person(string id, string name, string passport, Balance balance)
        {
            _id = id;
            _name = name;
            _passport = passport;
            _balance = balance;
        }
    }
}
