// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.

using static System.Console;
Clear();

WriteLine($"Введите длину стороны треугольника a: ");
int a = int.Parse(ReadLine()!);
WriteLine($"Введите длину стороны треугольника b: ");
int b = int.Parse(ReadLine()!);
WriteLine($"Введите длину стороны треугольника c: ");
int c = int.Parse(ReadLine()!);

WriteLine(isTriangle(a, b, c) ? $"Треугольник со сторонами {a}, {b} и {c} существует" : $"Треугольника со сторонами {a}, {b} и {c} не существует");

bool isTriangle(int inA, int inB, int inC)
{
    {
        return (inA + inB > inC && inA + inC > inB && inC + inB > inA);
    }
}


