﻿// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

using static System.Console;

Clear();
Write("Введите размер матрицы и диапазон значений через пробел: ");
// Перевод массива параметров типа string в массив параметров типа int:
// Было:
// string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
// Стало:

// Вариант 1:
// string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[] intParams = Array.ConvertAll(parameters, Convert.ToInt32);
// int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);

// Вариант 2:
// string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[] intParams = Array.ConvertAll(parameters, int.Parse);
// int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);

// Вариант 3, не заводя переменную parameters:
int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);

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
            Write($"{inArray[i, j],5} ");
        }
        WriteLine();
    }
}
