// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

using static System.Console;

Clear();

int[] array = GetArray(11);
int[] array2 = PairsProduct(array);

PrintArray(array);
WriteLine();
PrintArray(array2);

int[] PairsProduct(int[] inArr)
{
    int size = inArr.Length / 2;
    if (inArr.Length % 2 == 1) size++;

    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[inArr.Length - i - 1];
    }
    return result;
}

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
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