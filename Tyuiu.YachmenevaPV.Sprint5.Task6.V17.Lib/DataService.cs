using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.YachmenevaPV.Sprint5.Task6.V17.Lib
{
    public class DataService : ISprint5Task6V17
    {
        public int LoadFromDataFile(string path)
        {
            string line;

            using (StreamReader reader = new StreamReader(path)) { line = reader.ReadLine(); }
            
            int count = 0;
            int run = 0;

            foreach (char ch in line)
            {
                if (ch == ' ')
                {
                    run++;
                }
                else
                {
                    if (run > 1)
                        count++;

                    run = 0;
                }
            }

            if (run > 1)
                count++;

            return count;
        }
    }
}
