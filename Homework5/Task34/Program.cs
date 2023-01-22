// Напишите программу, реализующую методы формирования массива, 
// заполненного случайными положительными трёхзначными числами,
// и подсчета количества чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;

Clear();

int[] array = GetArray(4, 100, 999);

PrintArray(array);
WriteLine();
WriteLine(EvenNum(array));

int EvenNum(int[] num)
{
    int result = 0;
    foreach (var i in num)
    {
        if (i % 2 == 0) result++;
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
