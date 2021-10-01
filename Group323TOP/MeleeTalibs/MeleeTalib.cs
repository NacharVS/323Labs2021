using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP
{
    class MeleeTalib : IMeleeTalib
    {
        public MeleeTalib(int health, string fullName)
        {
            Health = health;
            FullName = fullName;
        }

        private int _health;

        private string _fullName;

        private int _damage = 100;

        public int Health
        {

            get => _health;

            set
            {
                _health = value;
            }
        }
        public string FullName
        {
            get => _fullName;

            set
            {
                _fullName = value;
            }
        }

        public int Damage
        {
            get => _damage;
        }

        public void Babah(Soldier soldier, MeleeTalib meleeTalib)
        {
            soldier.Health -= meleeTalib.Damage;
            meleeTalib.Health -= meleeTalib.Damage;
            Console.WriteLine("оба умерли");
        }

        public void Defence()
        {
            Console.WriteLine("defence");
        }
    }
}
