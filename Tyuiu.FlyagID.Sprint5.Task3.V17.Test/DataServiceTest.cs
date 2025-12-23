using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FlyagID.Sprint5.Task3.V17.Lib;

namespace Tyuiu.FlyagID.Sprint5.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();

            int x = 3;
            string path = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(path));

            double value;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                value = reader.ReadDouble();
            }

            Assert.AreEqual(68.3, value, 0.001);
        }
    }
}
