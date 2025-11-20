using System.IO;
using Tyuiu.YachmenevaPV.Sprint5.Task3.V6.Lib;
namespace Tyuiu.YachmenevaPV.Sprint5.Task3.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            string fullPath = ds.SaveToFileTextData(3);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
