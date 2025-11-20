using System.Text;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.YachmenevaPV.Sprint5.Task3.V6.Lib
{
    public class DataService : ISprint5Task3V6
    {
        public string SaveToFileTextData(int x)
        {
            string directory = Path.GetTempPath();
            string fileName = "OutPutFileTask3.bin";
            string fullPath = Path.Combine(directory, fileName);

            double y = ((double)x / Math.Sqrt((Math.Pow((double)x, 2)) + (double)x));
            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(fullPath, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return fullPath;
        }
    }
}
