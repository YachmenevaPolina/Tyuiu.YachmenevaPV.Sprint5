using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.YachmenevaPV.Sprint5.Task1.V9.Lib
{
    public class DataService : ISprint5Task1V9
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string directory = Path.GetTempPath();
            string fileName = "OutPutFileTask1.txt";
            string fullPath = Path.Combine(directory, fileName);

            if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }

            for (int x = startValue; x <= stopValue; x++)
            {
                double y = Math.Sin(x) + (Math.Cos(2 * x) / 2) - 1.5 * x;

                if (!double.IsFinite(y))
                {
                    y = 0;
                }

                y = Math.Round(y, 2);

                File.AppendAllText(fullPath, $"{y}\n");
                Console.WriteLine($"{x}\t{y}");
            }

            return fullPath;
        }
    }
}
