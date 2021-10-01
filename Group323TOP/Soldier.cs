using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Талибы
{
    class Soldier
    {

        public Soldier(int health, string fullName, int damage)
        {
            Health = health;
            FullName = fullName;
            Damage = damage;

        }
        private string _fullName;

        private int _health;

        private int _damage;
        public  int Health
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

            set
            {
                _damage = value;
            }
        }

        public void Shoot(MeleeTalib meleeTalib, Soldier soldier)
        {
            meleeTalib.Health -= soldier.Damage;

        }

        public void Shoot(GrenadierTalib grenadierTalib, Soldier soldier)
        {
            grenadierTalib.Health -= soldier.Damage;

        }

        public void Shoot(SniperTalib sniperTalib, Soldier soldier)
        {
            sniperTalib.Health -= soldier.Damage;

        }

        public void Defence()
        {
            Console.WriteLine("В укрытие!!!");
        }

    }
}
