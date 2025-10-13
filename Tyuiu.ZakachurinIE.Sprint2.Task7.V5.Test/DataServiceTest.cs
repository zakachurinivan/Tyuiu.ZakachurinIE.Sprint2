using Tyuiu.ZakachurinIE.Sprint2.Task7.V5.Lib;

namespace Tyuiu.ZakachurinIE.Sprint2.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidDot()
        {
            DataService ds = new DataService();

            double x = 0.2;
            double y = 0.37;

            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
    }
}
