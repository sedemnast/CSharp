// Задайте двумерный массив. Напишите программу, которая поменяет 
// местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

using static System.Console;

Clear();

Write("Введите количство строк, столбцов, минимальное и максимальное значение массива через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);

PrintMatrixArray(array);
WriteLine();
SwapFirstAndLastRows(array);

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

void SwapFirstAndLastRows(int[,] inArr)
{
    for (int i = 0; i < inArr.GetLength(1); i++) 
    {
        int newArray = inArr[0, i];
        inArr[0, i] = inArr[inArr.GetLength(0) - 1, i];
        inArr[inArr.GetLength(0) - 1, i] = newArray;
    }
    PrintMatrixArray(inArr);
}