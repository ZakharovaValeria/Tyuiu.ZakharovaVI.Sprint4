using Tyuiu.ZakharovaVI.Sprint4.Task5.V22.Lib;

namespace Tyuiu.ZakharovaVI.Sprint4.Task5.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -6, -5, 1, 2, 3 }, { -6, -1, 7, 2, 4 }, { -2, -5, -7, 1, 2 }, { 1, 4, 5, 6, 7 }, { -3, -2, -1, 5, 3 } };
            int res = ds.Calculate(mas2);
            int wait = 10;

            Assert.AreEqual(wait, res);


        }
    }
}
