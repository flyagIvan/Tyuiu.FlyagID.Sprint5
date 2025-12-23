using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FlyagID.Sprint5.Task5.V13.Lib;

namespace Tyuiu.FlyagID.Sprint5.Task5.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            string path = Path.GetTempFileName();
            File.WriteAllLines(path, new string[]
            {
                "-2  -1.5  -1  0  1  1.5  2"
            });

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            Assert.AreEqual(0, result);

            File.Delete(path);
        }
    }
}
