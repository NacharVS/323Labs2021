using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP
{
    class VK :game ,INTERFACES.IMessenger 
    {

        public void PublicNews()
        {
            Console.WriteLine("abc");
        }

        public void SendMessage()
        {
            Console.WriteLine("Daler sps");
        }
    }
}
