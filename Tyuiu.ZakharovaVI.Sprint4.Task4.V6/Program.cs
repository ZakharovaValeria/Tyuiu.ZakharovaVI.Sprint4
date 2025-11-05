using Tyuiu.ZakharovaVI.Sprint4.Task4.V6.Lib;

namespace Tyuiu.ZakharovaVI.Sprint4.Task4.V6

{
    class Program
    {
        static void Main(string[] args)
        {
            
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Захарова В. И. | ИБКС-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнила: Захарова Валерия Игоревна | ИБКСб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов                     *");
            Console.WriteLine("* Заменить нечетные элементы массива на 0.                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = { { 7, 6, 6, 6, 9 }, { 4, 4, 4, 9, 4 }, { 5, 5, 5, 6, 5 }, { 4, 9, 5, 9, 7 }, { 6, 9, 5, 6, 7 } };

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            Console.WriteLine("***************************************************************************");
            


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int[,] res = ds.Calculate(matrix);

            Console.WriteLine("\nМассив после замены нечетных элементов на 0:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{res[i, j]} \t");
                }
                Console.WriteLine();
            }
            

            Console.ReadKey();
        }
    }
}