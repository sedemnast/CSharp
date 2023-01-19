// Напишите программу, которая выдает сумму чисел от 1 до N, на которые N делится без остатка.

using static System.Console;

Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine()!);

int sum = GetSum(number);
WriteLine($"Сумма чисел от 1 до N, на которые N делится без остатка = {sum}");

int GetSum(int N)
{
    int result = 0;
    int temp = N;
    while (N > 0)
    {
        if (temp % N == 0)
        {
        result += N;
        }
        N--;
    }

    return result;
}