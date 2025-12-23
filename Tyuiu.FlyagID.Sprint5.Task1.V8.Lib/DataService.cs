using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FlyagID.Sprint5.Task1.V8.Lib
{
    public class DataService : ISprint5Task1V8
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(
                Path.GetTempPath(),
                "OutPutFileTask1.txt"
            );

            CultureInfo ru = CultureInfo.GetCultureInfo("ru-RU");

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double y;

                    if ((2 * x - 2) == 0)
                    {
                        y = 0;
                    }
                    else
                    {
                        y = 4
                          - 2 * x
                          + (2 + Math.Cos(x)) / (2 * x - 2);
                    }

                    y = Math.Round(y, 2);

                    string value;

                    if (y % 1 == 0)
                    {
                        value = ((int)y).ToString();
                    }
                    else
                    {
                        value = y.ToString("0.##", ru);
                    }

                    writer.WriteLine(value);
                }
            }

            return path;
        }
    }
}
