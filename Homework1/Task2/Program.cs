using static System.Console;

WriteLine("Введите два числа, чтобы узнать, какое из них большее, а какое меньшее");
Write("Введите первое число: ");
int a = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int b = int.Parse(ReadLine()!);

int max = a;
int min = b;

if (a > b)
{
    WriteLine($"max = {a}, min = {b}");
}
    else if (a < b)
    { 
        WriteLine($"max = {a}, min = {b}");
    }
else
{
    WriteLine($"Числа равны");
}
