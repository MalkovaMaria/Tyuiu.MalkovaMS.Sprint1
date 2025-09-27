using Tyuiu.MalkovaMS.Sprint1.Task5.V5.Lib;

namespace Tyuiu.MalkovaMS.Sprint1.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 32.597;
            Assert.AreEqual(5, ds.Calculate(x));
        }
    }
}
