﻿// Напишите программу, реализующую метод,принимающий позиции элемента в двумерном массиве,
// и возвращающий значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9

using static System.Console;

Clear();
Write("Введите размер матрицы и диапазон значений через пробел: ");
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);

PrintMatrixArray(array);
WriteLine();

Write("Введите строку и столбец элемента через пробел: ");
GetElement(array, Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse));

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

void GetElement(int[,] inArray, int[] param)
{
    if (param[0] >= inArray.GetLength(0) || param[1] >= inArray.GetLength(1))
    {
        WriteLine($"Такого элемента нет");
    }
    else
    {
        WriteLine($"Искомый элемент = {inArray[param[0], param[1]]}");
    }
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



