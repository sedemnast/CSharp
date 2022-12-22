using static System.Console;

WriteLine("Введите число:");
int n = int.Parse(ReadLine()!);

if(n >= 100 && n <= 999)
{
    WriteLine(n%10);
}
else
{
    WriteLine("Введено не трехзначное число");
}
