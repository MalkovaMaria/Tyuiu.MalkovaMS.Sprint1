using Tyuiu.MalkovaMS.Sprint1.Task7.V16.Lib;

namespace Tyuiu.MalkovaMS.Sprint1.Task7.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            Assert.AreEqual(1.022, ds.Calculate(x));

        }
    }
}
