// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив: Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
int[,] GetRandomArray(int m, int n, int minValue, int maxValue) // размер массива макс и мин значение
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

double[] AverageInMatrix(int[,] matrix)
{
    double[] result = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double total = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            total += matrix[j, i];
        }
        total /= matrix.GetLength(0);
        result[i] = total;
    }
    return result;
}



Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetRandomArray(row, col, 0, 10);
PrintArray(array);
double[] result = AverageInMatrix(array);
Console.WriteLine($"Среднее арифметическое каждого столбца: {string.Join("; ", result)}");