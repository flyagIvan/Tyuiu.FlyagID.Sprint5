using System;
using System.IO;
using Tyuiu.FlyagID.Sprint5.Task0.V20.Lib;

namespace Tyuiu.FlyagID.Sprint5.Task0.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Фляг Иван Дмитриевич | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Запись данных в текстовый файл                                    *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Фляг Иван Дмитриевич | ИСПб-25-1                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* f(x) = 2.12x^3 + 1.05x^2 + 4.1x * 2                                    *");
            Console.WriteLine("* при x = 2                                                               *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask0.txt                          *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            int x = 2;

            string path = ds.SaveToFileTextData(x);

            Console.WriteLine($"Файл сохранён по пути: {path}");
            Console.WriteLine("Результат вычисления:");
            Console.WriteLine(File.ReadAllText(path));

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
