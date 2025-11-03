using Tyuiu.ZakharovaVI.Sprint4.Task1.V16.Lib;

namespace Tyuiu.ZakharovaVI.Sprint4.Task1.V16

{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Захарова В. И. | ИБКС-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнила: Захарова Валерия Игоревна | ИБКСб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов                     *");
            Console.WriteLine("* подсчитать произведение нечетных элементов массива.                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 4, 3, 7, 3, 7, 4, 3, 3, 4, 4, 8, 3, 4 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numsArray.Length - 1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int umn = ds.Calculate(numsArray);
            Console.WriteLine($"Произведение четных элементов: {umn}");

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}