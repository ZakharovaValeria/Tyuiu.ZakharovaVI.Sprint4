using Tyuiu.ZakharovaVI.Sprint4.Task7.V1.Lib;

namespace Tyuiu.ZakharovaVI.Sprint4.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int n = 3;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "135792468";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
 