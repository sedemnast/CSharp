﻿// Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

using static System.Console;

Clear();

WriteLine(Exponentiation(2, 3));

int Exponentiation(int num, int pow)
{
    if (pow == 1) return num;
    else return Exponentiation(num, pow - 1) * num;
}