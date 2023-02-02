// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// В итоге получается вот такой массив:
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

using static System.Console;

Clear();

Write("Введите количство строк, столбцов, минимальное и максимальное значение массива через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);

PrintMatrixArray(array);
WriteLine();
ChangeRowsToColumns(array);

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

void ChangeRowsToColumns(int[,] inArr)
{
    int [,] newArray = new int[inArr.GetLength(0), inArr.GetLength(1)];
    if (inArr.GetLength(0) != inArr.GetLength(1))
    {
        WriteLine($"Невозможно поменять строки на столбцы, матрица не квадратная");
    }
    else
    {
        for (int i = 0; i < inArr.GetLength(0); i++)
        {
            for (int j = 0; j < inArr.GetLength(1); j++)
            {
                newArray[j, i] = inArr[i, j];
            }
        }
        PrintMatrixArray(newArray);
    }
}