// Напишите программу, которая реализует рекурсивный метод нахождения суммы 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;

Clear();

WriteLine(GetSum(1, 15));

int GetSum(int numM, int numN)
{
    if (numM == numN) return numN;
    else return GetSum(numM + 1, numN) + numM;
}