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
            int[] array1 = new int[5];
            int[] array2 = new int[5];
            int[] massive1 = new int[5];
            int[] massive2 = new int[5];
            int[,] arrays1 = new int[5, 5];
            int[,] arrays2 = new int[5, 5];

            ArrayGenegation.ArrayGeneration(array1);
            ArrayGenegation.ArrayGeneration(array2);
            ArrayGenegation.Operation(array1, array2);
            Arrays.ArrayGeneration(massive1);
            Arrays.ArrayGeneration(massive2);
            Arrays.Operation(massive1, massive2);
            Console.WriteLine();
         


        }
    }
}
