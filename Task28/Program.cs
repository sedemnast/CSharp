// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

using static System.Console;

Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine()!);

int count = NumCount(number);
WriteLine($"Количество цифр в числе = {count}");

int NumCount(int num)
{
    int result = 0;
    while (num > 0)
    {
        result++;
        num/=10;
    }

    return result;
}