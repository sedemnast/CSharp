// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

using static System.Console;

Clear();

int[] array = GetArray(123, -100, 100);

PrintArray(array);
WriteLine();
WriteLine(ArrayCount(array));

int ArrayCount(int[] inArr)
{
    int result = 0;
    foreach (var i in inArr)
    {
        if (10 <= i && i <= 99) result++;
    }
    return result;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(minValue, maxValue + 1);
    }
    return resultArray;
}

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}