using static System.Console;

WriteLine("Введите три числа, чтобы найти максимальное из них");
Write("Введите первое число: ");
int a = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int b = int.Parse(ReadLine()!);
Write("Введите третье число: ");
int c = int.Parse(ReadLine()!);

int max = a;

if (a > b && a > c)
{
    WriteLine($"max = {a}");
}
if (b > a && b > c)
{
    WriteLine($"max = {b}");
}
if (c > a && c > b)
{
    WriteLine($"max = {c}");
}
