// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

using static System.Console;

Clear();

PrintNumbers(10, 5);
WriteLine();
WriteLine(GetNumbers1(1, 5));
WriteLine(GetNumbers(10, 5));

// Первый метод:
void PrintNumbers(int start, int end)
{
    if (start > end) // Чтобы числа выводились по возрастанию, даже если первое число больше второго.
    {
        int temp = start;
        start = end;
        end = temp;
    }
    if (end == start) Write(end);
    else
    {
        PrintNumbers(start, end - 1);
        Write($",{end}");
    }
}

// Второй метод:
string GetNumbers1(int num1, int num2)
{
    // Чтобы числа выводились по возрастанию, даже если первое число больше второго (используя тернарный оператор, но лучше его не использовать, так как в этом случае много условий).
    return (num1 > num2) ? (num1 == num2 ? num1.ToString() :
    $"{GetNumbers1(num1 - 1, num2)},{num1}") : (num2 == num1 ? num2.ToString() :
    $"{GetNumbers1(num2 - 1, num1)},{num2}");
}

// Третий метод: 
string GetNumbers(int start, int end)
{
    if (start > end)
    {
        int temp = start;
        start = end;
        end = temp;
    }
    if (end == start) return end.ToString(); // ToString все преобразует в строку.
    else return $"{GetNumbers(start, end - 1)},{end}";
}