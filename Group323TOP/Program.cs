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
<<<<<<< Updated upstream
            //int[] array1 = new int[5];
            //int[] array2 = new int[5];
            //int[] massive1 = new int[5];
            //int[] massive2 = new int[5];
            //int[,] arrays1 = new int[5, 5];
            //int[,] arrays2 = new int[5, 5];

            //ArrayGenegation.ArrayGeneration(array1);
            //ArrayGenegation.ArrayGeneration(array2);
            //ArrayGenegation.Operation(array1, array2);
            //Arrays.ArrayGeneration(massive1);
            //Arrays.ArrayGeneration(massive2);
            //Arrays.Operation(massive1, massive2);


            Balance balance1 = new Balance(2000);
            Balance balance2 = new Balance(1337);
            Balance balance3 = new Balance(228);
            Balance balance4 = new Balance(1488);
            Balance balance5 = new Balance(322);
            DataBase db = new DataBase();
            db.users.Add(new Person("1", "Дорофеева Ева Михайловна", "123", balance1));
            db.users.Add(new Person("2", "Сухарева Ксения Михайловна", "323", balance2));
            db.users.Add(new Person("3", "Кондратьев Роберт Андреевич", "323", balance3));
            db.users.Add(new Person("4", "Кузьмина Мирослава Артёмовна", "323", balance4));
            db.users.Add(new Person("5", "Алехин Давид Маркович", "323", balance5));

            db.StartMenu();

            //GrenadierTalib Akhmed = new GrenadierTalib(100, "Akhmed", 20);

            //Soldier Artem = new Soldier(100, "Артемка", 40);


            //Akhmed.Shoot(Artem, Akhmed);
            //Console.WriteLine(Artem.Health);

=======
            Gunslinger Bekmansurov = new Gunslinger();
            Mechanic Galyaviev = new Mechanic();
            Glock weapon1 = new Glock();
            var mleeWeapon = new Knife();
            Shotgun weapon2 = new Shotgun();
            Machinegun weapon3 = new Machinegun();
            Bekmansurov.OpenFire(weapon1);
            
            Galyaviev.Repair(weapon2);
>>>>>>> Stashed changes
        }
    }
}
