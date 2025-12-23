using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.FlyagID.Sprint5.Task0.V20.Lib;

namespace Tyuiu.FlyagID.Sprint5.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSaveToFileTextData()
        {
            DataService ds = new DataService();
            int x = 2;

            string path = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(path));

            string result = File.ReadAllText(path);

       
            Assert.AreEqual("37,56", result);
        }
    }
}
