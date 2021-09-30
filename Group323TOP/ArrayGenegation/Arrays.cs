using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP
{
    class Arrays
    {
        public static void Operation(int[] massive1, int[] massive2)
        {
            Console.WriteLine();
            Console.WriteLine("composition");
            if (massive1.Length > massive2.Length)
            {
                for (int i = 0; i < massive2.Length; i++)
                {
                    massive1[i] = massive1[i] * massive2[i];
                }
                for (int i = 0; i < massive1.Length; i++)
                {
                    Console.Write($"{massive1[i]}");
                }
            }
            else
            {
                for (int i = 0; i < massive1.Length; i++)
                {
                    massive2[i] = massive1[i] * massive2[i];
                }
                for (int i = 0; i < massive2.Length; i++)
                {
                    Console.Write($" {massive2[i]}");
                }
                Console.WriteLine();
            }
            
        }
        public static void ArrayGeneration(int[] massive)
        {
            Console.WriteLine();
            Random rnd = new Random();
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = rnd.Next(0, 4);
                Console.Write($" {massive[i]}");
            }
        }
        public static void ArrayMax(int[,] arrays)
        {
            Random random = new Random();
            for (int i = 0; i < arrays.Length; i++)
            { 
            }
        }
    }
}
