// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

using static System.Console;
Clear();

WriteLine($"Введите десятичное число, чтобы преобразовать его в двоичное: ");
int number = int.Parse(ReadLine()!);

WriteLine($"Десятичное число {number} в двоичной системе счисления будет равно {DecimalToBinary(number)}");

string DecimalToBinary(int num)
{
    if (num == 0) return "0";
    string result = string.Empty;
    int remainder;

    while (num > 0)
    {
        remainder = num % 2;
        num /= 2;
        result = remainder.ToString() + result;
    }
    return result;
}