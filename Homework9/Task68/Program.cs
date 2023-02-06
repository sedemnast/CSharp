// Напишите программу реализующую метод вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static System.Console;

Clear();

WriteLine(AckermannFunction(2, 3));

int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0 && m > 0) return AckermannFunction (m - 1, 1);
    if (n > 0 && m > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return 0;
}