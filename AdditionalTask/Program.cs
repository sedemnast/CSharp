﻿using static System.Console;

WriteLine("Введите первое число: ");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число: ");
int b = Convert.ToInt32(ReadLine());

WriteLine(a == b ? "=" : a > b ? ">" : "<");