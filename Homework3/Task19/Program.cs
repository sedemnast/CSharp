using static System.Console;
Clear();

WriteLine("Является ли Ваше пятизначное число палиндромом?");
Write("Введите пятизначное число: ");
bool isParse = int.TryParse(ReadLine(), out int n);
if(!isParse)
{
    WriteLine("Введено не число");
    return;
}

if (n > 99999 || n < 10000)
{
    WriteLine("Вы ввели не пятизначное число");
}
    else if (n / 10000 == n % 10 && (n / 1000) % 10 == (n / 10) % 10)
    {
        WriteLine($"Число {n} является палиндромом");
    }
    else
    {
        WriteLine($"Число {n} не является палиндромом");  
    }