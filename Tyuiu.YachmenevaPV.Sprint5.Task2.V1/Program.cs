using System.IO;
using Tyuiu.YachmenevaPV.Sprint5.Task2.V1.Lib;
{
    int[,] matrix = { { 6, 9, 4}, {7, 2, 4}, { 4, 8, 3 } };

    int rows = matrix.GetUpperBound(0) + 1;
    int columns = matrix.Length / rows;

    DataService ds = new DataService();

    Console.Title = "Спринт #5 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #5                                                               *");
    Console.WriteLine("* Тема: Запись структурированных данных в текстовый файл.                 *");
    Console.WriteLine("* Задание #2                                                              *");
    Console.WriteLine("* Вариант #1                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Заменить нечетные элементы массива на 0.                                *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Массив: ");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");
    string res = ds.SaveToFileTextData(matrix);
    Console.WriteLine("Файл: " + res);
    Console.WriteLine("Создан!");
    Console.ReadKey();
}