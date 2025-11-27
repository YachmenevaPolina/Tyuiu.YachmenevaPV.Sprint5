using Tyuiu.YachmenevaPV.Sprint5.Task6.V17.Lib;
namespace Tyuiu.YachmenevaPV.Sprint5.Task6.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        private string GetInputFilePath()
        {
            string dir = Path.Combine("C:", "DataSprint5");
            string path = Path.Combine(dir, "InPutDataFileTask6V17.txt");
            return path;
        }

        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = GetInputFilePath();

            int res = ds.LoadFromDataFile(path);
            int wait = 2;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string path = GetInputFilePath();
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExist);
        }
    }
}
