// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

using static System.Console;
Clear();

Write($"Введите число: ");
int number = int.Parse(ReadLine()!);

Fibonacci(number);

void Fibonacci (int number)
{
    int temp, n1=0, n2=1;
    Write($"{n1} {n2} ");
    for (int i = 2; i < number; i++) 
    {
        temp = n1 + n2;
        n1 = n2;
        n2 = temp;
        Write($"{n2} ");
    }
}

