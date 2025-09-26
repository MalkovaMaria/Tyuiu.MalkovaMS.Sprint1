using Tyuiu.MalkovaMS.Sprint1.Task3.V8.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила: Малькова М. С. | ИИПб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнила: Малькова Мария Сергеевна | ИИПб-25-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("* ФОРМУЛИРОВКА ЗАДАНИЯ:                                                   *");
        Console.WriteLine("* Написать программу вычисления величины дохода по вкладу.                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double S, proc, days;
        Console.WriteLine("Введите величину вклада (руб.):");
        S = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите срок вклада (дней):");
        days = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введиьте процентную ставку (годовых):");
        proc = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Доход:" + ds.IncomeAmount(S, proc, days));
        double Sum = S + ds.IncomeAmount(S, proc, days);
        Console.WriteLine("Сумма по окончании срока вклада: " + Sum);
        Console.ReadLine();

    }
}