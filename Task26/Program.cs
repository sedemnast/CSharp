// Напишите программу, реализующую метод, который принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
using static System.Console;

Clear();
Write("Input number: ");
int number = int.Parse(ReadLine()!);

int product = GetProduct(number);
WriteLine($"Product number 1..N = {product}");

int GetProduct(int N)
{
    if (N <= 0) return 0;
    int result = 1;
    while (N > 0)
    {
        result *= N;
        N--;
    }

    return result;
}