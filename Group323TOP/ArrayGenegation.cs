using System;

namespace Group323TOP
{
    class ArrayGenegation
    {
        public static void Operation(int[] mass1, int[] mass2)
        {
            if (mass1.Length > mass2.Length)
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

            }
        }
        public static void ArrayGeneration(int[] mass)
        {
            Random rnd = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = rnd.Next(0, 2);
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
                    mass[i, j] = new Random().Next(0, 2);
                    Console.Write($" {mass[i, j]}");
                }
                Console.WriteLine();
            }
        }

        public static void Overload(int[] array11, int[] array22)
        {
            if (array11.Length > array22.Length)
            {
                for (int i = 0; i < array22.Length; i++)
                {
                    array11[i] = array11[i] * array22[i];
                }

                for (int i = 0; i < array11.Length; i++)
                {
                    Console.Write($" {array11[i]}");
                }
            }
            else
            {
                for (int i = 0; i < array11.Length; i++)
                {
                    array22[i] = array11[i] * array22[i];
                }
                for (int i = 0; i < array22.Length; i++)
                {
                    Console.Write($" {array22[i]}");
                }
            }
            Console.WriteLine();
        }
    }
}