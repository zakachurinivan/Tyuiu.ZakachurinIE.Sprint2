using Tyuiu.ZakachurinIE.Sprint2.Task3.V5.Lib;

namespace Tyuiu.ZakachurinIE.Sprint2.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            var res = ds.Calculate(x);
            Assert.AreEqual(-7, res);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            var res = ds.Calculate(x);
            Assert.AreEqual(-0.083, res);
        }
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -1;
            var res = ds.Calculate(x);
            Assert.AreEqual(0.1, res);
        }
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -10;
            var res = ds.Calculate(x);
            Assert.AreEqual(-1100,01, res);
        }
    }
}
