using System.IO;
using Tyuiu.YachmenevaPV.Sprint5.Task5.V8.Lib;
namespace Tyuiu.YachmenevaPV.Sprint5.Task5.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V8.txt";
            FileInfo fileInfo = new FileInfo(path);
            Assert.IsTrue(fileInfo.Exists);

            
            DataService ds = new DataService();
            double expected = -3.36;     
            double actual = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, actual);
        }
    }
}
