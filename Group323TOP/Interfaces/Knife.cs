using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP.Interfaces
{
    class Knife : IMleeWeapon, IThrowable
    {
      
        public int MleeDamage { get => 90; }
        public void MleeAttack()
        {
            Console.WriteLine($"{GetType().Name} makes chick-chirick with {MleeDamage }");
        }

        public void Repair()
        {
            Console.WriteLine($"{GetType().Name} has been repaired");
        }

        public void Throw()
        {
            Console.WriteLine($"{GetType().Name} makes kchau with {MleeDamage*2}");
        }
    }
}
