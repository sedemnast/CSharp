using static System.Console;

WriteLine("Введите число, чтобы увидеть все четные числа от 1 до этого числа");
Write("Введите число: ");
int number = int.Parse(ReadLine()!);

int i = 2;

while (i <= number)
{
    if (i % 2 == 0) 
    {
        WriteLine(i);
        i = i + 2;
    }
}
