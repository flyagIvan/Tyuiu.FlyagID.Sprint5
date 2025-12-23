using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FlyagID.Sprint5.Task7.V12.Lib;

namespace Tyuiu.FlyagID.Sprint5.Task7.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestRussianLowercaseToUppercase()
        {
            string inputPath = Path.GetTempFileName();
            File.WriteAllText(inputPath, "Привет мир, это тест");

            DataService ds = new DataService();
            string outputPath = ds.LoadDataAndSave(inputPath);

            string result = File.ReadAllText(outputPath);
            string expected = "ПРИВЕТ МИР, ЭТО ТЕСТ";

            Assert.AreEqual(expected, result);

            File.Delete(inputPath);
            File.Delete(outputPath);
        }
    }
}
