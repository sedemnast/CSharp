using static System.Console;

WriteLine("Является ли одно число квадратом другого?");
Write("Введите число a: ");
int a = Convert.ToInt32(ReadLine());
Write("Введите число b: ");
int b = Convert.ToInt32(ReadLine());

WriteLine(a * a == b ? "b является квадратом числа a" : b*b == a ? "a является квадратом числа b" : "Не являются кдадратами друг друга");
