using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZakharovaVI.Sprint4.Task2.V5.Lib
{
    public class DataService : ISprint4Task2V5
    {
        public int Calculate(int[] array)
        {
            int umn = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    umn *= array[i];
                }
            }
            return umn;
        }
    }
}
