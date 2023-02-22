// Задача 51: Задайте двумерный массив.  Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив: Сумма элементов главной диагонали: 1+9+2 = 12
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4 Сумма элементов главной диагонали: 1 + 9 + 2 = 12

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

int SummDiag(int[,] arrayForSumm)
{
    int summ = 0;
    int x = arrayForSumm.GetLength(0) > arrayForSumm.GetLength(1) ? arrayForSumm.GetLength(1) : arrayForSumm.GetLength(0);
    for (int i = 0; i < x; i++)
    {
       summ += arrayForSumm[i, i];
    }
    return summ;
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(row, col, 0, 10);
PrintArray(array);
Console.WriteLine(SummDiag(array));

