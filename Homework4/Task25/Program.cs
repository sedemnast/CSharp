// Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using static System.Console;
Clear();

Write("Введите число A: ");
int A = Convert.ToInt32(ReadLine());
Write("Введите число B: ");
int B = Convert.ToInt32(ReadLine());
int exponentiation = Exponentiation(A, B);

int Exponentiation(int A, int B)
{
  int result = 1;
  for(int i = 1; i <= B; i++)
  {
    result *= A;
  }
  return result;
}
WriteLine($"{A} в натуральной степени {B} = {exponentiation}");