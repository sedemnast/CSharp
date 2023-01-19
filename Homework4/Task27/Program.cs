// Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;
Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine()!);

int sum = SumDigits(number);
WriteLine($"Сумма цифр в числе = {sum}");

int SumDigits(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10; 
        num /= 10; 
    }
    return result;
}