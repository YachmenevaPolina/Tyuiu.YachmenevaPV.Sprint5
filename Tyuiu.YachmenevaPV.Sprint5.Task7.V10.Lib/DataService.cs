using System.Text;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YachmenevaPV.Sprint5.Task7.V10.Lib
{
    public class DataService : ISprint5Task7V10
    {
        public string LoadDataAndSave(string path)
        {
            string savepath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V10.txt");

            FileInfo fileInfo = new FileInfo(savepath);
            bool fileExists = fileInfo.Exists;

            if (fileExists) { File.Delete(savepath); }

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string newline = "";
                    foreach (char c in line) 
                    { 
                        newline += char.IsUpper(c) ? char.ToLower(c) : c; 
                    }
                    File.AppendAllText(savepath, newline + Environment.NewLine);
                }
               
            }
            return savepath;
        }

    }
}
