using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MalkovaMS.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double a = Math.Truncate(x * 10) / 10;
            int d = Convert.ToInt32((a - Math.Truncate(x)) * 10);
            return d;
        }
    }
}
