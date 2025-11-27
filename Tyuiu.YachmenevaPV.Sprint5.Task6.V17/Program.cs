using Tyuiu.YachmenevaPV.Sprint5.Task6.V17.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #5 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #5                                                               *");
    Console.WriteLine("* Тема: Обработка текстовых данных.                                       *");
    Console.WriteLine("* Задание #6                                                              *");
    Console.WriteLine("* Вариант #17                                                             *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Найти количество лишних пробелов в заданной строке.                     *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    string directory = Path.Combine("C:", "DataSprint5");
    string path = Path.Combine(directory, "InPutDataFileTask6V17.txt");

    Console.WriteLine("Данные находятся в файле:" +  path);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    int res = ds.LoadFromDataFile(path);
    Console.WriteLine(res);
    Console.ReadKey();
}