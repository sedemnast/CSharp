// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;

Clear();

Write("Введите количство строк, столбцов, минимальное и максимальное значение массива через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);

PrintMatrixArray(array);
WriteLine();
WriteLine($"Номер строки с наименьшей суммой элементов: {MinSumElementsInRow(array)}");

int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],5} ");
        }
        WriteLine();
    }
}

int MinSumElementsInRow(int[,] inArr)
{
    int[] sum = new int[inArr.GetLength(0)];
    for (int i = 0; i < inArr.GetLength(0); i++)
    {
        for (int j = 0; j < inArr.GetLength(1); j++)
        {
            sum[i] += inArr[i, j];
        }
    }
    
    int result = 0;
    for (int i = 1; i < sum.Length; i++)
    {
        if (sum[0] > sum[i])
        {
            sum[0] = sum[i];
            result = i;
        }
    }
    return result;
}