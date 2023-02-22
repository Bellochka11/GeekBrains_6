// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их 
// квадраты. Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть  вот так:
// 1 4 49 2
// 5 81 2 9
// 64 4 4 4
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

void SquareArray(int[,] array) // умножает элемент сам на себя
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
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
int[,] array = GetArray(row, col, -9, 9);
PrintArray(array);
SquareArray(array);
Console.WriteLine();
PrintArray(array);
