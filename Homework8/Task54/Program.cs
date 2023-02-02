// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;

Clear();

Write("Введите количство строк, столбцов, минимальное и максимальное значение массива через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);

PrintMatrixArray(array);
WriteLine($"Отсортированный массив: ");
SortDescending(array);
PrintMatrixArray(array);

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
            Write($"{inArray[i, j],3} ");
        }
        WriteLine();
    }
}

void SortDescending(int[,] inArr)
{
    for (int i = 0; i < inArr.GetLength(0); i++)
    {
        for (int j = 0; j < inArr.GetLength(1) - 1; j++)
        {
            for (int k = j + 1; k < inArr.GetLength(1); k++)
            {
                if (inArr[i, j] < inArr[i, k])
                {
                    int temporary = inArr[i, k];
                    inArr[i, k] = inArr[i, j];
                    inArr[i, j] = temporary;
                }
            }
        }

    }
}