using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.YachmenevaPV.Sprint5.Task0.V11.Lib
{
    public class DataService : ISprint5Task0V11
    {
        public string SaveToFileTextData(int x)
        {
            string directory = "C:\\Users\\Ieshua\\source\\repos\\Tyuiu.YachmenevaPV.Sprint5\\Tyuiu.YachmenevaPV.Sprint5.Task0.V11\\bin\\Debug";
            string fileName = "OutPutFileTask0.txt";
            string fullPath = Path.Combine(directory, fileName);

            double y = (4 - Math.Pow((double)x, 3)) / Math.Pow((double)x, 2);
            y = Math.Round(y, 3);
            File.WriteAllText(fullPath, Convert.ToString(y));
            return fullPath;
        }
    }
}
