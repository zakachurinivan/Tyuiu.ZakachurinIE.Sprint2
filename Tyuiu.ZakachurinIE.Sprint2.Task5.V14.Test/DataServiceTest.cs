using Tyuiu.ZakachurinIE.Sprint2.Task5.V14.Lib;

namespace Tyuiu.ZakachurinIE.Sprint2.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidDay()
        {
            DataService ds = new DataService();
            int k = 14;
            int d = 4;
            var res = ds.FindDayName(k, d);
            Assert.AreEqual("Среда", res);
        }
    }
}
