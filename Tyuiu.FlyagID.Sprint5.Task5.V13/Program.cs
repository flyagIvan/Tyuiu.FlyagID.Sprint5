using System;
using Tyuiu.FlyagID.Sprint5.Task5.V13.Lib;

namespace Tyuiu.FlyagID.Sprint5.Task5.V13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Иван Фляг Дмитриевич | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Найти среднее значение чисел из диапазона [-1.5; 1.5]                  *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\flyagIvan\DataSprint5\InPutDataFileTask5V13.txt";

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            Console.WriteLine($"Результат: {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
