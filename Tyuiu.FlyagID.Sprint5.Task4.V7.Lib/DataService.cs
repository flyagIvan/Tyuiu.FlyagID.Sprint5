using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FlyagID.Sprint5.Task4.V7.Lib
{
    public class DataService : ISprint5Task4V7
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            double x = Convert.ToDouble(text.Replace(",", "."), CultureInfo.InvariantCulture);

            double y = (1 / Math.Cos(x)) + Math.Pow(x, 3);
            return Math.Round(y, 3);
        }
    }
}
