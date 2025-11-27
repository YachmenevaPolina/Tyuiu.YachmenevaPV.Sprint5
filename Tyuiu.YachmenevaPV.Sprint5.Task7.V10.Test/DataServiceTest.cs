using Tyuiu.YachmenevaPV.Sprint5.Task7.V10.Lib;
namespace Tyuiu.YachmenevaPV.Sprint5.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        
        public void TestMethod2()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V10.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }

}
