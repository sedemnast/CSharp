using static System.Console;

WriteLine("Введите число:");
int number = Convert.ToInt32(ReadLine());

if(number > 99)
{
    while (number > 999)
        {
            number /= 10;
        }
        int digit = number %= 10;
        WriteLine(digit);
}
else
{
    WriteLine("Третьей цифры нет");
}


