using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.Interfaces
{
    class Glock : Weapon, IWeapon, IReloadable
    {
        public Glock(int clip, int damage, int maxClip)
        {
            _clip = clip;
            _damage = damage;
            _maxClip = maxClip;
            
        }

        public int Clip 
        {   get => _clip;
            set
            {
                if(value > _maxClip)
                {
                    _clip = _maxClip;
                }
                else
                    _clip = value; 
            }
        }
        public int Damage { get => _damage; set => _damage = value; }

 
        public void Attack()
        {
            if(Clip > 0)
            {
                Console.WriteLine($"{GetType().Name} makes tr-tr-tr with {Damage}");
                Clip--;
            }
            else
            {
                Console.WriteLine("Need reloading");
            }          
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has been repaired");
        }

        public void Reload()
        {
            Console.WriteLine($"{GetType().Name} reloaded");
        }
    }
}
