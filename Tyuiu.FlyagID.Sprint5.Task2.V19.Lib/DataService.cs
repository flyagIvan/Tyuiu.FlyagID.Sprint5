using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.FlyagID.Sprint5.Task2.V19.Lib
{
    public class DataService : ISprint5Task2V19
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 0; i < rows; i++)
                {
                    string[] row = new string[cols];

                    for (int j = 0; j < cols; j++)
                    {
                        row[j] = matrix[i, j] % 2 != 0 ? "0" : matrix[i, j].ToString();
                    }

                    writer.WriteLine(string.Join(";", row));
                }
            }

            return path;
        }
    }
}
