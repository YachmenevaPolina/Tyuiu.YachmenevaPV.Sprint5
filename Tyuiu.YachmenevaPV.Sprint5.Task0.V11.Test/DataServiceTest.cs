using System.IO;
using Tyuiu.YachmenevaPV.Sprint5.Task0.V11.Lib;
namespace Tyuiu.YachmenevaPV.Sprint5.Task0.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            string directory = "C:\\Users\\Ieshua\\source\\repos\\Tyuiu.YachmenevaPV.Sprint5\\Tyuiu.YachmenevaPV.Sprint5.Task0.V11\\bin\\Debug";
            string fileName = "OutPutFileTask0.txt";
            string fullPath = Path.Combine(directory, fileName);

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
