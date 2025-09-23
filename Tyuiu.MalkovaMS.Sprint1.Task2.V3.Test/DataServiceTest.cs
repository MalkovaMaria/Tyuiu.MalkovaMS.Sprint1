using Tyuiu.MalkovaMS.Sprint1.Task2.V3.Lib;

namespace Tyuiu.MalkovaMS.Sprint1.Task2.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.ConvertHourToMin(x);
            Assert.AreEqual(60, res);
        }
    }
}
