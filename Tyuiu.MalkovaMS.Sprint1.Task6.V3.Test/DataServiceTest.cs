using Tyuiu.MalkovaMS.Sprint1.Task6.V3.Lib;

namespace Tyuiu.MalkovaMS.Sprint1.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "abc d e fg hijk";
            Assert.AreEqual("cdegk", ds.LastLetterWord(value));

        }
    }
}
