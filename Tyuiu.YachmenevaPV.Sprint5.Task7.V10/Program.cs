using Tyuiu.YachmenevaPV.Sprint5.Task7.V10.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #5 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #5                                                               *");
    Console.WriteLine("* Тема: Добавление проектов.                                              *");
    Console.WriteLine("* Задание #7                                                              *");
    Console.WriteLine("* Вариант #10                                                             *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Заменить все заглавные латинские буквы на строчные.                     *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    string directory = Path.Combine("C:", "DataSprint5"); 
    string path = Path.Combine(directory, "InPutDataFileTask7V10.txt");
    string temp = Path.GetTempPath(); string save = "OutPutDataFileTask7V10.txt";
    string savepath = Path.Combine(temp, save);
    Console.WriteLine("Данные находятся в: " + path);
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Находятся в файле: ");
    savepath = ds.LoadDataAndSave(path);
    Console.WriteLine(savepath);
    Console.ReadKey();
}