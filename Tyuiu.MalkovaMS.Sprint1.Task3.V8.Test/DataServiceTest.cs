using Tyuiu.MalkovaMS.Sprint1.Task3.V8.Lib;

namespace Tyuiu.MalkovaMS.Sprint1.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double S = 2500;
            double days = 30;
            double proc = 20;
            double wait = 41.096;
            Assert.AreEqual(wait, ds.IncomeAmount(S, proc, days));
        }
    }
}
