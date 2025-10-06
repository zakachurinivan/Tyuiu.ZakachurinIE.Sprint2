using Tyuiu.ZakachurinIE.Sprint2.Task2.V20.Lib;

namespace Tyuiu.ZakachurinIE.Sprint2.Task2.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 5;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(res, wait);
        }
    }
}
