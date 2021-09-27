using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP
{
    class PersonalData
    {
        public PersonalData(string lastname, string name, int age, int accountNumber)
        {
            _LastName = lastname;
            _Name = name;
            _Age = age;
            _AccountNumber = accountNumber;
        }
        private string _Name;
        private string _LastName;
        private int _Age;
        private int _AccountNumber;

        public string Name
        {
            get => _Name;
            set
            {
                _Name = value;
            }
        }
        public int Age
        {
            get => _Age;
            set
            {
                _Age = value;
            }
        }

        public string LastName
        {
            get => _LastName;
            set
            {
                _LastName = value;
            }
        }
        public int AccountNumber
        {
            get => _AccountNumber;
            set
            {
                _AccountNumber = value;
            }
        }

    }
}
