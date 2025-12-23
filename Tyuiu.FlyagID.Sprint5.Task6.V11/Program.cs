using System;
using Tyuiu.FlyagID.Sprint5.Task6.V11.Lib;

namespace Tyuiu.FlyagID.Sprint5.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Иван Фляг Дмитриевич | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Найти количество слов длиной 6 символов                                 *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\flyagIvan\DataSprint5\InPutDataFileTask6V11.txt";

            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(path);

            Console.WriteLine($"Результат: {result}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
