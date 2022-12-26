using static System.Console;
Clear();

WriteLine("Введите число, чтобы получить таблицу кубов чисел от 1 до числа: ");
bool isParse = int.TryParse(ReadLine(), out int n);
if(!isParse)
{
    WriteLine("Введено не число");
    return;
}
int count = 1;
while (count <= n)
{
    WriteLine($"Куб числа {count} - {Math.Pow(count,3)}");
    count++;
}