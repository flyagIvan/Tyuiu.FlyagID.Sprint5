using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FlyagID.Sprint5.Task0.V20.Lib
{
    public class DataService : ISprint5Task0V20
    {
        public string SaveToFileTextData(int x)
        {
            double y = 2.12 * Math.Pow(x, 3)
                     + 1.05 * Math.Pow(x, 2)
                     + 4.1 * x * 2;

            y = Math.Round(y, 3);

            string path = Path.Combine(
                Path.GetTempPath(),
                "OutPutFileTask0.txt"
            );

            File.WriteAllText(path, y.ToString());

            return path;
        }
    }
}
