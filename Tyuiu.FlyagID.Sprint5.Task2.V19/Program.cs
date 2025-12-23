using System;
using System.IO;
using Tyuiu.FlyagID.Sprint5.Task2.V19.Lib;

namespace Tyuiu.FlyagID.Sprint5.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Иван Фляг Дмитриевич | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка файлов                                                  *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный массив 3х3                                                *");
            Console.WriteLine("* Заменить нечетные элементы на 0                                         *");
            Console.WriteLine("* Результат сохранить в CSV файл                                         *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix =
            {
                { 9, 2, 5 },
                { 8, 8, 2 },
                { 7, 4, 8 }
            };

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(matrix);

            Console.WriteLine($"Файл сохранён: {path}");
            Console.WriteLine("***************************************************************************");

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
