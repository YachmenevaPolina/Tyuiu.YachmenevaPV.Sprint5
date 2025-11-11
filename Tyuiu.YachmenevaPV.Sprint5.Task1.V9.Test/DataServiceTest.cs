using System.IO;
using Tyuiu.YachmenevaPV.Sprint5.Task1.V9.Lib;
namespace Tyuiu.YachmenevaPV.Sprint5.Task1.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid1()
        {
            DataService ds = new DataService();
            string fullPath = ds.SaveToFileTextData(-5, 5); 

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
