using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP
{
    class Arrays
    {
        public static void Operation(int[] mass1, int[] mass2)
        {
            if (mass1.Length > mass2.Length)
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    array1[i] = array1[i] * array2[i];
                }

                for (int i = 0; i < array1.Length; i++)
                {
                    Console.Write($" {array1[i]}");
                }
            }
            else
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    array2[i] = array1[i] * array2[i];
                }
                for (int i = 0; i < array2.Length; i++)
                {
                    Console.Write($" {array2[i]}");
                }
            }
        }
    }
}
