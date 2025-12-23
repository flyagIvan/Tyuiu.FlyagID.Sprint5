using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FlyagID.Sprint5.Task6.V11.Lib
{
    public class DataService : ISprint5Task6V11
    {
        public int LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            string[] words = text.Split(
                new[] { ' ', '\n', '\r', '\t', ',', '.', '!', '?', ';', ':' },
                System.StringSplitOptions.RemoveEmptyEntries);

            int count = 0;

            foreach (string word in words)
            {
                if (word.Length == 6)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
