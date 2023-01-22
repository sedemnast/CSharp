// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


using static System.Console;

Clear();

Write($"Введите число, чтобы узнать, есть ли оно в массиве: ");
int number = int.Parse(ReadLine()!);

int[] array = { 6, 7, 19, 345, 3 };

WriteLine(FindElement(array, number) ? "Да" : "Нет");

bool FindElement(int[] inArray, int num)
{
    foreach (var i in array)
    {
        if (num == i) return true;
    }
    return false;
}



