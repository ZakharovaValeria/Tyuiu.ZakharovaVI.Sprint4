using Tyuiu.ZakharovaVI.Sprint4.Task3.V3.Lib;

namespace Tyuiu.ZakharovaVI.Sprint4.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 9, 4, 5, 4, 8 }, { 7, 6, 7, 7, 4 }, { 4, 4, 3, 5, 6 }, { 6, 5, 9, 4, 9 }, { 9, 7, 8, 7, 7 } };

            int res = ds.Calculate(mas2);
            int wait = 14;
            Assert.AreEqual(wait, res);
        }
    }
}
