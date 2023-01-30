// Самая первая клетка шахматной доски - черная, далее они чередуются.
// Пользователь вводит координаты клетки.
// Какого цвета эта клетка?

using static System.Console;

Clear();

Write("Введите координаты клетки : ");

string parameters = ReadLine();
int par1 = parameters[0];
int par2 = parameters[1];

WriteLine(par1);
WriteLine(par2);

if ((par1 + par2) % 2 == 0)
{
    WriteLine("Черная");
}
else
{
    WriteLine("Белая");
}
