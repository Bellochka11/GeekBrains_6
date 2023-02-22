// Задача 46: Задайте двумерный массив размером m × n,  заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int[,] GetArray(int m, int n, int minValue, int maxValue) // размер массива макс и мин значение
{
    int[,] result = new int[m, n]; // создай массив с m и n элементами
    for (int i = 0; i < m; i++) // бегает по строкам
    {
        for (int j = 0; j < n; j++) // бегает по столбцам
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray) // Печать
{
    for (int i = 0; i < inArray.GetLength(0); i++) // бегает по строкам
    {
        for (int j = 0; j < inArray.GetLength(1); j++) // бегает по столбцам
        {
            Console.Write($"{inArray[i, j]}\t "); // табуляция красиво выводит массив на экран
        }
        Console.WriteLine();
    }
    
}
Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, col, 0, 10);
PrintArray(array);