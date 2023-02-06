// Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

using static System.Console;

Clear();

WriteLine(GetSum(45));

int GetSum(int num)
{
    if (num == 0) return 0; 
    else return GetSum(num / 10) + num % 10;
}