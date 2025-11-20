using System.IO;
using Tyuiu.YachmenevaPV.Sprint5.Task2.V1.Lib;
namespace Tyuiu.YachmenevaPV.Sprint5.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 6, 9, 4 },
                { 7, 2, 4 },
                { 4, 8, 3 }
            };


            string fullPath = ds.SaveToFileTextData(matrix);

            
            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
