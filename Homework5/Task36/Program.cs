// Напишите программу, реализующую методы формирования массива,
// заполненного случайными числами и подсчета суммы элементов,
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using static System.Console;

Clear();

int[] array = GetArray(4, 1, 100);

PrintArray(array);
WriteLine();
Sum(array);

void Sum(int[] inArray)
{
    int result = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (i % 2 != 0) result = result + inArray[i];
    }
    WriteLine($"Сумма элементов, стоящих на нечётных позициях: {result}");
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
