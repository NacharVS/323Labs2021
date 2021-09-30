using System;

namespace Group323TOP
{
    class ArrayGenegation
    {
        public static void Operation(int[] mass1, int[] mass2)
        {
            Console.WriteLine("amount");
            if(mass1.Length > mass2.Length)
            {
                for (int i = 0; i < mass2.Length; i++)
                {
                    mass1[i] = mass1[i] + mass2[i];                  
                }

                for (int i = 0; i < mass1.Length; i++)
                {
                    Console.Write($" {mass1[i]}");
                }
            }
            else
            {
                for (int i = 0; i < mass1.Length; i++)
                {
                    mass2[i] = mass1[i] + mass2[i];             
                }
                for (int i = 0; i < mass2.Length; i++)
                {
                    Console.Write($" {mass2[i]}");
                }
                Console.WriteLine("\n");
            }
        }
        public static void ArrayGeneration(int[] mass)
        {
            Random rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(0, 4);
                Console.Write($" {mass[i]}");
            }
            Console.WriteLine();
        }

        static void ArrayGeneration(int[,] mass)
        {
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = new Random().Next(0, 4);
                    Console.Write($" {mass[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
