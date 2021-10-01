using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Талибы
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
        int IMeleeTalib.Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Babah(Soldier soldier, MeleeTalib meleeTalib)
        {
            soldier.Health -= meleeTalib.Damage;
            meleeTalib.Health -= meleeTalib.Damage;
            Console.WriteLine("Ай ай ай ай, умер талиб с солдатом");
        }

        public void Defence()
        {
            Console.WriteLine("Все в мечеть!");
        }

        
    }
}
