// Из двумерного массива целых чисел удалить строку и столбец, 
// на пересечении которых расположен наименьший элемент.

using static System.Console;

Clear();

Write("Введите количство строк, столбцов, минимальное и максимальное значение массива через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);

PrintMatrixArray(array);
WriteLine();

int minValue = array[0, 0];
int minElementI = 0;
int minElementJ = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] < minValue)
        {
            minValue = array[i, j];
            minElementI = i;
            minElementJ = j;
        }
    }
}
WriteLine($"Минимальный элемент = {minValue}. Координаты элемента: [{minElementI},{minElementJ}].");

int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
newArray = DelRowCol(array, minElementI, minElementJ);
PrintMatrixArray(newArray);

int[,] DelRowCol(int[,] inArr, int row, int column)
{
    int[,] result = new int[inArr.GetLength(0) - 1, inArr.GetLength(1) - 1];

    int newMinElementI = 0;
    int newMinElementJ = 0;

    WriteLine($"Строка {row} и столбец {column} подлежат удалению.");

    for (int i = 0; i < inArr.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < inArr.GetLength(1) - 1; j++)
        {
            if (i < row) newMinElementI = i;
            else newMinElementI = i + 1;
            if (j < column) newMinElementJ = j;
            else newMinElementJ = j + 1;
            
            result[i, j] = array[newMinElementI, newMinElementJ];
        }
    }
    return result;
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

