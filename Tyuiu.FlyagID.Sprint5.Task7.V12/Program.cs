using System;
using System.IO;
using Tyuiu.FlyagID.Sprint5.Task7.V12.Lib;

namespace Tyuiu.FlyagID.Sprint5.Task7.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Иван Фляг Дмитриевич | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Заменить все строчные русские буквы на заглавные                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\flyagIvan\DataSprint5\InPutDataFileTask7V12.txt";

            DataService ds = new DataService();
            string outPath = ds.LoadDataAndSave(path);

            Console.WriteLine("Результат:");
            Console.WriteLine(File.ReadAllText(outPath));
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
