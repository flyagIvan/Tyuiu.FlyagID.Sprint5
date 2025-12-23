using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FlyagID.Sprint5.Task6.V11.Lib;

namespace Tyuiu.FlyagID.Sprint5.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCountWordsLengthSix()
        {
            string path = Path.GetTempFileName();
            File.WriteAllText(path, "planet orange banana apple summer winter");

            DataService ds = new DataService();
            int result = ds.LoadFromDataFile(path);


            Assert.AreEqual(5, result);

            File.Delete(path);
        }
    }
}
