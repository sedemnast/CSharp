// Задайте две матрицы. Напишите программу, которая будет находить произведение 
// двух матриц.Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;

Clear();

Write("Введите количство строк, столбцов, минимальное и максимальное значение первой матрицы через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);

Write("Введите количство строк, столбцов, минимальное и максимальное значение второй матрицы через пробел: ");

int[] intParams2 = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array2 = GetMatrixArray(intParams2[0], intParams2[1], intParams2[2], intParams2[3]);

PrintMatrixArray(array);
WriteLine();
PrintMatrixArray(array2);
WriteLine("Произведение матриц: ");

if (array.GetLength(1) != array2.GetLength(0))
{
    WriteLine("Количество столбцов первой матрицы должно равнятся числу строк второй матрицы!");
}
else PrintMatrixArray(MatrixProduct(array, array2));

int[,] MatrixProduct(int[,] inArr1, int[,] inArr2)
{
    int[,] resultMatrix = new int[inArr1.GetLength(0), inArr2.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inArr1.GetLength(1); k++)
            {
                resultMatrix[i, j] += inArr1[i, k] * inArr2[k, j];
            }
        }
    }
    return resultMatrix;
}

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