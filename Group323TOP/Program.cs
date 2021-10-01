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
            int a = 0;
            Console.WriteLine("Выбериет действие:");
            Console.WriteLine("1. Создание счета");
            Console.WriteLine("2. Удаление счета");
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    spermbank spermbank = new spermbank();
                    Console.WriteLine(spermbank);
                    break;

                case 2:

                    break;

                case double.NaN:
                    Console.WriteLine("Failed measurement.");
                    break;

                default:
                    Console.WriteLine($"Measured value is {measurement}.");
                    break;
            }
        }
    }
}
