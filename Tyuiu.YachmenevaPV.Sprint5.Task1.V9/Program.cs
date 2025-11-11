using Tyuiu.YachmenevaPV.Sprint5.Task1.V9.Lib;
{
    DataService ds = new DataService();
    int startValue = -5;
    int stopValue = 5;

    Console.Title = "Спринт #5 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #5                                                               *");
    Console.WriteLine("* Тема: Запись набора данных в текстовый файл.                            *");
    Console.WriteLine("* Задание #1                                                              *");
    Console.WriteLine("* Вариант #9                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Вычислить значение выражения, результат сохранить в текстовый файл      *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("startValue" + startValue);
    Console.WriteLine("stopValue" + stopValue);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    string res = ds.SaveToFileTextData(startValue, stopValue);
    Console.WriteLine("Файл" + res);
    Console.WriteLine("Создан!");
    Console.ReadKey();

}