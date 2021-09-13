using System;
using System.Collections.Generic;
using System.Text;

namespace Group323TOP
{
    class ArrayTasks
    {
        public static void SumArraysPrinting(double[] arraySum1, double[] arraySum2)
        {
            Console.WriteLine("Arrays for summing:");
            for (int i = 0; i < arraySum1.Length; i++)
            {
                Console.Write(arraySum1[i] + "  ");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < arraySum2.Length; i++)
            {
                Console.Write(arraySum2[i] + "  ");
            }
            Console.WriteLine("\n");


        }
        public static void Operation(double[] mass1, double[] mass2)
        {
            Console.WriteLine("1st task: Finding sum");
            if (mass1.Length > mass2.Length)
            {
                for (int i = 0; i < mass2.Length; i++)
                {
                    mass1[i] = mass1[i] + mass2[i];
                }

                for (int i = 0; i < mass1.Length; i++)
                {
                    Console.Write($"{Math.Round(mass1[i], 3)} ");
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
                    Console.Write($" {Math.Round(mass2[i], 3)} ");
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("-----------------------------------------------------------");
        }
        public static void MultArraysPrinting(int[] arrayMult1, int[] arrayMult2)
        {
            Console.WriteLine("Arrays for multiplying:");
            for (int i = 0; i < arrayMult1.Length; i++)
            {
                Console.Write(arrayMult1[i] + "  ");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < arrayMult2.Length; i++)
            {
                Console.Write(arrayMult2[i] + "  ");
            }
            Console.WriteLine("\n");

        }
        public static void Operation(int[] mass1, int[] mass2)
        {
            Console.WriteLine("2nd task: Finding multiply");
            if (mass1.Length > mass2.Length)
            {
                for (int i = 0; i < mass2.Length; i++)
                {
                    mass1[i] = mass1[i] * mass2[i];
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
                    mass2[i] = mass1[i] * mass2[i];
                }
                for (int i = 0; i < mass2.Length; i++)
                {
                    Console.Write($" {mass2[i]}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------");
        }
        public static void FindingMax(int[,] matrix)
        {
            Console.WriteLine("3rd task: matrix");
            Random rnd = new Random();
            int[,] matrix1 = new int[5, 5];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(-100, 101);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int maxElement = int.MinValue;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] > maxElement)
                    {
                        maxElement = matrix[i, j];
                    }
                }
                Console.WriteLine($"In {i} row max element is: {maxElement}");
            }
            Console.WriteLine("-----------------------------------------------------------");
        }
    }
}
