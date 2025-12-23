using System;
using Tyuiu.FlyagID.Sprint5.Task4.V7.Lib;

namespace Tyuiu.FlyagID.Sprint5.Task4.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Иван Фляг Дмитриевич | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* y = (1 / cos(x)) + x^3                                                  *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\flyagIvan\DataSprint5\InPutDataFileTask4V7.txt";

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            Console.WriteLine($"Результат: {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
