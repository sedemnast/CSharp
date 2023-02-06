// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

using static System.Console;

Clear();

// Метод, собирающий (возвращающий) строку и печатающий ее:
string result = GetNumbers(10);
WriteLine(result);

WriteLine(GetNumbers1(10));
PrintNumbers(10);

string GetNumbers(int num)
{
    if (num == 1) return num.ToString(); // ToString все преобразует в строку.
    else return $"{GetNumbers(num - 1)},{num}";
}

// С использованием тернарного оператора:
string GetNumbers1(int num)
{
    return (num == 1) ? num.ToString() : $"{GetNumbers1(num - 1)},{num}";
}

// Второй подход, напрямую вызывающий метод, который будет печатать в строке:
void PrintNumbers(int num)
{
    if (num == 1) Write(num);
    else
    {
        PrintNumbers(num - 1);
        Write($",{num}");
    }
}