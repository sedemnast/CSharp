using static System.Console;

WriteLine("Введите число, чтобы узнать, четное оно или нет");
Write("Введите число: ");
int a = int.Parse(ReadLine()!);

if (a % 2 == 0)
{
    WriteLine("Число четное");
}
else
{
    WriteLine("Число нечетное");
}