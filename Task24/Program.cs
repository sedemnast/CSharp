// Напишите программу, реализующую метод, который принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
using static System.Console;

Clear();
Write("Input number1: ");
int number1 = int.Parse(ReadLine()!);

int sum1 = GetSum(number1);
WriteLine($"Sum number 1..A = {sum1}");

// Write("Input number2: ");
// int number2 = int.Parse(ReadLine()!);

// int sum2 = GetSum(number2);
// WriteLine($"Sum number 1..A = {sum2}");

int GetSum(int A)
{
    int result = 0;
    while (A > 0)
    {
        result += A;
        A--;
    }

    return result;
}