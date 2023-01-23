// Напишите программу, реализующую методы формирования массива, 
// заполненного случайными **вещественными** числами и
// вычисления разницы между максимальным и минимальным элементов массива.
// [3,3 7,1 22,5 2,2 78,2] -> 76

using static System.Console;

Clear();
Write("Введите размер массива, min и max через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

double[] array = GetArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]));

PrintArray(array);
WriteLine();
Diff(array);

void Diff(double[] inArr)
{
    double min = double.MaxValue;
    double max = double.MinValue;
    for (int i = 0; i < inArr.Length; i++)
    {
        if (inArr[i] > max) max = inArr[i];
        if (inArr[i] < min) min = inArr[i];
    }
    WriteLine($"Максимальный элемент = {max}");
    WriteLine($"Минимальный элемент = {min}");
    WriteLine($"Разница между максимальным и минимальным элементами массива = {max - min}");
}

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] resultArray = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = Math.Round(rnd.Next(minValue, maxValue) + rnd.NextDouble(), 2);
    }
    return resultArray;
}

void PrintArray(double[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}
