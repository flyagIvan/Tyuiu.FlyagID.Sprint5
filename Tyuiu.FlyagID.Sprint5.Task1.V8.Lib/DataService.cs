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

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double result;

                    if ((2 * x - 2) == 0)
                    {
                        result = 0;
                    }
                    else
                    {
                        result = 4
                               - 2 * x
                               + (2 + Math.Cos(x)) / (2 * x - 2);
                    }

                    result = Math.Round(result, 2);

                    writer.WriteLine(
                        result.ToString("0.00", CultureInfo.InvariantCulture)
                    );
                }
            }

            return path;
        }
    }
}
