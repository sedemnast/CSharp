// Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

using static System.Console;
Clear();

int[] array = { 1, 2, 6, 7, 3 };
WriteLine($"Копия заданного массива = [{String.Join(", ", CopyArray(array))}]");

int[] CopyArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[i];
    }
    return result;
}

