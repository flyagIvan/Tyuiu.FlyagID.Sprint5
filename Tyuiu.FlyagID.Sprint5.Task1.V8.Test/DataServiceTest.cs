using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FlyagID.Sprint5.Task1.V8.Lib;

namespace Tyuiu.FlyagID.Sprint5.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextData()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            string path = ds.SaveToFileTextData(startValue, stopValue);

            Assert.IsTrue(File.Exists(path));

            string[] lines = File.ReadAllLines(path);

            Assert.AreEqual(stopValue - startValue + 1, lines.Length);

            foreach (string line in lines)
            {
                Assert.IsFalse(string.IsNullOrWhiteSpace(line));
            }
        }
    }
}
