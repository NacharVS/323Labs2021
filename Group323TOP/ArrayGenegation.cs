using System;

namespace Group323TOP
{
    class ArrayGenegation
    {
        static void ArrayGeneration(int[] mass)
        {
            Random rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(0, 2);
                Console.Write($" {mass[i]}");
            }
        }

        static void ArrayGeneration(int[,] mass)
        {
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = new Random().Next(0, 2);
                    Console.Write($" {mass[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
