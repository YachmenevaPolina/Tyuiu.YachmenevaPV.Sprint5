using System.IO;
using Tyuiu.YachmenevaPV.Sprint5.Task4.V11.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #5 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #5                                                               *");
    Console.WriteLine("* Тема: Чтение данныхиз текстового файла.                                 *");
    Console.WriteLine("* Задание #4                                                              *");
    Console.WriteLine("* Вариант #11                                                             *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Вычислить значение по формуле.                                          *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    string path = @"C:\DataSprint5\InPutDataFileTask4V11.txt";
    Console.WriteLine("Данные находятся в файле " + path);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    double res = ds.LoadFromDataFile(path);
    Console.WriteLine(res);
    Console.ReadKey();
}