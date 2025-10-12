using Tyuiu.ZakachurinIE.Sprint2.Task4.V19.Lib;

namespace Tyuiu.ZakachurinIE.Sprint2.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc1()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 9.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(36.595, res);
        }
        public void ValidCalc2()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.871, res);
        }
    }
}
