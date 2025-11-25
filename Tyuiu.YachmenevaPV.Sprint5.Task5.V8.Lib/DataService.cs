using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.YachmenevaPV.Sprint5.Task5.V8.Lib
{
    public class DataService : ISprint5Task5V8
    {
        public double LoadFromDataFile(string path)
        {
            double min = double.MaxValue;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] chisla = line.Split(' ');

                    for (int i = 0; i < chisla.Length; i++)
                    {
                        chisla[i] = chisla[i].Replace(".", ",");

                        if (double.TryParse(chisla[i], out double temp))
                        {
                            temp = Math.Round(temp, 3);

                            
                            if (temp % 1 == 0)
                                continue;

                            if (temp < min)
                                min = temp;
                        }
                    }
                }
            }

            return min;
        }
    }
}
