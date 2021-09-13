using System;

namespace Group323TOP
{
    class Program
    {
        // 0. Создать метод для нахождения суммы элементов двух одномерных массивов.
        // 1. Создать перегрузку предыдущеко метода, для нахождения произведения элементов двух одномерных массивов
        // 2. найти максимальный элемент в каждой строке матрицы
        static void Main(string[] args)
        {
            double[] arraySum1 = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double[] arraySum2 = new double[] { 6.6, 7.7, 8.8 };
            int[] arrayMult1 = new int[] { 1, 2, 3, 4, 14 };
            int[] arrayMult2 = new int[] { 5, 6, 7 };
            int[,] arrayMatrix = new int[5, 5];
            ArrayTasks.SumArraysPrinting(arraySum1, arraySum2);
            ArrayTasks.Operation(arraySum1, arraySum2);
            ArrayTasks.MultArraysPrinting(arrayMult1, arrayMult2);
            ArrayTasks.Operation(arrayMult1, arrayMult2);
            Console.WriteLine();
            ArrayTasks.FindingMax(arrayMatrix);
            Console.WriteLine("Test");

        }
    }
}

