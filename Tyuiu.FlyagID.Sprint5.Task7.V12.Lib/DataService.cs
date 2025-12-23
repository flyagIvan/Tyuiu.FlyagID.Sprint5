using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FlyagID.Sprint5.Task7.V12.Lib
{
    public class DataService : ISprint5Task7V12
    {
        public string LoadDataAndSave(string path)
        {
            string text = File.ReadAllText(path);

            string result = text.ToUpper(new CultureInfo("ru-RU"));

            string outPath = Path.Combine(
                Path.GetTempPath(),
                "OutPutDataFileTask7V12.txt"
            );

            File.WriteAllText(outPath, result);

            return outPath;
        }
    }
}
