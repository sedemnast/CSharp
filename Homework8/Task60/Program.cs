// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента. Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static System.Console;

Clear();

Write("Введите размер массива через пробел: ");

int[] intParams = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
if ((intParams[0] * intParams[1] * intParams[2]) < 91)
{
    int[,,] array = GetArray(intParams[0], intParams[1], intParams[2]);
    PrintArray(array);
}
else WriteLine("В такой матрице не может не быть повторяющихся двузначных значений, введите меньший размер матрицы.");

int[,,] GetArray(int rows, int columns, int pages)
{
    int[,,] newArray = new int[rows, columns, pages];
    int[] rnd = RandomArray(rows * columns * pages);
    int count = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < pages; k++)
            {
                newArray[i, j, k] = rnd[count];
                count++;
            }
        }
    }
    return newArray;
}

int[] RandomArray(int size)
{
    int[] random = new int[size];
    Random rnd = new Random();
    int temporary = 0;
    for (int i = 0; i < size; i++)
    {
        int count = 0;
        while (count != size)
        {
            temporary = rnd.Next(10, 100);
            foreach (int m in random)
                count += m != temporary ? 1 : 0;
        }
        random[i] = temporary;
    }
    return random;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Write($"{inArray[i, j, k],2} ({i}, {j}, {k}) ");
            }
        }
        WriteLine();
    }
}
