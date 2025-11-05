using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZakharovaVI.Sprint4.Task4.V6.Lib
{
    public class DataService : ISprint4Task4V6
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[,] res = new int[rows, columns];


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        res[i, j] = 0;
                    }
                    else
                    {
                        res[i, j] = matrix[i, j];
                    }
                }
            }
            return res;
        }
    }
}
