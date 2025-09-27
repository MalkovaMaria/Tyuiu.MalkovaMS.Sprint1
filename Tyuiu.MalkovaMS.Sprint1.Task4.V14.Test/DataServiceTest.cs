using Tyuiu.MalkovaMS.Sprint1.Task4.V14.Lib;

namespace Tyuiu.MalkovaMS.Sprint1.Task4.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 0.236;
            Assert.AreEqual(wait, ds.Calculate(x,y));
        }
    }
}
