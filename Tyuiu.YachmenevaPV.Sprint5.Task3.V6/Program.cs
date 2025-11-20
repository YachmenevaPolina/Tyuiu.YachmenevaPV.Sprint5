using System.IO;
using Tyuiu.YachmenevaPV.Sprint5.Task3.V6.Lib;
{
    int x = 3;

    DataService ds = new DataService();

    Console.Title = "Спринт #5 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #5                                                               *");
    Console.WriteLine("* Тема: Запись данных в бинарный файл.                                    *");
    Console.WriteLine("* Задание #3                                                              *");
    Console.WriteLine("* Вариант #6                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Вычислить значение при x = 3, результат сохранить в бинарный файл.      *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("x = " + x);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    string res = ds.SaveToFileTextData(x);
    Console.WriteLine("Файл" + res);
    Console.WriteLine("Создан!");
    Console.ReadKey();
}