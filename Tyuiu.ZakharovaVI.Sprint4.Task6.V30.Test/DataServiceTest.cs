using Tyuiu.ZakharovaVI.Sprint4.Task6.V30.Lib;

namespace Tyuiu.ZakharovaVI.Sprint4.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = { "Береза", "Дуб", "Клен", "Сосна", "Пихта", "Осина" };
            string[] res = ds.Calculate(array);
            string[] wait = { "Береза" };
            CollectionAssert.AreEqual(wait, res); 

        }
    }
}
