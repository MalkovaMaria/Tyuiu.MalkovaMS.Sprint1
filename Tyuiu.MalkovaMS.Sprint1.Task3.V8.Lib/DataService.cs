using System.Runtime.CompilerServices;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MalkovaMS.Sprint1.Task3.V8.Lib
{
    public class DataService : ISprint1Task3V8
    {
        public double IncomeAmount(double startAmount, double percent, double timeDays)
        {
            double proc = percent * timeDays / 365;
            double res = startAmount / 100 * proc;
            return Math.Round(res, 3);
        }
    }
}
