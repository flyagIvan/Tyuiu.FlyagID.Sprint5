using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.FlyagID.Sprint5.Task4.V7.Lib;

namespace Tyuiu.FlyagID.Sprint5.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "TestFileTask4V7.txt");
            File.WriteAllText(path, "2");

            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            double expected = Math.Round((1 / Math.Cos(2)) + Math.Pow(2, 3), 3);
            Assert.AreEqual(expected, result);

            File.Delete(path);
        }
    }
}
