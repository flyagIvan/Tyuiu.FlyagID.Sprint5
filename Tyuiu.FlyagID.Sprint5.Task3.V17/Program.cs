using System;
using System.IO;
using Tyuiu.FlyagID.Sprint5.Task3.V17.Lib;

namespace Tyuiu.FlyagID.Sprint5.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Иван Фляг Дмитриевич | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Работа с бинарными файлами                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* f(x) = 2.4x^3 + 0.4x^2 - 1.4x + 4.1                                     *");
            Console.WriteLine("* x = 3                                                                   *");
            Console.WriteLine("* Результат сохранить в бинарный файл                                    *");
            Console.WriteLine("***************************************************************************");

            int x = 3;

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(x);

            double value;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                value = reader.ReadDouble();
            }

            Console.WriteLine($"Файл: {path}");
            Console.WriteLine($"Значение функции при x = {x}: {value}");
            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
