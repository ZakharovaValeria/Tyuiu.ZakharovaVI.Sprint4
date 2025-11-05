using Tyuiu.ZakharovaVI.Sprint4.Task6.V30.Lib;

namespace Tyuiu.ZakharovaVI.Sprint4.Task6.V30

{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
           
            Console.Title = "Спринт #4 | Выполнила: Захарова В. И. | ИБКС-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                    *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнила: Захарова Валерия Игоревна | ИБКСб-25-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов                     *");
            Console.WriteLine("* Найти количество отрицательных элементов.                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] array = { "Береза", "Дуб", "Клен", "Сосна", "Пихта", "Осина" };

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < array.Length-1; i++)
            {
                Console.WriteLine(array[i]);
            }

            string[] mas = ds.Calculate(array);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]+" ");
            }

            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}