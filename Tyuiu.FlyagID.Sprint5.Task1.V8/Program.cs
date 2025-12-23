using System;
using System.IO;
using Tyuiu.FlyagID.Sprint5.Task1.V8.Lib;

namespace Tyuiu.FlyagID.Sprint5.Task1.V8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Иван Фляг Дмитриевич | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Табулирование функции                                             *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Иван Фляг Дмитриевич | ИСПб-25-1                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* f(x) = 4 - 2x + (2 + cos(x)) / (2x - 2)                                 *");
            Console.WriteLine("* Диапазон [-5; 5], шаг 1                                                 *");
            Console.WriteLine("* При делении на ноль вернуть 0                                           *");
            Console.WriteLine("* Результат сохранить в файл                                              *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine($"Файл сохранён: {path}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" x\tf(x)");

            string[] lines = File.ReadAllLines(path);
            int x = startValue;

            foreach (string line in lines)
            {
                Console.WriteLine($"{x}\t{line}");
                x++;
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}
