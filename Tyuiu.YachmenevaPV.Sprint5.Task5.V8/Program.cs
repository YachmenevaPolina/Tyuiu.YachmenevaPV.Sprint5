using Tyuiu.YachmenevaPV.Sprint5.Task5.V8.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #5 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #5                                                               *");
    Console.WriteLine("* Тема: Чтение набора данных.                                             *");
    Console.WriteLine("* Задание #5                                                              *");
    Console.WriteLine("* Вариант #8                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Найти минимальное вещественное число в файле.                           *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    string path = @"C:\DataSprint5\InPutDataFileTask5V8.txt";
    Console.WriteLine("Данные находятся в файле " + path);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    double res = ds.LoadFromDataFile(path);
    Console.WriteLine(res);
    Console.ReadKey();
}