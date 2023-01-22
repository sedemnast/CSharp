// Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

using static System.Console;

Clear();

int[] array = { -4, -8, 8, 2 };

PrintArray(array);
Write($" -> ");
SignReplacement(array);
PrintArray(array);

void SignReplacement(int[] inArr)
{
    for (int i = 0; i < inArr.Length; i++)
    {
        inArr[i] *= -1;
    }
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

