using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FlyagID.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            string[] values = text.Split(
                new[] { ' ', '\n', '\r', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;
            int count = 0;

            foreach (string v in values)
            {
                if (double.TryParse(
                        v.Replace(",", "."),
                        NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out double num))
                {
                    if (num >= -1.5 && num <= 1.5)
                    {
                        sum += num;
                        count++;
                    }
                }
            }

            if (count == 0)
                return 0;

            return Math.Round(sum / count, 3);
        }
    }
}
