// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();

Write("Введите числа через пробел: ");
int[] numbers = Array.ConvertAll(ReadLine().Split(), int.Parse);

WriteLine($"Количество чисел больше 0 = {SumNum(numbers)}");

int SumNum (int[] num)
{
    int sum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] > 0) sum++;
    }
    return sum;
}

