using static System.Console;
Clear();

Write("Введите координату x: ");
int x = int.Parse(ReadLine()!);
Write("Введите координату y: ");
int y = int.Parse(ReadLine()!);

if(x == 0 || y == 0)
{
    WriteLine("Ошибка");
    return;
}
if (x > 0 && y > 0)
{
    WriteLine("1 четверть");
}
if (x < 0 && y > 0)
{
    WriteLine("2 четверть");
}
if (x < 0 && y < 0)
{
    WriteLine("3 четверть");
}
if (x > 0 && y < 0)
{
    WriteLine("4 четверть");
}
